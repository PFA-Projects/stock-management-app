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

namespace StockManagement.BAL
{
    public class MaterialRepairBLO:BaseBLO<MaterialRepair>
    {
        ModelContext db = new ModelContext();

        public MaterialRepairBLO(DbContext context, Type typeDbContext) : base(context, typeDbContext)
        {

        }


        public MaterialRepairBLO(DbContext context) : this(context, null)
        {

        }
        public MaterialRepairBLO() : this(null, null) { }

        public MaterialRepairBLO(Type typeDbContext) : this(null, typeDbContext)
        {

        }


        
       
    }
}
