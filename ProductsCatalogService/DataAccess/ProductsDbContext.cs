using ProductsCatalogService.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsCatalogService.DataAccess
{
    public class ProductsDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Catagory> Catagories { get; set; }

        //public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Person> People { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Fluent API - TPC

            // create and map sp

            modelBuilder.Entity<Product>().MapToStoredProcedures(); // I/U/D

            //modelBuilder.Entity<Customer>().ToTable("Customers").Map().;
            //modelBuilder.Entity<Supplier>().ToTable("Suppliers");
            modelBuilder.Entity<Customer>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Customers");
            });

            modelBuilder.Entity<Supplier>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Suppliers");
            });
        }
    }
}
