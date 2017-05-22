// Mariam Ait Al
// 2017

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using StockManagement.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities.Materials
{
    [GwinEntity(Localizable = true, DisplayMember = "InventoryNumber")]
    [Menu(Group = "Materiels")]
    public class Material : BaseEntity
    {
        [EntryForm]
        [DataGrid]
        public String InventoryNumber { get; set; }

        [EntryForm]
        [DataGrid]
        public LocalizedString Designation { get; set; }

        [EntryForm]
        [DataGrid]
        public LocalizedString Mark { get; set; }

        [EntryForm]
        [DataGrid]
        public LocalizedString Model { get; set; }

        //[EntryForm]
        //[DataGrid]
        //public DateTime UpdateServiceDate { get; set; }

        [EntryForm]
        [DataGrid]
        public LocalizedString Observation { get; set; }

        [EntryForm]
        [DataGrid]
        public float AcquisitionValue { get; set; }

        [EntryForm]
        [DataGrid]
        public LocalizedString Acquisition { get; set; }

        [EntryForm]
        [DataGrid]
        public PhysicalStates PhysicalState { get; set; }

        //public bool StockExistence { get; set; }

        [EntryForm]
        [DataGrid]
        public float Dimension { get; set; }

        //[EntryForm]
        //[DataGrid]
        //public String SerieNumber { get; set; }

        [EntryForm]
        [DataGrid]
        public int NBRE { get; set; }

        /// Relations
        /// 
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm]
        [DataGrid]
        public Delivery Delivery { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm]
        [DataGrid]
        public Service Service { get; set; }

       

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm]
        [DataGrid]
        public Location Location { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm]
        [DataGrid]
        public MaterialCategory Materialcategory { get; set; }
    }
}
