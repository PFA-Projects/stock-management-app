namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Arrival_Class : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arrivals",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ArrivalDate = c.DateTime(nullable: false),
                        Object_French = c.String(),
                        Object_English = c.String(),
                        Object_Arab = c.String(),
                        Type_French = c.String(),
                        Type_English = c.String(),
                        Type_Arab = c.String(),
                        Designation_French = c.String(),
                        Designation_English = c.String(),
                        Designation_Arab = c.String(),
                        Number = c.Int(nullable: false),
                        Observations_French = c.String(),
                        Observations_English = c.String(),
                        Observations_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        Configuration_Id = c.Long(),
                        Receiver_Id = c.Long(),
                        Sender_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MailConfigurations", t => t.Configuration_Id)
                .ForeignKey("dbo.Receivers", t => t.Receiver_Id)
                .ForeignKey("dbo.Senders", t => t.Sender_Id)
                .Index(t => t.Configuration_Id)
                .Index(t => t.Receiver_Id)
                .Index(t => t.Sender_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Arrivals", "Sender_Id", "dbo.Senders");
            DropForeignKey("dbo.Arrivals", "Receiver_Id", "dbo.Receivers");
            DropForeignKey("dbo.Arrivals", "Configuration_Id", "dbo.MailConfigurations");
            DropIndex("dbo.Arrivals", new[] { "Sender_Id" });
            DropIndex("dbo.Arrivals", new[] { "Receiver_Id" });
            DropIndex("dbo.Arrivals", new[] { "Configuration_Id" });
            DropTable("dbo.Arrivals");
        }
    }
}
