// Mariam Ait Al
// 2017

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using StockManagement.DAL;
using StockManagement.Enumerations;
using StockManagement.Presentation.MailManagement;
using StockManagement.Presentations.Print_BRD_Departure;
using System;
using System.Linq;

namespace StockManagement.Entities
{
    /// <summary>
    /// fr : Depart
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "CorrespondanceObject")]
    // we can't set duplicate datagridviewSelectedAction ?!!
    [DataGridSelectedAction(Title = "BRD", Description = "Print_Departure_BRD", TypeOfForm = typeof(FormPrintBRD))]
    [ManagementForm(TitrePageGridView = "Departure_DGV", TitreButtonAjouter = "btn_add_Departure", Height = 580, Width = 1050)]
    [Menu(Group = "Operations")]
    [PresentationLogic(TypePLO = typeof(DeparturePLO))]
    public class Departure:BaseEntity
    {
        [EntryForm(isShowDefaultValueWhenAdd =true,Ordre = 1,Enable =false)]
        public long number { get; set; }

        [EntryForm(Ordre =3)]
        [DataGrid(Ordre = 2)]
        public DateTime DepartureDate { get; set; }

        [EntryForm(MultiLine =true,Ordre =2)]
        [DataGrid]
        public LocalizedString CorrespondanceObject { get; set; }

        [EntryForm(Ordre = 4)]
        [DataGrid(Ordre = 3)]
        [Filter(Ordre =1 ,WidthControl =150)]
        public LocalizedString Designation { get; set; }

        

        [EntryForm(Ordre = 5,MultiLine =  true,isShowDefaultValueWhenAdd =true)]
        [DataGrid(Ordre = 4)]
        public String Observations { get; set; }

        [EntryForm(Ordre =1,isDefaultIsEmpty =true)]
        [DataGrid(Ordre =1)]
        //[Filter]
        public DepartureType Type { get; set; }

        [EntryForm(Ordre = 6)]
        [DataGrid(Ordre = 6)]
        public int NBRE { get; set; }

        
        //
        ModelContext db = new ModelContext();
       
        public Departure()
        {
            Observations = "pour touts fins utils";
            number = db.Departurs.Count() + 1;
            DepartureDate = DateTime.Now;
        }

        // Relations
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm(isDefaultIsEmpty = true,Ordre =7,isFormulaire =true)]
        [DataGrid]
        public MailConfiguration Configuration { get; set; }

        
    }
}
