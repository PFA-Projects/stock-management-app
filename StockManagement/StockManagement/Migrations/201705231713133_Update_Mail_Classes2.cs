namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Mail_Classes2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Senders",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name_French = c.String(),
                        Name_English = c.String(),
                        Name_Arab = c.String(),
                        Adress_French = c.String(),
                        Adress_English = c.String(),
                        Adress_Arab = c.String(),
                        Remarks_French = c.String(),
                        Remarks_English = c.String(),
                        Remarks_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departures",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DepartureDate = c.DateTime(nullable: false),
                        CorrespondanceObject_French = c.String(),
                        CorrespondanceObject_English = c.String(),
                        CorrespondanceObject_Arab = c.String(),
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
                .ForeignKey("dbo.Recievers", t => t.Receiver_Id)
                .ForeignKey("dbo.Senders", t => t.Sender_Id)
                .Index(t => t.Configuration_Id)
                .Index(t => t.Receiver_Id)
                .Index(t => t.Sender_Id);
            
            AddColumn("dbo.Arrivals", "Sender_Id", c => c.Long());
            CreateIndex("dbo.Arrivals", "Sender_Id");
            AddForeignKey("dbo.Arrivals", "Sender_Id", "dbo.Senders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departures", "Sender_Id", "dbo.Senders");
            DropForeignKey("dbo.Departures", "Receiver_Id", "dbo.Recievers");
            DropForeignKey("dbo.Departures", "Configuration_Id", "dbo.MailConfigurations");
            DropForeignKey("dbo.Arrivals", "Sender_Id", "dbo.Senders");
            DropIndex("dbo.Departures", new[] { "Sender_Id" });
            DropIndex("dbo.Departures", new[] { "Receiver_Id" });
            DropIndex("dbo.Departures", new[] { "Configuration_Id" });
            DropIndex("dbo.Arrivals", new[] { "Sender_Id" });
            DropColumn("dbo.Arrivals", "Sender_Id");
            DropTable("dbo.Departures");
            DropTable("dbo.Senders");
        }
    }
}
