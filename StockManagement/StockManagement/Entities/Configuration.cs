//Hala Ftouh Ghammat
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

    public class Configuration : BaseEntity
    {


        [DisplayProperty(Titre = "TVA")]
        [EntryForm]
        [DataGrid]
        [Filter]

        public float TVA { get; set; }


        [DisplayProperty(Titre = "RiskOfStock")]
        [EntryForm]
        [DataGrid]
        [Filter]

        public int RiskOfStock { get; set; }

        public Configuration()
        {
            TVA = 20;
            RiskOfStock = 10;
        }
    }
}