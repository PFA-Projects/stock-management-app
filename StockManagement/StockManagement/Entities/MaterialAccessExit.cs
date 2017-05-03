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
    /// fr: Entree Sorties Materiels
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "Reference")]
    [Menu]
    public class MaterialAccessExit:BaseEntity
    {
        [EntryForm]
        [DataGrid]
       // [Filter]
        public DateTime ExitDate { get; set; }

        [EntryForm]
        [DataGrid]
        // [Filter]
        public DateTime AccessDate { get; set; }

        [EntryForm]
        [DataGrid]
        // [Filter]
        public LocalizedString AccessReason { get; set; }

        [EntryForm]
        [DataGrid]
        // [Filter]
        public LocalizedString Observation { get; set; }

        // Initialize DateTime
        public MaterialAccessExit()
        {
            AccessDate = DateTime.Now;
            ExitDate = DateTime.Now;
        }

        // Relations
        [EntryForm]
        [DataGrid]
        [Filter]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Material material { get; set; }
        //
        [EntryForm]
        [DataGrid]
        [Filter]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Location location { get; set; }

    }
}
