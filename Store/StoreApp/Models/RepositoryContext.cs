using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products {get ; set ;}
        
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(
                new Product(){ProductId=1,ProductName="Computer",Price=17_000},
                new Product(){ProductId=2,ProductName="mouse",Price=17_000},
                new Product(){ProductId=3,ProductName="monitor",Price=17_000},
                new Product(){ProductId=4,ProductName="ssd",Price=2323},
                new Product(){ProductId=5,ProductName="hdd",Price=1237_000},
                new Product(){ProductId=6,ProductName="spekar",Price=171_000}
            );
        }







    
    }

}