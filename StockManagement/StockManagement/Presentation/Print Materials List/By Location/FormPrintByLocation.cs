// Mariam Ait Al 
// 2017

using App.Gwin.Application.Presentation;
using App.Gwin.Components.Manager.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Gwin.Entities;
using StockManagement.Entities;
using StockManagement.DAL;
using System.Drawing.Printing;
using StockManagement.BLL.MaterialsManagement;

namespace StockManagement.Presentations.Print_Materials_List.By_Location
{
    public partial class FormPrintByLocation : BaseForm, IFormSelectedEntityAction
    {
        public FormPrintByLocation()
        {
            InitializeComponent();
        }

        Location Location = null;
        public string PathPDF = "";

        public void SetEntity(BaseEntity obj)
        {
            Location = obj as Location;
        }
        //
        ModelContext db = new ModelContext();
        private void FormPrintByLocation_Load(object sender, EventArgs e)
        {
            PrintMaterialsListByLocation printMaterialsList = new PrintMaterialsListByLocation();



            printMaterialsList.Location = Location;

            this.PathPDF = printMaterialsList.CreatePDF();
            // Print Document with Spire Library
            Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
            doc.LoadFromFile(this.PathPDF);

            printPreviewControl1.Document = doc.PrintDocument;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            // Print Document with Spire Library
            Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
            doc.LoadFromFile(this.PathPDF);


            //var ppd = new PrintPreviewDialog();
            //ppd.Document = doc.PrintDocument;
            //ppd.ShowDialog(this); // renders Image1 attached


            //printPreviewDialog1.Document = doc.PrintDocument;

            ///////
            ////Use the default printer to print all the pages 
            //doc.PrintDocument.Print();

            //Set the printer and select the pages you want to print 

            PrintDialog dialogPrint = new PrintDialog();
            dialogPrint.AllowPrintToFile = true;
            dialogPrint.AllowSomePages = true;
            dialogPrint.PrinterSettings.MinimumPage = 1;
            dialogPrint.PrinterSettings.MaximumPage = doc.Pages.Count;
            dialogPrint.PrinterSettings.FromPage = 1;
            dialogPrint.PrinterSettings.ToPage = doc.Pages.Count;

            if (dialogPrint.ShowDialog() == DialogResult.OK)
            {
                //Set the pagenumber which you choose as the start page to print 
                doc.PrintFromPage = dialogPrint.PrinterSettings.FromPage;
                //Set the pagenumber which you choose as the final page to print 
                doc.PrintToPage = dialogPrint.PrinterSettings.ToPage;
                //Set the name of the printer which is to print the PDF 
                doc.PrinterName = dialogPrint.PrinterSettings.PrinterName;

                PrintDocument printDoc = doc.PrintDocument;
                dialogPrint.Document = printDoc;
                printDoc.Print();
            }
        }
    }
}
