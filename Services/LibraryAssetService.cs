using MedelLibrary.Data;
using MedelLibrary.Models;

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
    }
}