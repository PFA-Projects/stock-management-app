// Mariam Ait Al

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using StockManagement.Enumerations;
using StockManagement.Presentations.MaterialManagement;
using System;

namespace StockManagement.Entities
{
    /// <summary>
    /// fr: Entree Sorties Materiels
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "Reference")]
    [Menu(Group = "Operations")]
    [PresentationLogic(TypePLO = typeof(MaterialInOutPLO))]
    public class MaterialInOut:BaseEntity
    {
        [EntryForm(GroupeBox ="Material_Informations",GroupeBoxOrder =1,isDefaultIsEmpty =true,Ordre = 1)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [Filter(isDefaultIsEmpty = true,Ordre = 1,WidthControl = 250)]
        [DataGrid(Ordre =1)]
        public virtual Material Material { get; set; }

        // In
        //[EntryForm(GroupeBox = "In",GroupeBoxOrder =2,Ordre = 1)]
        public bool InStock { get; set; }
        //[EntryForm(GroupeBox = "In", GroupeBoxOrder = 2,Ordre =2)]
        public DateTime InDate { get; set; }
        //[EntryForm(GroupeBox = "In", GroupeBoxOrder = 2,Ordre = 3, MultiLine =true)]
        public String InReason { get; set; }

        // Out 
        [DataGrid(Ordre =4)]
        [EntryForm(GroupeBox = "Service_Changement", GroupeBoxOrder = 2)]
        public DateTime OutDate { get; set; }

        [DataGrid(Ordre =5)]
        [EntryForm(GroupeBox = "Service_Changement", GroupeBoxOrder = 2,MultiLine =true)]
        public String OutReason { get; set; }

        [DataGrid(Ordre =2)]
        [EntryForm(isDefaultIsEmpty = true, GroupeBox = "Service_Changement", GroupeBoxOrder = 2)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public virtual  Service Service { get; set; }

        [DataGrid(Ordre =3)]
        [EntryForm(isDefaultIsEmpty =true, GroupeBox = "Service_Changement", GroupeBoxOrder = 2)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public virtual Location Location { get; set; }

        //
        [EntryForm(GroupeBox = "Service_Changement",GroupeBoxOrder = 2)]
        [DataGrid(Ordre =6)]
        public String Observations { get; set; }

        public MaterialInOut()
        {
            InDate = DateTime.Now;
            OutDate = DateTime.Now;
        }

    }
}
