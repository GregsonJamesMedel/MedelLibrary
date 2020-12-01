using System;
using System.Collections.Generic;
using MedelLibrary.Data;
using MedelLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MedelLibrary.Services
{
    public class TransactionService : ITransaction
    {
        private readonly DataContext _context;

        public TransactionService(DataContext context)
        {
            this._context = context;
        }

        public bool AddCheckIn(int AssetId, int LibraryCardId)
        {
            var checkOutHistory = this._context.CheckoutHistories
            .FirstOrDefault(c => c.LibraryAsset.Id == AssetId && c.LibraryCard.Id == LibraryCardId && c.Checkin == null);

            if(checkOutHistory == null)
                return false;

            checkOutHistory.Checkin = DateTime.Now;
            this._context.CheckoutHistories.Update(checkOutHistory);

            var result = this._context.SaveChanges() > 0 ? true : false;

            if (result)
                UpdateStatus(AssetId, "Available");

            return result;
        }

        public bool AddCheckout(int AssetId, int LibraryCardId)
        {
            var asset = this._context.LibraryAssets.Find(AssetId);
            var libraryCard = GetLibraryCardById(LibraryCardId);

            var checkout = new Checkout()
            {
                LibraryAsset = asset,
                LibraryCard = libraryCard,
                Since = DateTime.Now,
                Until = DateTime.Now.AddDays(5)
            };

            this._context.Checkouts.Add(checkout);
            var result = this._context.SaveChanges() > 0 ? true : false;
            if (result)
            {
                result = AddCheckoutHistory(checkout);
                result = UpdateStatus(AssetId, "Checked out");
                return result;
            }

            return false;
        }

        public bool AddCheckoutHistory(Checkout checkout)
        {
            var checkOutHistory = new CheckoutHistory()
            {
                LibraryAsset = checkout.LibraryAsset,
                LibraryCard = checkout.LibraryCard,
                Checkout = checkout.Since
            };

            this._context.CheckoutHistories.Add(checkOutHistory);
            var result = this._context.SaveChanges();

            return result > 0 ? true : false;
        }

        public LibraryCard CreateLibraryCard()
        {
            var libraryCard = new LibraryCard()
            {
                Created = DateTime.Now
            };

            this._context.LibraryCards.Add(libraryCard);
            this._context.SaveChanges();
            return libraryCard;
        }

        public IEnumerable<Checkout> GetAllCheckouts()
        {
            return this._context.Checkouts
            .Include(a => a.LibraryAsset).Include(c => c.LibraryCard).OrderByDescending(a => a.Since);
        }

        public LibraryCard GetLibraryCardById(int id)
        {
            return this._context.LibraryCards.Find(id);
        }

        public bool UpdateStatus(int id, string status)
        {
            var asset = this._context.LibraryAssets.Find(id);
            asset.Status = status;
            var result = this._context.SaveChanges();

            return result > 0 ? true : false;
        }
    }
}