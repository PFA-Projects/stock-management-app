namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Departure_Class : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departures", "number", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departures", "number");
        }
    }
}
