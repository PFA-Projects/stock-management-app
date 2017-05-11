// hala ftouh Ghammat

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
        [EntryForm]
        [DataGrid]
        [Filter]
        public LocalizedString FirstName { get; set; }

        [EntryForm]
        [DataGrid]
        public LocalizedString LastName { get; set; }

        [EntryForm]
        [DataGrid]
        [Filter]
        public  LocalizedString Phone { get; set; }

        //Relations
       [EntryForm(GroupeBox = "")]
       [DataGrid]
       [Filter]
       [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Location location { get; set; }

       
   }
}
