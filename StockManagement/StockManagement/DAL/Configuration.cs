namespace StockManagement.Migrations
{
    using App.Gwin.Application.BAL;
    using App.Gwin.Entities.Application;
    using App.Gwin.Entities.MultiLanguage;
    using App.Gwin.Entities.Secrurity.Authentication;
    using App.Gwin.Entities.Secrurity.Autorizations;
    using Entities;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StockManagement.DAL.ModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "StockManagement";
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
                            Reference = "StockManagementSystem",
                            Name = new App.Gwin.Entities.MultiLanguage.LocalizedString { Arab = "برنامج تدبير المخزون", English = "Stock Management System", French = "Application de gestion de stock" }
                        }

                      );


            //
            // Gwin Roles
            //
            Role RoleGuest = null;
            Role RoleRoot = null;
            Role RoleAdmin = null;
            // Material Roles
            Role MaterialRole = null;
            // Mail Roles
            Role RHRole = null;
            Role DirRole = null;

            context.Roles.AddOrUpdate(
                 r => r.Reference
                        ,
              new Role { Reference = nameof(Role.Roles.Guest), Name = new LocalizedString() { Current = nameof(Role.Roles.Guest) } },
              new Role { Reference = nameof(Role.Roles.User), Name = new LocalizedString() { Current = nameof(Role.Roles.User) } },
              new Role { Reference = nameof(Role.Roles.Admin), Name = new LocalizedString() { Current = nameof(Role.Roles.Admin) } },
              new Role { Reference = nameof(Role.Roles.Root), Name = new LocalizedString() { Current = nameof(Role.Roles.Root) }, Hidden = true },
              //
              new Role { Reference = "MaterialRole",Name=new LocalizedString() { French ="MaterialRole"} },
              new Role { Reference = "RHRole",Name = new LocalizedString() { French="RHRole"} },
              new Role { Reference = "DirRole",Name= new LocalizedString() { French="DirRole"} }
            );
            // Save Change to Select RoleRoot and RoleGuest
            context.SaveChanges();
            RoleRoot = context.Roles.Where(r => r.Reference == nameof(Role.Roles.Root)).SingleOrDefault();
            RoleGuest = context.Roles.Where(r => r.Reference == nameof(Role.Roles.Guest)).SingleOrDefault();
            RoleAdmin = context.Roles.Where(r => r.Reference == nameof(Role.Roles.Admin)).SingleOrDefault();
            //
            MaterialRole = context.Roles.Where(r => r.Reference == "MaterialRole" ).SingleOrDefault();
            //
            RHRole = context.Roles.Where(r => r.Reference == "RHRole").SingleOrDefault();
            DirRole = context.Roles.Where(r => r.Reference == "DirRole").SingleOrDefault();
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
            RoleAdmin.Authorizations.Add(UserAutorization);



            // Material Authorizations
            MaterialRole.Authorizations = new List<Authorization>();
            Authorization MRAuthorizations = new Authorization();
            MRAuthorizations.BusinessEntity = typeof(User).FullName;
            MaterialRole.Authorizations.Add(UserAutorization);

            // Rh Authorizations
            RHRole.Authorizations = new List<Authorization>();
            Authorization RHAuthorizations = new Authorization();
            RHAuthorizations.BusinessEntity = typeof(User).FullName;
            RHRole.Authorizations.Add(RHAuthorizations);

            context.SaveChanges();

            //-- Giwn Users
            context.Users.AddOrUpdate(
                u => u.Reference,
                new User() { Reference = nameof(User.Users.Root), Login = nameof(User.Users.Root), Password = nameof(User.Users.Root), Roles = new List<Role>() { RoleRoot } },
                new User() { Reference = nameof(User.Users.Admin), Login = nameof(User.Users.Admin), Password = nameof(User.Users.Admin), Roles = new List<Role>() { RoleAdmin } },
                new User() { Reference = nameof(User.Users.Guest), Login = nameof(User.Users.Guest), Password = nameof(User.Users.Guest), Roles = new List<Role>() { RoleGuest } } ,
                //
                new User() { Reference = "MaterialRole" ,Login ="Materiel",Password="Materiel",Roles=new List<Role>() { MaterialRole} ,Language= App.Gwin.GwinApp.Languages.fr},
                new User() { Reference = "RHRole",Login="RH",Password="RH",Roles = new List<Role>() { RHRole},Language = App.Gwin.GwinApp.Languages.fr },
                new User() { Reference ="DirRole",Login="Dir",Roles = new List<Role>() { DirRole},Language = App.Gwin.GwinApp.Languages.fr }
                );
            //-- Gwin  Menu
            context.MenuItemApplications.AddOrUpdate(
                            r => r.Code
                         ,
                         new MenuItemApplication { Id = 1, Code = "Configuration", Title = new LocalizedString { Arab = "إعدادات", English = "Configuration", French = "Configuration" } },
                         new MenuItemApplication { Id = 2, Code = "Admin", Title = new LocalizedString { Arab = "تدبير البرنامج", English = "Admin", French = "Administration" } },
                         new MenuItemApplication { Id = 3, Code = "Root", Title = new LocalizedString { Arab = "مصمم اليرنامج", English = "Application Constructor", French = "Rélisateur de l'application" } }
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
            MaterialRole.Authorizations.Add(DeliveryAuthorizations);

            context.SaveChanges();

            //
            //Employee
            Authorization EmployeeAuthorizations = new Authorization();
            EmployeeAuthorizations.BusinessEntity = typeof(Employee).FullName;
            RoleAdmin.Authorizations.Add(EmployeeAuthorizations);
            MaterialRole.Authorizations.Add(EmployeeAuthorizations);

            context.SaveChanges();

            //
            // Location
            Authorization LocationAuthorizations = new Authorization();
            LocationAuthorizations.BusinessEntity = typeof(Location).FullName;
            RoleAdmin.Authorizations.Add(LocationAuthorizations);
            MaterialRole.Authorizations.Add(LocationAuthorizations);

            context.SaveChanges();

            

            //
            //Material Category
            Authorization MaterialCategoryAuthorizations = new Authorization();
            MaterialCategoryAuthorizations.BusinessEntity = typeof(MaterialCategory).FullName;
            RoleAdmin.Authorizations.Add(MaterialCategoryAuthorizations);
            MaterialRole.Authorizations.Add(MaterialCategoryAuthorizations);

            context.SaveChanges();
            //
            // Material
            Authorization MaterialAuthorizations = new Authorization();
            MaterialAuthorizations.BusinessEntity = typeof(Material).FullName;
            RoleAdmin.Authorizations.Add(MaterialAuthorizations);
            MaterialRole.Authorizations.Add(MaterialAuthorizations);
            //
            // Material In out
            Authorization MaterialInOutAuthorizations = new Authorization();
            MaterialInOutAuthorizations.BusinessEntity = typeof(MaterialInOut).FullName;
            RoleAdmin.Authorizations.Add(MaterialInOutAuthorizations);
            MaterialRole.Authorizations.Add(MaterialInOutAuthorizations);

            context.SaveChanges();

            //
            // Service
            Authorization ServiceAuthorizations = new Authorization();
            ServiceAuthorizations.BusinessEntity = typeof(Service).FullName;
            RoleAdmin.Authorizations.Add(ServiceAuthorizations);
            MaterialRole.Authorizations.Add(ServiceAuthorizations);

            context.SaveChanges();

            //
            // Material Repair
            Authorization MaterialRepairAuthorizations = new Authorization();
            MaterialRepairAuthorizations.BusinessEntity = typeof(MaterialRepair).FullName;
            RoleAdmin.Authorizations.Add(MaterialRepairAuthorizations);
            MaterialRole.Authorizations.Add(MaterialRepairAuthorizations);

            context.SaveChanges();

            //
            // Material Transfer
            Authorization MaterialTransferAuthorizations = new Authorization();
            MaterialTransferAuthorizations.BusinessEntity = typeof(MaterialTransfer).FullName;
            RoleAdmin.Authorizations.Add(MaterialTransferAuthorizations);
            MaterialRole.Authorizations.Add(MaterialTransferAuthorizations);



            //
            // Services Data :
            // SAA , Bloc , Maternite , Urgence , Consultation , Hospitalisation , Laboratoire , Radio , Administration 
            context.Services.AddOrUpdate(
                s => s.Reference,
                new Service() { Reference = "SAA", Name = new LocalizedString() { French = "SAA", English = "SAA", Arab = "SAA" }, Description = new LocalizedString() { French = "", English = "", Arab = "" }, Observation = new LocalizedString() { French = "", English = "", Arab = "" } },
                new Service() { Reference = "Bloc", Name = new LocalizedString() { French = "Bloc", English = "Bloc", Arab = "Bloc" }, Observation = new LocalizedString() { French = "", Arab = "", English = "" }, Description = new LocalizedString() { French = "", English = "", Arab = "" } },
                new Service() { Reference = "Maternite", Name = new LocalizedString() { French = "Maternite", English = "Maternite", Arab = "Maternite" }, Observation = new LocalizedString() { French = "", Arab = "", English = "" }, Description = new LocalizedString() { French = "", English = "", Arab = "" } },
                new Service() { Reference = "Urgence", Name = new LocalizedString() { French = "Urgence", English = "Urgence", Arab = "Urgence" }, Observation = new LocalizedString() { French = "", Arab = "", English = "" }, Description = new LocalizedString() { French = "", English = "", Arab = "" } },
                new Service() { Reference = "Consultations", Name = new LocalizedString() { French = "Consultations", English = "Consultation", Arab = "Consultation" }, Observation = new LocalizedString() { French = "", Arab = "", English = "" }, Description = new LocalizedString() { French = "", English = "", Arab = "" } },
                new Service() { Reference = "Hospitalisation", Name = new LocalizedString() { French = "Hospitalisation", English = "Hospitalisation", Arab = "Hospitalisation" }, Observation = new LocalizedString() { French = "", Arab = "", English = "" }, Description = new LocalizedString() { French = "", English = "", Arab = "" } },
                new Service() { Reference = "Laboratoire", Name = new LocalizedString() { French = "Laboratoire", English = "Laboratoire", Arab = "Laboratoire" }, Observation = new LocalizedString() { French = "", Arab = "", English = "" }, Description = new LocalizedString() { French = "", English = "", Arab = "" } },
                new Service() { Reference = "Radio", Name = new LocalizedString() { French = "Radio", English = "Radio", Arab = "Radio" }, Observation = new LocalizedString() { French = "", Arab = "", English = "" }, Description = new LocalizedString() { French = "", English = "", Arab = "" } },
                new Service() { Reference = "Administration", Name = new LocalizedString() { French = "Administration", English = "Administration", Arab = "Administration" }, Observation = new LocalizedString() { French = "", Arab = "", English = "" }, Description = new LocalizedString() { French = "", English = "", Arab = "" } }
                );
            // Locations Data : 
            // (Service : SAA) : Statistiques , Recouvrement , RDV(Rendez vous) , Caisse 
            // (Service Administration ) : RH(Resources Humaines) , Comptabilite , Materiel

            //---------------------------------------------------------
            // Mail Management System
            //---------------------------------------------------------
            Authorization MailConfigurationAuthorizations = new Authorization();
            MailConfigurationAuthorizations.BusinessEntity = typeof(MailConfiguration).FullName;
            RoleAdmin.Authorizations.Add(MailConfigurationAuthorizations);
            RHRole.Authorizations.Add(MailConfigurationAuthorizations);
            DirRole.Authorizations.Add(MailConfigurationAuthorizations);
            // Receiver
            Authorization ReceiverAuthorizations = new Authorization();
            ReceiverAuthorizations.BusinessEntity = typeof(Receiver).FullName;
            RoleAdmin.Authorizations.Add(ReceiverAuthorizations);
            RHRole.Authorizations.Add(ReceiverAuthorizations);
            DirRole.Authorizations.Add(ReceiverAuthorizations);
            // Sender
            Authorization SenderAuthorizations = new Authorization();
            SenderAuthorizations.BusinessEntity = typeof(Sender).FullName;
            RoleAdmin.Authorizations.Add(SenderAuthorizations);
            RHRole.Authorizations.Add(SenderAuthorizations);
            DirRole.Authorizations.Add(SenderAuthorizations);
            // Arrival
            Authorization ArrivalAuthorizations = new Authorization();
            ArrivalAuthorizations.BusinessEntity = typeof(Arrival).FullName;
            RoleAdmin.Authorizations.Add(ArrivalAuthorizations);
            RHRole.Authorizations.Add(ArrivalAuthorizations);
            DirRole.Authorizations.Add(ArrivalAuthorizations);
            // Departure
            Authorization DepartureAuthorizations = new Authorization();
            DepartureAuthorizations.BusinessEntity = typeof(Departure).FullName;
            RoleAdmin.Authorizations.Add(DepartureAuthorizations);
            RHRole.Authorizations.Add(DepartureAuthorizations);
            DirRole.Authorizations.Add(DepartureAuthorizations);

            context.SaveChanges();

        }
    }
}
