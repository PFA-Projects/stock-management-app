namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Material_Table : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Materials", "AcquisitionValueExist");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Materials", "AcquisitionValueExist", c => c.Boolean(nullable: false));
        }
    }
}
