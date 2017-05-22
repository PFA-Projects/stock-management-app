namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Material_Class : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Materials", "Materialcategory_Id", c => c.Long());
            CreateIndex("dbo.Materials", "Materialcategory_Id");
            AddForeignKey("dbo.Materials", "Materialcategory_Id", "dbo.MaterialCategories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Materials", "Materialcategory_Id", "dbo.MaterialCategories");
            DropIndex("dbo.Materials", new[] { "Materialcategory_Id" });
            DropColumn("dbo.Materials", "Materialcategory_Id");
        }
    }
}
