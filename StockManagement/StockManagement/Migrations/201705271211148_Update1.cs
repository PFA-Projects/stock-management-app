namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "City_Id", "dbo.Cities");
            DropIndex("dbo.Users", new[] { "City_Id" });
            DropColumn("dbo.Users", "FirstName_French");
            DropColumn("dbo.Users", "FirstName_English");
            DropColumn("dbo.Users", "FirstName_Arab");
            DropColumn("dbo.Users", "LastName_French");
            DropColumn("dbo.Users", "LastName_English");
            DropColumn("dbo.Users", "LastName_Arab");
            DropColumn("dbo.Users", "CIN");
            DropColumn("dbo.Users", "DateOfBirth");
            DropColumn("dbo.Users", "Sex");
            DropColumn("dbo.Users", "ProfilePhoto");
            DropColumn("dbo.Users", "Email");
            DropColumn("dbo.Users", "PhoneNumber");
            DropColumn("dbo.Users", "Address");
            DropColumn("dbo.Users", "Cellphone");
            DropColumn("dbo.Users", "FaceBook");
            DropColumn("dbo.Users", "WebSite");
            DropColumn("dbo.Users", "City_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "City_Id", c => c.Long());
            AddColumn("dbo.Users", "WebSite", c => c.String());
            AddColumn("dbo.Users", "FaceBook", c => c.String());
            AddColumn("dbo.Users", "Cellphone", c => c.String());
            AddColumn("dbo.Users", "Address", c => c.String());
            AddColumn("dbo.Users", "PhoneNumber", c => c.String());
            AddColumn("dbo.Users", "Email", c => c.String());
            AddColumn("dbo.Users", "ProfilePhoto", c => c.String());
            AddColumn("dbo.Users", "Sex", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "CIN", c => c.String());
            AddColumn("dbo.Users", "LastName_Arab", c => c.String());
            AddColumn("dbo.Users", "LastName_English", c => c.String());
            AddColumn("dbo.Users", "LastName_French", c => c.String());
            AddColumn("dbo.Users", "FirstName_Arab", c => c.String());
            AddColumn("dbo.Users", "FirstName_English", c => c.String());
            AddColumn("dbo.Users", "FirstName_French", c => c.String());
            CreateIndex("dbo.Users", "City_Id");
            AddForeignKey("dbo.Users", "City_Id", "dbo.Cities", "Id");
        }
    }
}
