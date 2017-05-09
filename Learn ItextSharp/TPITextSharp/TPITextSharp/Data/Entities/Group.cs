using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPITextSharp.Data.Entities
{
    [GwinEntity(Localizable = true, DisplayMember = "Name")]
    [Menu]
    public class Group:BaseEntity
    {
        [EntryForm]
        [DataGrid]
        public string Name { get; set; }

        [EntryForm]
        [DataGrid]
        public string Description { get; set; }
    }
}
