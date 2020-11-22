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

        public IEnumerable<LibraryAsset> GetAllAssets()
        {
            return this._context.LibraryAsset.Include(asset => asset.Category);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return this._context.Books.Include(asset => asset.Category);

        }
    }
}