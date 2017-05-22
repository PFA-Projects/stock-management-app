// Mariam Ait Al
//2017

using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vtts.Presentation.PrintOrderMission;

namespace StockManagement.BLL.PrintManagement
{
    public class PrintPage
    {

        // Header
        public void CreateHeader(PdfFile file, Document doc, PdfWriter writer)
        {
            file.CreateParagraph(doc, "Royaume du Maroc\nMinistère de la sante\nDélégation Tanger-assilah\nHôpital Mohammed VI", false, false, false);
            file.AddImage(doc, 50f, 100f, 10f, doc.PageSize.Width / 2 - 15, doc.PageSize.Height / 2 + 320, Resources.MarocHeaderresx.Maroc, ImageFormat.Bmp);
            file.AddImage(doc, 50f, 100f, 22f, doc.PageSize.Width - 36f - 72f, doc.PageSize.Height / 2 + 320, Resources.SanteHeader.Sante, ImageFormat.Bmp);
            //

            file.CreateText(doc, writer, "Inventaire de Materiels de Service : " + service.Name.French, doc.PageSize.Width / 2 - 85, doc.PageSize.Height / 2 + 250, false, true);
        }
    }
}
