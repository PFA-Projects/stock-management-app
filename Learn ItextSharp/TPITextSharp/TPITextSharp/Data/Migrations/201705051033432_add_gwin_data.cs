using System.Data.Entity.Migrations;

namespace TPITextSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_gwin_data : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationNames",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name_French = c.String(),
                        Name_English = c.String(),
                        Name_Arab = c.String(),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name_French = c.String(),
                        Name_English = c.String(),
                        Name_Arab = c.String(),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        Country_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name_French = c.String(),
                        Name_English = c.String(),
                        Name_Arab = c.String(),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContactInformations",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                        Cellphone = c.String(),
                        FaceBook = c.String(),
                        WebSite = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        City_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.MenuItemApplications",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Code = c.String(maxLength: 65),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Title_French = c.String(),
                        Title_English = c.String(),
                        Title_Arab = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Reference = c.String(),
                        Name_French = c.String(),
                        Name_English = c.String(),
                        Name_Arab = c.String(),
                        Description_French = c.String(),
                        Description_English = c.String(),
                        Description_Arab = c.String(),
                        Hidden = c.Boolean(nullable: false),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Authorizations",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        BusinessEntity = c.String(),
                        ActionsNamesAsString = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Login = c.String(maxLength: 255),
                        Password = c.String(),
                        Language = c.Int(nullable: false),
                        FirstName_French = c.String(),
                        FirstName_English = c.String(),
                        FirstName_Arab = c.String(),
                        LastName_French = c.String(),
                        LastName_English = c.String(),
                        LastName_Arab = c.String(),
                        CIN = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Sex = c.Boolean(nullable: false),
                        ProfilePhoto = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                        Cellphone = c.String(),
                        FaceBook = c.String(),
                        WebSite = c.String(),
                        Reference = c.String(),
                        Ordre = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        City_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .Index(t => t.Login, unique: true)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.AuthorizationRoles",
                c => new
                    {
                        Authorization_Id = c.Long(nullable: false),
                        Role_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.Authorization_Id, t.Role_Id })
                .ForeignKey("dbo.Authorizations", t => t.Authorization_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.Authorization_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.RoleMenuItemApplications",
                c => new
                    {
                        Role_Id = c.Long(nullable: false),
                        MenuItemApplication_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_Id, t.MenuItemApplication_Id })
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .ForeignKey("dbo.MenuItemApplications", t => t.MenuItemApplication_Id, cascadeDelete: true)
                .Index(t => t.Role_Id)
                .Index(t => t.MenuItemApplication_Id);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        User_Id = c.Long(nullable: false),
                        Role_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Role_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Role_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.UserRoles", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.RoleMenuItemApplications", "MenuItemApplication_Id", "dbo.MenuItemApplications");
            DropForeignKey("dbo.RoleMenuItemApplications", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.AuthorizationRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.AuthorizationRoles", "Authorization_Id", "dbo.Authorizations");
            DropForeignKey("dbo.ContactInformations", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Cities", "Country_Id", "dbo.Countries");
            DropIndex("dbo.UserRoles", new[] { "Role_Id" });
            DropIndex("dbo.UserRoles", new[] { "User_Id" });
            DropIndex("dbo.RoleMenuItemApplications", new[] { "MenuItemApplication_Id" });
            DropIndex("dbo.RoleMenuItemApplications", new[] { "Role_Id" });
            DropIndex("dbo.AuthorizationRoles", new[] { "Role_Id" });
            DropIndex("dbo.AuthorizationRoles", new[] { "Authorization_Id" });
            DropIndex("dbo.Users", new[] { "City_Id" });
            DropIndex("dbo.Users", new[] { "Login" });
            DropIndex("dbo.MenuItemApplications", new[] { "Code" });
            DropIndex("dbo.ContactInformations", new[] { "City_Id" });
            DropIndex("dbo.Cities", new[] { "Country_Id" });
            DropTable("dbo.UserRoles");
            DropTable("dbo.RoleMenuItemApplications");
            DropTable("dbo.AuthorizationRoles");
            DropTable("dbo.Users");
            DropTable("dbo.Authorizations");
            DropTable("dbo.Roles");
            DropTable("dbo.MenuItemApplications");
            DropTable("dbo.ContactInformations");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.ApplicationNames");
        }
    }
}
