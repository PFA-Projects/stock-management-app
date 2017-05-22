using App.Gwin.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement
{
    //[Menu(EntityType = typeof(Entities.Material), Order = 10, Title = "AjouterGroupe")]
  //  [Menu(Group ="Societe")]
    public partial class FormAjouterGroupe : Form
    {
        public FormAjouterGroupe()
        {
            InitializeComponent();
        }
    DAL.ModelContext db = new DAL.ModelContext();
        private void FormAjouterGroupe_Load(object sender, EventArgs e)
        {
         //  List<Entities.MaterialCategory> Lm =   db.MaterialCategories.ToList<Entities.MaterialCategory>();
            comboBoxcategorie.DataSource = db.MaterialCategories.ToList<Entities.MaterialCategory>(); ;
        }
    }
}
