// Mariam Ait Al
// 2017

using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities
{
    /// <summary>
    /// fr : Configuration des courriers
    /// </summary>
    [GwinEntity(Localizable = true, DisplayMember = "Adress")]
    [ManagementForm( TitrePageGridView = "MailConfig_DGV", TitreButtonAjouter = "btn_Add_MailConfig",Height =550, Width = 700)]
    [Menu(Group = "Configuration")]
    public class MailConfiguration:BaseEntity
    {
        [EntryForm(GroupeBox ="Configuration",GroupeBoxOrder =1,MultiLine =true)]
        [DataGrid(WidthColonne =350)]
        [Filter(WidthControl = 300)]
        public String Adress { get; set; }


        [EntryForm(GroupeBox = "Configuration", GroupeBoxOrder = 1, MultiLine = true)]
        [DataGrid(WidthColonne = 350)]
        public String Observations { get; set; }


    }
}
