using MedelLibrary.Models;

namespace MedelLibrary.Services
{
    public interface ITransaction
    {
        LibraryCard CreateLibraryCard();

        LibraryCard GetLibraryCardById(int id);
        bool AddCheckout(Checkout checkout); 
    }
}