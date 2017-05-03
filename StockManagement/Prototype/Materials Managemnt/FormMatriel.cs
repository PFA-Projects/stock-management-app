using StockManagement.BLL;
using StockManagement.DAL;
using StockManagement.Entities;
using System;
using System.Windows.Forms;

namespace GestionMagasin.GestionMatriel
{
    public partial class FormMatriel : UserControl
    {
        public event EventHandler EnregistrerClick;
        public event EventHandler AnnulerClick;

        public FormMatriel()
        {
            InitializeComponent();
        }

        public Material Matriel { set; get; }
        public void Afficher()
        {


         acquisitionTextBox.Text=  ""+ Matriel.Acquisition ;
            dateMiseServiceDateTimePicker.Value = Matriel.UpdateServiceDate;
            designationTextBox.Text= Matriel.Designation.Current ;
          dimensionTextBox.Text=""+  Matriel.dimension ;
            // Physique state : enumerations
       // etatPhysiqueTextBox.Text=            Matriel.EtatPhysique ;
          
            if (Matriel.StockExistence == true) 
            {
                isExistStokRadioButton.Checked = true;
            }
            else
            {
               radioButton1.Checked = true;
            }
           
            if (Matriel.AcquisitionValueExist==true)
            {
                radioButton3.Checked = true;
              
            }
            else
            {
                radioButton2.Checked = true;

            }
           modelTextBox.Text= Matriel.Model.Current ;
           numero_INNTextBox.Text = Matriel.INN_Number;
           numero_SerieTextBox.Text = Matriel.SerieNumber;
           numeroInvontaireTextBox.Text = Matriel.InventoryNumber.Current;
            observationTextBox.Text    =  Matriel.Observation.Current;
            valeurAcquisitionTextBox.Text = Matriel.AcquisitionValue.ToString() ;






            if (categorieComboBox.SelectedItem != null)
                Matriel.materialCategory = (MaterialCategory)categorieComboBox.SelectedItem;

        }

        private void br_enregistrer_Click(object sender, EventArgs e)
        {

            if (this.Matriel == null) Matriel = new Material();
            Matriel.Acquisition = acquisitionTextBox.Text;
            Matriel.UpdateServiceDate = dateMiseServiceDateTimePicker.Value;
            Matriel.Designation.Current = designationTextBox.Text;
            Matriel.dimension = int.Parse(dimensionTextBox.Text);
            // Etat Physique : Enumerations
            //Matriel.EtatPhysique = etatPhysiqueTextBox.Text;
          if(isExistStokRadioButton.Checked)
            {
                Matriel.StockExistence = true;
            }else
            {
                Matriel.StockExistence = false;
            }
            if (radioButton3.Checked)
            {
                Matriel.AcquisitionValueExist = true;
            }
            else
            {
                Matriel.AcquisitionValueExist = false;
            }
            Matriel.Model.Current = modelTextBox.Text;
            Matriel.INN_Number = numero_INNTextBox.Text;
            Matriel.SerieNumber = numero_SerieTextBox.Text;
            Matriel.InventoryNumber.Current = numeroInvontaireTextBox.Text;
            Matriel.Observation.Current = observationTextBox.Text;
            Matriel.AcquisitionValue = float.Parse(valeurAcquisitionTextBox.Text);
           
        
          


        
            if (categorieComboBox.SelectedItem != null)
                Matriel.materialCategory= (MaterialCategory)categorieComboBox.SelectedItem;
          //  new ServiceMatriel().Ajouter(Matriel);
            EnregistrerClick(this, e);

        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            AnnulerClick(this, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //
        ModelContext db = new ModelContext();
        private void FormMatriel_Load(object sender, EventArgs e)
        {
            categorieMatrielBindingSource.DataSource = new MaterialsCategoriesBLO(db).GetAll();
        }
    }
}
