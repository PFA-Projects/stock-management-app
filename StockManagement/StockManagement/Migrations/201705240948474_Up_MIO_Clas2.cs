namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Up_MIO_Clas2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MaterialInOuts", "IsMaterialInStock", c => c.Boolean(nullable: false));
            AddColumn("dbo.MaterialInOuts", "InDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.MaterialInOuts", "InReason", c => c.String());
            AddColumn("dbo.MaterialInOuts", "OutDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.MaterialInOuts", "OutReason", c => c.String());
            AddColumn("dbo.MaterialInOuts", "Location_Id", c => c.Long());
            AddColumn("dbo.MaterialInOuts", "Service_Id", c => c.Long());
            CreateIndex("dbo.MaterialInOuts", "Location_Id");
            CreateIndex("dbo.MaterialInOuts", "Service_Id");
            AddForeignKey("dbo.MaterialInOuts", "Location_Id", "dbo.Locations", "Id");
            AddForeignKey("dbo.MaterialInOuts", "Service_Id", "dbo.Services", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaterialInOuts", "Service_Id", "dbo.Services");
            DropForeignKey("dbo.MaterialInOuts", "Location_Id", "dbo.Locations");
            DropIndex("dbo.MaterialInOuts", new[] { "Service_Id" });
            DropIndex("dbo.MaterialInOuts", new[] { "Location_Id" });
            DropColumn("dbo.MaterialInOuts", "Service_Id");
            DropColumn("dbo.MaterialInOuts", "Location_Id");
            DropColumn("dbo.MaterialInOuts", "OutReason");
            DropColumn("dbo.MaterialInOuts", "OutDate");
            DropColumn("dbo.MaterialInOuts", "InReason");
            DropColumn("dbo.MaterialInOuts", "InDate");
            DropColumn("dbo.MaterialInOuts", "IsMaterialInStock");
        }
    }
}
