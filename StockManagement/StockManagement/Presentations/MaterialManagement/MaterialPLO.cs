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
using StockManagement.Enumerations;

namespace StockManagement.Presentations.MaterialManagement
{
    public class MaterialPLO : IGwinPLO
    {
        public void FormAfterInit(BaseEntryForm EntryForm)
        {
            // Location
            EntryForm.Fields[nameof(Material.Location)].Hide();
            // Physical State Explication
            EntryForm.Fields[nameof(Material.PhysicalStateExplication)].Hide();
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
                case nameof(Material.Service):
                    {
                        ManyToOneField servicefield = field as ManyToOneField;

                        Service service = servicefield.SelectedItem as Service;
                  
                        if (service != null)
                        {
                            EntryForm.Fields[nameof(Material.Location)].Show();
                            
                            ManyToOneField LocationField = EntryForm.Fields[nameof(Material.Location)] as ManyToOneField;
                            List<Location> lc = new LocationBLO(db).LocationsByService(service);
                            LocationField.DataSource = lc;
                        }
                        else
                        {
                            EntryForm.Fields[nameof(MaterialInOut.Location)].Hide();
                        }


                    }
                    break;
                // Physical State Explication
                case nameof(Material.PhysicalState):
                    {
                        ComboBoxField PhysicalstateField = field as ComboBoxField;

                        PhysicalStates PhysicalState = (PhysicalStates)PhysicalstateField.Value ;

                        if (PhysicalState == PhysicalStates.autre)
                        {
                            EntryForm.Fields[nameof(Material.PhysicalStateExplication)].Show();
                        }

                    }
                    break;

            }

        }
    }
}
