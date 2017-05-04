// Mariam Ait Al

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using App.Gwin.Entities.Persons;
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
    [Menu]
    public class Employee:Person
    {
       

       
    }
}
