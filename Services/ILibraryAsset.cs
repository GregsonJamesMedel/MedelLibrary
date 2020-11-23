using System.Collections;
using System.Collections.Generic;
using MedelLibrary.Models;

namespace MedelLibrary.Services
{
    public interface ILibraryAsset
    {
        bool AddLibraryAsset(LibraryAsset asset);
        IEnumerable<LibraryAsset> GetAllAssets();
        IEnumerable<Book> GetAllBooks();
        string GetAuthorOrDirector(int id);
        string GetISBN(int id);
    }
}