namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Table_MaterielInOut : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MaterialInOuts", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.MaterialInOuts", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.MaterialInOuts", "Material_Id", "dbo.Materials");
            DropIndex("dbo.MaterialInOuts", new[] { "Employee_Id" });
            DropIndex("dbo.MaterialInOuts", new[] { "Location_Id" });
            DropIndex("dbo.MaterialInOuts", new[] { "Material_Id" });
            DropColumn("dbo.MaterialInOuts", "Employee_Id");
            DropColumn("dbo.MaterialInOuts", "Location_Id");
            DropColumn("dbo.MaterialInOuts", "Material_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MaterialInOuts", "Material_Id", c => c.Long());
            AddColumn("dbo.MaterialInOuts", "Location_Id", c => c.Long());
            AddColumn("dbo.MaterialInOuts", "Employee_Id", c => c.Long());
            CreateIndex("dbo.MaterialInOuts", "Material_Id");
            CreateIndex("dbo.MaterialInOuts", "Location_Id");
            CreateIndex("dbo.MaterialInOuts", "Employee_Id");
            AddForeignKey("dbo.MaterialInOuts", "Material_Id", "dbo.Materials", "Id");
            AddForeignKey("dbo.MaterialInOuts", "Location_Id", "dbo.Locations", "Id");
            AddForeignKey("dbo.MaterialInOuts", "Employee_Id", "dbo.Employees", "Id");
        }
    }
}
