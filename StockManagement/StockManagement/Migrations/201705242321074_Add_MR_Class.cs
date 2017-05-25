namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_MR_Class : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.Location_Id)
                .ForeignKey("dbo.Materials", t => t.Material_Id)
                .ForeignKey("dbo.Services", t => t.Service_Id)
                .Index(t => t.Location_Id)
                .Index(t => t.Material_Id)
                .Index(t => t.Service_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaterialRepairs", "Service_Id", "dbo.Services");
            DropForeignKey("dbo.MaterialRepairs", "Material_Id", "dbo.Materials");
            DropForeignKey("dbo.MaterialRepairs", "Location_Id", "dbo.Locations");
            DropIndex("dbo.MaterialRepairs", new[] { "Service_Id" });
            DropIndex("dbo.MaterialRepairs", new[] { "Material_Id" });
            DropIndex("dbo.MaterialRepairs", new[] { "Location_Id" });
            DropTable("dbo.MaterialRepairs");
        }
    }
}
