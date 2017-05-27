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
    [Menu(Group = "Operations")]
    [ManagementForm(Width = 800, TitrePageGridView = "repair_Grid", TitreButtonAjouter = "btn_Add_RM")]
    [PresentationLogic(TypePLO = typeof(MaterialRepairPLO))]
    public class MaterialRepair:BaseEntity
    {
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm(GroupeBox = "Materials_Informations", GroupeBoxOrder = 1,isDefaultIsEmpty =true)]
        [Filter(Ordre = 1)]
        [DataGrid(Ordre =1)]
        public Material Material { get; set; }

        [EntryForm(GroupeBox = "repair_Informations", GroupeBoxOrder = 2)]
        [Filter(Ordre =2)]
        [DataGrid(Ordre =2)]
        public String Societe { get; set; }

        [EntryForm(GroupeBox = "repair_Informations", GroupeBoxOrder = 2,MultiLine =true)]
        [DataGrid(Ordre =3)]
        public String Description { get; set; }

        [EntryForm(GroupeBox = "repair_Informations", GroupeBoxOrder = 2)]
        [DataGrid(Ordre = 4)]
        public DateTime OutDate { get; set; }

        [EntryForm(GroupeBox = "repair_Informations", GroupeBoxOrder = 2)]
        [DataGrid(Ordre = 5)]
        public DateTime ReturnDate { get; set; }

        
        


        public MaterialRepair()
        {
            OutDate = DateTime.Now;
            ReturnDate = DateTime.Now;
        }
    }
}
