// Mariam Ait Al

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities
{
    /// <summary>
    /// fr : Livraison
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "DeliveryReceiptNumber")]
    [Menu]
    [ManagementForm(Width = 800, TitrePageGridView = "Delivery_Grid_Title", TitreButtonAjouter = "btn_add_Delivery")]
    public class Delivery:BaseEntity
    {
        [EntryForm(Ordre =2)]
        [DataGrid(Ordre =2)]
        //[Filter]
        public DateTime DeliveryDate { get; set; }

        [EntryForm(Ordre =3)]
        [DataGrid(Ordre = 3)]
        [Filter]
        public LocalizedString Market { get; set; }

        [EntryForm(Ordre =1)]
        [DataGrid(Ordre =1)]
        [Filter]
        public String DeliveryReceiptNumber { get; set; }

        // Observations Multiline doesn 't work !
        [EntryForm(Ordre =4,MultiLine = true)]
        [DataGrid(Ordre = 4)]
        public String Observations { get; set; }

        //Initialize dateTime
        public Delivery()
        {
            DeliveryDate = DateTime.Now;
        }

        
    }
}
