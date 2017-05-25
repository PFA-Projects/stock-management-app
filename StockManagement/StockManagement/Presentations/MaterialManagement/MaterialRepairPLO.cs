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
            // Location
            EntryForm.Fields[nameof(MaterialRepair.Location)].Hide();
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
            BaseField field = sender as BaseField;

            switch (field.Name)
            {
                // Location
                case nameof(MaterialRepair.Service):
                    {
                        ManyToOneField servicefield = field as ManyToOneField;

                        Service service = servicefield.SelectedItem as Service;

                        if (service != null)
                        {
                            EntryForm.Fields[nameof(MaterialRepair.Location)].Show();

                            ManyToOneField LocationField = EntryForm.Fields[nameof(MaterialRepair.Location)] as ManyToOneField;
                            List<Location> lc = new LocationBLO(db).LocationsByService(service);
                            LocationField.DataSource = lc;
                        }
                        else
                        {
                            EntryForm.Fields[nameof(MaterialInOut.Location)].Hide();
                        }


                    }
                    break;
            }
            }
    }
}
