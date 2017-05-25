namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class u6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MaterialInOuts", "Material_Id", "dbo.Materials");
            DropIndex("dbo.MaterialInOuts", new[] { "Material_Id" });
            AddColumn("dbo.MaterialInOuts", "InStock", c => c.Boolean(nullable: false));
            DropColumn("dbo.MaterialInOuts", "MaterialState");
            DropColumn("dbo.MaterialInOuts", "IsMaterialInStock");
            DropColumn("dbo.MaterialInOuts", "Material_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MaterialInOuts", "Material_Id", c => c.Long());
            AddColumn("dbo.MaterialInOuts", "IsMaterialInStock", c => c.Boolean(nullable: false));
            AddColumn("dbo.MaterialInOuts", "MaterialState", c => c.Int(nullable: false));
            DropColumn("dbo.MaterialInOuts", "InStock");
            CreateIndex("dbo.MaterialInOuts", "Material_Id");
            AddForeignKey("dbo.MaterialInOuts", "Material_Id", "dbo.Materials", "Id");
        }
    }
}
