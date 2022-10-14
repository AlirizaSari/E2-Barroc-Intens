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
            //modelBuilder.Entity<CustomInvoiceProduct>().HasNoKey();
            //modelBuilder.Entity<CustomInvoiceProduct>().HasKey(c => new { c.CustomInvoiceId, c.ProductId });
        }
    }
}
