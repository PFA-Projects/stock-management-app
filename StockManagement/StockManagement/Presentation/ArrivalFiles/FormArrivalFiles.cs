// Mariam Ait Al
// 2017

using App.Gwin.Application.Presentation;
using StockManagement.BAL;
using StockManagement.DAL;
using StockManagement.Entities;
using StockManagement.Entities.Mail_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.Presentation.ArrivalFiles
{
    [App.Gwin.Attributes.Menu(EntityType = typeof(ArrivalFile), Title = "FichiersArrivee", Group = "Fichiers")]
    public partial class FormArrivalFiles : BaseForm
    {
        public FormArrivalFiles()
        {
            InitializeComponent();
        }

        private void FormArrivalFiles_Load(object sender, EventArgs e)
        {
            Arriv_cmbx.DataSource = null;
            Arriv_cmbx.DataSource = new ArrivalBLO().GetAll();
           // nothing selected
            Arriv_cmbx.SelectedIndex = -1;
            //
            first_btn.Visible = false;
            previous_btn.Visible = false;
            next_btn.Visible = false;
            last_btn.Visible = false;
        }
        // define the user's operation 's choice
        string Choice = null;
        private void Save_mRDB_CheckedChanged(object sender, EventArgs e)
        {
            // nothing selected
            Arriv_cmbx.SelectedIndex = -1;
            // making file download enable in case of the user choice to save a new file
            download_btn.Enabled = false;
            //
            first_btn.Visible = false;
            previous_btn.Visible = false;
            next_btn.Visible = false;
            last_btn.Visible = false;
            //
            Choice = "Save";
        }

        private void show_mrdb_CheckedChanged(object sender, EventArgs e)
        {
            // nothing selected
            Arriv_cmbx.SelectedIndex = -1;
            //
            first_btn.Visible = false;
            previous_btn.Visible = false;
            next_btn.Visible = false;
            last_btn.Visible = false;
            // making file download able in case of consulting departurs files 
            Arrival_picbox.Image = null;
            download_btn.Enabled = true;
            Choice = "Show";
        }

        ModelContext db = new ModelContext();
        List<ArrivalFile> ArrivalFileList = new List<ArrivalFile>();

        private void Arriv_cmbx_SelectedValueChanged(object sender, EventArgs e)
        {
            first_btn.Visible = false;
            previous_btn.Visible = false;
            next_btn.Visible = false;
            last_btn.Visible = false;
            // Case of choice  is "Save"
            if (Choice == "Save")
            {
                Arrival_picbox.Image = null;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Image image = Image.FromFile(openFileDialog.FileName);
                    Arrival_picbox.Image = image;

                    ArrivalFile arrFile = new ArrivalFile();
                    Arrival arrival = (Arrival)Arriv_cmbx.SelectedValue;
                    arrFile.Arrival = new ArrivalBLO(db).GetByID(arrival.Id);
                    arrFile.File = new DepartureFileBLO(db).Convert(Arrival_picbox);
                    new ArrivalFileBLO(db).Save(arrFile);
                    MessageBox.Show("bien enregisteree");
                }
            }
            if (Choice == "Show")
            {
                Arrival arrival = (Arrival)Arriv_cmbx.SelectedValue;
                List<ArrivalFile> ArrivalFiles = new ArrivalFileBLO(db).GetArrivalFilesByArrival(arrival);
                ArrivalFileList = ArrivalFiles;
                if (ArrivalFiles.Count == 1)
                {
                    byte[] image = ArrivalFiles[0].File;
                    new DepartureFileBLO(db).FromByteToImage(image, Arrival_picbox);
                }
                if (ArrivalFiles.Count <= 0)
                {
                    MessageBox.Show("Aucun Fichier a affiché");
                    Arrival_picbox.Image = null;
                }
                if (ArrivalFiles.Count > 1)
                {
                    MessageBox.Show("Ce Depart Contient plusieurs Fichiers !");
                    byte[] image = ArrivalFiles[0].File;
                    new DepartureFileBLO(db).FromByteToImage(image, Arrival_picbox);
                    first_btn.Visible = true;
                    previous_btn.Visible = true;
                    next_btn.Visible = true;
                    last_btn.Visible = true;
                }
            }
        }

        private void download_btn_Click(object sender, EventArgs e)
        {
            if (Arrival_picbox.Image != null)
            {
                var fd = new SaveFileDialog();
                fd.Filter = "Bmp(*.BMP;)|*.BMP;| Jpg(*Jpg)|*.jpg";
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    switch (Path.GetExtension(fd.FileName))
                    {
                        case ".BMP":
                            Arrival_picbox.Image.Save(fd.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                        case ".Jpg":
                            Arrival_picbox.Image.Save(fd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        default:
                            break;
                    }
                }
            }
            

        }
        int index = 0;
        private void first_btn_Click(object sender, EventArgs e)
        {
            if (ArrivalFileList != null)
            {
                byte[] image = ArrivalFileList[0].File;
                new DepartureFileBLO(db).FromByteToImage(image, Arrival_picbox);
                index = 0;
            }
        }

        private void previous_btn_Click(object sender, EventArgs e)
        {
            if (index > 0 && index <= ArrivalFileList.Count - 1)
            {
                index--;
                byte[] image = ArrivalFileList[index].File;
                new DepartureFileBLO(db).FromByteToImage(image, Arrival_picbox);
            }
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index < ArrivalFileList.Count - 1)
            {
                index++;
                byte[] image = ArrivalFileList[index].File;
                new DepartureFileBLO(db).FromByteToImage(image, Arrival_picbox);
            }
        }

        private void last_btn_Click(object sender, EventArgs e)
        {
            if (ArrivalFileList != null)
            {
                byte[] image = ArrivalFileList[(ArrivalFileList.Count) - 1].File;
                new DepartureFileBLO(db).FromByteToImage(image, Arrival_picbox);
                index = ArrivalFileList.Count - 1;
            }
        }
    }
}
