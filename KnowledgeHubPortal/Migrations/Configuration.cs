namespace KnowledgeHubPortal.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KnowledgeHubPortal.Models.Data.KnowledgeHubDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "KnowledgeHubPortal.Models.Data.KnowledgeHubDbContext";
        }

        protected override void Seed(KnowledgeHubPortal.Models.Data.KnowledgeHubDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
