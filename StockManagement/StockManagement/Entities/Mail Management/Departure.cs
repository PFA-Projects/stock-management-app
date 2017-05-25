// Mariam Ait Al
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
    /// fr : Depart
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "Name")]
    [ManagementForm(TitrePageGridView = "Departure_DGV", TitreButtonAjouter = "btn_add_Departure", Height = 580, Width = 1050)]
    [Menu(Group = "Operations")]
    public class Departure:BaseEntity
    {
        public DateTime DepartureDate { get; set; }
        public LocalizedString CorrespondanceObject { get; set; }
        public LocalizedString Designation { get; set; }
        public int Number { get; set; }
        public LocalizedString Observations { get; set; }

        //
        public Departure()
        {
            DepartureDate = DateTime.Now;
        }

        // Relations
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public MailConfiguration Configuration { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Receiver Receiver { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Sender Sender { get; set; }
    }
}
