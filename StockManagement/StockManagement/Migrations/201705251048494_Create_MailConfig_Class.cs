namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_MailConfig_Class : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Arrivals", "Configuration_Id", "dbo.MailConfigurations");
            DropForeignKey("dbo.Arrivals", "Receiver_Id", "dbo.Recievers");
            DropForeignKey("dbo.Arrivals", "Sender_Id", "dbo.Senders");
            DropForeignKey("dbo.Departures", "Configuration_Id", "dbo.MailConfigurations");
            DropForeignKey("dbo.Departures", "Receiver_Id", "dbo.Recievers");
            DropForeignKey("dbo.Departures", "Sender_Id", "dbo.Senders");
            DropIndex("dbo.Arrivals", new[] { "Configuration_Id" });
            DropIndex("dbo.Arrivals", new[] { "Receiver_Id" });
            DropIndex("dbo.Arrivals", new[] { "Sender_Id" });
            DropIndex("dbo.Departures", new[] { "Configuration_Id" });
            DropIndex("dbo.Departures", new[] { "Receiver_Id" });
            DropIndex("dbo.Departures", new[] { "Sender_Id" });
            DropTable("dbo.Arrivals");
            DropTable("dbo.Recievers");
            DropTable("dbo.Senders");
            DropTable("dbo.Departures");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.Id);
            
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
                "dbo.Recievers",
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
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Departures", "Sender_Id");
            CreateIndex("dbo.Departures", "Receiver_Id");
            CreateIndex("dbo.Departures", "Configuration_Id");
            CreateIndex("dbo.Arrivals", "Sender_Id");
            CreateIndex("dbo.Arrivals", "Receiver_Id");
            CreateIndex("dbo.Arrivals", "Configuration_Id");
            AddForeignKey("dbo.Departures", "Sender_Id", "dbo.Senders", "Id");
            AddForeignKey("dbo.Departures", "Receiver_Id", "dbo.Recievers", "Id");
            AddForeignKey("dbo.Departures", "Configuration_Id", "dbo.MailConfigurations", "Id");
            AddForeignKey("dbo.Arrivals", "Sender_Id", "dbo.Senders", "Id");
            AddForeignKey("dbo.Arrivals", "Receiver_Id", "dbo.Recievers", "Id");
            AddForeignKey("dbo.Arrivals", "Configuration_Id", "dbo.MailConfigurations", "Id");
        }
    }
}
