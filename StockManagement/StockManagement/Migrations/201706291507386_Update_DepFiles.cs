namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_DepFiles : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DepartureFiles", "Departure_Id", "dbo.Departures");
            DropIndex("dbo.DepartureFiles", new[] { "Departure_Id" });
            DropTable("dbo.DepartureFiles");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.DepartureFiles", "Departure_Id");
            AddForeignKey("dbo.DepartureFiles", "Departure_Id", "dbo.Departures", "Id");
        }
    }
}
