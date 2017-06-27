namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Delivery_Class : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Deliveries", "DeliveryReceiptNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Deliveries", "DeliveryReceiptNumber", c => c.Int(nullable: false));
        }
    }
}
