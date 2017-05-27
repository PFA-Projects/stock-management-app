// Mariam Ait Al
// 2017

using StockManagement.DAL;
using StockManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Gwin.Entities;

namespace StockManagement.BAL
{
    public class MaterialBLO:BaseBLO<Material>
    {
        ModelContext db = new ModelContext();

        public MaterialBLO(DbContext context, Type typeDbContext) : base(context, typeDbContext)
        {

        }


        public MaterialBLO(DbContext context) : this(context, null)
        {

        }
        public MaterialBLO() : this(null, null) { }

        public MaterialBLO(Type typeDbContext) : this(null, typeDbContext)
        {

        }
        

        /// <summary>
        /// Get Materials List By Locations
        /// </summary>
        /// <param name="Location"></param>
        /// <returns></returns>
        //public List<Material> GetMaterialsBylocation(Location Location)
        //{
        //    var query = from m in db.Materials
        //                where m.Location.Id == Location.Id
        //                select m;
        //    return query.ToList<Material>();
        //}

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

        /// <summary>
        /// Get Service Materials List
        /// </summary>
        /// <param name="Service">Service</param>
        /// <returns>Materials List</returns>
        //public List<Material> GetMaterialsByService(Service Service)
        //{
        //    List<Material> MaterialsList = new List<Material>();
        //    foreach (var item in db.Materials)
        //    {
        //        List<MaterialInOut> MaterialinOuts = new MaterialInOutBLO(db).GetMaterialsInOutByMaterial(item);
        //        //MaterialInOut MaterialInOut = MaterialinOuts[0];
        //        foreach (var MIO in MaterialinOuts)
        //        {

        //        }
        //    }

        //    return MaterialsList;
        //}

        //



        

    }
}
