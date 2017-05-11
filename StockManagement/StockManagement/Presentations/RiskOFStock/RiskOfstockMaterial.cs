//hala ftouh ghammat
using App.Gwin.Attributes;
using StockManagement.DAL;
using StockManagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.Presentations.RiskOFStock
{
    [GwinEntity(Localizable = true, DisplayMember = "Reference")]
    [Menu(Group = "Materiels")]
    public partial class RiskOfstockMaterial : Form
    {
       
        ModelContext db = new ModelContext();
        public RiskOfstockMaterial()
        {
            InitializeComponent();
        }

        private void RiskOfstockMaterial_Load(object sender, EventArgs e)
        {

            this.materialGridUC1.acctualisir();
            materialGridUC1.EditerMaterialEvent += MAterialGrid_EditerMaterialEvent;
        }

        private void MAterialGrid_EditerMaterialEvent(object sender, EventArgs e)
        {
            Material material = materialGridUC1.Currnt();
            string tabEditerName = "TabEditer-" + material.Id;

            if (tabControl1.TabPages.IndexOfKey(tabEditerName) == -1)
            {
                // Création de Tab
                TabPage tabEditerStagiaire = new TabPage();
                tabEditerStagiaire.Text = material.InventoryNumber + " " + material.Designation+""+material.Delivery+""+material.dimension+""+material.INN_Number+""+material.Mark+""+material.Model+""+material.Observation+""+material.SerieNumber+""+material.AcquisitionValue+""+material.Acquisition;
                tabEditerStagiaire.Name = tabEditerName;
                tabControl1.TabPages.Add(tabEditerStagiaire);
                tabControl1.SelectedTab = tabEditerStagiaire;

                // Insertion du formulaire 
               MaterialUC materialUC = new MaterialUC();
               materialUC.Name = "MaterialUC";
                materialUC.material= material;
                materialUC.AfficherMaterial();
                this.tabControl1.TabPages[tabEditerName].Controls.Add(materialUC);
                materialUC.EnregistrerClick += MaterialForm_EditerClick;
                materialUC.AnnulerClick += MaterialForm_AnnulerEditerClick;
            }
        }

        private void MaterialForm_AnnulerEditerClick(object sender, EventArgs e)
        {
            MaterialUC materialUC = (MaterialUC)sender;
            Material material = materialUC.material;
            string tabEditerName = "TabEditer-" + material.Id;
            TabPage tabEditer = this.tabControl1.TabPages[tabEditerName];
            tabControl1.TabPages.Remove(tabEditer);
        }

        private void MaterialForm_EditerClick(object sender, EventArgs e)
        {
            MaterialUC materialUC = (MaterialUC)sender;
            Material material= materialUC.material;
            string tabEditerName = "TabEditer-" + material.Id;
            TabPage tabEditer = this.tabControl1.TabPages[tabEditerName];
            Material m = db.Materials.Find(material.Id);
            m.InventoryNumber= materialUC.material.InventoryNumber;
            m.Mark = materialUC.material.Mark;
            m.INN_Number = materialUC.material.INN_Number;
            m.Model = materialUC.material.Model;
            m.Observation = materialUC.material.Observation;
            m.SerieNumber = materialUC.material.SerieNumber;
           // m.StockExistence = materialUC.material.StockExistence;
            m.Acquisition = materialUC.material.Acquisition;
            m.AcquisitionValue = materialUC.material.AcquisitionValue;
            //m.AcquisitionValueExist = materialUC.material.AcquisitionValueExist;
            m.dimension = materialUC.material.dimension;
            m.Designation = materialUC.material.Designation;
            db.MaterialCategories.Attach(m.MaterialCategory);
            db.Materials.Attach(m);
            db.Deliveries.Attach(m.Delivery);
            db.Materials.Attach(m);

            if (db.SaveChanges() > 0)
            {
                MessageBox.Show(" le material :" + material.InventoryNumber+ " a été bien enregistrer");
            }
            else
            {
                MessageBox.Show("Le Material :" + material.ToString() + " n'est pas enregistrer car il n'y a pas des modifications");
            }


            // Suppression de la page Editer
            this.tabControl1.TabPages.Remove(tabEditer);
            this.materialGridUC1.acctualisir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Insertion du formulaire Si la page TabAjouter n'existe pas
            if (tabControl1.TabPages.IndexOfKey("TabAjouter") == -1)
            {
                // Création de Tab
                TabPage tabAjouterMaterial = new TabPage();
                tabAjouterMaterial.Text = "Ajouter un Material";
                tabAjouterMaterial.Name = "TabAjouter";
                tabControl1.TabPages.Add(tabAjouterMaterial);
                tabControl1.SelectedTab = tabAjouterMaterial;

                // Insertion du formulaire 
                MaterialUC materialUC = new MaterialUC();
                materialUC.Name = "materialUC=";
                this.tabControl1.TabPages["TabAjouter"].Controls.Add(materialUC );
                materialUC.EnregistrerClick += MaterialUC_EnregistrerClick;
                materialUC.AnnulerClick += MaterialUC_AnnulerAjouterClick;
            } }

        private void MaterialUC_AnnulerAjouterClick(object sender, EventArgs e)
        {
            TabPage tabAjouter = this.tabControl1.TabPages["TabAjouter"];
            tabControl1.TabPages.Remove(tabAjouter);
        }

        private void MaterialUC_EnregistrerClick(object sender, EventArgs e)
        {
            TabPage tabAjouter = this.tabControl1.TabPages["TabAjouter"];
            MaterialUC materialUC= (MaterialUC)tabAjouter.Controls
                .Find("materialUC",false).First();
           

            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Le Material:" + materialUC.material.ToString() + " a été bien enregistrer");
            }
            else
            {
                MessageBox.Show("Le Material :" + materialUC.material.ToString() + " n'est pas enregistrer");
            }

            this.tabControl1.TabPages.Remove(tabAjouter);
            this.materialGridUC1.acctualisir();
        }
    }
    }
