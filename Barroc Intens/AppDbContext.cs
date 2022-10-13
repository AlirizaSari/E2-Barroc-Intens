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
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
 




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=barroc_intens;user=root;password=;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Automaten", IsEmployeeOnly = 1 },
                new Category { CategoryId = 2, Name = "Koffiebonen", IsEmployeeOnly = 1 });

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, CategoryId = 1, Name = "Barroc Intens Italian Light" },
                new Product { ProductId = 2, CategoryId = 1, Name = "Barroc Intens Italian" },
                new Product { ProductId = 3, CategoryId = 1, Name = "Barroc Intens Italian Deluxe" },
                new Product { ProductId = 4, CategoryId = 1, Name = "Barroc Intens Italian Deluxe Special" },
                new Product { ProductId = 5, CategoryId = 2, Name = "Espresso Beneficio" },
                new Product { ProductId = 6, CategoryId = 2, Name = "Yellow Bourbon Brasil" },
                new Product { ProductId = 7, CategoryId = 2, Name = "Espresso Roma" },
                new Product { ProductId = 8, CategoryId = 2, Name = "Red Honey Honduras" });

        }
    }
}
