namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.configurations",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        TVA = c.Single(nullable: false),
                        RiskOfStock = c.Int(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        creationDate = c.DateTime(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderLines",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Quantity = c.Single(nullable: false),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        material_Id = c.Long(),
                        order_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Materials", t => t.material_Id)
                .ForeignKey("dbo.Orders", t => t.order_Id)
                .Index(t => t.material_Id)
                .Index(t => t.order_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        orderDate = c.DateTime(nullable: false),
                        DeliveryDateExpected = c.DateTime(nullable: false),
                        OrderState = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        societe_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Societes", t => t.societe_Id)
                .Index(t => t.societe_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderLines", "order_Id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "societe_Id", "dbo.Societes");
            DropForeignKey("dbo.OrderLines", "material_Id", "dbo.Materials");
            DropIndex("dbo.Orders", new[] { "societe_Id" });
            DropIndex("dbo.OrderLines", new[] { "order_Id" });
            DropIndex("dbo.OrderLines", new[] { "material_Id" });
            DropTable("dbo.Orders");
            DropTable("dbo.OrderLines");
            DropTable("dbo.Notifications");
            DropTable("dbo.configurations");
        }
    }
}
