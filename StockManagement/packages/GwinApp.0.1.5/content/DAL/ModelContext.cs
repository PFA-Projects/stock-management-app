namespace App
{
    using Gwin.Entities.Application;
    using Gwin.Entities.Logging;
    using Gwin.Entities.Secrurity.Authentication;
    using Gwin.Entities.Secrurity.Autorizations;
    using SamplesGwin.Entities.TraineeManagement;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class ModelContext : DbContext
    {

        public ModelContext() : base(@"data source =(LocalDb)\MSSQLLocalDB; initial catalog = SamplesGwin; integrated security=True; MultipleActiveResultSets = True; App = EntityFramework")
        {
          
        }
        public ModelContext(string connectionString) : base(connectionString)
        {

        }

        // 
        // Gwin : Authentication
        // 
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Authorization> Authorizations { get; set; }
        public virtual DbSet<GwinActivity> GwinActivities { get; set; }

        // 
        // Gwin : Application
        // 
        public virtual DbSet<ApplicationName> ApplicationNames { get; set; }
        public virtual DbSet<MenuItemApplication> MenuItemApplications { get; set; }


        // 
        // TraineeManagement
        // 
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Trainee> Trainees { get; set; }

 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }

        /// <summary>
        /// Get All Type of Entities in ModelContext 
        /// this.methode is used by GwinApp to Load All Type of ModelContext
        /// </summary>
        /// <returns>All Entities Type of ModelContext</returns>
        public List<Type> GetTypesSets()
        {
            var sets = from p in typeof(ModelContext).GetProperties() where p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>) let entityType = p.PropertyType.GetGenericArguments().First() select p.PropertyType.GetGenericArguments()[0];
            return sets.ToList<Type>();
        }
    }
}