// Mariam Ait Al
// 2017

using App.Gwin.Components.Manager.EntryForms.PLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Gwin;
using StockManagement.Entities;
using App.Gwin.Fields;
using StockManagement.BLL;
using StockManagement.DAL;

namespace StockManagement.Presentations.MaterialManagement
{
    public class MaterialRepairPLO : IGwinPLO
    {
        public void FormAfterInit(BaseEntryForm EntryForm)
        {
        }

        public void FormBeforInit(BaseEntryForm EntryForm)
        {
           
        }

        public void ValidatingFiled(BaseEntryForm EntryForm, object sender)
        {
            
        }
        //
        ModelContext db = new ModelContext();
        public void ValueChanged(BaseEntryForm EntryForm, object sender)
        {
           
            }
    }
}
