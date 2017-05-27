// Mariam Ait Al
// 2017
using StockManagement.BLL;
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
    public class MaterialInOutBLO:BaseBLO<MaterialInOut>
    {
       
        public MaterialInOutBLO(DbContext context, Type typeDbContext) : base(context, typeDbContext)
        {
           
        }


        public MaterialInOutBLO(DbContext context):this(context,null)
        {

        }
        public MaterialInOutBLO() : this(null,null) { }

        public MaterialInOutBLO(Type typeDbContext):this(null,typeDbContext)
        {
        }

        //
        ModelContext db = new ModelContext();


        public List<MaterialInOut> GetMIOByMaterial(Material Material)
        {
            //var query = from mio in db.MaterialsAccessexit
            //            where mio.Material.Id == Material.Id
            //            //orderby(mio.DateCreation)
            //            select mio;
            //return query.ToList();
            return db.MaterialsAccessexit.Where(r => r.Material.Id == Material.Id).OrderByDescending(r => r.DateCreation).ToList<MaterialInOut>();
        }

       


    }
}
