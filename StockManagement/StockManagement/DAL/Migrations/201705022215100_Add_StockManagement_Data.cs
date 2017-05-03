namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_StockManagement_Data : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deliveries",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DeliveryDate = c.DateTime(nullable: false),
                        Market_French = c.String(),
                        Market_English = c.String(),
                        Market_Arab = c.String(),
                        deliveryReceiptNumber = c.Int(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        societe_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Societes", t => t.societe_Id)
                .Index(t => t.societe_Id);
            
            CreateTable(
                "dbo.Societes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Designation_French = c.String(),
                        Designation_English = c.String(),
                        Designation_Arab = c.String(),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Designation_French = c.String(),
                        Designation_English = c.String(),
                        Designation_Arab = c.String(),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Name_French = c.String(),
                        Name_English = c.String(),
                        Name_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        service_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Services", t => t.service_Id)
                .Index(t => t.service_Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name_French = c.String(),
                        Name_English = c.String(),
                        Name_Arab = c.String(),
                        Observation_French = c.String(),
                        Observation_English = c.String(),
                        Observation_Arab = c.String(),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MaterialCategories",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Designation_French = c.String(),
                        Designation_English = c.String(),
                        Designation_Arab = c.String(),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        InventoryNumber_French = c.String(),
                        InventoryNumber_English = c.String(),
                        InventoryNumber_Arab = c.String(),
                        Designation_French = c.String(),
                        Designation_English = c.String(),
                        Designation_Arab = c.String(),
                        Mark_French = c.String(),
                        Mark_English = c.String(),
                        Mark_Arab = c.String(),
                        Model_French = c.String(),
                        Model_English = c.String(),
                        Model_Arab = c.String(),
                        UpdateServiceDate = c.DateTime(nullable: false),
                        Observation_French = c.String(),
                        Observation_English = c.String(),
                        Observation_Arab = c.String(),
                        AcquisitionValue = c.Single(nullable: false),
                        Acquisition = c.String(),
                        AcquisitionValueExist = c.Boolean(nullable: false),
                        StockExistence = c.Boolean(nullable: false),
                        dimension = c.Single(nullable: false),
                        INN_Number = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        delivery_Id = c.Long(),
                        materialCategory_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Deliveries", t => t.delivery_Id)
                .ForeignKey("dbo.MaterialCategories", t => t.materialCategory_Id)
                .Index(t => t.delivery_Id)
                .Index(t => t.materialCategory_Id);
            
            CreateTable(
                "dbo.MaterialAccessExits",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ExitDate = c.DateTime(nullable: false),
                        AccessDate = c.DateTime(nullable: false),
                        AccessReason_French = c.String(),
                        AccessReason_English = c.String(),
                        AccessReason_Arab = c.String(),
                        Observation_French = c.String(),
                        Observation_English = c.String(),
                        Observation_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        location_Id = c.Long(),
                        material_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.location_Id)
                .ForeignKey("dbo.Materials", t => t.material_Id)
                .Index(t => t.location_Id)
                .Index(t => t.material_Id);
            
            CreateTable(
                "dbo.Personnes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Cin = c.String(),
                        FirstName_French = c.String(),
                        FirstName_English = c.String(),
                        FirstName_Arab = c.String(),
                        LastName_French = c.String(),
                        LastName_English = c.String(),
                        LastName_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaterialAccessExits", "material_Id", "dbo.Materials");
            DropForeignKey("dbo.MaterialAccessExits", "location_Id", "dbo.Locations");
            DropForeignKey("dbo.Materials", "materialCategory_Id", "dbo.MaterialCategories");
            DropForeignKey("dbo.Materials", "delivery_Id", "dbo.Deliveries");
            DropForeignKey("dbo.Locations", "service_Id", "dbo.Services");
            DropForeignKey("dbo.Deliveries", "societe_Id", "dbo.Societes");
            DropIndex("dbo.MaterialAccessExits", new[] { "material_Id" });
            DropIndex("dbo.MaterialAccessExits", new[] { "location_Id" });
            DropIndex("dbo.Materials", new[] { "materialCategory_Id" });
            DropIndex("dbo.Materials", new[] { "delivery_Id" });
            DropIndex("dbo.Locations", new[] { "service_Id" });
            DropIndex("dbo.Deliveries", new[] { "societe_Id" });
            DropTable("dbo.Personnes");
            DropTable("dbo.MaterialAccessExits");
            DropTable("dbo.Materials");
            DropTable("dbo.MaterialCategories");
            DropTable("dbo.Services");
            DropTable("dbo.Locations");
            DropTable("dbo.Societes");
            DropTable("dbo.Deliveries");
        }
    }
}
