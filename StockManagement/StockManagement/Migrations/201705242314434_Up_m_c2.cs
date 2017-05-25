namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Up_m_c2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MaterialInOuts", "Observations", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MaterialInOuts", "Observations");
        }
    }
}
