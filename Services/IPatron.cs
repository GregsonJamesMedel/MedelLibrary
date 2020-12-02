using System.Collections.Generic;
using MedelLibrary.ViewModels;

namespace MedelLibrary.Services
{
    public interface IPatron
    {
        IEnumerable<PatronModel> GetAllPatrons();
    }
}