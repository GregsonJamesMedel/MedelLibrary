using MedelLibrary.Models;

namespace MedelLibrary.Services
{
    public interface ITransaction
    {
        LibraryCard CreateLibraryCard();
        bool AddCheckout(Checkout checkout); 
    }
}