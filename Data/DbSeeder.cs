using Microsoft.AspNetCore.Identity;
using MedelLibrary.Models;
using System;

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
                        Address = "Medel Library"
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
                        Address = "Medel Library"
                    },
                    LibraryCard = new LibraryCard { Created = DateTime.Now }
                };

                this._userManager.CreateAsync(defaultAdmin, "medellibrary").GetAwaiter().GetResult();
                this._userManager.CreateAsync(defaultStaff, "medellibrary").GetAwaiter().GetResult();

                this._userManager.AddToRoleAsync(defaultAdmin, "Administrator").GetAwaiter().GetResult();
                this._userManager.AddToRoleAsync(defaultStaff, "Staff").GetAwaiter().GetResult();
            }
        }
    }
}