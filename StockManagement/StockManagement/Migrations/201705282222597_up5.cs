namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departures", "Type", c => c.Int(nullable: false));
            DropColumn("dbo.Arrivals", "Type");
            DropColumn("dbo.Departures", "Number");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departures", "Number", c => c.Int(nullable: false));
            AddColumn("dbo.Arrivals", "Type", c => c.Int(nullable: false));
            DropColumn("dbo.Departures", "Type");
        }
    }
}
