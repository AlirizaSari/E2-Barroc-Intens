using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barroc_Intens
{
    internal class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<MaintenanceAppointment> MaintenanceAppointments { get; set; }
        public DbSet<CustomInvoice> CustomInvoices { get; set; }
        public DbSet<CustomInvoiceProduct> CustomInvoiceProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
 




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=barroc_intens;user=root;password=;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rol>().HasData(
                new Rol { RolId = 1, Name = "Admin", IsManager = 1 },
                new Rol { RolId = 2, Name = "Finance.Head", IsManager = 1 },
                new Rol { RolId = 3, Name = "Finance", IsManager = 2 },
                new Rol { RolId = 4, Name = "Sales.Head", IsManager = 1 },
                new Rol { RolId = 5, Name = "Sales", IsManager = 2 },
                new Rol { RolId = 6, Name = "Inkoop.Head", IsManager = 1 },
                new Rol { RolId = 7, Name = "Inkoop", IsManager = 2 },
                new Rol { RolId = 8, Name = "Maintenance.Head", IsManager = 1 },
                new Rol { RolId = 9, Name = "Mainentance", IsManager = 2 });

            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Name = "Admin", UserName = "Admin", Password = "123", RolId = 1/*, IsLoggedIn = false*/ },
                new User { UserId = 2, Name = "Finance Head", UserName = "FinanceHead", Password = "123", RolId = 2/*, IsLoggedIn = false*/ },
                new User { UserId = 3, Name = "Finance", UserName = "Finance", Password = "123", RolId = 3/*, IsLoggedIn = false*/ },
                new User { UserId = 4, Name = "Sales Head", UserName = "SalesHead", Password = "123", RolId = 4/*, IsLoggedIn = false*/ },
                new User { UserId = 5, Name = "Sales", UserName = "Sales", Password = "123", RolId = 5/*, IsLoggedIn = false*/ },
                new User { UserId = 6, Name = "Inkoop Head", UserName = "InkoopHead", Password = "123", RolId = 6/*, IsLoggedIn = false*/ },
                new User { UserId = 7, Name = "Inkoop", UserName = "Inkoop", Password = "123", RolId = 7/*, IsLoggedIn = false*/ },
                new User { UserId = 8, Name = "Maintenance Head", UserName = "MaintenanceHead", Password = "123", RolId = 8/*, IsLoggedIn = false*/ },
                new User { UserId = 9, Name = "Mainentance", UserName = "Maintenance", Password = "123", RolId = 9/*, IsLoggedIn = false*/ });

            modelBuilder.Entity<Company>().HasData(
                new Company { CompanyId = 1, Name = "Curio", Phone = "0648686105", Street = "terheidenseweg", HouseNumber = "350", City = "Breda", CountryCode = "31", BkrCheckedAt = DateTime.Now, UserId = 1 
                });

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Automaten", IsEmployeeOnly = 2 },
                new Category { CategoryId = 2, Name = "Koffiebonen", IsEmployeeOnly = 2 });
        }
    }
}
