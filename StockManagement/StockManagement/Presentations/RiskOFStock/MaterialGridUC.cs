//hala Ftouh Ghammat
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagement.DAL;
using StockManagement.Entities;

namespace StockManagement.Presentations.RiskOFStock
{
    public partial class MaterialGridUC : UserControl
    {
        ModelContext db = new ModelContext();
        public MaterialGridUC()
        {
            InitializeComponent();
        }
        public event EventHandler EditerMaterialEvent;
        public Material Currnt()
        {
            return (Material)materialBindingSource.Current;
        }

        public void acctualisir()
        {
            materialBindingSource.Clear();
            materialBindingSource.DataSource = db.Materials.ToList<Material>();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {

                if (DialogResult.Yes == MessageBox.Show(
                    "Voullez-vous vraimment supprimer ce Material",
                    "Confirmation de supprision", MessageBoxButtons.YesNo))
                {
                    Material m = (Material)materialBindingSource.Current;
                    db.Materials.Remove(m);
                    db.SaveChanges();
                    this.acctualisir();
                }

            }
            // Editer
            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index && e.RowIndex >= 0)
            {

                EditerMaterialEvent(sender, e);
            }
        }

        private void MaterialGridUC_Load(object sender, EventArgs e)
        {

        }
    }
}
        