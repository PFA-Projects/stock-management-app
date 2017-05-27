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
        [EntryForm(GroupeBox ="Material_Informations",GroupeBoxOrder =1,WidthControl = 550,isDefaultIsEmpty =true,Ordre = 1)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public virtual Material Material { get; set; }

        // In
        [EntryForm(GroupeBox = "In",GroupeBoxOrder =2,Ordre = 1)]
        public bool InStock { get; set; }
        [EntryForm(GroupeBox = "In", GroupeBoxOrder = 2,Ordre =2)]
        public DateTime InDate { get; set; }
        [EntryForm(GroupeBox = "In", GroupeBoxOrder = 2,Ordre = 3, MultiLine =true)]
        public String InReason { get; set; }

        // Out 
        [EntryForm(GroupeBox = "Out", GroupeBoxOrder = 3)]
        public DateTime OutDate { get; set; }
        [EntryForm(GroupeBox = "Out", GroupeBoxOrder = 3,MultiLine =true)]
        public String OutReason { get; set; }
        [EntryForm(isDefaultIsEmpty = true, GroupeBox = "Out", GroupeBoxOrder = 3)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public virtual  Service Service { get; set; }
        [EntryForm(isDefaultIsEmpty =true, GroupeBox = "Out", GroupeBoxOrder = 3)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public virtual Location Location { get; set; }

        //
        public String Observations { get; set; }

        public MaterialInOut()
        {
            InDate = DateTime.Now;
            OutDate = DateTime.Now;
        }

    }
}
