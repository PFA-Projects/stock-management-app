namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Up11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Materials", "IsInStock", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Materials", "IsInStock");
        }
    }
}
