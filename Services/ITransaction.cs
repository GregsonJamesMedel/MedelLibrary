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
        IEnumerable<Hold> GetAssetHolds(int assetId);
        Checkout GetRecentCheckOut(int assetId);
        bool UpdateStatus(int id,string status); 
        Hold GetMostRecentHold(int assetId);
        IEnumerable<Checkout> GetAllCheckouts();
        IEnumerable<CheckoutHistory> GetAllCheckoutHistoryByLibraryCardId(int id);
        IEnumerable<CheckoutHistory> GetCheckoutHistoriesByAssetId(int assetId);
    }
}