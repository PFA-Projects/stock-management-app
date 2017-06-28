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
    public class DepartureBLO : BaseBLO<Departure>
    {
        ModelContext db = new ModelContext();

        public DepartureBLO(DbContext context) : base(context)
        {
        }

        public DepartureBLO() : base()
        {
        }
    }
}
