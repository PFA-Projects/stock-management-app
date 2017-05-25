namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_m_c : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Materials", "UpdateServiceDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Materials", "UpdateServiceDate");
        }
    }
}
