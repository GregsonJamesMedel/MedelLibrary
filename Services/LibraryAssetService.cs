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
            throw new System.NotImplementedException();
        }
    }
}