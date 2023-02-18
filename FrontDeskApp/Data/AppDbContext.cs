using FrontDeskApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontDeskApp.Data
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "StorageFacility");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<StorageTransaction> StorageTransactions { get; set; }
    }
}
