// Mariam Ait Al
// 2017

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities
{
    /// <summary>
    /// fr : Destinataire
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "Name")]
    [ManagementForm(TitrePageGridView = "Receivers_DGV", TitreButtonAjouter = "btn_add_Receivers", Height = 580, Width = 1050)]
    //[Menu(Group = "Transactions")]
    public class Receiver:BaseEntity
    {
        [Filter(Ordre = 1,WidthControl = 250)]
        [DataGrid(WidthColonne =150,Ordre = 1)]
        [EntryForm(Ordre = 1,WidthControl =350)]
        public LocalizedString Name { get; set; }

        
        [DataGrid(WidthColonne =300,Ordre =2)]
        [EntryForm(Ordre = 2,WidthControl =350,MultiLine =true)]
        public LocalizedString Adress { get; set; }

        
        [DataGrid(WidthColonne =300,Ordre =3)]
        [EntryForm(Ordre = 3,WidthControl =350,MultiLine =true)]
        public LocalizedString Remarks { get; set; }
    }
}
