// Mariam Ait Al
// 2017

using StockManagement.BAL;
using StockManagement.DAL;
using StockManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Gwin.Entities;

namespace StockManagement.BLL
{
    /// <summary>
    /// fr : Gestion des Materiels Entrees-Sorties
    /// en : Materials In-Out Management
    /// </summary>
    public class MaterialInOutBLO:BaseBLO<MaterialInOut>
    {
        ModelContext db = new ModelContext();

        public MaterialInOutBLO(DbContext context) : base(context)
        {
        }

        public MaterialInOutBLO() : base()
        {
        }

        //public override int Save(MaterialInOut item)
        //{
        //    Material Material = item.Material;
        //    Material.Service = item.Service;
        //    Material.Location = item.Location;
        //    new MaterialBLO(db).Save(Material);
        //    db.MaterialsAccessexit.Add(item);
        //    return db.SaveChanges();
        //}
    }
}
