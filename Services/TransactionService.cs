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
    }
}