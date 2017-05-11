namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_tables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Phone_French", c => c.String());
            AddColumn("dbo.Employees", "Phone_English", c => c.String());
            AddColumn("dbo.Employees", "Phone_Arab", c => c.String());
            AddColumn("dbo.Employees", "location_Id", c => c.Long());
            CreateIndex("dbo.Employees", "location_Id");
            AddForeignKey("dbo.Employees", "location_Id", "dbo.Locations", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "location_Id", "dbo.Locations");
            DropIndex("dbo.Employees", new[] { "location_Id" });
            DropColumn("dbo.Employees", "location_Id");
            DropColumn("dbo.Employees", "Phone_Arab");
            DropColumn("dbo.Employees", "Phone_English");
            DropColumn("dbo.Employees", "Phone_French");
        }
    }
}
