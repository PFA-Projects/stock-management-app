// Mariam Ait Al

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using StockManagement.Entities.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities
{
    /// <summary>
    /// fr : Employee
    /// en : Employee
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "Cin")]
    [Menu(Group = "Societe",Title ="Employe_Management")]
    [ManagementForm(Width = 800, TitrePageGridView = "Employe_Grid_Title", TitreButtonAjouter = "btn_Add_Employe")]
    public class Employee: Person
    {
       

       
    }
}
