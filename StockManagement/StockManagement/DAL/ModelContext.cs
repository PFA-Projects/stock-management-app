namespace StockManagement.DAL
{
    using App.Gwin.Entities.Application;
    using App.Gwin.Entities.Secrurity.Authentication;
    using App.Gwin.Entities.Secrurity.Autorizations;
    using Entities;
    using Entities.ContactInformations;
    using System.Data.Entity;

    public class ModelContext : DbContext
    {
        // Your context has been configured to use a 'ModelContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'StockManagement.DAL.ModelContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelContext' 
        // connection string in the application configuration file.

        //public ModelContext()
        //    : base("name=ModelContext")
        //{

        //}
        //public ModelContext()
        //    : base("name=ModelContext")
        //{

        //}

        // (LocalDb)\MSSQLLocalDB
        public ModelContext() : base(@"data source=.\SQLEXPRESS;initial catalog=StockManagement;integrated security = true;MultipleActiveResultSets=True;App=EntityFramework")
        {

            // public ModelContext() : base(@"data source=(LocalDb)\MSSQLLocalDB;initial catalog=StockManagement;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")

            //  Database.SetInitializer<ModelContext>(new CreateDatabaseIfNotExists<ModelContext>());

            // Disable automatic migrations 
            Database.SetInitializer<ModelContext>(null); 

        }

           
        

       

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        //
        // Gwin : Entites

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<MenuItemApplication> MenuItemApplications { get; set; }
        public virtual DbSet<Country> Countrys { get; set; }
        public virtual DbSet<City> Citys { get; set; }
        public virtual DbSet<ContactInformation> ContactInformations { get; set; }
        public virtual DbSet<ApplicationName> ApplicationNames { get; set; }
        //
        // Stock Management : Entities
        public virtual DbSet<Delivery> Deliveries { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<MaterialInOut> MaterialsAccessexit { get; set; }
        public virtual DbSet<MaterialCategory> MaterialCategories { get; set; }
        public virtual DbSet<Employee> Personnes { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<MaterialRepair> MaterialsRepair { get; set; }
        public virtual DbSet<MaterialTransfer> MaterialTransfers { get; set; }
        //
        // Mail Management : Entities
        public virtual DbSet<MailConfiguration> MailConfigurations { get; set; }
        public virtual DbSet<Arrival> Arrivals { get; set; }
        public virtual DbSet<Departure> Departurs { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}