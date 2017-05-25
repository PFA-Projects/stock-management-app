namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_TM : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MaterialTransfers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Recipient = c.String(),
                        TransferDate = c.DateTime(nullable: false),
                        Observations = c.String(),
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
            DropForeignKey("dbo.MaterialTransfers", "Service_Id", "dbo.Services");
            DropForeignKey("dbo.MaterialTransfers", "Material_Id", "dbo.Materials");
            DropForeignKey("dbo.MaterialTransfers", "Location_Id", "dbo.Locations");
            DropIndex("dbo.MaterialTransfers", new[] { "Service_Id" });
            DropIndex("dbo.MaterialTransfers", new[] { "Material_Id" });
            DropIndex("dbo.MaterialTransfers", new[] { "Location_Id" });
            DropTable("dbo.MaterialTransfers");
        }
    }
}
