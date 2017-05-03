namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateClasses1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MaterialAccessExits", "location_Id", "dbo.Locations");
            DropForeignKey("dbo.MaterialAccessExits", "material_Id", "dbo.Materials");
            DropIndex("dbo.Deliveries", new[] { "societe_Id" });
            DropIndex("dbo.Locations", new[] { "service_Id" });
            DropIndex("dbo.Materials", new[] { "delivery_Id" });
            DropIndex("dbo.Materials", new[] { "materialCategory_Id" });
            DropIndex("dbo.MaterialAccessExits", new[] { "location_Id" });
            DropIndex("dbo.MaterialAccessExits", new[] { "material_Id" });
            CreateTable(
                "dbo.MaterialInOuts",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        OutDate = c.DateTime(nullable: false),
                        InDate = c.DateTime(nullable: false),
                        InReason_French = c.String(),
                        InReason_English = c.String(),
                        InReason_Arab = c.String(),
                        OutReason_French = c.String(),
                        OutReason_English = c.String(),
                        OutReason_Arab = c.String(),
                        Observation_French = c.String(),
                        Observation_English = c.String(),
                        Observation_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        Employee_Id = c.Long(),
                        Location_Id = c.Long(),
                        Material_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .ForeignKey("dbo.Locations", t => t.Location_Id)
                .ForeignKey("dbo.Materials", t => t.Material_Id)
                .Index(t => t.Employee_Id)
                .Index(t => t.Location_Id)
                .Index(t => t.Material_Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName_French = c.String(),
                        FirstName_English = c.String(),
                        FirstName_Arab = c.String(),
                        LastName_French = c.String(),
                        LastName_English = c.String(),
                        LastName_Arab = c.String(),
                        CIN = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Sex = c.Boolean(nullable: false),
                        ProfilePhoto = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                        Cellphone = c.String(),
                        FaceBook = c.String(),
                        WebSite = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        City_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .Index(t => t.City_Id);
            
            AddColumn("dbo.Materials", "PhysicalState", c => c.Int(nullable: false));
            CreateIndex("dbo.Deliveries", "Societe_Id");
            CreateIndex("dbo.Locations", "Service_Id");
            CreateIndex("dbo.Materials", "Delivery_Id");
            CreateIndex("dbo.Materials", "MaterialCategory_Id");
            DropColumn("dbo.Locations", "Designation_French");
            DropColumn("dbo.Locations", "Designation_English");
            DropColumn("dbo.Locations", "Designation_Arab");
            DropTable("dbo.MaterialAccessExits");
            DropTable("dbo.Personnes");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Locations", "Designation_Arab", c => c.String());
            AddColumn("dbo.Locations", "Designation_English", c => c.String());
            AddColumn("dbo.Locations", "Designation_French", c => c.String());
            DropForeignKey("dbo.MaterialInOuts", "Material_Id", "dbo.Materials");
            DropForeignKey("dbo.MaterialInOuts", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.MaterialInOuts", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Employees", "City_Id", "dbo.Cities");
            DropIndex("dbo.Employees", new[] { "City_Id" });
            DropIndex("dbo.MaterialInOuts", new[] { "Material_Id" });
            DropIndex("dbo.MaterialInOuts", new[] { "Location_Id" });
            DropIndex("dbo.MaterialInOuts", new[] { "Employee_Id" });
            DropIndex("dbo.Materials", new[] { "MaterialCategory_Id" });
            DropIndex("dbo.Materials", new[] { "Delivery_Id" });
            DropIndex("dbo.Locations", new[] { "Service_Id" });
            DropIndex("dbo.Deliveries", new[] { "Societe_Id" });
            DropColumn("dbo.Materials", "PhysicalState");
            DropTable("dbo.Employees");
            DropTable("dbo.MaterialInOuts");
            CreateIndex("dbo.MaterialAccessExits", "material_Id");
            CreateIndex("dbo.MaterialAccessExits", "location_Id");
            CreateIndex("dbo.Materials", "materialCategory_Id");
            CreateIndex("dbo.Materials", "delivery_Id");
            CreateIndex("dbo.Locations", "service_Id");
            CreateIndex("dbo.Deliveries", "societe_Id");
            AddForeignKey("dbo.MaterialAccessExits", "material_Id", "dbo.Materials", "Id");
            AddForeignKey("dbo.MaterialAccessExits", "location_Id", "dbo.Locations", "Id");
        }
    }
}
