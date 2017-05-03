namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_table_Material : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Materials", "SerieNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Materials", "SerieNumber");
        }
    }
}
