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
    /// fr : Gestion des Categoriy de materiels
    /// en : Materials Categries Management
    /// </summary>
    public class MaterialsCategoriesBLO : BaseBLO<MaterialCategory>
    {
        ModelContext db = new ModelContext();

        public MaterialsCategoriesBLO(DbContext context) : base(context)
        {
        }

        public MaterialsCategoriesBLO() : base()
        {
        }

        public int  countMaterialNumbre (int cat)

        {
                  int  x = new int ();
             x=Convert.ToInt32( db.Materials.SqlQuery(" select count (m.InventoryNumber) as totalMaterial from Material m,MaterialCategory mc where m.Id=mc.Id and mc.Id="+cat));
            return x;
        }
        
        
    }
}
