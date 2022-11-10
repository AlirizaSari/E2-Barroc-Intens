using Barroc_Intens.Classes;
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
        public DbSet<MaintenanceAppointmentProduct> MaintenanceAppointmentProducts { get; set; }
        public DbSet<CustomInvoice> CustomInvoices { get; set; }
        public DbSet<CustomInvoiceProduct> CustomInvoiceProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<StockStatus> StockStatuses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Leasecontract> LeaseContracts { get; set; }





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
                new User { UserId = 1, Name = "Admin", UserName = "Admin", Password = "123", RolId = 1 },
                new User { UserId = 2, Name = "Finance Head", UserName = "FinanceHead", Password = "123", RolId = 2 },
                new User { UserId = 3, Name = "Finance", UserName = "Finance", Password = "123", RolId = 3 },
                new User { UserId = 4, Name = "Sales Head", UserName = "SalesHead", Password = "123", RolId = 4 },
                new User { UserId = 5, Name = "Sales", UserName = "Sales", Password = "123", RolId = 5 },
                new User { UserId = 6, Name = "Inkoop Head", UserName = "InkoopHead", Password = "123", RolId = 6 },
                new User { UserId = 7, Name = "Inkoop", UserName = "Inkoop", Password = "123", RolId = 7 },
                new User { UserId = 8, Name = "Maintenance Head", UserName = "MaintenanceHead", Password = "123", RolId = 8 },
                new User { UserId = 9, Name = "Mainentance", UserName = "Maintenance", Password = "123", RolId = 9 },

                new User { UserId = 10, Name = "Henk", UserName = "Henk", Password = "123", RolId = 9 },
                new User { UserId = 11, Name = "Piet", UserName = "Piet", Password = "123", RolId = 9 },
                new User { UserId = 12, Name = "Elsa", UserName = "Elsa", Password = "123", RolId = 9 },
                new User { UserId = 13, Name = "Sharon", UserName = "Sharon", Password = "123", RolId = 9 });


            modelBuilder.Entity<Company>().HasData(
                new Company { CompanyId = 1, Name = "Curio", Phone = "0648686105", EmailAddress = "curio@curio.com",Street = "Terheidenseweg", HouseNumber = "350", City = "Breda", CountryCode = "31", IsBkrChecked = true, BkrCheckedAt = DateTime.Now, UserId = 1 },
                new Company { CompanyId = 2, Name = "Hustllebv", Phone = "0658686185", EmailAddress = "hustllebv@hustle.nl",Street = "Poolseweg", HouseNumber = "50", City = "Tilburg", CountryCode = "31", IsBkrChecked = true, BkrCheckedAt = DateTime.Today.AddDays(-10), UserId = 2 },
                new Company { CompanyId = 3, Name = "Jarmo Inc.", Phone = "267-555-0100", EmailAddress = "Jarmo@Jarmo.nl",Street = "Grove Street", HouseNumber = "204", City = "LazyTown", CountryCode = "69", IsBkrChecked = false, BkrCheckedAt = null, UserId = 3
                });

            modelBuilder.Entity<Leasecontract>().HasData(
                new Leasecontract { id = 1, CompanyId = 1, BkrChecked = 1, UserId = 1, ProductId = 2, PaymentTerm = "Jaarlijks", CreateDate = DateTime.Today.AddMonths(-1) }, 
                new Leasecontract { id = 2, CompanyId = 2, BkrChecked = 0, UserId = 2, ProductId = 3, PaymentTerm = "Maandelijks", CreateDate = DateTime.Today                 
                });

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Automaten", IsEmployeeOnly = 2 },
                new Category { CategoryId = 2, Name = "Koffiebonen", IsEmployeeOnly = 2 },
                new Category { CategoryId = 3, Name = "Onderdelen", IsEmployeeOnly = 2 
                });

            modelBuilder.Entity<CustomInvoice>().HasData(
                new CustomInvoice { CustomInvoiceId=1, CompanyId=2, Date = DateTime.Today.AddDays(20), PricePerHour = 30, Discount = 0, HoursWorked = 10, PaidAt = null, Notes = "Koffiebonen ontbreken nog", PaymentTerm = "Jaarlijks" },
                new CustomInvoice { CustomInvoiceId=2, CompanyId=3, Date = DateTime.Today, PricePerHour = 10, Discount = 0, HoursWorked = 4, PaidAt = null, Notes = "BKR is nog niet gechecked", PaymentTerm = "Maandelijks" },
                new CustomInvoice { CustomInvoiceId=3, CompanyId=1, Date = DateTime.Today.AddDays(-20), PricePerHour = 20, Discount = 10, HoursWorked = 40, PaidAt = DateTime.Today, Notes = "10 jaar klant", PaymentTerm = "Jaarlijks" }
                );

            modelBuilder.Entity<StockStatus>().HasData(
                new StockStatus { StockStatusId = 1, Name = "Uit voorraad" },
                new StockStatus { StockStatusId = 2, Name = "Momenteel leverbaar" },
                new StockStatus { StockStatusId = 3, Name = "Momenteel leverbaar(Bijbesteld)" },
                new StockStatus { StockStatusId = 4, Name = "Besteld" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Barroc Intens Italian Light", Description = "S234FREKT\r\n\r\nLease contract: 499,- excl btw per maand\r\n\r\nInstallatiekosten vast: 289,- excl btw.", Brand = "Italian", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 1 },
                new Product { ProductId = 2, Name = "Barroc Intens Italian", Description = "S234KNDPF\r\n\r\nLease contract: 599 excl btw\r\n\r\nInstallatiekosten vast: 289,- excl btw.", Brand = "Italian", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 1 },
                new Product { ProductId = 3, Name = "Barroc Intens Italian Deluxe", Description = "S234NNBMV\r\n\r\nLease contract: 799 excl btw\r\n\r\nInstallatiekosten eenmalig vast: 375,- excl btw.", Brand = "Italian", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 1 },
                new Product { ProductId = 4, Name = "Barroc Intens Italian Deluxe Special", Description = "S234MMPLA\r\n\r\nLease contract: 999 excl btw\r\n\r\nInstallatiekosten eenmalig vast: 375,- excl btw.", Brand = "Italian", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 1 },
                new Product { ProductId = 5, Name = "Espresso Beneficio", Description = "S239KLIUP\r\n\r\nEen toegankelijke en zachte koffie. Hij is afkomstig van de Finca El Limoncillo, een weelderige plantage aan de rand van het regenwoud in de Matagalpa regio in Nicaragua.\r\n\r\nPer kg: 21.60 excl btw.", Brand = "Beneficio", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 2 },
                new Product { ProductId = 6, Name = "Yellow Bourbon Brasil", Description = "S239MNKLL\r\n\r\nKoffie van de oorspronkelijke koffiestruik (de Bourbon) met gele koffiebessen. Deze zeldzame koffie heeft de afgelopen 20 jaar steeds meer erkenning gekregen en vele prijzen gewonnen.\r\n\r\nPer kg: 23,20 excl btw.", Brand = "Bourbon Brasil", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 2 },
                new Product { ProductId = 7, Name = "Espresso Roma", Description = "S239IPPSD\r\n\r\nEen Italiaanse espresso met een krachtig karakter en een aromatische afdronk.\r\n\r\nPer kg: 20,80 excl btw.", Brand = "Roma", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 2 },
                new Product { ProductId = 8, Name = "Red Honey Honduras", Description = "S239EVVFS\r\n\r\nDe koffie is geproduceerd volgens de honey-methode. Hierbij wordt de koffieboon in haar vruchtvlees gedroogd, waardoor de zoete fruitsmaak diep in de boon trekt. Dit levert een éxtra zoete koffie op.\r\n\r\nPer kg: 27,80 excl btw.", Brand = "Honduras",
                    AmountInStock = 0,
                    StockStatusId = 1,
                    OrderAmount = 0,
                    CategoryId = 2
                }); ;

            modelBuilder.Entity<MaintenanceAppointment>().HasData(
                new MaintenanceAppointment { MaintenanceAppointmentId = 1, CompanyId = 1, Remark = "Koffiezet automaat 1 is ontploft", Added = DateTime.Now, AppointmentDate = null, AppointmentTime = null, AppointmentIsPlanned = false, AssignedEmployee = null, UserId = null, IsRoutineAppointment = true, },
                new MaintenanceAppointment { MaintenanceAppointmentId = 2, CompanyId = 1, Remark = "Koffiezet automaat 2 is ontploft", Added = DateTime.Now, AppointmentDate = null, AppointmentTime = null, AppointmentIsPlanned = false, AssignedEmployee = null, UserId = null, IsRoutineAppointment = false, },
                new MaintenanceAppointment { MaintenanceAppointmentId = 3, CompanyId = 1, Remark = "Koffiezet automaat 3 is de linker tuben kapot", Added = DateTime.Now, AppointmentDate = null, AppointmentTime = null, AppointmentIsPlanned = false, AssignedEmployee = null, UserId = null, IsRoutineAppointment = false, },
                new MaintenanceAppointment { MaintenanceAppointmentId = 4, CompanyId = 1, Remark = "Koffiezet automaat 4 is ontploft", Added = DateTime.Now, AppointmentDate = null, AppointmentTime = null, AppointmentIsPlanned = false, AssignedEmployee = null, UserId = null, IsRoutineAppointment = false, },
                new MaintenanceAppointment { MaintenanceAppointmentId = 5, CompanyId = 2, Remark = "Koffiezet automaat 1 is ontploft", Added = DateTime.Now, AppointmentDate = null, AppointmentTime = null, AppointmentIsPlanned = false, AssignedEmployee = null, UserId = null, IsRoutineAppointment = true, },
                new MaintenanceAppointment { MaintenanceAppointmentId = 6, CompanyId = 2, Remark = "Koffiezet automaat 2 is de linker tuben kapot", Added = DateTime.Now, AppointmentDate = null, AppointmentTime = null, AppointmentIsPlanned = false, AssignedEmployee = null, UserId = null, IsRoutineAppointment = false, },
                new MaintenanceAppointment { MaintenanceAppointmentId = 7, CompanyId = 2, Remark = "Koffiezet automaat 3 is ontploft", Added = DateTime.Now, AppointmentDate = null, AppointmentTime = null, AppointmentIsPlanned = false, AssignedEmployee = null, UserId = null, IsRoutineAppointment = false, },
                new MaintenanceAppointment{ MaintenanceAppointmentId = 8,CompanyId = 2,Remark = "Koffiezet automaat 4 is ontploft",Added = DateTime.Now,AppointmentDate = null,AppointmentTime = null, AppointmentIsPlanned = false, AssignedEmployee = null, UserId = null,IsRoutineAppointment = false,                
                });
        }
    }
}