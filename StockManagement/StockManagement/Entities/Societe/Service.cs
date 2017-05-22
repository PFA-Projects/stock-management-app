// Mariam Ait Al
//2017
using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using StockManagement.Presentations.Print_Materials_List_By_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities
{
    /// <summary>
    /// fr : Service
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "Name")]
    [Menu(Group = "Societe",Title ="Service_Management")]
    [DataGridSelectedAction(Title = "MaterialsList", Description = "Print_Material_List", TypeOfForm = typeof(FormPrintByService))]
    [ManagementForm(Width = 800, TitrePageGridView = "Service_Grid_Title",TitreButtonAjouter ="btn_add_MG")]
    public class Service:BaseEntity
    {
        [EntryForm(WidthControl =300,Ordre =1)]
        [DataGrid(WidthColonne =50,Ordre =1)]
        [Filter]
        public LocalizedString Name { get; set; }

        [EntryForm(WidthControl = 300, MultiLine =true,Ordre =3)]
        [DataGrid(WidthColonne =120,Ordre =3)]
        //[Filter]
        public LocalizedString Observation { get; set; }

        [EntryForm(WidthControl = 300,Ordre =2)]
        [DataGrid(WidthColonne =50,Ordre = 2)]
       // [Filter]
        public LocalizedString Description { get; set; }

        
    }
}
