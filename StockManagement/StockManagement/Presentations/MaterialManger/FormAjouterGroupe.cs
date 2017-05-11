using App.Gwin.Attributes;
using StockManagement.Entities;
using StockManagement.Entities.Resources.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement
{
  [App.Gwin.Attributes.Menu(EntityType = typeof(Material), Order = 10, Title = "AjouterGroupe")]
    //[Menu(Group ="Societe")]
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
