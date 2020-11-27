using MedelLibrary.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedelLibrary.Data
{
    public class DataContext : IdentityDbContext<Patron>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Category> Categories { get; set; }
        public DbSet<LibraryAsset> LibraryAssets { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<PersonalDetails> PersonalDetails { get; set; }
        public DbSet<LibraryCard> LibraryCards { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
        public DbSet<CheckoutHistory> CheckoutHistories { get; set; }
        public DbSet<Hold> Holds { get; set; }
    }
}