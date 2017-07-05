// Mariam Ait Al
//

using App.Gwin.Components.Manager.EntryForms.PLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Gwin;
using App.Gwin.Fields;
using StockManagement.Entities;
using StockManagement.Enumerations;

namespace StockManagement.Presentation.MailManagement
{
    public class DeparturePLO : IGwinPLO
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

        public void ValueChanged(BaseEntryForm EntryForm, object sender)
        {
            BaseField field = sender as BaseField;
            switch (field.Name)
            {

                // Physical State Explication
                case nameof(Departure.Type):
                    {
                        ComboBoxField DepartureTypeField = field as ComboBoxField;

                        DepartureType DepartureType = (DepartureType)DepartureTypeField.Value;

                        if (DepartureType == DepartureType.Externe)
                        {
                            EntryForm.Fields[nameof(Departure.Observations)].Hide();
                           
                        }
                        else
                        {
                            EntryForm.Fields[nameof(Departure.Observations)].Show();
                        }
                    }
                    break;

            }
        }
    }
}
