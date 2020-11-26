using MedelLibrary.Models;

namespace MedelLibrary.Services
{
    public interface IPersonalDetails
    {
        PersonalDetails AddPersonalDetails(PersonalDetails model);
        PersonalDetails GetPersonalDetailsById(int id);
    }
}