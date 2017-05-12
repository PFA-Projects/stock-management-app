// Mariam Ait Al

using App.Gwin.Entities.MultiLanguage;
using StockManagement.BAL;
using StockManagement.DAL;
using StockManagement.Entities;
using System.Data.Entity;
using System.Linq;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;

namespace StockManagement.BAL
{
    /// <summary>
    /// fr : Gestion des Materials
    /// en : Materials Management
    /// </summary>
    public class MaterialBLO: BaseBLO<Material>
    {
        ModelContext db = new ModelContext();

        public MaterialBLO() : base()
        {

        }
        public MaterialBLO(DbContext context) : base(context)
        {

        }
        public MaterialBLO(Type TypeDbContext) : base(TypeDbContext)
        {

        }
        
        //public List<Object> GetMaterielsToPrint()
        //{
        //    // count
        //    var query = from m in db.Materials
                        
        //                select new
        //                {
        //                    m.Designation ,
        //                    m.InventoryNumber ,
        //                    m.dimension,
        //                    m.Observation
        //                };
            
        //    return query.ToList<Object>();
        //}


    }
}
