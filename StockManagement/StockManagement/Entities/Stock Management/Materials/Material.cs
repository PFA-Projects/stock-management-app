// Mariam Ait Al
//2017

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using StockManagement.Enumerations;
using StockManagement.Presentations.MaterialManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities
{
    [GwinEntity(Localizable = true, DisplayMember = "SerieNumber")]
    [ManagementForm(Width = 800, TitrePageGridView = "Service_Grid_Title", TitreButtonAjouter = "btn_add_MG")]
    [Menu(Group = "Materiels")]
    [PresentationLogic(TypePLO = typeof(MaterialPLO))]
    public class Material:BaseEntity
    {

        [EntryForm(GroupeBox ="")]
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

        [EntryForm]
        [DataGrid]
        public String Provider { get; set; }

        [EntryForm]
        [DataGrid]
        public LocalizedString Observation { get; set; }

        [EntryForm]
        [DataGrid]
        public float AcquisitionValue { get; set; }

        [EntryForm]
        [DataGrid]
        public LocalizedString Acquisition { get; set; }

        [EntryForm(isDefaultIsEmpty = true)]
        [DataGrid]
        public PhysicalStates PhysicalState { get; set; }

        [EntryForm]
        [DataGrid]
        public String PhysicalStateExplication { get; set; }

        [EntryForm]
        [DataGrid]
        public float Dimension { get; set; }

        [EntryForm]
        [DataGrid]
        public String SerieNumber { get; set; }

        [EntryForm]
        [DataGrid]
        public int NBRE { get; set; }

        [EntryForm]
        public DateTime UpdateServiceDate { get; set; }
        //
        public Material()
        {
            UpdateServiceDate = DateTime.Now;
        }

        /// Relations
        /// 
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm(GroupeBox = "", GroupeBoxOrder = 1 , isDefaultIsEmpty =true)]
        [DataGrid]
        public Delivery Delivery { get; set; }

       

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm(isDefaultIsEmpty = true)]
        [DataGrid]
        public MaterialCategory Materialcategory { get; set; }

        
    }
}
