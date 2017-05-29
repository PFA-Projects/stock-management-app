namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Up_Arriv : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Arrivals", "Type", c => c.Int(nullable: false));
            DropColumn("dbo.Arrivals", "Type_French");
            DropColumn("dbo.Arrivals", "Type_English");
            DropColumn("dbo.Arrivals", "Type_Arab");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Arrivals", "Type_Arab", c => c.String());
            AddColumn("dbo.Arrivals", "Type_English", c => c.String());
            AddColumn("dbo.Arrivals", "Type_French", c => c.String());
            DropColumn("dbo.Arrivals", "Type");
        }
    }
}
