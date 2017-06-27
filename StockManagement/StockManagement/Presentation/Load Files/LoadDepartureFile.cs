using App.Gwin.Application.Presentation;
using App.Gwin.Components.Manager.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Gwin.Entities;
using StockManagement.Entities;

namespace StockManagement.Presentation.Load_Files
{
    public partial class LoadDepartureFile : BaseForm, IFormSelectedEntityAction
    {
        public LoadDepartureFile()
        {
            InitializeComponent();
        }

        Departure Departure = null;

        public void SetEntity(BaseEntity obj)
        {
            Departure = obj as Departure;
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            // openFileDialog.Multiselect = true;
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // string path = openFileDialog.FileName;
            }
        }
    }
}
