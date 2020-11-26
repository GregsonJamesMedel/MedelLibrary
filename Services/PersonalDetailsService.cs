using MedelLibrary.Data;
using MedelLibrary.Models;

namespace MedelLibrary.Services
{
    public class PersonalDetailsService : IPersonalDetails
    {
        private readonly DataContext _context;

        public PersonalDetailsService(DataContext context)
        {
            this._context = context;
        }

        public int AddPersonalDetails(PersonalDetails model)
        {
            this._context.PersonalDetails.Add(model);
            var result = this._context.SaveChanges();
            return model.Id;
        }
    }
}