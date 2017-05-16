// Mariam Ait Al

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using StockManagement.Enumerations;
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
    [Menu(Group = "Materiels")]
    public class Material: BaseEntity
    {
        [EntryForm(GroupeBox = "InventoryInformations")]
        [DataGrid]
        [Filter]
        public LocalizedString InventoryNumber { get; set; }

        [EntryForm(GroupeBox = "InventoryInformations")]
        [DataGrid]
        [Filter]
        public LocalizedString Designation { get; set; }

        [EntryForm(GroupeBox = "AcquisitionInformations")]
        [DataGrid]
        [Filter]
        public LocalizedString Mark { get; set; }

        [EntryForm(GroupeBox = "AcquisitionInformations")]
        [DataGrid]
        [Filter]
        public LocalizedString Model { get; set; }

        [EntryForm(GroupeBox = "InventoryInformations")]
        [DataGrid]
        [Filter]
        public DateTime UpdateServiceDate { get; set; }

        [EntryForm(GroupeBox = "InventoryInformations")]
        [DataGrid]
        [Filter]
        public LocalizedString Observation { get; set; }

        [EntryForm(GroupeBox = "AcquisitionInformations")]
        [DataGrid]
        [Filter]
        public float AcquisitionValue { get; set; }

        [EntryForm(GroupeBox = "AcquisitionInformations")]
        [DataGrid]
        [Filter]
        public string Acquisition { get; set; }

        [EntryForm]
        [DataGrid]
        [Filter]
        public bool AcquisitionValueExist { get; set; }

        [EntryForm(GroupeBox = "MaterialSituation")]
        [DataGrid]

        public PhysicalStates PhysicalState { get; set; }

        //
        [EntryForm(GroupeBox = "MaterialSituation")]
        [DataGrid]
        [Filter]
        public bool StockExistence { get; set; }

        [EntryForm(GroupeBox = "InventoryInformations")]
        [DataGrid]
        [Filter]
        public float dimension { get; set; }

        [EntryForm(GroupeBox = "InventoryInformations")]
        [DataGrid]
        [Filter]
        public string INN_Number { get; set; }

        [EntryForm(GroupeBox = "InventoryInformations")]
        [DataGrid]
        [Filter]
        public string SerieNumber { get; set; }
        //
        public Material()
        {
            UpdateServiceDate = DateTime.Now;
        }

        // Relations
        [EntryForm(GroupeBox = "")]
        [DataGrid]
        [Filter]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Delivery Delivery { get; set; }

        [EntryForm(GroupeBox = "")]
        [DataGrid]
        [Filter]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public MaterialCategory MaterialCategory { get; set; }
    }
}
