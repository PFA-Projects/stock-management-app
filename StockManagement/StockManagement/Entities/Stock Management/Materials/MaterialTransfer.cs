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
    /// fr : Transfert des Materiels
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "TransferDate")]
    [Menu(Group = "Operations")]
    [ManagementForm(Width = 800, TitrePageGridView = "Tr_Grid", TitreButtonAjouter = "btn_Add_Tr")]
    [PresentationLogic(TypePLO = typeof(MaterialTransferPLO))]
    public class MaterialTransfer:BaseEntity
    {
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm(GroupeBox = "Material_Informations", GroupeBoxOrder = 1, isDefaultIsEmpty = true)]
        [DataGrid]
        [Filter(WidthControl =250)]
        public Material Material { get; set; }

        [EntryForm(GroupeBox = "Transfer_Informations", GroupeBoxOrder = 2)]
        [DataGrid]
        [Filter(WidthControl = 250)]
        public String Recipient { get; set; }

        [EntryForm(GroupeBox = "Transfer_Informations", GroupeBoxOrder = 2)]
        [DataGrid]
        public DateTime TransferDate { get; set; }

        [EntryForm(GroupeBox = "Transfer_Informations", GroupeBoxOrder = 2)]
        [DataGrid]
        public String Observations { get; set; }


    }
}
