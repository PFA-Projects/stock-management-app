// Mariam Ait Al
// 2017

using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities.Mail_Management
{
    [GwinEntity(Localizable = true, DisplayMember = "Reference")]
    public class DepartureFile:BaseEntity
    {
        public Byte[] File { get; set; }

        public Departure Departure { get; set; }
    }
}
