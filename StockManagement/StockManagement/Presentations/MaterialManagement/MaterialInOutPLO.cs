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
using StockManagement.Enumerations;
using StockManagement.BLL;
using StockManagement.DAL;

namespace StockManagement.Presentations.MaterialManagement
{
    public class MaterialInOutPLO : IGwinPLO
    {
        public void FormAfterInit(BaseEntryForm EntryForm)
        {
            // Locations By Service
            EntryForm.Fields[nameof(MaterialInOut.Location)].Hide();
            // IN /OUT
            EntryForm.Fields[nameof(MaterialInOut.InDate)].Hide();
            EntryForm.Fields[nameof(MaterialInOut.InReason)].Hide();
            EntryForm.Fields[nameof(MaterialInOut.IsMaterialInStock)].Hide();
            EntryForm.Fields[nameof(MaterialInOut.Service)].Hide();
            EntryForm.Fields[nameof(MaterialInOut.Location)].Hide();
            EntryForm.Fields[nameof(MaterialInOut.OutDate)].Hide();
            EntryForm.Fields[nameof(MaterialInOut.OutReason)].Hide();
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
                case nameof(MaterialInOut.Service):
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


                    }
                    break;
                // Material Category
                case nameof(MaterialInOut.MaterialCategory):
                    {
                        ManyToOneField MaterialCategoryField = field as ManyToOneField;
                        MaterialCategory MaterialCategory = MaterialCategoryField.SelectedItem as MaterialCategory;

                        if(MaterialCategory != null)
                        {
                            ManyToOneField MaterialsField = EntryForm.Fields[nameof(MaterialInOut.Material)] as ManyToOneField;
                            List<Material> lm = new MaterialBLO(db).GetMaterialsByMaterialCategory(MaterialCategory);
                            MaterialsField.DataSource = lm;
                        }

                    }
                    break;
                // Material State
                // In / Out
                case nameof(MaterialInOut.MaterialState):
                    {
                        ComboBoxField MaterialStateField = field as ComboBoxField;

                        MaterialState MaterialState = (MaterialState)MaterialStateField.Value;

                        if(MaterialState == MaterialState.Changement)
                        {
                            EntryForm.Fields[nameof(MaterialInOut.IsMaterialInStock)].Show();
                            EntryForm.Fields[nameof(MaterialInOut.Service)].Show();
                            EntryForm.Fields[nameof(MaterialInOut.OutDate)].Show();
                            EntryForm.Fields[nameof(MaterialInOut.OutReason)].Show();
                        }

                    }
                    break;
                // In
                case nameof(MaterialInOut.IsMaterialInStock):
                    {
                    }
                    break;
            }


            }
    }
}
