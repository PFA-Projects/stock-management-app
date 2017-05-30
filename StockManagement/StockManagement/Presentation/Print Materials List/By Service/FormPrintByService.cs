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
using StockManagement.BLL.MaterialsManagement;
using StockManagement.BLL;
using System.Drawing.Printing;
using StockManagement.DAL;
using iTextSharp.text;
using App.Gwin.Entities.MultiLanguage;

namespace StockManagement.Presentations.Print_Materials_List_By_Service
{
    public partial class FormPrintByService : BaseForm, IFormSelectedEntityAction
    {
        public FormPrintByService()
        {
            InitializeComponent();
        }

        Service service = null;
        public string PathPDF = "";

        public void SetEntity(BaseEntity obj)
        {
            service = obj as Service;
        }

        private void print_btn_Click(object sender, EventArgs e)
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

        //
        ModelContext db = new ModelContext();
        private void FormPrintByService_Load(object sender, EventArgs e)
        {
            PrintMaterialsListByService printMaterialsList = new PrintMaterialsListByService();



            printMaterialsList.service = service;

            
            this.PathPDF = printMaterialsList.CreatePDF();
            // Print Document with Spire Library
            Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
            doc.LoadFromFile(this.PathPDF);

            printPreviewControl1.Document = doc.PrintDocument;
        }
    }
}
