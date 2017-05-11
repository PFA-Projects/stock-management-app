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
using App.Gwin.Entities.MultiLanguage;

namespace StockManagement.Presentations.RiskOFStock
{
    public partial class MaterialUC : UserControl
    {
        ModelContext db = new ModelContext();
        public MaterialUC()
        {
            InitializeComponent();
        }
        public event EventHandler EnregistrerClick;
        public event EventHandler AnnulerClick;
        public Material material { set; get; }

        LocalizedString local = new LocalizedString();
        public void AfficherMaterial()
        {
            InventoryNumbertextBox.Text = material.InventoryNumber.Current;
            DesingationtextBox.Text = material. Designation.Current;
            DimensiontextBox.Text = material.dimension.ToString();
            //AcquisitionValueExitextBox.Text = material.AcquisitionValueExist.ToString();
            AcquisitionValuetextBox.Text = material.AcquisitionValue.ToString();
            AcquitextBox.Text = material.Acquisition.ToString();
            INN_NumbertextBox.Text = material.INN_Number;
            MarktextBox.Text = material.Mark.Current;
            ModeltextBox.Text = material.Model.Current;
            ObservationtextBox.Text = material.Observation.Current;
            
            SerieNumbertextBox.Text = material.SerieNumber;
          //  StockExistencetextBox.Text = material.SerieNumber;

        }

        private void MaterialUC_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (this.material == null) material = new Material();
            material.InventoryNumber = new LocalizedString();
            material.InventoryNumber.Current = InventoryNumbertextBox.Text  ;

            material.Designation = new LocalizedString();
            material.Designation.Current = DesingationtextBox.Text ;
           
          material.dimension  =float.Parse( DimensiontextBox.Text);
          //material.AcquisitionValueExist = bool.Parse( AcquisitionValueExitextBox.Text );
           material.AcquisitionValue= float.Parse( AcquisitionValuetextBox.Text)  ;
           material.Acquisition =AcquitextBox.Text  ;
           material.INN_Number =INN_NumbertextBox.Text ;
            material.Mark = new LocalizedString();
           material.Mark.Current =MarktextBox.Text  ;
            material.Model = new LocalizedString();
           material.Model.Current =ModeltextBox.Text  ;
            material.Observation = new LocalizedString();
           material.Observation.Current= ObservationtextBox.Text  ;

            material.PhysicalState = Enumerations.PhysicalStates.New;
           material.SerieNumber= SerieNumbertextBox.Text  ;
           // material.StockExistence= StockExistencetextBox.Text ;
            material.DateCreation = DateTime.Now;
            



            if (comboBox1.SelectedItem != null)
                material.Delivery= (Delivery)comboBox1.SelectedItem;
            if (comboBox2.SelectedItem != null)
                material.MaterialCategory = (MaterialCategory)comboBox2.SelectedItem;
            EnregistrerClick(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           AnnulerClick(this, e);
        }
    }
}
