// Mariam Ait Al

using App.Gwin.Entities.MultiLanguage;
using StockManagement.BAL;
using StockManagement.DAL;
using StockManagement.Entities;
using System.Data.Entity;
using System.Linq;
using App.Gwin.Entities;

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

        /// <summary>
        /// fr : reEcrire La methode enregistrer materiel
        /// en : Define material s save function
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        //public override int Save(Material item)
        //{
        //    // Get the materiel s informations
        //    Material material = new Material();
        //    material.InventoryNumber = item.InventoryNumber;
        //    material.Designation = item.Designation;
        //    material.Mark = item.Mark;
        //    material.Model = item.Model;
        //    material.UpdateServiceDate = item.UpdateServiceDate;
        //    material.Observation = item.Observation;
        //    material.AcquisitionValue = item.AcquisitionValue;
        //    material.Acquisition = item.Acquisition;
        //    material.PhysicalState = item.PhysicalState;
        //    material.StockExistence = item.StockExistence;
        //    material.dimension = item.dimension;
        //    material.INN_Number = item.INN_Number;
        //    material.SerieNumber = item.SerieNumber;
        //    material.Delivery = item.Delivery;
        //    material.MaterialCategory = item.MaterialCategory;
        //    // define if the acquisition value existe 
        //    if(item.AcquisitionValue != 0)
        //    {
        //        material.AcquisitionValueExist = true;
        //    }
        //    else
        //    {
        //        material.AcquisitionValueExist = false;
        //    }
        //    return db.SaveChanges();
        //}

        
    }
}
