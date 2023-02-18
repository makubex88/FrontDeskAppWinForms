using FrontDeskAppAPI.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace FrontDeskAppAPI.Context
{
    public class APIDbContext : DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "StorageDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity => 
            { 
                entity.Property(e => e.Id).IsRequired(); 
            });

            modelBuilder.Entity<Storage>(entity =>
            {
                entity.Property(e => e.Id).IsRequired();
            });

            modelBuilder.Entity<StorageTransaction>(entity =>
            {
                entity.Property(e => e.Id).IsRequired();
            });

            #region Customer
            modelBuilder.Entity<Customer>().HasData(new Customer 
            { 
                Id = 1, 
                LastName = "Testm",
                FirstName= "TestFN",
                Phone = "54354353543"
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 2,
                LastName = "Testq",
                FirstName = "TestFN2",
                Phone = "2131321321"
            });
            #endregion

            #region Storage
            modelBuilder.Entity<Storage>().HasData(new Storage
            {
                Id = 1,
                StorageName = "StorageOne",
                TotalOfSmallStorage = 48,
                TotalOfMediumStorage = 14,
                TotalOfLargeStorage = 12
            });
            #endregion
        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<StorageTransaction> StorageTransactions { get; set; }
    }
}
