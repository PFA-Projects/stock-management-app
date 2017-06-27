namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Upd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departures", "DepartureFile", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departures", "DepartureFile");
        }
    }
}
