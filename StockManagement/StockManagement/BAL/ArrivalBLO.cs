//Mariam Ait Al
using StockManagement.DAL;
using StockManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace StockManagement.BAL
{
    public class ArrivalBLO : BaseBLO<Arrival>
    {
        ModelContext db = new ModelContext();

        public ArrivalBLO(DbContext context) : base(context)
        {
        }

        public ArrivalBLO() : base()
        {
        }
        
    }
}
