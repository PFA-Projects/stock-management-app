using App.Gwin;
using App.Gwin.Entities.Secrurity.Authentication;
using GenericWinForm.Demo;
using iTextSharp.text;
using StockManagement.BAL;
using StockManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
// Mariam Ait AL

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.Presentations.Print_PDF_using_itextsharp
{
    [App.Gwin.Attributes.Menu(EntityType = typeof(Entities.Material), Order = 10, Title = "Print Inventories PDf File")]
    public partial class PrintPDF : Form
    {
        public PrintPDF()
        {
            InitializeComponent();
        }

        private void PrintPDF_Load(object sender, EventArgs e)
        {
            //
            User user = null;
            //user = User.CreateGuestUser(new ModelContext());

             user = User.CreateAdminUser(new ModelContext());
            ///user = User.CreateRootUser(new ModelContext());
            user.Language = GwinApp.Languages.fr;


            // Start Gwin Application with Authentification
            FormMenuApplication form = new FormMenuApplication();
            GwinApp.Start(typeof(ModelContext), typeof(BaseBLO<>), form, user);

            //
            //Print Inventories PDf File 
            // Create Header File
            PdfFile InventoriesPDFFile = new PdfFile();
            Document doc = InventoriesPDFFile.CreateDocument();
            InventoriesPDFFile.OpenPDFFile("Inventaire de materiels", doc);
            InventoriesPDFFile.CreateParagraph(doc, "Royaume du Maroc\nMinistère de la sante\nDélégation Tanger-assilah\nHôpital Mohammed VI", false, false, false);
            InventoriesPDFFile.AddImage(doc, @"C:\Users\DELL\Desktop\stock-management-app\Images\Maroc.jpg", 50f, 100f, 10f, doc.PageSize.Width / 2, 700f);
            InventoriesPDFFile.AddImage(doc, @"C:\Users\DELL\Desktop\stock-management-app\Images\Sante.png", 50f, 100f, 26f, doc.PageSize.Width - 36f - 72f, 675f);
            InventoriesPDFFile.ClosePDFFile(doc);

        }
    }
}
