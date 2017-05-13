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
using StockManagement.BLL;

namespace StockManagement.Presentations.RiskOFStock.MaterialCategories
{
    public partial class MaterialCategoryGridUC : UserControl
    {
        ModelContext db = new ModelContext();
        public MaterialCategoryGridUC()
        {
            InitializeComponent();
        }
        public event EventHandler EditerMaterialCategoryEvent;
        public MaterialCategory Currnt()
        {
            return (MaterialCategory)materialCategoryBindingSource.Current;
        }

        public void acctualisir()
        {
            materialCategoryBindingSource.Clear();
            materialCategoryBindingSource.DataSource = db.MaterialCategories.ToList<MaterialCategory>();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {

                if (DialogResult.Yes == MessageBox.Show(
                    "Voullez-vous vraimment supprimer ce Material Category",
                    "Confirmation de supprision", MessageBoxButtons.YesNo))
                {
                    MaterialCategory m = (MaterialCategory)materialCategoryBindingSource.Current;
                    db.MaterialCategories.Remove(m);
                    db.SaveChanges();
                    this.acctualisir();
                }

            }
            // Editer
            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index && e.RowIndex >= 0)
            {

                EditerMaterialCategoryEvent(sender, e);
            }


            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (dataGridView1.CurrentRow.Cells[0].Value != null)
                {
                    MaterialCategory materialcategory = new MaterialCategory();
                int x  = new MaterialsCategoriesBLO(db).countMaterialNumbre(Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    r.Cells[2].Value = x + "";
                }
              
            }

        }


    }
}