using Microsoft.EntityFrameworkCore;
using MiniSiparisTakipUygulamasi.Models.Entities;

namespace MiniSiparisTakipUygulamasi.Models.MyConext
{
    public class Context : DbContext
    {

        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }

        public Context(DbContextOptions<Context> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //bağlantı vermeyi unutma 
            if (!optionsBuilder.IsConfigured)  
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-UNIU7FP\\SQLEXPRESS01;Database=MiniSiparisUyg;Trusted_Connection=True;TrustServerCertificate=true");
            }
        }
        // Seed Data eklemek için OnModelCreating metodunu override ediyoruz.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
        .HasKey(c => c.CategoryId);

            modelBuilder.Entity<Products>().HasKey(p => p.ProductId);

            // Seed Data: Kategoriler
            modelBuilder.Entity<Categories>().HasData(
                new Categories { CategoryId = 1, CategoryName = "Teknoloji" },
                new Categories { CategoryId = 2, CategoryName = "Gıda" },
                new Categories { CategoryId = 3, CategoryName = "Giyim" }
            );

            // Seed Data: Ürünler
            modelBuilder.Entity<Products>().HasData(
                new Products { ProductId = 1, ProductName = "Laptop", UnitPrice = 1000, UnitsInStock = 50, CategoryId = 1 },
                new Products { ProductId = 2, ProductName = "Yemek", UnitPrice = 25, UnitsInStock = 200, CategoryId = 2 },
                new Products { ProductId = 3, ProductName = "Tişört", UnitPrice = 15, UnitsInStock = 100, CategoryId = 3 }
            );
        }
    }
}
        

    
