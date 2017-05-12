//Mariam Ait Al
//2017

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.Presentations.Print_PDF_using_itextsharp
{
    /// <summary>
    /// Itextsharp functions
    /// </summary>
    /// 
    public class PdfFile
    {
        /// <summary>
        ///  Open PDF File
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="doc"></param>
        public PdfWriter OpenPDFFile(string FileName,Document doc)
        {
            doc = new Document(PageSize.LETTER, 10, 10, 42, 35);
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
        /// Insert image to the pdf file
        /// </summary>
        /// <param name="doc"> Document Name</param>
        /// <param name="ImageInstance">Image Instance</param>
        /// <param name="fitwidth"> the width to fit</param>
        /// <param name="fitheight">the height to ft</param>
        /// <param name="Percent">the scaling percentage</param>
        /// <param name="absoluteX">the absolute position to the image : X</param>
        /// <param name="absoluteY">the absolute position to the image : Y</param>
        public void AddImage(Document doc,string ImageInstance,float fitwidth , float fitheight,float Percent,float absoluteX , float absoluteY)
        {
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(ImageInstance);
            image.ScaleToFit(fitwidth, fitheight);
            image.ScalePercent(Percent);
            image.SetAbsolutePosition(absoluteX, absoluteY);
            doc.Add(image);
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
        /// Create Paragraph
        /// </summary>
        /// <param name="doc">Document Name</param>
        /// <param name="ParagraphMessag">Paragraph s Text</param>
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
        /// Create Text with setting position X, Y
        /// </summary>
        /// <param name="doc">Document PDF Name</param>
        /// <param name="writer">PDFWriter from OpenPDFfile function</param>
        /// <param name="Text">Text To set in the PDf</param>
        /// <param name="XSetTextMatrix">Position X (width)</param>
        /// <param name="YSetTextMatrix">Position Y (Height)</param>
        public void CreateText(Document doc, PdfWriter writer, string Text ,float XSetTextMatrix, float YSetTextMatrix)
        {
            PdfContentByte cb = writer.DirectContent;
            ColumnText ct = new ColumnText(cb);
            cb.BeginText();
            cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 12.0f);
            cb.SetTextMatrix(XSetTextMatrix, YSetTextMatrix);
            cb.ShowText(Text);
            cb.EndText();
        }



        /// <summary>
        /// Export data from datagridview to the table of pdf file
        /// </summary>
        /// <param name="doc">Document Name</param>
        /// <param name="DGV">DataGridview</param>
        public void ExportDataGridviewToPDFTable(Document doc ,DataGridView DGV)
        {
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
        /// Add cell in existing table
        /// </summary>
        /// <param name="doc">Document s name</param>
        /// <param name="Table">Pdf Table</param>
        /// <param name="TextCells">Text to add to the table</param>
        public void AddCellTable(Document doc , PdfPTable Table ,List<String> TextCells)
        {
            if(Table.NumberOfColumns == TextCells.Count)
            {
                for (int i = 0; i < TextCells.Count; i++)
                {
                    Table.AddCell(TextCells[i]);
                }
            }
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


      
    }
}
