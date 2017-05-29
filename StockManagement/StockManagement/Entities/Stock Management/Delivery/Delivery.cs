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
    public class Delivery:BaseEntity
    {
        [EntryForm(Ordre =2)]
        [DataGrid(Ordre =2)]
        //[Filter]
        public DateTime DeliveryDate { get; set; }

        [EntryForm(Ordre =3)]
        [DataGrid(Ordre = 3)]
        public LocalizedString Market { get; set; }

        [EntryForm(Ordre =1)]
        [DataGrid(Ordre =1)]
       [Filter]
        public int DeliveryReceiptNumber { get; set; }

        [EntryForm(Ordre =4)]
        [DataGrid(Ordre = 4)]
        public String Observations { get; set; }

        //Initialize dateTime
        public Delivery()
        {
            DeliveryDate = DateTime.Now;
        }

        
    }
}
