using System.Collections.Generic;
using MedelLibrary.Models;

namespace MedelLibrary.Services
{
    public interface ITransaction
    {
        LibraryCard CreateLibraryCard();
        LibraryCard GetLibraryCardById(int id);
        bool AddCheckout(int AssetId, int LibraryCardId);
        bool UpdateStatus(int id,string status); 
        IEnumerable<Checkout> GetAllCheckouts();
    }
}