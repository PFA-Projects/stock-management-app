// Mariam Ait Al
// 2017

using iTextSharp.text;
using iTextSharp.text.pdf;
using StockManagement.BAL;
using StockManagement.DAL;
using StockManagement.Entities;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using vtts.Presentation.PrintOrderMission;

namespace StockManagement.BLL.MaterialsManagement
{
    /// <summary>
    ///  en : Create Materials List By Location
    ///  fr : Generer List Materiels par emplacement dans un fichier PDF
    /// </summary>
    public class PrintMaterialsListByLocation
    {
        public Location Location { get; set; }


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
                using (FileStream fs = new FileStream("MaterialsList_"+Location.Name+".pdf", FileMode.Create, FileAccess.Write, FileShare.None))
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
                    // Document Header
                    file.CreateParagraph(doc, "Royaume du Maroc\nMinistère de la sante\nDélégation Tanger-assilah\nHôpital Mohammed VI", false, false, false);
                    file.AddImage(doc, 50f, 100f, 10f, doc.PageSize.Width / 2 - 15, doc.PageSize.Height / 2 + 320, Resources.MarocHeaderresx.Maroc, ImageFormat.Bmp);
                    file.AddImage(doc, 50f, 100f, 22f, doc.PageSize.Width - 36f - 72f, doc.PageSize.Height / 2 + 320, Resources.SanteHeader.Sante, ImageFormat.Bmp);
                    //

                    file.CreateText(doc, writer, "Inventaire de Materiels de Service : " + Location.Name.French, doc.PageSize.Width / 2 - 85, doc.PageSize.Height / 2 + 250, false, true);


                    List<String> HeaderText = new List<string>();
                    HeaderText.Add("Designation");
                    HeaderText.Add("N/INV");
                    HeaderText.Add("Dimension");
                    HeaderText.Add("Observation");
                    HeaderText.Add("NBRE");
                    PdfPTable table = file.CreateHeaderTable(doc, HeaderText);

                   // List<Material> MaterialsList = new  MaterialBLO(db).GetMaterialsBylocation(Location);

                    //foreach (var item in MaterialsList)
                    //{

                    //    // Designation
                    //    PdfPCell DesignationCell = new PdfPCell(new Phrase(item.Designation.French));
                    //    DesignationCell.MinimumHeight = 32f;
                    //    table.AddCell(DesignationCell);

                    //    // Inventory Number
                    //    PdfPCell InventoryNumberCell = new PdfPCell(new Phrase(item.InventoryNumber));
                    //    InventoryNumberCell.MinimumHeight = 32f;
                    //    table.AddCell(InventoryNumberCell);

                    //    // Dimension
                    //    PdfPCell DimensionCell = new PdfPCell(new Phrase(item.Dimension.ToString()));
                    //    DimensionCell.MinimumHeight = 32f;
                    //    table.AddCell(DimensionCell);

                    //    // Observation
                    //    PdfPCell ObservationCell = new PdfPCell(new Phrase(item.Observation.French));
                    //    ObservationCell.MinimumHeight = 32f;
                    //    table.AddCell(ObservationCell);

                    //    //NBRE
                    //    PdfPCell NBRECell = new PdfPCell(new Phrase(item.NBRE.ToString()));
                    //    NBRECell.MinimumHeight = 32f;
                    //    table.AddCell(NBRECell);
                    //}


                    PdfContentByte cb = writer.DirectContent;
                    table.TotalWidth = 500f;
                    table.WriteSelectedRows(0, -1, 50, 665, cb);

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

            return "MaterialsList_" + Location.Name + ".pdf";
        }
    }
}
