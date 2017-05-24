//Mariam Ait Al
//2017

using StockManagement.BAL;
using StockManagement.DAL;
using StockManagement.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace StockManagement.BLL
{
    /// <summary>
    /// en : Materials Management
    /// fr : Gestion des Materiels
    /// </summary>
    public class MaterialBLO:BaseBLO<Material>
    {
        ModelContext db = new ModelContext();

        public MaterialBLO(DbContext context) : base(context)
        {
        }

        public MaterialBLO() : base()
        {
        }

        /// <summary>
        /// Get Materials List By Service
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        public List<Material> GetMaterialsByService(Service service)
        {
            var query = from m in db.Materials
                        where m.Service.Id == service.Id
                        select m;
            return query.ToList<Material>();
        }

        /// <summary>
        /// Get Materials List By Locations
        /// </summary>
        /// <param name="Location"></param>
        /// <returns></returns>
        public List<Material> GetMaterialsBylocation(Location Location)
        {
            var query = from m in db.Materials
                        where m.Location.Id == Location.Id
                        select m;
            return query.ToList<Material>();
        }
        
        /// <summary>
        /// Get Materials List By Material Category
        /// </summary>
        /// <param name="MaterialCategory"></param>
        /// <returns></returns>
        public List<Material> GetMaterialsByMaterialCategory(MaterialCategory MaterialCategory)
        {
            var query = from m in db.Materials
                        where m.Materialcategory.Id == MaterialCategory.Id
                        select m;
            return query.ToList<Material>();
        }
    }
}
