// Mariam Ait Al
// 2017

using App.Gwin.Attributes;
using App.Gwin.Entities;
using StockManagement.Presentations.MaterialManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities
{
    /// <summary>
    /// fr : Reparation des Materiels
    /// en : Repair Materiels (Maintenance)
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "Reference")]
    [Menu(Group = "Maintenance")]
    [ManagementForm(Width = 800, TitrePageGridView = "repair_Grid", TitreButtonAjouter = "btn_Add_RM")]
    [PresentationLogic(TypePLO = typeof(MaterialRepairPLO))]
    public class MaterialRepair:BaseEntity
    {
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm(GroupeBox = "Materials_Informations", GroupeBoxOrder = 1)]
        public Material Material { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm(GroupeBox = "Materials_Informations", GroupeBoxOrder = 1,isDefaultIsEmpty =true)]
        public Service Service { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm(GroupeBox = "Materials_Informations", GroupeBoxOrder = 1,isDefaultIsEmpty =true)]
        public Location Location { get; set; }

        [EntryForm(GroupeBox = "repair_Informations", GroupeBoxOrder = 2)]
        public String Societe { get; set; }

        [EntryForm(GroupeBox = "repair_Informations", GroupeBoxOrder = 2,MultiLine =true)]
        public String Description { get; set; }

        [EntryForm(GroupeBox = "repair_Informations", GroupeBoxOrder = 2)]
        public DateTime OutDate { get; set; }

        [EntryForm(GroupeBox = "repair_Informations", GroupeBoxOrder = 2)]
        public DateTime ReturnDate { get; set; }

        // Get This Material Repairs Number 
        [DataGrid]
        public int TimesNumber { get; set; }


        public MaterialRepair()
        {
            OutDate = DateTime.Now;
            ReturnDate = DateTime.Now;
        }
    }
}
