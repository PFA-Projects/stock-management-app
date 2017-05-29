namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_Mail_c2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MailConfigurations", "Observations", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MailConfigurations", "Observations");
        }
    }
}
