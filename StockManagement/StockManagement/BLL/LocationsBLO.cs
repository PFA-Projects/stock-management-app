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
    ///  en : Locations Management
    ///  fr : Gestion d'emplacements
    /// </summary>
    public class LocationsBLO:BaseBLO<Location>
    {
        ModelContext db = new ModelContext();

        public LocationsBLO(DbContext context) : base(context)
        {
        }

        public LocationsBLO() : base()
        {
        }
    }
}
