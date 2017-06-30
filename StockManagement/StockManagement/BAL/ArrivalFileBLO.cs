// Mariam Ait Al
// 2017

using StockManagement.DAL;
using StockManagement.Entities;
using StockManagement.Entities.Mail_Management;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.BAL
{
    public class ArrivalFileBLO:BaseBLO<ArrivalFile>
    {
        ModelContext db = new ModelContext();

        public ArrivalFileBLO(DbContext context) : base(context)
        {
        }

        public ArrivalFileBLO() : base()
        {
        }
        /// <summary>
        /// Get Arrival Files By Arrival
        /// </summary>
        /// <param name="Arrival"></param>
        /// <returns></returns>
        public List<ArrivalFile> GetArrivalFilesByArrival(Arrival Arrival)
        {
            var query = from a in db.ArrivalFiles
                        where a.Arrival.Id == Arrival.Id
                        select a;
            return query.ToList<ArrivalFile>();
        }
    }
}
