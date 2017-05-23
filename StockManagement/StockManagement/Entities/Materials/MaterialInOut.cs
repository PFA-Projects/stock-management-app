// Mariam Ait Al

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;

namespace StockManagement.Entities
{
    /// <summary>
    /// fr: Entree Sorties Materiels
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "Reference")]
    [Menu(Group = "Materiels")]
    public class MaterialInOut:BaseEntity
    {
        // [EntryForm]
        // [DataGrid]
        //// [Filter]
        // public DateTime OutDate { get; set; }

        // [EntryForm]
        // [DataGrid]
        // // [Filter]
        // public DateTime InDate { get; set; }

        // [EntryForm]
        // [DataGrid]
        // // [Filter]
        // public LocalizedString InReason { get; set; }


        // [EntryForm]
        // [DataGrid]
        // // [Filter]
        // public LocalizedString OutReason { get; set; }


        // [EntryForm]
        // [DataGrid]
        // // [Filter]
        // public LocalizedString Observation { get; set; }

        // // Initialize DateTime
        // public MaterialInOut()
        // {
        //     InDate = DateTime.Now;
        //     OutDate = DateTime.Now;
        // }

        //// Relations
        //[EntryForm]
        //[DataGrid]
        ////[Filter]
        //[Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        // public Material Material { get; set; }
        // // //
        // [EntryForm]
        // [DataGrid]
        // // [Filter]
        // [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        // public Location Location { get; set; }

        // // /// <summary>
        // // /// Out Responsible
        // // /// </summary>

        // [EntryForm]
        // [DataGrid]
        // // [Filter]
        // [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        // public Employee Employee { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm]
        [DataGrid]
        [Filter]
        public Material Material { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm]
        [DataGrid]
        public Location OriginaLLocation { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm]
        [DataGrid]
        public Location NewLocation { get; set; }

        [EntryForm]
        [DataGrid]
        public LocalizedString Reason { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm]
        [DataGrid]
        public Employee Employee { get; set; }

        [EntryForm]
        [DataGrid]
        public LocalizedString Observation { get; set; }

        [EntryForm]
        [DataGrid]
        public DateTime InOutDate { get; set; }
    }
}
