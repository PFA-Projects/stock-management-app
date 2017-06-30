// Mariam Ait Al
// 2017

using App.Gwin;
using App.Gwin.Application.Presentation;
using App.Gwin.Application.Presentation.EntityManagement;
using App.Gwin.Components.Manager.DataGrid;
using StockManagement.BAL;
using StockManagement.DAL;
using StockManagement.Entities;
using StockManagement.Entities.Mail_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.Presentation.DepartureFiles
{
    [App.Gwin.Attributes.Menu(EntityType = typeof(DepartureFile),Title = "FichiersDepart",Group ="Fichiers")]
    public partial class FormDepartureFiles : BaseForm
    {
        public FormDepartureFiles()
        {
            InitializeComponent();
        }

        private void FormDepartureFiles_Load(object sender, EventArgs e)
        {
            // filling departurs combobox
            Depart_combo.DataSource = null;
            Depart_combo.DataSource = new DepartureBLO().GetAll();
            //nothing selected
            Depart_combo.SelectedIndex = -1;
            //
            btn_first.Visible = false;
            btn_previous.Visible = false;
            btn_next.Visible = false;
            btn_last.Visible = false;
        }
        // define the user's operation 's choice 
        string Choice = null;
        private void Save_metrordb_CheckedChanged(object sender, EventArgs e)
        {
            // making file download enable in case of the user choice to save a new file
            download_btn.Enabled = false;
            //
            btn_first.Visible = false;
            btn_previous.Visible = false;
            btn_next.Visible = false;
            btn_last.Visible = false;
            //
            Choice = "Save";
        }

        private void show_metrordb_CheckedChanged(object sender, EventArgs e)
        {
            btn_first.Visible = false;
            btn_previous.Visible = false;
            btn_next.Visible = false;
            btn_last.Visible = false;
            // making file download able in case of consulting departurs files 
            File_picbox.Image = null;
            download_btn.Enabled = true;
            Choice = "Show";
        }
        ModelContext db = new ModelContext();
        List<DepartureFile> DepartureFileList = new List<DepartureFile>();
        private void Depart_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            btn_first.Visible = false;
            btn_previous.Visible = false;
            btn_next.Visible = false;
            btn_last.Visible = false;
            // Case of choice  is "Save"
            if (Choice == "Save")
            {
                File_picbox.Image = null;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Image image = Image.FromFile(openFileDialog.FileName);
                    File_picbox.Image = image;

                    DepartureFile depFile = new DepartureFile();
                    Departure departure = (Departure)Depart_combo.SelectedValue;
                    depFile.Departure = new DepartureBLO(db).GetByID(departure.Id);
                    depFile.File = new DepartureFileBLO(db).Convert(File_picbox);
                    new DepartureFileBLO(db).Save(depFile);
                    MessageBox.Show("bien enregisteree");
                }
            }
            if(Choice == "Show")
            {
                Departure Departure = (Departure)Depart_combo.SelectedValue;
                List<DepartureFile> DepartureFiles = new DepartureFileBLO(db).GetDepFilesByDeparture(Departure);
                DepartureFileList = DepartureFiles;
                if (DepartureFiles.Count == 1)
                {
                    byte[] image = DepartureFiles[0].File;
                    new DepartureFileBLO(db).FromByteToImage(image, File_picbox);
                }
                if(DepartureFiles.Count <= 0 )
                {
                    MessageBox.Show("Aucun Fichier a affiché");
                    File_picbox.Image = null;
                }
                if(DepartureFiles.Count > 1)
                {
                    MessageBox.Show("Ce Depart Contient plusieurs Fichiers !");
                    byte[] image = DepartureFiles[0].File;
                    new DepartureFileBLO(db).FromByteToImage(image, File_picbox);
                    btn_first.Visible = true;
                    btn_previous.Visible = true;
                    btn_next.Visible = true;
                    btn_last.Visible = true;
                }
            }

        }

        private void download_btn_Click(object sender, EventArgs e)
        {
            if (File_picbox.Image != null)
            {
                var fd = new SaveFileDialog();
                fd.Filter = "Bmp(*.BMP;)|*.BMP;| Jpg(*Jpg)|*.jpg";
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    switch (Path.GetExtension(fd.FileName))
                    {
                        case ".BMP":
                            File_picbox.Image.Save(fd.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                        case ".Jpg":
                            File_picbox.Image.Save(fd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        int index = 0;
        private void btn_first_Click(object sender, EventArgs e)
        {
            if (DepartureFileList != null)
            {
                byte[] image = DepartureFileList[0].File;
                new DepartureFileBLO(db).FromByteToImage(image, File_picbox);
                index = 0;
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            if (DepartureFileList != null)
            {
                byte[] image = DepartureFileList[(DepartureFileList.Count)-1].File;
                new DepartureFileBLO(db).FromByteToImage(image, File_picbox);
                index = DepartureFileList.Count-1;
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if(index > 0 && index <= DepartureFileList.Count - 1)
            {
                index--;
                byte[] image = DepartureFileList[index].File;
                new DepartureFileBLO(db).FromByteToImage(image, File_picbox);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(index >= 0 && index <DepartureFileList.Count - 1)
            {
                index++;
                byte[] image = DepartureFileList[index].File;
                new DepartureFileBLO(db).FromByteToImage(image, File_picbox);
            }
        }
    }
 }

