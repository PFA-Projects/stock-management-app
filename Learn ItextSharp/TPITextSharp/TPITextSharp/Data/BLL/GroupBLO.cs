using StockManagement.BAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPITextSharp.Data.DAL;
using TPITextSharp.Data.Entities;

namespace TPITextSharp.Data.BLL
{
    public class GroupBLO:BaseBLO<Group>
    {
        ModelContext db = new ModelContext();

        public GroupBLO(DbContext context) : base(context)
        {
        }

        public GroupBLO() : base()
        {
        }

        
    }
}
