namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_MIO_Clas5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MaterialInOuts", "MaterialCategory_Id", "dbo.MaterialCategories");
            DropIndex("dbo.MaterialInOuts", new[] { "MaterialCategory_Id" });
            DropColumn("dbo.MaterialInOuts", "MaterialCategory_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MaterialInOuts", "MaterialCategory_Id", c => c.Long());
            CreateIndex("dbo.MaterialInOuts", "MaterialCategory_Id");
            AddForeignKey("dbo.MaterialInOuts", "MaterialCategory_Id", "dbo.MaterialCategories", "Id");
        }
    }
}
