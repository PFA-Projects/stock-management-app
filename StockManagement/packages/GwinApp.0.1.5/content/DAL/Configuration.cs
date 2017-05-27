namespace App.Migrations
{
    using Gwin.Application.BAL;
    using Gwin.Entities.Application;
    using Gwin.Entities.MultiLanguage;
    using Gwin.Entities.Secrurity.Authentication;
    using Gwin.Entities.Secrurity.Autorizations;
    using SamplesGwin.Entities.TraineeManagement;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "SamplesGwin";
        }

        protected override void Seed(App.ModelContext context)
        {
            //
            // GwinApp Data Configuration
            //

            // Set Name of Application
            context.ApplicationNames.AddOrUpdate(
                                 r => r.Reference
                              ,
                              new ApplicationName
                              {
                                  Reference = "SamplesGwin",
                                  Name = new LocalizedString
                                  {
                                      English = "SamplesGwin Application",
                                      French = "Échantillons GwinApp",
                                      Arab = "برنامج توضيخي للإستعمال الكوين"
                                  }
                              }

                        );
            context.SaveChanges();

            // Add default Roles
            context.Roles.AddOrUpdate(
                 r => r.Reference
                        ,
              new Role { Reference = nameof(Role.Roles.Guest), Name = new LocalizedString() { Current = nameof(Role.Roles.Guest) } },
              new Role { Reference = nameof(Role.Roles.Admin), Name = new LocalizedString() { Current = nameof(Role.Roles.Admin) } },
              new Role { Reference = nameof(Role.Roles.Root), Name = new LocalizedString() { Current = nameof(Role.Roles.Root) }, Hidden = true }
            );
            context.SaveChanges();


            // Load Degault Roles
            Role RoleGuest = null;
            Role RoleRoot = null;
            Role RoleAdmin = null;
            RoleRoot = context.Roles.Where(r => r.Reference == nameof(Role.Roles.Root)).SingleOrDefault();
            RoleGuest = context.Roles.Where(r => r.Reference == nameof(Role.Roles.Guest)).SingleOrDefault();
            RoleAdmin = context.Roles.Where(r => r.Reference == nameof(Role.Roles.Admin)).SingleOrDefault();
           

            // Guest Autorization
            Authorization FindUserAutorization = new Authorization();
            FindUserAutorization.BusinessEntity = typeof(User).FullName;
            FindUserAutorization.ActionsNames = new List<string>();
            FindUserAutorization.ActionsNames.Add(nameof(IGwinBaseBLO.Recherche));
           
            RoleGuest.Authorizations = new List<Authorization>();
            RoleGuest.Authorizations.Add(FindUserAutorization);

            context.SaveChanges();

            // Admin Autorization
            Authorization TrianeeAuthorisation = new Authorization();
            TrianeeAuthorisation.BusinessEntity = typeof(Trainee).FullName;
            Authorization GroupAuthorisation = new Authorization();
            GroupAuthorisation.BusinessEntity = typeof(Group).FullName;

            RoleAdmin.Authorizations = new List<Authorization>();
            RoleAdmin.Authorizations.Add(TrianeeAuthorisation);
            RoleAdmin.Authorizations.Add(GroupAuthorisation);

  
            //  Add Users
            context.Users.AddOrUpdate(
                u => u.Reference,
                new User() { Reference = nameof(User.Users.Root), Login = nameof(User.Users.Root), Password = nameof(User.Users.Root), Roles = new List<Role>() { RoleRoot } },
                new User() { Reference = nameof(User.Users.Admin), Login = nameof(User.Users.Admin), Password = nameof(User.Users.Admin), Roles = new List<Role>() { RoleAdmin } },
                new User() { Reference = nameof(User.Users.Guest), Login = nameof(User.Users.Guest), Password = nameof(User.Users.Guest), Roles = new List<Role>() { RoleGuest } }
            );


            //
            // Menu
            //
            context.MenuItemApplications.AddOrUpdate(
                            r => r.Code
                         ,
                         new MenuItemApplication { Id = 1, Code = "Configuration", Title = new Gwin.Entities.MultiLanguage.LocalizedString { Arab = "إعدادات", English = "Configuration", French = "Configuration" } },
                         new MenuItemApplication { Id = 2, Code = "Admin", Title = new Gwin.Entities.MultiLanguage.LocalizedString { Arab = "تدبير البرنامج", English = "Admin", French = "Administration" } },
                         new MenuItemApplication { Id = 3, Code = "Root", Title = new Gwin.Entities.MultiLanguage.LocalizedString { Arab = "مصمم اليرنامج", English = "Application Constructor", French = "Rélisateur de l'application" } },
                         new MenuItemApplication { Id = 4, Code = "Trainee", Title = new Gwin.Entities.MultiLanguage.LocalizedString { Arab = " تدبيرالمتدرب", English = "Trainee Management", French = "Gestion des stagiaires" } }
           );
        }
    }
}
