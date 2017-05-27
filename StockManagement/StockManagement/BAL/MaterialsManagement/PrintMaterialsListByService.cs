// Mariam Ait Al
using iTextSharp.text;
using iTextSharp.text.pdf;
using StockManagement.BAL;
using StockManagement.BLL.PrintManagement;
using StockManagement.DAL;
using StockManagement.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using vtts.Presentation.PrintOrderMission;

namespace StockManagement.BLL.MaterialsManagement
{
    /// <summary>
    /// en : Create Materials List PDF By Service
    /// fr : generer List Materiels Par service dans un fichier PDF
    /// </summary>
    public class PrintMaterialsListByService:PrintPage
    {
        public Service service { get; set; }

        


        ModelContext db = new ModelContext();
        public string CreatePDF()
        {
            // Create PDF Document with ItextSharp
            //string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).FullName;
            //string path = appRootDir + "/PDFs/" + "OrdreMission.pdf";
            try
            {
                // Step 1: Creating System.IO.FileStream object
                using (FileStream fs = new FileStream("MaterialsList_"+service.Name+".pdf", FileMode.Create, FileAccess.Write, FileShare.None))
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

                    PrintPage page = new PrintPage();
                    page.CreateHeader(file, doc, writer,service);
                    //
                    List<String> HeaderText = new List<string>();
                    HeaderText.Add("Designation");
                    HeaderText.Add("N/INV");
                    HeaderText.Add("Dimension");
                    HeaderText.Add("Observation");
                    HeaderText.Add("NBRE");
                    PdfPTable table = file.CreateHeaderTable(doc, HeaderText);



                    //List<Material> MaterialsList = new MaterialBLO(db).GetMaterialsByService(service);

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
                    ///////////////////////////////////////////////

                    foreach (var item in db.Materials)
                    {
                        List<MaterialInOut> InOutMaterial = new MaterialInOutBLO(db).GetMIOByMaterial(item);
                        if(InOutMaterial.Count > 0)
                        {
                            MaterialInOut MIO = InOutMaterial[InOutMaterial.Count - 1];
                            if (MIO.Service.Id ==Convert.ToInt32( service.Id))
                            {
                                // Designation
                                PdfPCell DesignationCell = new PdfPCell(new Phrase(MIO.Material.Designation.French));
                                DesignationCell.MinimumHeight = 32f;
                                table.AddCell(DesignationCell);

                                // Inventory Number
                                PdfPCell InventoryNumberCell = new PdfPCell(new Phrase(MIO.Material.InventoryNumber));
                                InventoryNumberCell.MinimumHeight = 32f;
                                table.AddCell(InventoryNumberCell);

                                // Dimension
                                PdfPCell DimensionCell = new PdfPCell(new Phrase(MIO.Material.ToString()));
                                DimensionCell.MinimumHeight = 32f;
                                table.AddCell(DimensionCell);

                                // Observation
                                PdfPCell ObservationCell = new PdfPCell(new Phrase(MIO.Material.Observation.French));
                                ObservationCell.MinimumHeight = 32f;
                                table.AddCell(ObservationCell);

                                //NBRE
                                PdfPCell NBRECell = new PdfPCell(new Phrase(MIO.Material.ToString()));
                                NBRECell.MinimumHeight = 32f;
                                table.AddCell(NBRECell);
                            }
                        }
                        
                    }








                    PdfContentByte cb = writer.DirectContent;
                    table.TotalWidth = 500f;
                    table.WriteSelectedRows(0, -1, 50, 665, cb);

                    //
                    page.CreateFooter(file, doc, writer);
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

            return "MaterialsList_" + service.Name + ".pdf";

        }
    }
}
   
