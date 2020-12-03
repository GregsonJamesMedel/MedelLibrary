using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MedelLibrary.Data;
using MedelLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace MedelLibrary.Services
{
    public class LibraryAssetService : ILibraryAsset
    {
        private readonly DataContext _context;

        public LibraryAssetService(DataContext context)
        {
            this._context = context;
        }

        public bool AddLibraryAsset(LibraryAsset asset)
        {
            this._context.LibraryAssets.Add(asset);
            var result = this._context.SaveChanges();

            return result > 0 ? true : false;
        }

        public bool DeleteAsset(int id)
        {
            var asset = this._context.LibraryAssets.Find(id);

            if(asset == null)
                return false;
            
            this._context.LibraryAssets.Remove(asset);
            var result = this._context.SaveChanges();

            return result > 0 ? true : false;
        }

        public IEnumerable<LibraryAsset> GetAllAssets()
        {
            return this._context.LibraryAssets.Include(asset => asset.Category);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return this._context.LibraryAssets.OfType<Book>().Include(asset => asset.Category);

        }

        public LibraryAsset GetAsset(int id)
        {
            if(this.GetType(id) == "Book")
                return this._context.Books.Include(a => a.Category).FirstOrDefault(a => a.Id == id);
            
            return this._context.Videos.Include(a => a.Category).FirstOrDefault(a => a.Id == id);
        }

        public string GetAuthorOrDirector(int id)
        {
            var isBook = this._context.LibraryAssets
                .OfType<Book>()
                .Where(asset => asset.Id == id).Any();

            return isBook ? 
                this._context.Books.FirstOrDefault(b => b.Id == id).Author : 
                this._context.Videos.FirstOrDefault(v => v.Id == id).Director;
        }

        public string GetISBN(int id)
        {
            if(this._context.Books.Any(b => b.Id == id))
                return this._context.Books.FirstOrDefault(b => b.Id == id).ISBN;

            return "";
        }

        public string GetType(int id)
        {
            return this._context.Books
                .Any(b => b.Id == id) ? "Book" : "Video" ?? "Unknown";  
        }

        public bool MarkFound(int assetId)
        {
            var asset = GetAsset(assetId);

            var checkOut = this._context.Checkouts
                .FirstOrDefault(c => c.LibraryAsset.Id == asset.Id);

            if(checkOut != null)
                this._context.Checkouts.Remove(checkOut);
            
            var checkOutHistory = this._context.CheckoutHistories
                .FirstOrDefault(ch => ch.LibraryAsset.Id == asset.Id && ch.Checkin == null);

            if(checkOutHistory != null)
            {
                checkOutHistory.Checkin = DateTime.Now;
                this._context.CheckoutHistories.Update(checkOutHistory);
            }

            asset.Status = "Available";
            this._context.LibraryAssets.Update(asset);

            return this._context.SaveChanges() > 0;
        }

        public bool MarkLost(int assetId)
        {
            var asset = GetAsset(assetId);
            asset.Status = "Lost";

            var checkout = this._context.Checkouts
            .Include(a => a.LibraryAsset)
            .Include(l => l.LibraryCard)
            .FirstOrDefault(c => c.LibraryAsset.Id == asset.Id);

            if(checkout != null)
            {
                var LibraryCard = checkout.LibraryCard;
                LibraryCard.Fees += asset.Cost;
                this._context.LibraryCards.Update(LibraryCard);
            }

            this._context.LibraryAssets.Update(asset);
            var res = this._context.SaveChanges();

            return res > 0 ? true : false;
        }

        

        public bool UpdateAsset(LibraryAsset asset)
        {
            this._context.LibraryAssets.Update(asset);
            var result = this._context.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}