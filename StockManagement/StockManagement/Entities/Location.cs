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
    /// fr : Emplacement
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "Name")]
    [Menu]
    public class Location:BaseEntity
    {
      

        [EntryForm]
        [DataGrid]
       // [Filter]
        public LocalizedString Description { get; set; }

        [EntryForm]
        [DataGrid]
        [Filter]
        public LocalizedString Name { get; set; }


        // Relations
        [EntryForm]
        [DataGrid]
        [Filter]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Service Service { get; set; }
    }
}
