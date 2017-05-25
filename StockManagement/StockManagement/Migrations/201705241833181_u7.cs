namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class u7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MaterialInOuts", "Material_Id", c => c.Long());
            CreateIndex("dbo.MaterialInOuts", "Material_Id");
            AddForeignKey("dbo.MaterialInOuts", "Material_Id", "dbo.Materials", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaterialInOuts", "Material_Id", "dbo.Materials");
            DropIndex("dbo.MaterialInOuts", new[] { "Material_Id" });
            DropColumn("dbo.MaterialInOuts", "Material_Id");
        }
    }
}
