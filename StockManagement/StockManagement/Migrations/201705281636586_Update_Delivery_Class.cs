namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Delivery_Class : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Deliveries", "Observations", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Deliveries", "Observations");
        }
    }
}
