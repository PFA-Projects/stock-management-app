namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Up_Mr_c1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MaterialRepairs", "TimesNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MaterialRepairs", "TimesNumber", c => c.Int(nullable: false));
        }
    }
}
