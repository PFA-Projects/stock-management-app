namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Up_M_c : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Materials", "Provider", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Materials", "Provider");
        }
    }
}
