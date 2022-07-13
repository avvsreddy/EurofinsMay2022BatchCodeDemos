namespace KnowledgeHubPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catagories",
                c => new
                    {
                        CatagoryID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.CatagoryID);
            
            CreateStoredProcedure(
                "dbo.Catagory_Insert",
                p => new
                    {
                        Title = p.String(maxLength: 100),
                        Description = p.String(maxLength: 500),
                    },
                body:
                    @"INSERT [dbo].[Catagories]([Title], [Description])
                      VALUES (@Title, @Description)
                      
                      DECLARE @CatagoryID int
                      SELECT @CatagoryID = [CatagoryID]
                      FROM [dbo].[Catagories]
                      WHERE @@ROWCOUNT > 0 AND [CatagoryID] = scope_identity()
                      
                      SELECT t0.[CatagoryID]
                      FROM [dbo].[Catagories] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[CatagoryID] = @CatagoryID"
            );
            
            CreateStoredProcedure(
                "dbo.Catagory_Update",
                p => new
                    {
                        CatagoryID = p.Int(),
                        Title = p.String(maxLength: 100),
                        Description = p.String(maxLength: 500),
                    },
                body:
                    @"UPDATE [dbo].[Catagories]
                      SET [Title] = @Title, [Description] = @Description
                      WHERE ([CatagoryID] = @CatagoryID)"
            );
            
            CreateStoredProcedure(
                "dbo.Catagory_Delete",
                p => new
                    {
                        CatagoryID = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Catagories]
                      WHERE ([CatagoryID] = @CatagoryID)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Catagory_Delete");
            DropStoredProcedure("dbo.Catagory_Update");
            DropStoredProcedure("dbo.Catagory_Insert");
            DropTable("dbo.Catagories");
        }
    }
}
