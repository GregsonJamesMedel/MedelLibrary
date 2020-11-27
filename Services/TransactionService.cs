using System;
using MedelLibrary.Data;
using MedelLibrary.Models;

namespace MedelLibrary.Services
{
    public class TransactionService : ITransaction
    {
        private readonly DataContext _context;

        public TransactionService(DataContext context)
        {
            this._context = context;
        }

        public bool AddCheckout(Checkout checkout)
        {
            this._context.Checkouts.Add(checkout);
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