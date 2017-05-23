// Mariam Ait Al

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
    /// <summary>
    ///  en : Locations Management
    ///  fr : Gestion d'emplacements
    /// </summary>
    public class LocationBLO:BaseBLO<Location>
    {
        ModelContext db = new ModelContext();

        public LocationBLO(DbContext context) : base(context)
        {
        }

        public LocationBLO() : base()
        {
        }

        /// <summary>
        /// Get Locations By Service
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        public List<Location> LocationsByService(Service service)
        {
            var query = from l in db.Locations
                        where l.Service.Id == service.Id
                        select l;
            return query.ToList<Location>();
        }
    }
}
