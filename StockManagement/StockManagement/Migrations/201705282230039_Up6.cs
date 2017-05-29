namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Up6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departures", "NBRE", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departures", "NBRE");
        }
    }
}
