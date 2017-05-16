// Mariam Ait Al

using StockManagement.BAL;
using StockManagement.DAL;
using StockManagement.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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


        public int getMaterialNumbre(int id)
        {
            var query = from mc in db.MaterialCategories
                        join m in db.Materials
                        on mc.Id equals m.MaterialCategory.Id
                       where mc.Id == id
                        select new

                        {
                            //Count(m.InventoryNumber),
                            mc.Designation,
                            mc.Description,
                            mc.DateCreation,
                            mc.DateModification,
                        };
            return query.ToList().Count();
        }
        //// x=Convert.ToInt32( db.Materials.SqlQuery(" select count (m.InventoryNumber) as totalMaterial from Material m,MaterialCategory mc where m.Id=mc.Id"));

        public int MaterialNumbreinMaterialCategory(int id)
        {
            int x = Convert.ToInt32(db.Materials.SqlQuery(" select count (m.InventoryNumber) as totalMaterial from Material m,MaterialCategory mc where m.Id=mc.Id and mc.Id="+id));

            return x;
        }
        }

        
        
    }

