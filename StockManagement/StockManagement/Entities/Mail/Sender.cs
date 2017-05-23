// Mariam Ait Al
// 2017

using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities.Mail
{
    public class Sender: BaseEntity
    {
        public LocalizedString Name { get; set; }
        public LocalizedString Adress { get; set; }
        public LocalizedString Remarks { get; set; }
    }
}
