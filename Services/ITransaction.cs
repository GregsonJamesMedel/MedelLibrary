using System.Collections.Generic;
using MedelLibrary.Models;

namespace MedelLibrary.Services
{
    public interface ITransaction
    {
        LibraryCard CreateLibraryCard();
        LibraryCard GetLibraryCardById(int id);
        bool AddCheckout(int AssetId, int LibraryCardId);
        bool AddCheckIn(int AssetId, int LibraryCardId);
        bool AddCheckoutHistory(Checkout checkout);
        bool AddHold(int assetId, int libraryCardId);
        Checkout GetRecentCheckOut(int assetId);
        bool UpdateStatus(int id,string status); 
        IEnumerable<Checkout> GetAllCheckouts();
        IEnumerable<CheckoutHistory> GetAllCheckoutHistoryByLibraryCardId(int id);
    }
}