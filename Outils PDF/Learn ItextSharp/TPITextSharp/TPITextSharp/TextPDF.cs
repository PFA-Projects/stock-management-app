// Mariam Ait Al
// 2017

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using TPITextSharp.Data.DAL;
using TPITextSharp.Data.BLL;
using App.Gwin.Entities.Secrurity.Authentication;
using App.Gwin;
using StockManagement.BAL;
using GenericWinForm.Demo;

namespace TPITextSharp
{
    public partial class TextPDF : Form
    {
        public TextPDF()
        {
            InitializeComponent();
        }
        /// <summary>
        /// using itextsharp :
        /// 1 - Create Message
        /// 2 - Create Lists
        /// 3 - Working with images
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msgpdf_btn_Click(object sender, EventArgs e)
        {
            // 1
            Document doc = new Document(PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("MessagTest.pdf", FileMode.Create));
            doc.Open();
            Paragraph paragraph = new Paragraph("Testing Itextsharp !!");
            doc.Add(paragraph);
            // 2
            List list = new List(List.UNORDERED);
            list.Add(new ListItem("One"));
            list.Add("Two");
            list.Add("Three");
            list.Add("four");
            doc.Add(list);
            // 3
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(@"C:\Users\DELL\Desktop\stock-management-app\Learn ItextSharp\Lighthouse.jpg");
            //image.ScalePercent(20f);
            //image.SetAbsolutePosition(doc.PageSize.Width - 36f - 72f, doc.PageSize.Height - 36f - 216.6f);
            image.ScaleToFit(50f, 100f);
            image.Border = iTextSharp.text.Rectangle.BOX;
            image.BorderColor = iTextSharp.text.BaseColor.YELLOW;
            image.BorderWidth = 5f;
            doc.Add(image);
            

            doc.Close();
        }

        /// <summary>
        /// Get Data From DataGridview to pdf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void data_btn_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("TableTest.pdf", FileMode.Create));
            doc.Open();

            
            PdfPTable table = new PdfPTable(GroupsDataGridView.Columns.Count);
            // add the headers from the dgv to the table
            for (int i = 0; i < GroupsDataGridView.Columns.Count; i++)
            {
                table.AddCell(new Phrase(GroupsDataGridView.Columns[i].HeaderText));
            }
            // flag the first row as a header
            table.HeaderRows = 1;

            // add the actual rows from the dgv to the table
            for (int i = 0; i < GroupsDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < GroupsDataGridView.Columns.Count; j++)
                {
                    if(GroupsDataGridView[j,i].Value != null)
                    {
                        table.AddCell(new Phrase(GroupsDataGridView[j, i].Value.ToString()));
                    }
                }
            }

            doc.Add(table);
            doc.Close();
        }

        // 
        ModelContext db = new ModelContext();
        private void TextPDF_Load(object sender, EventArgs e)
        {
            User user = null;
            //user = User.CreateGuestUser(new ModelContext());

            user = User.CreateAdminUser(new ModelContext());

            // user = User.CreateRootUser(new ModelContext());
            // Start Gwin Application with Authentification
            FormMenuApplication form = new FormMenuApplication();
            GwinApp.Start(typeof(ModelContext), typeof(BaseBLO<>), form, user);

            //
            GroupsDataGridView.DataSource = null;
            GroupsDataGridView.DataSource = new GroupBLO(db).GetAll();
            //
            GroupsDataGridView.Columns.Remove("Id");
            GroupsDataGridView.Columns.Remove("Ordre");
            GroupsDataGridView.Columns.Remove("DateCreation");
            GroupsDataGridView.Columns.Remove("DateModification");
            GroupsDataGridView.Columns.Remove("Reference");
        }

        /// <summary>
        /// get pdf file to the form using reader pdf itextsharp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_readpdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.src = file.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Directory.GetCurrentDirectory());
        }
    }
}
