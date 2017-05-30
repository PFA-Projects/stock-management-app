namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_MT_C : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MaterialTransfers", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.MaterialTransfers", "Service_Id", "dbo.Services");
            DropIndex("dbo.MaterialTransfers", new[] { "Location_Id" });
            DropIndex("dbo.MaterialTransfers", new[] { "Service_Id" });
            DropColumn("dbo.MaterialTransfers", "Location_Id");
            DropColumn("dbo.MaterialTransfers", "Service_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MaterialTransfers", "Service_Id", c => c.Long());
            AddColumn("dbo.MaterialTransfers", "Location_Id", c => c.Long());
            CreateIndex("dbo.MaterialTransfers", "Service_Id");
            CreateIndex("dbo.MaterialTransfers", "Location_Id");
            AddForeignKey("dbo.MaterialTransfers", "Service_Id", "dbo.Services", "Id");
            AddForeignKey("dbo.MaterialTransfers", "Location_Id", "dbo.Locations", "Id");
        }
    }
}
