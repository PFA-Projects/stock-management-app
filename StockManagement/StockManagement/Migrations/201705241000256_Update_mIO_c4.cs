namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_mIO_c4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MaterialInOuts", "MaterialCategory_Id", c => c.Long());
            CreateIndex("dbo.MaterialInOuts", "MaterialCategory_Id");
            AddForeignKey("dbo.MaterialInOuts", "MaterialCategory_Id", "dbo.MaterialCategories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaterialInOuts", "MaterialCategory_Id", "dbo.MaterialCategories");
            DropIndex("dbo.MaterialInOuts", new[] { "MaterialCategory_Id" });
            DropColumn("dbo.MaterialInOuts", "MaterialCategory_Id");
        }
    }
}
