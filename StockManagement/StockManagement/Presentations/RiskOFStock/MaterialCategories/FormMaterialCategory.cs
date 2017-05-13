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

namespace StockManagement.Presentations.RiskOFStock.MaterialCategories
{
    [App.Gwin.Attributes.Menu(EntityType = typeof(MaterialCategory), Order = 10, Title = "RiskOfStockMaterialCat")]

    public partial class FormMaterialCategory : Form
    {

        ModelContext db = new ModelContext();
        public FormMaterialCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {// Insertion du formulaire Si la page TabAjouter n'existe pas
            if (tabControl1.TabPages.IndexOfKey("TabAjouter") == -1)
            {
                // Création de Tab
                TabPage tabAjouterMaterialCategory = new TabPage();
                tabAjouterMaterialCategory.Text = "Ajouter un MaterialCategory";
                tabAjouterMaterialCategory.Name = "TabAjouter";
                tabControl1.TabPages.Add(tabAjouterMaterialCategory);
                tabControl1.SelectedTab = tabAjouterMaterialCategory;

                // Insertion du formulaire 
                MaterialCategoryUC materialCategoryUC = new MaterialCategoryUC();
             materialCategoryUC.Name = "materialCategoryUC";
                this.tabControl1.TabPages["TabAjouter"].Controls.Add(materialCategoryUC);
            materialCategoryUC.EnregistrerClick += materialCategoryUC_EnregistrerClick;
            materialCategoryUC.AnnulerClick += materialCategoryUC_AnnulerAjouterClick;
            }
        }

        private void materialCategoryUC_AnnulerAjouterClick(object sender, EventArgs e)
        {
            TabPage tabAjouter = this.tabControl1.TabPages["TabAjouter"];
            tabControl1.TabPages.Remove(tabAjouter);
        }

        private void materialCategoryUC_EnregistrerClick(object sender, EventArgs e)
        {
            TabPage tabAjouter = this.tabControl1.TabPages["TabAjouter"];
            MaterialCategoryUC materialCategoryUC = (MaterialCategoryUC)tabAjouter.Controls
                .Find("materialCategoryUC", true).First();
           db.MaterialCategories.Add (materialCategoryUC.materialcategory);

            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Le Material:" + materialCategoryUC.materialcategory.ToString() + " a été bien enregistrer");
            }
            else
            {
              //  MessageBox.Show("Le Material :" + materialCategoryUC.materialcategory.ToString() + " n'est pas enregistrer");
            }

            this.tabControl1.TabPages.Remove(tabAjouter);
            this.materialCategoryGridUC1.acctualisir();
        }
    
    

    private void FormMaterialCategory_Load(object sender, EventArgs e)
        {
            this.materialCategoryGridUC1.acctualisir();
           materialCategoryGridUC1.EditerMaterialCategoryEvent += materialCategoryGridUC1_EditermaterialCategoryEvent;
          
        
        }

        private void materialCategoryGridUC1_EditermaterialCategoryEvent(object sender, EventArgs e)
        {
            MaterialCategory materialcategory = materialCategoryGridUC1.Currnt();
            string tabEditerName = "TabEditer-" + materialcategory.Id;

            if (tabControl1.TabPages.IndexOfKey(tabEditerName) == -1)
            {
                // Création de Tab
                TabPage tabEditerStagiaire = new TabPage();
                tabEditerStagiaire.Text = materialcategory.Description + " " + materialcategory.Designation;
                tabEditerStagiaire.Name = tabEditerName;
                tabControl1.TabPages.Add(tabEditerStagiaire);
                tabControl1.SelectedTab = tabEditerStagiaire;

                // Insertion du formulaire 
              MaterialCategoryUC materiacategoryUC = new MaterialCategoryUC();
                materiacategoryUC.Name = "";
                materiacategoryUC.materialcategory =materialcategory;
                materiacategoryUC.AfficherMaterialCategory();
                this.tabControl1.TabPages[tabEditerName].Controls.Add(materiacategoryUC);
                materiacategoryUC.EnregistrerClick += materiacategoryUC_EditerClick;
                materiacategoryUC.AnnulerClick += materiacategoryUC_AnnulerEditerClick;
            }
        }

        private void materiacategoryUC_AnnulerEditerClick(object sender, EventArgs e)
        {
       MaterialCategoryUC materiacategoryUC = (MaterialCategoryUC)sender;
            MaterialCategory materialcategory = materiacategoryUC.materialcategory;
            string tabEditerName = "TabEditer-" + materialcategory.Id;
            TabPage tabEditer = this.tabControl1.TabPages[tabEditerName];
            tabControl1.TabPages.Remove(tabEditer);
        }

        private void materiacategoryUC_EditerClick(object sender, EventArgs e)
        {
            MaterialCategoryUC materialcategoryUC= (MaterialCategoryUC)sender;
            MaterialCategory materialcategory = materialcategoryUC.materialcategory;
            string tabEditerName = "TabEditer-" + materialcategory.Id;
            TabPage tabEditer = this.tabControl1.TabPages[tabEditerName];
            MaterialCategory m = db.MaterialCategories.Find(materialcategory.Id);
           
            m.Designation = materialcategoryUC.materialcategory.Designation;
            m.Description= materialcategoryUC.materialcategory.Description;
           
          
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show(" le material Category:" + materialcategory.Description + " a été bien enregistrer");
            }
            else
            {
                MessageBox.Show("Le Material Category :" + materialcategory.ToString() + " n'est pas enregistrer car il n'y a pas des modifications");
            }


            // Suppression de la page Editer
            this.tabControl1.TabPages.Remove(tabEditer);
            this.materialCategoryGridUC1.acctualisir();
        }
    }
    }

