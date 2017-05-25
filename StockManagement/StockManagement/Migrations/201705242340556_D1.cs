namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class D1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MaterialRepairs", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.MaterialRepairs", "Material_Id", "dbo.Materials");
            DropForeignKey("dbo.MaterialRepairs", "Service_Id", "dbo.Services");
            DropIndex("dbo.MaterialRepairs", new[] { "Location_Id" });
            DropIndex("dbo.MaterialRepairs", new[] { "Material_Id" });
            DropIndex("dbo.MaterialRepairs", new[] { "Service_Id" });
            DropTable("dbo.MaterialRepairs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MaterialRepairs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Societe = c.String(),
                        Description = c.String(),
                        OutDate = c.DateTime(nullable: false),
                        ReturnDate = c.DateTime(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        Location_Id = c.Long(),
                        Material_Id = c.Long(),
                        Service_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.MaterialRepairs", "Service_Id");
            CreateIndex("dbo.MaterialRepairs", "Material_Id");
            CreateIndex("dbo.MaterialRepairs", "Location_Id");
            AddForeignKey("dbo.MaterialRepairs", "Service_Id", "dbo.Services", "Id");
            AddForeignKey("dbo.MaterialRepairs", "Material_Id", "dbo.Materials", "Id");
            AddForeignKey("dbo.MaterialRepairs", "Location_Id", "dbo.Locations", "Id");
        }
    }
}
