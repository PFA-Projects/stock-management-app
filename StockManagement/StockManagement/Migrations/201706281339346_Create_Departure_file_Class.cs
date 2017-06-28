namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Departure_file_Class : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DepartureFiles",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        File = c.Binary(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        Departure_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departures", t => t.Departure_Id)
                .Index(t => t.Departure_Id);
            
            DropColumn("dbo.Departures", "DepartureFile");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departures", "DepartureFile", c => c.Binary());
            DropForeignKey("dbo.DepartureFiles", "Departure_Id", "dbo.Departures");
            DropIndex("dbo.DepartureFiles", new[] { "Departure_Id" });
            DropTable("dbo.DepartureFiles");
        }
    }
}
