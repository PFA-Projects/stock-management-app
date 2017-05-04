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
    /// fr : Category de Materiel
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "Reference")]
    [Menu(Group = "Materiels")]
    public class MaterialCategory:BaseEntity
    {
        [EntryForm]
        [DataGrid]
        [Filter]
        public LocalizedString Designation { get; set; }

        [EntryForm]
        [DataGrid]
        //[Filter]
        public LocalizedString Description { get; set; }
    }
}
