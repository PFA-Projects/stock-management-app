//Mariam Ait Al
// 2017

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using StockManagement.Entities;
using StockManagement.Enumerations;
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
    [GwinEntity(Localizable = true, DisplayMember = "Object")]
    [ManagementForm(TitrePageGridView = "Arrival_DGV", TitreButtonAjouter = "btn_add_Arrival", Height = 580, Width = 1050)]
    [Menu(Group = "Operations")]
    public class Arrival:BaseEntity
    {
        [EntryForm]
        [DataGrid]
        public DateTime ArrivalDate { get; set; }

        [EntryForm(MultiLine = true)]
        [DataGrid]
        [Filter(Ordre =1 ,WidthControl =150)]
        public LocalizedString Object { get; set; }

        

        [EntryForm]
        [DataGrid]
        [Filter]
        public LocalizedString Designation { get; set; }

        [EntryForm]
        [DataGrid]
        public int Number { get; set; }

        [EntryForm(MultiLine = true)]
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
        [Filter(isDefaultIsEmpty =true,WidthControl =250)]
        public MailConfiguration Configuration { get; set; }

        
    }
}
