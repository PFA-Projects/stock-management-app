namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_ArrivalFile_Class : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArrivalFiles",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        File = c.Binary(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        Arrival_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Arrivals", t => t.Arrival_Id)
                .Index(t => t.Arrival_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArrivalFiles", "Arrival_Id", "dbo.Arrivals");
            DropIndex("dbo.ArrivalFiles", new[] { "Arrival_Id" });
            DropTable("dbo.ArrivalFiles");
        }
    }
}
