// Mariam Ait Al
//2017
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
    /// fr : Category de Materiel
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "Designation")]
    [Menu(Group = "Materiels",Title ="Materials_Categories_Management")]
    [ManagementForm(Width = 800, TitrePageGridView = "MG_DGV", TitreButtonAjouter = "btn_Add_Service")]
    public class MaterialCategory:BaseEntity
    {
        [EntryForm(WidthControl =300,Ordre =1)]
        [DataGrid(WidthColonne =100,Ordre =1)]
        [Filter(WidthControl = 100)]
        public LocalizedString Designation { get; set; }

        [EntryForm(WidthControl = 300, Ordre = 2,MultiLine = true)]
        [DataGrid(WidthColonne = 200, Ordre = 2)]
        public LocalizedString Description { get; set; }
    }
}
