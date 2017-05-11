using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities
{
    [GwinEntity(Localizable = true, DisplayMember = "Name")]
  
    [Menu(Group = "Configuration")]

    public class configuration : BaseEntity
    {


     
        [EntryForm]
        [DataGrid]

        public float TVA { get; set; }

      
         [EntryForm]
        [DataGrid]

        public int RiskOfStock { get; set; }

        public configuration()
        {
            TVA = 20;
            RiskOfStock = 10;
        }
    }
}