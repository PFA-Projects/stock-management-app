namespace StockManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Mail_Classes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Arrivals", "Receiver_Id", "dbo.Receivers");
            DropForeignKey("dbo.Arrivals", "Sender_Id", "dbo.Senders");
            DropForeignKey("dbo.Departures", "Receiver_Id", "dbo.Receivers");
            DropForeignKey("dbo.Departures", "Sender_Id", "dbo.Senders");
            DropIndex("dbo.Arrivals", new[] { "Receiver_Id" });
            DropIndex("dbo.Arrivals", new[] { "Sender_Id" });
            DropIndex("dbo.Departures", new[] { "Receiver_Id" });
            DropIndex("dbo.Departures", new[] { "Sender_Id" });
            DropColumn("dbo.Arrivals", "Receiver_Id");
            DropColumn("dbo.Arrivals", "Sender_Id");
            DropColumn("dbo.Departures", "Receiver_Id");
            DropColumn("dbo.Departures", "Sender_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departures", "Sender_Id", c => c.Long());
            AddColumn("dbo.Departures", "Receiver_Id", c => c.Long());
            AddColumn("dbo.Arrivals", "Sender_Id", c => c.Long());
            AddColumn("dbo.Arrivals", "Receiver_Id", c => c.Long());
            CreateIndex("dbo.Departures", "Sender_Id");
            CreateIndex("dbo.Departures", "Receiver_Id");
            CreateIndex("dbo.Arrivals", "Sender_Id");
            CreateIndex("dbo.Arrivals", "Receiver_Id");
            AddForeignKey("dbo.Departures", "Sender_Id", "dbo.Senders", "Id");
            AddForeignKey("dbo.Departures", "Receiver_Id", "dbo.Receivers", "Id");
            AddForeignKey("dbo.Arrivals", "Sender_Id", "dbo.Senders", "Id");
            AddForeignKey("dbo.Arrivals", "Receiver_Id", "dbo.Receivers", "Id");
        }
    }
}
