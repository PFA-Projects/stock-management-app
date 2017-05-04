namespace StockManagement.Migrations
{
    using App.Gwin.Application.BAL;
    using App.Gwin.Entities.Application;
    using App.Gwin.Entities.ContactInformations;
    using App.Gwin.Entities.MultiLanguage;
    using App.Gwin.Entities.Secrurity.Authentication;
    using App.Gwin.Entities.Secrurity.Autorizations;
    using Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StockManagement.DAL.ModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "StockManagementSystem";
        }

        protected override void Seed(StockManagement.DAL.ModelContext context)
        {
            // -------------------------------------
            // Giwn App V 0.08
            // -------------------------------------
            //-- Gwin Application Name
            context.ApplicationNames.AddOrUpdate(
                           r => r.Reference
                        ,
                        new App.Gwin.Entities.Application.ApplicationName
                        {
                            Reference = "ClubManagementSystem",
                            Name = new App.Gwin.Entities.MultiLanguage.LocalizedString { Arab = "برنامج تدبير المخزون", English = "Stock Management System", French = "Application de gestion de stock" }
                        }

                      );


            //
            // Gwin Roles
            //
            Role RoleGuest = null;
            Role RoleRoot = null;
            Role RoleAdmin = null;
            context.Roles.AddOrUpdate(
                 r => r.Reference
                        ,
              new Role { Reference = nameof(Role.Roles.Guest), Name = new App.Gwin.Entities.MultiLanguage.LocalizedString() { Current = nameof(Role.Roles.Guest) } },
              new Role { Reference = nameof(Role.Roles.User), Name = new App.Gwin.Entities.MultiLanguage.LocalizedString() { Current = nameof(Role.Roles.User) } },
              new Role { Reference = nameof(Role.Roles.Admin), Name = new App.Gwin.Entities.MultiLanguage.LocalizedString() { Current = nameof(Role.Roles.Admin) } },
              new Role { Reference = nameof(Role.Roles.Root), Name = new App.Gwin.Entities.MultiLanguage.LocalizedString() { Current = nameof(Role.Roles.Root) }, Hidden = true }
            );
            // Save Change to Select RoleRoot and RoleGuest
            context.SaveChanges();
            RoleRoot = context.Roles.Where(r => r.Reference == nameof(Role.Roles.Root)).SingleOrDefault();
            RoleGuest = context.Roles.Where(r => r.Reference == nameof(Role.Roles.Guest)).SingleOrDefault();
            RoleAdmin = context.Roles.Where(r => r.Reference == nameof(Role.Roles.Admin)).SingleOrDefault();

            // 
            // Giwn Autorizations
            //
            // Guest Autorization
            Authorization FindUserAutorization = new Authorization();
            FindUserAutorization.BusinessEntity = typeof(User).FullName;
            FindUserAutorization.ActionsNames = new List<string>();
            FindUserAutorization.ActionsNames.Add(nameof(IGwinBaseBLO.Recherche));

            RoleGuest.Authorizations = new List<Authorization>();
            RoleGuest.Authorizations.Add(FindUserAutorization);

            // Admin Autorization
            RoleAdmin.Authorizations = new List<Authorization>();

            Authorization UserAutorization = new Authorization();
            UserAutorization.BusinessEntity = typeof(User).FullName;
            RoleRoot.Authorizations.Add(UserAutorization);


            //Authorization CityAutorization = new Authorization();
            //CityAutorization.BusinessEntity = typeof(City).FullName;
            //RoleRoot.Authorizations.Add(CityAutorization);


            //Authorization CountryAutorization = new Authorization();
            //CountryAutorization.BusinessEntity = typeof(Country).FullName;
            //RoleRoot.Authorizations.Add(CountryAutorization);

            context.SaveChanges();

            //-- Giwn Users
            context.Users.AddOrUpdate(
                u => u.Reference,
                new User() { Reference = nameof(User.Users.Root), Login = nameof(User.Users.Root), Password = nameof(User.Users.Root), LastName = new LocalizedString() { Current = nameof(User.Users.Root) }, Roles = new List<Role>() { RoleRoot } },
                new User() { Reference = nameof(User.Users.Admin), Login = nameof(User.Users.Admin), Password = nameof(User.Users.Admin), LastName = new LocalizedString() { Current = nameof(User.Users.Admin) }, Roles = new List<Role>() { RoleAdmin } },
                new User() { Reference = nameof(User.Users.Guest), Login = nameof(User.Users.Guest), Password = nameof(User.Users.Guest), LastName = new LocalizedString() { Current = nameof(User.Users.Guest) }, Roles = new List<Role>() { RoleGuest } }
                );
            //-- Gwin  Menu
            context.MenuItemApplications.AddOrUpdate(
                            r => r.Code
                         ,
                         new MenuItemApplication { Id = 1, Code = "Configuration", Title = new App.Gwin.Entities.MultiLanguage.LocalizedString { Arab = "إعدادات", English = "Configuration", French = "Configuration" } },
                         new MenuItemApplication { Id = 2, Code = "Admin", Title = new App.Gwin.Entities.MultiLanguage.LocalizedString { Arab = "تدبير البرنامج", English = "Admin", French = "Administration" } },
                         new MenuItemApplication { Id = 3, Code = "Root", Title = new App.Gwin.Entities.MultiLanguage.LocalizedString { Arab = "مصمم اليرنامج", English = "Application Constructor", French = "Rélisateur de l'application" } }
                       );


            //---------------------------------------------------------
            // Stock Management System
            //---------------------------------------------------------

            // Admin Autorization
            //
            // Delivery
            Authorization DeliveryAuthorizations = new Authorization();
            DeliveryAuthorizations.BusinessEntity = typeof(Delivery).FullName;
            RoleAdmin.Authorizations.Add(DeliveryAuthorizations);

            context.SaveChanges();

            //
            //Employee
            Authorization EmployeeAuthorizations = new Authorization();
            EmployeeAuthorizations.BusinessEntity = typeof(Employee).FullName;
            RoleAdmin.Authorizations.Add(EmployeeAuthorizations);

            context.SaveChanges();

            //
            // Location
            Authorization LocationAuthorizations = new Authorization();
            LocationAuthorizations.BusinessEntity = typeof(Location).FullName;
            RoleAdmin.Authorizations.Add(LocationAuthorizations);

            context.SaveChanges();

            //
            //Materiel
            Authorization MaterielAuthorizations = new Authorization();
            MaterielAuthorizations.BusinessEntity = typeof(Material).FullName;
            RoleAdmin.Authorizations.Add(MaterielAuthorizations);

            context.SaveChanges();

            //
            //Material Category
            Authorization MaterialCategoryAuthorizations = new Authorization();
            MaterialCategoryAuthorizations.BusinessEntity = typeof(MaterialCategory).FullName;
            RoleAdmin.Authorizations.Add(MaterialCategoryAuthorizations);

            context.SaveChanges();

            //
            // Material In out
            Authorization MaterialInOutAuthorizations = new Authorization();
            MaterialInOutAuthorizations.BusinessEntity = typeof(MaterialInOut).FullName;
            RoleAdmin.Authorizations.Add(MaterialInOutAuthorizations);

            context.SaveChanges();

            //
            // Service
            Authorization ServiceAuthorizations = new Authorization();
            ServiceAuthorizations.BusinessEntity = typeof(Service).FullName;
            RoleAdmin.Authorizations.Add(ServiceAuthorizations);

            context.SaveChanges();

            //
            // Societe
            Authorization SocieteAuthorizations = new Authorization();
            SocieteAuthorizations.BusinessEntity = typeof(Societe).FullName;
            RoleAdmin.Authorizations.Add(SocieteAuthorizations);

            context.SaveChanges();

        }
    }
}
