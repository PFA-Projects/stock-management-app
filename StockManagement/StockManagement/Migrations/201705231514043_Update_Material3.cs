namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Material3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Materials", "PhysicalStateExplication", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Materials", "PhysicalStateExplication");
        }
    }
}
