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
    /// fr : Materiel
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "InventoryNumber")]
    [Menu]
    public class Material: BaseEntity
    {
        [EntryForm]
        [DataGrid]
        [Filter]
        public LocalizedString InventoryNumber { get; set; }

        [EntryForm]
        [DataGrid]
       // [Filter]
        public LocalizedString Designation { get; set; }

        [EntryForm]
        [DataGrid]
        [Filter]
        public LocalizedString Mark { get; set; }

        [EntryForm]
        [DataGrid]
        //[Filter]
        public LocalizedString Model { get; set; }

        [EntryForm]
        [DataGrid]
       // [Filter]
        public DateTime UpdateServiceDate { get; set; }

        [EntryForm]
        [DataGrid]
        //[Filter]
        public LocalizedString Observation { get; set; }

        [EntryForm]
        [DataGrid]
        //[Filter]
        public float AcquisitionValue { get; set; }

        [EntryForm]
        [DataGrid]
        //[Filter]
        public string Acquisition { get; set; }

        [EntryForm]
        [DataGrid]
        //[Filter]
        public bool AcquisitionValueExist { get; set; }
        //
        [EntryForm]
        [DataGrid]
        [Filter]
        public enum PhysicalState
        {
        };
        //
        [EntryForm]
        [DataGrid]
        //[Filter]
        public bool StockExistence { get; set; }

        [EntryForm]
        [DataGrid]
        //[Filter]
        public float dimension { get; set; }

        [EntryForm]
        [DataGrid]
        [Filter]
        public string INN_Number { get; set; }

        [EntryForm]
        [DataGrid]
        [Filter]
        public string SerieNumber { get; set; }
        //
        public Material()
        {
            UpdateServiceDate = DateTime.Now;
        }

        // Relations
        [EntryForm]
        [DataGrid]
        [Filter]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Delivery delivery { get; set; }

        [EntryForm]
        [DataGrid]
        [Filter]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public MaterialCategory materialCategory { get; set; }
    }
}
