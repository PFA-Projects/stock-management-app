namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Upd_MIO_clas1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MaterialInOuts", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.MaterialInOuts", "Material_Id", "dbo.Materials");
            DropForeignKey("dbo.MaterialInOuts", "NewLocation_Id", "dbo.Locations");
            DropForeignKey("dbo.MaterialInOuts", "OriginaLLocation_Id", "dbo.Locations");
            DropIndex("dbo.MaterialInOuts", new[] { "Employee_Id" });
            DropIndex("dbo.MaterialInOuts", new[] { "Material_Id" });
            DropIndex("dbo.MaterialInOuts", new[] { "NewLocation_Id" });
            DropIndex("dbo.MaterialInOuts", new[] { "OriginaLLocation_Id" });
            AddColumn("dbo.MaterialInOuts", "MaterialState", c => c.Int(nullable: false));
            DropColumn("dbo.MaterialInOuts", "Reason_French");
            DropColumn("dbo.MaterialInOuts", "Reason_English");
            DropColumn("dbo.MaterialInOuts", "Reason_Arab");
            DropColumn("dbo.MaterialInOuts", "Observation_French");
            DropColumn("dbo.MaterialInOuts", "Observation_English");
            DropColumn("dbo.MaterialInOuts", "Observation_Arab");
            DropColumn("dbo.MaterialInOuts", "InOutDate");
            DropColumn("dbo.MaterialInOuts", "Employee_Id");
            DropColumn("dbo.MaterialInOuts", "Material_Id");
            DropColumn("dbo.MaterialInOuts", "NewLocation_Id");
            DropColumn("dbo.MaterialInOuts", "OriginaLLocation_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MaterialInOuts", "OriginaLLocation_Id", c => c.Long());
            AddColumn("dbo.MaterialInOuts", "NewLocation_Id", c => c.Long());
            AddColumn("dbo.MaterialInOuts", "Material_Id", c => c.Long());
            AddColumn("dbo.MaterialInOuts", "Employee_Id", c => c.Long());
            AddColumn("dbo.MaterialInOuts", "InOutDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.MaterialInOuts", "Observation_Arab", c => c.String());
            AddColumn("dbo.MaterialInOuts", "Observation_English", c => c.String());
            AddColumn("dbo.MaterialInOuts", "Observation_French", c => c.String());
            AddColumn("dbo.MaterialInOuts", "Reason_Arab", c => c.String());
            AddColumn("dbo.MaterialInOuts", "Reason_English", c => c.String());
            AddColumn("dbo.MaterialInOuts", "Reason_French", c => c.String());
            DropColumn("dbo.MaterialInOuts", "MaterialState");
            CreateIndex("dbo.MaterialInOuts", "OriginaLLocation_Id");
            CreateIndex("dbo.MaterialInOuts", "NewLocation_Id");
            CreateIndex("dbo.MaterialInOuts", "Material_Id");
            CreateIndex("dbo.MaterialInOuts", "Employee_Id");
            AddForeignKey("dbo.MaterialInOuts", "OriginaLLocation_Id", "dbo.Locations", "Id");
            AddForeignKey("dbo.MaterialInOuts", "NewLocation_Id", "dbo.Locations", "Id");
            AddForeignKey("dbo.MaterialInOuts", "Material_Id", "dbo.Materials", "Id");
            AddForeignKey("dbo.MaterialInOuts", "Employee_Id", "dbo.Employees", "Id");
        }
    }
}
