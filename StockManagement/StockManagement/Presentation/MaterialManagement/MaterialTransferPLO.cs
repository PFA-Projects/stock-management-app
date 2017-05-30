// Mariam Ait Al
//2017

using App.Gwin.Components.Manager.EntryForms.PLL;
using System.Collections.Generic;
using App.Gwin;
using StockManagement.DAL;
using App.Gwin.Fields;
using StockManagement.Entities;
using StockManagement.BLL;

namespace StockManagement.Presentations.MaterialManagement
{
    public class MaterialTransferPLO : IGwinPLO
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
