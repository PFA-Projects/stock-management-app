using App.Gwin;
using App.Gwin.Entities.Secrurity.Authentication;
using StockManagement.BAL;
using StockManagement.BLL;
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

namespace GestionMagasin.GestionMatriel
{
    public partial class FormGestionMateriel : Form
    {
        public FormGestionMateriel()
        {
            InitializeComponent();
        }
        private void FormGestionMateriel_Load(object sender, EventArgs e)
        {
            // Start Gwin Application with Authentification
            User user = null;

            user = User.CreateRootUser();
            user.Language = GwinApp.Languages.fr;
            GwinApp.Start(typeof(ModelContext), typeof(BaseBLO<>), null, user);

            //Form Aggrandize
            this.WindowState = FormWindowState.Maximized;


            this.materielGrid1.Actualiser();



            // événement Supprimer et Editer sur la liste des stagiaires
            materielGrid1.EditerStagiaireEvent += GridMatriel_EditerMatrielEvent;
        }

        private void GridMatriel_EditerMatrielEvent(object sender, EventArgs e)
        {
          Material mat = materielGrid1.Current;
            string tabEditerName = "TabEditer-" + mat.InventoryNumber;

            if (tabMatriel.TabPages.IndexOfKey(tabEditerName) == -1)
            {
                // Création de Tab
                TabPage tabEditerStagiaire = new TabPage();
                tabEditerStagiaire.Text = mat.InventoryNumber + " " ;
                tabEditerStagiaire.Name = tabEditerName;
                tabMatriel.TabPages.Add(tabEditerStagiaire);
                tabMatriel.SelectedTab = tabEditerStagiaire;

                // Insertion du formulaire 
            FormMatriel matForm = new FormMatriel();
                matForm.Name = "MatrielForm";
                matForm.Matriel = mat;
                matForm.Afficher();
                matForm.Afficher();
                this.tabMatriel.TabPages[tabEditerName].Controls.Add(matForm);
              matForm.EnregistrerClick += StagiaireForm_EditerClick;
                matForm.AnnulerClick += StagiaireForm_AnnulerEditerClick;
            }
        }
        ModelContext db = new ModelContext();
        private void StagiaireForm_EditerClick(object sender, EventArgs e)
        {
            FormMatriel formMatriel = (FormMatriel )sender;
            Material mat = formMatriel.Matriel;
            string tabEditerName = "TabEditer-" + mat.InventoryNumber;
            TabPage tabEditer = this.tabMatriel.TabPages[tabEditerName];

            if (new MaterialsBLO(db).Save(mat) >0)
            {
                MessageBox.Show("Le Matriel :" + mat.ToString() + " a été bien enregistrer");
            }
            else
            {
                MessageBox.Show("Le Matriel :" + mat.ToString() + " n'est pas enregistrer car il n'y a pas des modifications");
            }


            // Suppression de la page Editer
            this.tabMatriel.TabPages.Remove(tabEditer);
            this.materielGrid1.Actualiser();
        }
        private void StagiaireForm_AnnulerEditerClick(object sender, EventArgs e)
        {
           FormMatriel formMat = (FormMatriel)sender;
            Material Mater = formMat.Matriel;
            string tabEditerName = "TabEditer-" + Mater.InventoryNumber;
            TabPage tabEditer = this.tabMatriel.TabPages[tabEditerName];
           tabMatriel.TabPages.Remove(tabEditer);
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            // Insertion du formulaire Si la page TabAjouter n'existe pas
            if (tabMatriel.TabPages.IndexOfKey("TabAjouter") == -1)
            {
                // Création de Tab
                TabPage tabAjouterMatriel = new TabPage();
                tabAjouterMatriel.Text = "Ajouter un matriel";
                tabAjouterMatriel.Name = "TabAjouter";
                tabAjouterMatriel.Height = 300000;
                tabMatriel.TabPages.Add(tabAjouterMatriel);
                tabMatriel.Height = 3000000;
                tabMatriel.SelectedTab = tabAjouterMatriel;

                // Insertion du formulaire 
            FormMatriel   MatrielForm = new FormMatriel();
                MatrielForm.Name = "MatrielForm";
                MatrielForm.Height = 2000000;
                this.tabMatriel.TabPages["TabAjouter"].Controls.Add(MatrielForm);
                MatrielForm.EnregistrerClick += MatrielForm_EnregistrerClick;
                MatrielForm.AnnulerClick += MatrielForm_AnnulerAjouterClick;
            }
        }
        private void MatrielForm_EnregistrerClick(object sender, EventArgs e)
        {
            TabPage tabAjouter = this.tabMatriel.TabPages["TabAjouter"];
           FormMatriel form = (FormMatriel)tabAjouter.Controls
                .Find("MatrielForm", false).First();

           if (new MaterialsBLO(db).Save(form.Matriel)>0)
            {
                MessageBox.Show("Le Matriel :" + form.Matriel.ToString() + " a été bien enregistrer");
            }
           else
            {
                MessageBox.Show("Le Matriel  :" + form.Matriel.ToString() + " n'est pas enregistrer");
            }

            this.tabMatriel.TabPages.Remove(tabAjouter);
            this.materielGrid1.Actualiser();
        }
        /// <summary>
        /// Annuler l'insertion d'un stagiaire
        /// </summary>
        private void MatrielForm_AnnulerAjouterClick(object sender, EventArgs e)
        {
            TabPage tabAjouter = this.tabMatriel.TabPages["TabAjouter"];
            tabMatriel.TabPages.Remove(tabAjouter);
        }




    }
}
