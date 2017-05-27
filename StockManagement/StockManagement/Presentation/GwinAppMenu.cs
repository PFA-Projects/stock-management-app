using App;
using App.Gwin;
using App.Gwin.Application.Presentation.MainForm;
using App.Gwin.Entities.Secrurity.Authentication;
using StockManagement.BAL;
using StockManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamplesGwin.Presentation
{
    public partial class GwinAppMenu : FormApplication
    {
        public GwinAppMenu()
        {
            InitializeComponent();
        }

        private void GwinAppMenu_Load(object sender, EventArgs e)
        {
            User user = null;

            // Create User : Admin user
            user = User.CreateAdminUser(new ModelContext());

            // Create User : Root user
            user = User.CreateRootUser(new ModelContext());

            // 
            // Create Guest User : he can authenticate with login and password
            //
            // user = User.CreateGuestUser(new ModelContext());
            // login : admin
            // password : admin

            // Create GwinApp Instance
            GwinApp.Start(typeof(ModelContext), typeof(BaseBLO<>), this, user);
        }

        /// <summary>
        /// Used to Init Interface after language Change
        /// </summary>
        public override void Reload()
        {
            base.Reload();
            InitializeComponent();
        }
    }
}
