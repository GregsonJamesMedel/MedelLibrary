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

            var dateNow = DateTime.Now;

            if (checkOutHistory == null)
                return false;


            checkOutHistory.Checkin = dateNow;
            this._context.CheckoutHistories.Update(checkOutHistory);


            var result = this._context.SaveChanges() > 0 ? true : false;

            if (GetHoldsForAsset(AssetId).Any())
            {
                var res = UpdateStatus(AssetId,"On Hold");
                RemoveCheckOut(AssetId, LibraryCardId);
                return res;
            }

            if (result)
                UpdateStatus(AssetId, "Available");
            RemoveCheckOut(AssetId, LibraryCardId);

            return result;
        }

        private void RemoveCheckOut(int assetId, int libraryCardId)
        {
            var checkOut = this._context.Checkouts
                .FirstOrDefault(a => a.LibraryAsset.Id == assetId && a.LibraryCard.Id == libraryCardId);
            this._context.Remove(checkOut);
            this._context.SaveChanges();
        }

        public bool AddCheckout(int AssetId, int LibraryCardId)
        {
            var asset = this._context.LibraryAssets.Find(AssetId);
            var libraryCard = GetLibraryCardById(LibraryCardId);
            var dateNow = DateTime.Now;

            var checkout = new Checkout()
            {
                LibraryAsset = asset,
                LibraryCard = libraryCard,
                Since = dateNow,
                Until = dateNow.AddDays(5)
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

        private IEnumerable<Hold> GetHoldsForAsset(int assetId)
        {
            return this._context.Holds.Where(h => h.LibraryAsset.Id == assetId);
        }

        public Hold GetMostRecentHold(int assetId)
        {
            return this._context.Holds
                    .Include(a => a.LibraryAsset)
                    .Include(l => l.LibraryCard)
                    .OrderBy(h => h.HoldPlace)
                    .FirstOrDefault(a => a.LibraryAsset.Id == assetId);
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

        public bool AddHold(int assetId, int libraryCardId)
        {
            var asset = this._context.LibraryAssets.FirstOrDefault(a => a.Id == assetId);
            var libraryCard = this._context.LibraryCards.FirstOrDefault(lc => lc.Id == libraryCardId);
            var dateNow = DateTime.Now;

            var hold = new Hold()
            {
                LibraryAsset = asset,
                LibraryCard = libraryCard,
                HoldPlace = dateNow
            };

            this._context.Holds.Add(hold);
            var result = this._context.SaveChanges();

            return result > 0;
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

        public IEnumerable<CheckoutHistory> GetAllCheckoutHistoryByLibraryCardId(int id)
        {
            return this._context.CheckoutHistories
                    .Include(X => X.LibraryAsset)
                    .Include(X => X.LibraryCard)
                    .Where(ch => ch.LibraryCard.Id == id);
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

        public Checkout GetRecentCheckOut(int assetId)
        {
            return this._context.Checkouts
                .OrderBy(c => c.Since)
                .Include(a => a.LibraryAsset)
                .Include(l => l.LibraryCard)
                .FirstOrDefault(a => a.LibraryAsset.Id == assetId);
        }

        public IEnumerable<Hold> GetAssetHolds(int assetId)
        {
            return this._context.Holds
                .Include(a => a.LibraryAsset)
                .Include(l => l.LibraryCard)
                .Where(h => h.LibraryAsset.Id == assetId).OrderBy(h => h.HoldPlace);
        }

        public IEnumerable<CheckoutHistory> GetCheckoutHistoriesByAssetId(int assetId)
        {
            return this._context.CheckoutHistories
                .Include(a => a.LibraryAsset)
                .Include(l => l.LibraryCard)
                .Where(c => c.LibraryAsset.Id == assetId).OrderBy(c => c.Checkout);
        }

        public bool RemoveHold(int holdId)
        {
            var hold = this._context.Holds.Find(holdId);
            this._context.Holds.Remove(hold);
            return this._context.SaveChanges() > 0;
        }

        public bool SettleFees(string patronId)
        {
            var patron = this._context.Users
                    .Include(l => l.LibraryCard)
                    .SingleOrDefault(p => p.Id == patronId);
            
            if(patron == null)
                return false;
            
            if(patron.LibraryCard.Fees > 0)
            {
                patron.LibraryCard.Fees = 0;
                this._context.Users.Update(patron);
                return this._context.SaveChanges() > 0;
            }

            return false;

        }
    }
}