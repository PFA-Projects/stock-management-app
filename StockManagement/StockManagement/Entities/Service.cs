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
    /// fr : Service
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "Name")]
    [Menu(Group = "Societe")]
    public class Service:BaseEntity
    {
        [EntryForm]
        [DataGrid]
        [Filter]
        public LocalizedString Name { get; set; }

        [EntryForm]
        [DataGrid]
        //[Filter]
        public LocalizedString Observation { get; set; }

        [EntryForm]
        [DataGrid]
       // [Filter]
        public LocalizedString Description { get; set; }

        
    }
}
