using StockManagement.BLL;
using StockManagement.DAL;
using StockManagement.Entities;
using System;
using System.Windows.Forms;

namespace GestionMagasin.GestionMatriel
{
    public partial class MaterielGrid : UserControl
    {
        public MaterielGrid()
        {
            InitializeComponent();
        }


        //événements
        public event EventHandler EditerStagiaireEvent;

        /// <summary>
        /// Obient le stagiaire séléctionner
        /// </summary>
        public  Material Current
        {
            get
            {
                return (Material)matrielBindingSource.Current;
            }
        }

        //
        ModelContext db = new ModelContext();
        public void Actualiser()
        {
            matrielBindingSource.Clear();
            matrielBindingSource.DataSource = new MaterialsBLO(db).GetAll();

        }
        private void MaterielGrid_Load(object sender, EventArgs e)
        {

        }


        private void dataGridViewStagiaires_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void matrielDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Supprimer
            if (e.ColumnIndex == matrielDataGridView.Columns["Supprimer"].Index && e.RowIndex >= 0)
            {

                if (DialogResult.Yes == MessageBox.Show(
                    "Voullez-vous vraimment supprimer ce stagiaire",
                    "Confirmation de supprision", MessageBoxButtons.YesNo))
                {
                    Material s = (Material)matrielBindingSource.Current;
                    new MaterialsBLO(db).Delete(s.Id);
                    //      new StagiairesService().Supprimer(s.Id);
                    this.Actualiser();
                }

            }
            // Editer
            if (e.ColumnIndex == matrielDataGridView.Columns["Modifier"].Index && e.RowIndex >= 0)
            {

                EditerStagiaireEvent(sender, e);

            }
        }

       
    }
}
