namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Upd_MR_c : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MaterialRepairs", "TimesNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MaterialRepairs", "TimesNumber");
        }
    }
}
