using MedelLibrary.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedelLibrary.Data
{
    public class DataContext : IdentityDbContext<Patron>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
    }
}