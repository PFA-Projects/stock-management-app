namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_mail_classes1 : DbMigration
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
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MailConfigurations", t => t.Configuration_Id)
                .ForeignKey("dbo.Recievers", t => t.Receiver_Id)
                .Index(t => t.Configuration_Id)
                .Index(t => t.Receiver_Id);
            
            CreateTable(
                "dbo.MailConfigurations",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Adress = c.String(),
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Arrivals", "Receiver_Id", "dbo.Recievers");
            DropForeignKey("dbo.Arrivals", "Configuration_Id", "dbo.MailConfigurations");
            DropIndex("dbo.Arrivals", new[] { "Receiver_Id" });
            DropIndex("dbo.Arrivals", new[] { "Configuration_Id" });
            DropTable("dbo.Recievers");
            DropTable("dbo.MailConfigurations");
            DropTable("dbo.Arrivals");
        }
    }
}
