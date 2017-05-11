namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Up_table_material : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Materials", "service_Id", c => c.Long());
            CreateIndex("dbo.Materials", "service_Id");
            AddForeignKey("dbo.Materials", "service_Id", "dbo.Services", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Materials", "service_Id", "dbo.Services");
            DropIndex("dbo.Materials", new[] { "service_Id" });
            DropColumn("dbo.Materials", "service_Id");
        }
    }
}
