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
    public class MaterialInOutPLO : IGwinPLO
    {
        public void FormAfterInit(BaseEntryForm EntryForm)
        {
            // In
            //EntryForm.Fields[nameof(MaterialInOut.InDate)].Hide();
            //EntryForm.Fields[nameof(MaterialInOut.InReason)].Hide();
            // Location
            EntryForm.Fields[nameof(MaterialInOut.Location)].Hide();
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
            //// In
            //if ((bool)EntryForm.Fields[nameof(MaterialInOut.InStock)].Value == true)
            //{
            //    EntryForm.Fields[nameof(MaterialInOut.InDate)].Show();
            //    EntryForm.Fields[nameof(MaterialInOut.InReason)].Show();
            //}
            //else
            //{
            //    EntryForm.Fields[nameof(MaterialInOut.InDate)].Hide();
            //    EntryForm.Fields[nameof(MaterialInOut.InReason)].Hide();
            //}

            // Location
            BaseField field = sender as BaseField;

            switch (field.Name)
            {
                // Location
                case nameof(MaterialInOut.Service):
                    {
                        ManyToOneField servicefield = field as ManyToOneField;

                        Service service = servicefield.SelectedItem as Service;

                        if (service != null && new LocationBLO(db).LocationsByService(service).Count >0)
                        {
                            EntryForm.Fields[nameof(MaterialInOut.Location)].Show();

                            ManyToOneField LocationField = EntryForm.Fields[nameof(MaterialInOut.Location)] as ManyToOneField;
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
