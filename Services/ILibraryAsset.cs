using System.Collections;
using System.Collections.Generic;
using MedelLibrary.Models;

namespace MedelLibrary.Services
{
    public interface ILibraryAsset
    {
        bool AddLibraryAsset(LibraryAsset asset);
        bool DeleteAsset(int id);
        bool UpdateAsset(LibraryAsset asset);
        bool MarkLost(int assetId);
        bool MarkFound(int assetId);
        IEnumerable<LibraryAsset> GetAllAssets();
        IEnumerable<Book> GetAllBooks();
        string GetAuthorOrDirector(int id);
        string GetISBN(int id);
        string GetType(int id);
        LibraryAsset GetAsset(int id);
    }
}