namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update2_Table_Material : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Materials", "StockExistence");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Materials", "StockExistence", c => c.Boolean(nullable: false));
        }
    }
}
