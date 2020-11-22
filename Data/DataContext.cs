using MedelLibrary.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedelLibrary.Data
{
    public class DataContext : IdentityDbContext<Patron>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Category> Categories { get; set; }
        public DbSet<LibraryAsset> LibraryAsset { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}