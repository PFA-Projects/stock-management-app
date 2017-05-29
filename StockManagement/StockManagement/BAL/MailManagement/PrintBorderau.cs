//Mariam Ait Al

using iTextSharp.text;
using iTextSharp.text.pdf;
using StockManagement.BLL.PrintManagement;
using StockManagement.DAL;
using StockManagement.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vtts.Presentation.PrintOrderMission;

namespace StockManagement.BAL.MailManagement
{
    /// <summary>
    /// fr : Generer le borderau d'envoi
    /// 
    /// </summary>
    public class PrintBorderau
    {
        //
        public Departure Departure { get; set; }

        // 
        ModelContext db = new ModelContext();

        public string CreatePDF()
        {
            // Create PDF Document with ItextSharp
            //string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).FullName;
            //string path = appRootDir + "/PDFs/" + "OrdreMission.pdf";
            try
            {
                // Step 1: Creating System.IO.FileStream object
                using (FileStream fs = new FileStream("Borderau" + Departure.Id+ ".pdf", FileMode.Create, FileAccess.Write, FileShare.None))
                // Step 2: Creating iTextSharp.text.Document object
                using (Document doc = new Document())
                // Step 3: Creating iTextSharp.text.pdf.PdfWriter object
                // It helps to write the Document to the Specified FileStream
                using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
                {
                    // Step 4: Openning the Document
                    doc.Open();

                    // Step 5: Adding a paragraph
                    // NOTE: When we want to insert text, then we've to do it through creating paragraph
                    //doc.Add(new Paragraph("Hello World :"));

                    PdfFile file = new PdfFile();

                    PrintPage page = new PrintPage();

                    page.BRDHeader(file, doc, writer,Departure);

                    List<String> HeaderText = new List<string>();
                    HeaderText.Add("Designations");
                    HeaderText.Add("NBRE");
                    HeaderText.Add("Observations");

                    PdfPTable table = file.CreateHeaderTable(doc, HeaderText);
                    // Designations
                    PdfPCell DesignationsCell = new PdfPCell(new Phrase(Departure.Designation.French));
                    DesignationsCell.MinimumHeight = 50f;
                    table.AddCell(DesignationsCell);
                    //NBRE
                    PdfPCell NBRECell = new PdfPCell(new Phrase(Departure.NBRE.ToString()));
                    NBRECell.MinimumHeight = 32f;
                    table.AddCell(NBRECell);
                    //Observations
                    PdfPCell ObsCell = new PdfPCell(new Phrase(Departure.Observations.French));
                    ObsCell.MinimumHeight = 32f;
                    table.AddCell(ObsCell);


                    PdfContentByte cb = writer.DirectContent;
                    table.TotalWidth = 500f;
                    table.WriteSelectedRows(0, -1, 50, doc.PageSize.Width / 2 +80, cb);

                    page.BRDFooter(file, doc, writer);

                    // Step 6: Closing the Document
                    doc.Close();
                }

            }
            // Catching iTextSharp.text.DocumentException if any
            catch (DocumentException de)
            {
                throw de;
            }
            // Catching System.IO.IOException if any
            catch (IOException ioe)
            {
                throw ioe;
            }

            return "Borderau" + Departure.Id + ".pdf";
        }
    }
}
