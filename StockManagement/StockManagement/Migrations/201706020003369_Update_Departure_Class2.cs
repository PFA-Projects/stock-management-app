namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Departure_Class2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departures", "Observations", c => c.String());
            DropColumn("dbo.Departures", "Observations_French");
            DropColumn("dbo.Departures", "Observations_English");
            DropColumn("dbo.Departures", "Observations_Arab");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departures", "Observations_Arab", c => c.String());
            AddColumn("dbo.Departures", "Observations_English", c => c.String());
            AddColumn("dbo.Departures", "Observations_French", c => c.String());
            DropColumn("dbo.Departures", "Observations");
        }
    }
}
