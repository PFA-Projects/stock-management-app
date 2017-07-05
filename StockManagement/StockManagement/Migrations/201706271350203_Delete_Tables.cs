namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delete_Tables : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Receivers");
            DropTable("dbo.Senders");
        }
        
        public override void Down()
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
                "dbo.Receivers",
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
    }
}
