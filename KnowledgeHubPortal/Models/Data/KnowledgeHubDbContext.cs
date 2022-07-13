using KnowledgeHubPortal.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KnowledgeHubPortal.Models.Data
{
    public class KnowledgeHubDbContext : DbContext
    {
        public KnowledgeHubDbContext():base("name=DefaultConnection")
        {

        }


        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catagory>().MapToStoredProcedures();
        }
    }
}