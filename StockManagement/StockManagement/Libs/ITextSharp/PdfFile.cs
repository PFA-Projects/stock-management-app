//Mariam Ait Al
//2017

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtts.Presentation.PrintOrderMission
{
    /// <summary>
    /// Itextsharp functions
    /// </summary>
    /// 
    public class PdfFile
    {
        /// <summary>
        /// Create Document before openning the pdf file
        /// </summary>
        /// <returns></returns>
        public Document CreateDocument()
        {
            Document doc = new Document(PageSize.LETTER, 10, 10, 42, 35);
            return doc;
        }
        /// <summary>
        ///  Open PDF File
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="doc"></param>
        public PdfWriter OpenPDFFile(string FileName,Document doc)
        {
            string Directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Directory +@"\"+FileName+@".pdf", FileMode.Create));
            doc.Open();
            return writer;
        }

        /// <summary>
        /// Close PDF File
        /// </summary>
        /// <param name="doc"></param>
        public void ClosePDFFile(Document doc)
        {
            if (doc != null)
                doc.Close();
        }

        /// <summary>
        /// Convert and Insert Image at specified Positions
        /// </summary>
        /// <param name="doc">PDF Document</param>
        /// <param name="fitwidth">width</param>
        /// <param name="fitheight">Height</param>
        /// <param name="Percent">Image Percent</param>
        /// <param name="absoluteX">X : Position</param>
        /// <param name="absoluteY">Y : Position</param>
        /// <param name="ImageFile">Image ressource</param>
        /// <param name="imageFormatToConvert">Format to convert</param>
        public void AddImage(Document doc,float fitwidth , float fitheight,float Percent,float absoluteX , float absoluteY,System.Drawing.Image ImageFile, ImageFormat imageFormatToConvert)
        {
            ////  iTextSharp.text.Image image =  iTextSharp.text.Image.GetInstance(ImageInstance);
            ////var ms = new MemoryStream();
            ////ms.Position = 0;
            ////ResourceImage.Header.Save(ms, ImageFormat.Bmp);(HeaderImage.Header, ImageFormat.Bmp);
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(ImageFile, imageFormatToConvert);
            
            image.ScaleToFit(fitwidth, fitheight);
            image.ScalePercent(Percent);
            image.SetAbsolutePosition(absoluteX, absoluteY);
            doc.Add(image);
        }

        /// <summary>
        /// Insert Image at specified Position (X , Y)
        /// </summary>
        /// <param name="doc">Pdf Document</param>
        /// <param name="fitwidth">Width</param>
        /// <param name="fitheight">Height</param>
        /// <param name="Percent">Image Percent</param>
        /// <param name="absoluteX">X : Position</param>
        /// <param name="absoluteY">Y : Position</param>
        /// <param name="InstanceImage">Image Directory</param>
        public void InsertImage(Document doc, float fitwidth, float fitheight, float Percent, float absoluteX, float absoluteY, string InstanceImage)
        {
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(InstanceImage);
            image.ScaleToFit(fitwidth, fitheight);
            image.ScalePercent(Percent);
            image.SetAbsolutePosition(absoluteX, absoluteY);
            doc.Add(image);
        }

        /// <summary>
        /// Convert Image Format
        /// </summary>
        /// <param name="image"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static Stream ToStream(System.Drawing.Image image, ImageFormat format)
        {
            var stream = new System.IO.MemoryStream();
            image.Save(stream, format);
            stream.Position = 0;
            return stream;
        }




        /// <summary>
        /// Get Directory Pdf File
        /// </summary>
        /// <param name="doc">Document Name</param>
        /// <param name="FileName">Pdf File Name</param>
        /// <returns>PDF File Directory</returns>
        public string GetPDfFile(Document doc, string FileName)
        {
            string Directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            return Directory + @"\" + FileName + @".pdf";
        }

        /// <summary>
        /// Create paragraph
        /// </summary>
        /// <param name="doc">Pdf Document</param>
        /// <param name="ParagraphMessag">Paragraph or text To write</param>
        /// <param name="Underlining"></param>
        /// <param name="TextCenter"></param>
        /// <param name="TextRight"></param>
        public void CreateParagraph(Document doc, string ParagraphMessag, bool Underlining, bool TextCenter , bool TextRight)
        {
            var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
            Chunk chSoulignement = new Chunk(ParagraphMessag, boldFont);
            if (Underlining != false)
            {
                chSoulignement.SetUnderline(1f, -2f);
            }

            Paragraph Paragraph = new Paragraph(chSoulignement);

            if (TextCenter == true)
            {
                Paragraph.Alignment = 1;
            }
            if(TextRight == true)
            {
                Paragraph.Alignment = 2;
            }
            
            doc.Add(Paragraph);
        }

        
        /// <summary>
        /// Create Text with position
        /// </summary>
        /// <param name="doc">Pdf Document</param>
        /// <param name="writer">PDfWriter</param>
        /// <param name="Text">Text To write</param>
        /// <param name="XSetTextMatrix">X : Position</param>
        /// <param name="YSetTextMatrix">Y : Position</param>
        /// <param name="TextBold">Font : Bold</param>
        /// <param name="TextItalique">Font : Italique</param>
        public void CreateText(Document doc, PdfWriter writer, string Text ,float XSetTextMatrix, float YSetTextMatrix , bool TextBold , bool TextItalique )
        {
            PdfContentByte cb = writer.DirectContent;
            ColumnText ct = new ColumnText(cb);
            cb.BeginText();
            cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 12.0f);
            if (TextBold == true)
            {
                cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 12.0f);
            }

            if (TextItalique == true)
            {
                cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.TIMES_ITALIC, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 12.0f);
            }


            cb.SetTextMatrix(XSetTextMatrix, YSetTextMatrix);

            //cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Text, XSetTextMatrix, YSetTextMatrix,0);

            cb.ShowText(Text);
            cb.EndText();
        }

        

        /// <summary>
        /// Export data from datagridview to the table of pdf file
        /// </summary>
        /// <param name="doc">Document Name</param>
        /// <param name="DGV">DataGridview</param>
        public void ExportDataGridviewToPDFTable(Document doc ,DataGridView DGV,PdfWriter writer)
        {
            // PdfContentByte cb = writer.DirectContent;
            
            //
            PdfPTable table = new PdfPTable(DGV.Columns.Count);
            table.TotalWidth = 300;
            // add the headers from the dgv to the table
            for (int i = 0; i < DGV.Columns.Count; i++)
            {
                table.AddCell(new Phrase(DGV.Columns[i].HeaderText));
            }
            // flag the first row as a header
            table.HeaderRows = 1;

            // add the actual rows from the dgv to the table
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                for (int j = 0; j < DGV.Columns.Count; j++)
                {
                    if (DGV[j, i].Value != null)
                    {
                        table.AddCell(new Phrase(DGV[j, i].Value.ToString()));
                    }
                }
            }
            //table.WriteSelectedRows(0, -1, 600, 50, cb);
           // table.WriteSelectedRows(0, -1, doc.PageSize.Width / 2, doc.PageSize.Height / 2, cb);
     
            doc.Add(table);
        }


        /// <summary>
        /// Create Table Header in PDF
        /// </summary>
        /// <param name="doc">Pdf Document Name</param>
        /// <param name="HeaderColumnsText">Table s Header s text</param>
        /// <returns>table , helps to define the columns s number</returns>
        public PdfPTable CreateHeaderTable(Document doc , List<String> HeaderColumnsText)
        {
            PdfPTable table = new PdfPTable(HeaderColumnsText.Count);
            foreach (var item in HeaderColumnsText)
            {
                PdfPCell cell = new PdfPCell(new Phrase(item));
                cell.BackgroundColor = BaseColor.GRAY;
                table.AddCell(cell);
            }
            return table;
        }



        /// <summary>
        /// After Creating Header and defining the Table s Cell 
        /// we should add the table to the pdf file !
        /// </summary>
        /// <param name="doc">Document s name </param>
        /// <param name="table">Table s Name</param>
        public void AddTableToDocument(Document doc , PdfPTable table)
        {
            doc.Add(table);
        }

      
        /// <summary>
        /// Add Cells into Tabele with specified Positions
        /// </summary>
        /// <param name="writer">PdfWriter</param>
        /// <param name="TextCells">Text to  write into table cells</param>
        /// <param name="XPos">X : Position</param>
        /// <param name="YPos">Y : Position</param>
        public PdfPTable AddTableCells(PdfWriter writer,List<Object> TextCells,float XPos , float YPos)
        {
            PdfPTable table = new PdfPTable(TextCells.Count);
            PdfContentByte cb = writer.DirectContent;
            table.TotalWidth = 500f;
            
            //if (table.NumberOfColumns == TextCells.Count)
            //{
            for (int i = 0; i < TextCells.Count; i++)
            {

                table.AddCell(TextCells[i].ToString());
                
            }
            
            // }

            table.WriteSelectedRows(0, -1, XPos, YPos, cb);

            return table;
        }

        
        
      
    }
}
