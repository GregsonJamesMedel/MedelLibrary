using Microsoft.AspNetCore.Identity;
using MedelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MedelLibrary.Data
{
    public class DbSeeder : IDbSeeder
    {
        private readonly UserManager<Patron> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly DataContext _context;

        public DbSeeder(UserManager<Patron> userManager,
            RoleManager<IdentityRole> roleManager,
            DataContext context)
        {
            this._userManager = userManager;
            this._roleManager = roleManager;
            this._context = context;
        }

        public void Seed()
        {
            if (this._context.Database.EnsureCreated())
            {
                SeedRoles();
                SeedDefaultUsers();
                SeedCategory();
                SeedBooks();
            }
        }

        private void SeedRoles()
        {
            var adminRole = this._roleManager.FindByNameAsync("Administrator").GetAwaiter().GetResult();
            var staffRole = this._roleManager.FindByNameAsync("Staff").GetAwaiter().GetResult();

            if (adminRole == null && staffRole == null)
            {
                var admin = new IdentityRole { Name = "Administrator" };
                var staff = new IdentityRole { Name = "Staff" };

                this._roleManager.CreateAsync(admin).GetAwaiter().GetResult();
                this._roleManager.CreateAsync(staff).GetAwaiter().GetResult();
            }
        }
        private void SeedDefaultUsers()
        {
            var adminAcc = this._userManager.FindByNameAsync("Administrator").GetAwaiter().GetResult();
            var staffAcc = this._userManager.FindByNameAsync("Staff").GetAwaiter().GetResult();

            if (adminAcc == null && staffAcc == null)
            {
                var defaultAdmin = new Patron
                {
                    UserName = "Administrator@MedelLibrary.com",
                    Email = "Administrator@MedelLibrary.com",
                    PersonalDetails = new PersonalDetails
                    {
                        Firstname = "Administrator",
                        Lastname = "Medel Library",
                        Address = "Medel Library",
                        ImageUrl = "NoProfilePhoto.png"
                    },
                    LibraryCard = new LibraryCard { Created = DateTime.Now }
                };

                var defaultStaff = new Patron
                {
                    UserName = "Staff@MedelLibrary.com",
                    Email = "Staff@MedelLibrary.com",
                    PersonalDetails = new PersonalDetails
                    {
                        Firstname = "Staff",
                        Lastname = "Medel Library",
                        Address = "Medel Library",
                        ImageUrl = "NoProfilePhoto.png"
                    },
                    LibraryCard = new LibraryCard { Created = DateTime.Now }
                };

                this._userManager.CreateAsync(defaultAdmin, "medellibrary").GetAwaiter().GetResult();
                this._userManager.CreateAsync(defaultStaff, "medellibrary").GetAwaiter().GetResult();

                this._userManager.AddToRoleAsync(defaultAdmin, "Administrator").GetAwaiter().GetResult();
                this._userManager.AddToRoleAsync(defaultStaff, "Staff").GetAwaiter().GetResult();
            }
        }
        private void SeedCategory()
        {
            
                var categories = new List<Category>
                {
                    new Category { Name = "Novel" },
                    new Category { Name = "Documentary" },
                    new Category { Name = "Computer" }
                };

                this._context.Categories.AddRange(categories);
                this._context.SaveChanges();
            
        }
        private void SeedBooks()
        {
            
            var books = new List<LibraryAsset>
            {
                new Book
                {
                    ISBN = "11-1234-567",
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    Year = "1925",
                    Cost = 399,
                    NumberOfCopies = 2,
                    Shelf = "SHELF-1",
                    Category = this._context.Categories.Find(1),
                    Condition = "New",
                    Status = "Available",
                    ImageUrl = "book1.jpg"
                },
                new Book
                {
                    ISBN = "12-1234-567",
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    Year = "1960",
                    Cost = 499,
                    NumberOfCopies = 4,
                    Shelf = "SHELF-2",
                    Category = this._context.Categories.Find(1),
                    Condition = "New",
                    Status = "Available",
                    ImageUrl = "book2.jpg"
                },
                new Book
                {
                    ISBN = "13-1234-567",
                    Title = "The Catcher in the Rye",
                    Author = "J. D. Salinger",
                    Year = "1951",
                    Cost = 599,
                    NumberOfCopies = 3,
                    Shelf = "SHELF-3",
                    Category = this._context.Categories.Find(1),
                    Condition = "New",
                    Status = "Available",
                    ImageUrl = "book3.jpg"
                },
                new Book
                {
                    ISBN = "14-1234-567",
                    Title = "One Hundred Years of Solitude",
                    Author = "Gabriel García Márquez",
                    Year = "1967",
                    Cost = 699,
                    NumberOfCopies = 5,
                    Shelf = "SHELF-4",
                    Category = this._context.Categories.Find(1),
                    Condition = "New",
                    Status = "Available",
                    ImageUrl = "book4.jpg"
                },
                new Book
                {
                    ISBN = "15-1234-567",
                    Title = "The Lord of the Rings",
                    Author = "J. R. R. Tolkien",
                    Year = "1954",
                    Cost = 799,
                    NumberOfCopies = 6,
                    Shelf = "SHELF-4",
                    Category = this._context.Categories.Find(1),
                    Condition = "New",
                    Status = "Available",
                    ImageUrl = "book5.jpg"
                },
                new Book
                {
                    ISBN = "16-1234-567",
                    Title = "Don Quixote",
                    Author = "Miguel de Cervantes",
                    Year = "1605",
                    Cost = 799,
                    NumberOfCopies = 3,
                    Shelf = "SHELF-5",
                    Category = this._context.Categories.Find(1),
                    Condition = "New",
                    Status = "Available",
                    ImageUrl = "book6.jpg"
                },
                new Book
                {
                    ISBN = "17-1234-567",
                    Title = "Madame Bovary",
                    Author = "Gustave Flaubert",
                    Year = "1856",
                    Cost = 569,
                    NumberOfCopies = 3,
                    Shelf = "SHELF-6",
                    Category = this._context.Categories.Find(1),
                    Condition = "New",
                    Status = "Available",
                    ImageUrl = "book7.jpg"
                },
                new Book
                {
                    ISBN = "18-1234-567",
                    Title = "The Brothers Karamazov",
                    Author = "Fyodor Dostoevsky",
                    Year = "1880",
                    Cost = 349,
                    NumberOfCopies = 3,
                    Shelf = "SHELF-6",
                    Category = this._context.Categories.Find(1),
                    Condition = "New",
                    Status = "Available",
                    ImageUrl = "book8.jpg"
                },
                new Book
                {
                    ISBN = "19-1234-567",
                    Title = "The Trial",
                    Author = "Franz Kafka",
                    Year = "1925",
                    Cost = 349,
                    NumberOfCopies = 3,
                    Shelf = "SHELF-6",
                    Category = this._context.Categories.Find(1),
                    Condition = "New",
                    Status = "Available",
                    ImageUrl = "book9.jpg"
                },
                new Book
                {
                    ISBN = "110-1234-567",
                    Title = "Heart of Darkness",
                    Author = "Joseph Conrad",
                    Year = "1899",
                    Cost = 349,
                    NumberOfCopies = 3,
                    Shelf = "SHELF-6",
                    Category = this._context.Categories.Find(1),
                    Condition = "New",
                    Status = "Available",
                    ImageUrl = "book10.jpg"
                }
            };

            this._context.LibraryAssets.AddRange(books);
            this._context.SaveChanges();
            
        }
    }
}