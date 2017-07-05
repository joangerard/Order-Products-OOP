using OrderProducts.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Repository.Config
{
    class StoreContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }

        public StoreContext()
            :base("StoreDatabase")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>().ToTable("Product");
        }
    }
}
