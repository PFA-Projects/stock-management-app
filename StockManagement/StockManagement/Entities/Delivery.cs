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
    [GwinEntity(Localizable = true, DisplayMember = "Reference")]
    [Menu]
    public class Delivery:BaseEntity
    {
        [EntryForm]
        [DataGrid]
        //[Filter]
        public DateTime DeliveryDate { get; set; }

        [EntryForm]
        [DataGrid]
        [Filter]
        public LocalizedString Market { get; set; }

        [EntryForm]
        [DataGrid]
       // [Filter]
        public int DeliveryReceiptNumber { get; set; }
        //Initialize dateTime
        public Delivery()
        {
            DeliveryDate = DateTime.Now;
        }

        // Relations
        // One To Many 
        [EntryForm]
        [DataGrid]
        [Filter]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Societe Societe { get; set; }
    }
}
