// Mariam Ait Al

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
    /// fr : Personne
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "Cin")]
    [Menu]
    public class Personne:BaseEntity
    {
        [EntryForm]
        [DataGrid]
        [Filter]
        public string Cin { get; set; }

        [EntryForm]
        [DataGrid]
        [Filter]
        public LocalizedString FirstName { get; set; }

        [EntryForm]
        [DataGrid]
        [Filter]
        public LocalizedString LastName { get; set; }
    }
}
