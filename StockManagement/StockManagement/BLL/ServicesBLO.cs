// Mariam Ait Al

using App.Gwin.Entities.MultiLanguage;
using StockManagement.BAL;
using StockManagement.DAL;
using StockManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.BLL
{
    public class ServicesBLO:BaseBLO<Service>
    {
        ModelContext db = new ModelContext();

        public ServicesBLO(DbContext context) : base(context)
        {
        }

        public ServicesBLO() : base()
        {
        }

        /// <summary>
        /// en : Get Service By Name
        /// fr : Rechercher service par nom
        /// </summary>
        /// <param name="Name">
        /// fr : Nom de service
        /// </param>
        public List<Service> GetServiceByName(LocalizedString Name)
        {
            var query = from s in db.Services
                        where s.Name == Name
                        select s;

            return query.ToList<Service>();
        }
        
      
    }
}
