// Mariam Ait Al

using App.Gwin.Entities.MultiLanguage;
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
    public class ServicesBLO:BaseBLO<Service>
    {
        ModelContext db = new ModelContext();

        public ServicesBLO(DbContext context) : base(context)
        {
        }

        public ServicesBLO() : base()
        {
        }

      
    }
}
