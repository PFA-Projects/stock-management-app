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
    [Menu(Group = "Materiels")]
    [PresentationLogic(TypePLO = typeof(MaterialInOutPLO))]
    public class MaterialInOut:BaseEntity
    {
        
        // Material In Out Type 
        [EntryForm(Ordre = 1) ]
        public MaterialState MaterialState { get; set; }

        // Material Informations
        [EntryForm(Ordre =2,isDefaultIsEmpty =true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public MaterialCategory MaterialCategory { get; set; }

        [EntryForm(Ordre = 2,isDefaultIsEmpty =true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Material Material { get; set; }

        // Type = "Changement" (IN/OUT)
        // In

        [EntryForm(Ordre = 3)]
        public bool IsMaterialInStock { get; set; }
        [EntryForm(Ordre = 3)]
        public DateTime InDate { get; set; }
        [EntryForm(Ordre = 3)]
        public String InReason { get; set; }
        // Out
        [EntryForm(Ordre = 4)]
        public DateTime OutDate { get; set; }
        [EntryForm(Ordre = 4)]
        public String OutReason { get; set; }
        [EntryForm(Ordre = 4,isDefaultIsEmpty = true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Service Service { get; set; }
        [EntryForm(Ordre = 4)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Location Location { get; set; }
        





        //
        public MaterialInOut()
        {
            InDate = DateTime.Now;
        }


    }
}
