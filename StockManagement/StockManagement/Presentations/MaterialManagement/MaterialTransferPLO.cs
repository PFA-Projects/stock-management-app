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
            EntryForm.Fields[nameof(MaterialTransfer.Location)].Hide();
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
                case nameof(MaterialTransfer.Service):
                    {
                        ManyToOneField servicefield = field as ManyToOneField;

                        Service service = servicefield.SelectedItem as Service;

                        if (service != null)
                        {
                            EntryForm.Fields[nameof(MaterialTransfer.Location)].Show();

                            ManyToOneField LocationField = EntryForm.Fields[nameof(MaterialTransfer.Location)] as ManyToOneField;
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
