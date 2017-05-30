// Mariam Ait Al
// 2017

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using StockManagement.Entities;
using StockManagement.Enumerations;
using StockManagement.Presentations.Print_BRD_Departure;
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
    [GwinEntity(Localizable = true, DisplayMember = "CorrespondanceObject")]
    [DataGridSelectedAction(Title = "BRD", Description = "Print_Departure_BRD", TypeOfForm = typeof(FormPrintBRD))]
    [ManagementForm(TitrePageGridView = "Departure_DGV", TitreButtonAjouter = "btn_add_Departure", Height = 580, Width = 1050)]
    [Menu(Group = "Operations")]
    public class Departure:BaseEntity
    {
        [EntryForm(Ordre =2)]
        [DataGrid(Ordre = 2)]
        public DateTime DepartureDate { get; set; }

        [EntryForm(MultiLine =true)]
        [DataGrid]
        public LocalizedString CorrespondanceObject { get; set; }

        [EntryForm(Ordre = 3)]
        [DataGrid(Ordre = 3)]
        [Filter(Ordre =1 ,WidthControl =150)]
        public LocalizedString Designation { get; set; }

        

        [EntryForm(Ordre = 4,MultiLine =  true)]
        [DataGrid(Ordre = 4)]
        public LocalizedString Observations { get; set; }

        [EntryForm(Ordre =1,isDefaultIsEmpty =true)]
        [DataGrid(Ordre =1)]
        //[Filter]
        public DepartureType Type { get; set; }

        [EntryForm(Ordre = 6)]
        [DataGrid(Ordre = 6)]
        public int NBRE { get; set; }

        //
        public Departure()
        {
            DepartureDate = DateTime.Now;
        }

        // Relations
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm(Ordre = 5,WidthControl =200)]
        [DataGrid(Ordre = 5)]
        [Filter(Ordre =2,isDefaultIsEmpty =true,WidthControl =200)]
        public MailConfiguration Configuration { get; set; }

        
    }
}
