// Mariam Ait Al

using App.Gwin.Entities.MultiLanguage;
using StockManagement.BAL;
using StockManagement.DAL;
using StockManagement.Entities;
using System.Data.Entity;
using System.Linq;

namespace StockManagement.BLL
{
    /// <summary>
    /// fr : Gestion des Materials
    /// en : Materials Management
    /// </summary>
    public class MaterialsBLO: BaseBLO<Material>
    {
        ModelContext db = new ModelContext();

        public MaterialsBLO(DbContext context) : base(context)
        {
        }

        public MaterialsBLO() : base()
        {
        }

        // Delete By Inventory Number
        public bool DeleteBYInventoryNumber(LocalizedString InventoryNumber)
        {
            var query = from m in db.Materials
                        where m.InventoryNumber == InventoryNumber
                        select m;
            db.Materials.Remove(query.ElementAt(0));
            return db.SaveChanges() > 0;
        }
    }
}
