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
            this._context.LibraryAsset.Add(asset);
            var result = this._context.SaveChanges();

            return result > 0 ? true : false;
        }

        public bool DeleteAsset(int id)
        {
            var asset = this._context.LibraryAsset.Find(id);

            if(asset == null)
                return false;
            
            this._context.LibraryAsset.Remove(asset);
            var result = this._context.SaveChanges();

            return result > 0 ? true : false;
        }

        public IEnumerable<LibraryAsset> GetAllAssets()
        {
            return this._context.LibraryAsset.Include(asset => asset.Category);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return this._context.LibraryAsset.OfType<Book>().Include(asset => asset.Category);

        }

        public LibraryAsset GetAsset(int id)
        {
            if(this.GetType(id) == "Book")
                return this._context.Books.Include(a => a.Category).FirstOrDefault(a => a.Id == id);
            
            return this._context.Videos.Include(a => a.Category).FirstOrDefault(a => a.Id == id);
        }

        public string GetAuthorOrDirector(int id)
        {
            var isBook = this._context.LibraryAsset.OfType<Book>().Where(asset => asset.Id == id).Any();

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
            return this._context.Books.Any(b => b.Id == id) ? "Book" : "Video" ?? "Unknown";  
        }
    }
}