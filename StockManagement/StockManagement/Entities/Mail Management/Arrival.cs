//Mariam Ait Al
// 2017

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using StockManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities
{
    /// <summary>
    /// fr : Arrivee
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "Name")]
    [ManagementForm(TitrePageGridView = "Arrival_DGV", TitreButtonAjouter = "btn_add_Arrival", Height = 580, Width = 1050)]
    [Menu(Group = "Operations")]
    public class Arrival:BaseEntity
    {
        [EntryForm]
        [DataGrid]
        public DateTime ArrivalDate { get; set; }

        [EntryForm]
        [DataGrid]
        [Filter]
        public LocalizedString Object { get; set; }

        [EntryForm]
        [DataGrid]
        public LocalizedString Type { get; set; }

        [EntryForm]
        [DataGrid]
        [Filter]
        public LocalizedString Designation { get; set; }

        [EntryForm]
        [DataGrid]
        public int Number { get; set; }

        [EntryForm]
        [DataGrid]
        public LocalizedString Observations { get; set; }


        public Arrival()
        {
            ArrivalDate = DateTime.Now;
        }

        // Relations
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm]
        [DataGrid]
        public MailConfiguration Configuration { get; set; }


        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm]
        [DataGrid]
        public Receiver Receiver { get; set; }


        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [Filter]
        [DataGrid]
        public Sender Sender { get; set; }
    }
}
