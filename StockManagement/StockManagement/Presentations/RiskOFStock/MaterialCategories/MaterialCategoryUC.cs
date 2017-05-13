using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Gwin.Entities.MultiLanguage;
using StockManagement.Entities;

namespace StockManagement.Presentations.RiskOFStock.MaterialCategories
{
    public partial class MaterialCategoryUC : UserControl
    {
        public MaterialCategoryUC()
        {
            InitializeComponent();
        }
        public event EventHandler EnregistrerClick;
        public event EventHandler AnnulerClick;
        public  MaterialCategory materialcategory { set; get; }

        LocalizedString local = new LocalizedString();

        public void AfficherMaterialCategory()
        {
            Descriptiontextbox.Text = materialcategory.Description.Current;
            DesignationtextBox.Text = materialcategory.Designation.Current;
        }
          
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (materialcategory == null) materialcategory= new MaterialCategory();
            materialcategory.Description = new LocalizedString();
            materialcategory.Description .Current= Descriptiontextbox.Text;

            materialcategory.Designation= new LocalizedString();
            materialcategory.Designation.Current = DesignationtextBox.Text;
            EnregistrerClick(this, e);
        }

        private void MaterialCategoryUC_Load(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            AnnulerClick(this, e);
        }
    }
}
