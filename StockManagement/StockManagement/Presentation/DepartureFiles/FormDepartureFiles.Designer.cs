namespace StockManagement.Presentation.DepartureFiles
{
    partial class FormDepartureFiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Save_metrordb = new MetroFramework.Controls.MetroRadioButton();
            this.show_metrordb = new MetroFramework.Controls.MetroRadioButton();
            this.Detaills_grpx = new System.Windows.Forms.GroupBox();
            this.download_btn = new MetroFramework.Controls.MetroButton();
            this.File_picbox = new System.Windows.Forms.PictureBox();
            this.File_label = new System.Windows.Forms.Label();
            this.Depart_combo = new MetroFramework.Controls.MetroComboBox();
            this.Depart_label = new MetroFramework.Controls.MetroLabel();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.Detaills_grpx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.File_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Save_metrordb
            // 
            this.Save_metrordb.AutoSize = true;
            this.Save_metrordb.Location = new System.Drawing.Point(57, 190);
            this.Save_metrordb.Name = "Save_metrordb";
            this.Save_metrordb.Size = new System.Drawing.Size(79, 15);
            this.Save_metrordb.TabIndex = 0;
            this.Save_metrordb.Text = "Enregistrer";
            this.Save_metrordb.UseSelectable = true;
            this.Save_metrordb.CheckedChanged += new System.EventHandler(this.Save_metrordb_CheckedChanged);
            // 
            // show_metrordb
            // 
            this.show_metrordb.AutoSize = true;
            this.show_metrordb.Location = new System.Drawing.Point(57, 253);
            this.show_metrordb.Name = "show_metrordb";
            this.show_metrordb.Size = new System.Drawing.Size(74, 15);
            this.show_metrordb.TabIndex = 1;
            this.show_metrordb.Text = "Consulter";
            this.show_metrordb.UseSelectable = true;
            this.show_metrordb.CheckedChanged += new System.EventHandler(this.show_metrordb_CheckedChanged);
            // 
            // Detaills_grpx
            // 
            this.Detaills_grpx.Controls.Add(this.btn_last);
            this.Detaills_grpx.Controls.Add(this.btn_next);
            this.Detaills_grpx.Controls.Add(this.btn_previous);
            this.Detaills_grpx.Controls.Add(this.btn_first);
            this.Detaills_grpx.Controls.Add(this.download_btn);
            this.Detaills_grpx.Controls.Add(this.File_picbox);
            this.Detaills_grpx.Controls.Add(this.File_label);
            this.Detaills_grpx.Controls.Add(this.Depart_combo);
            this.Detaills_grpx.Controls.Add(this.Depart_label);
            this.Detaills_grpx.Location = new System.Drawing.Point(249, 63);
            this.Detaills_grpx.Name = "Detaills_grpx";
            this.Detaills_grpx.Size = new System.Drawing.Size(474, 453);
            this.Detaills_grpx.TabIndex = 2;
            this.Detaills_grpx.TabStop = false;
            this.Detaills_grpx.Text = "Detaills";
            // 
            // download_btn
            // 
            this.download_btn.Location = new System.Drawing.Point(15, 343);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(105, 34);
            this.download_btn.TabIndex = 4;
            this.download_btn.Text = "Charger ";
            this.download_btn.UseSelectable = true;
            this.download_btn.Click += new System.EventHandler(this.download_btn_Click);
            // 
            // File_picbox
            // 
            this.File_picbox.Location = new System.Drawing.Point(126, 98);
            this.File_picbox.Name = "File_picbox";
            this.File_picbox.Size = new System.Drawing.Size(317, 279);
            this.File_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.File_picbox.TabIndex = 3;
            this.File_picbox.TabStop = false;
            // 
            // File_label
            // 
            this.File_label.AutoSize = true;
            this.File_label.Location = new System.Drawing.Point(41, 174);
            this.File_label.Name = "File_label";
            this.File_label.Size = new System.Drawing.Size(44, 13);
            this.File_label.TabIndex = 2;
            this.File_label.Text = "Fichier :";
            // 
            // Depart_combo
            // 
            this.Depart_combo.FormattingEnabled = true;
            this.Depart_combo.ItemHeight = 23;
            this.Depart_combo.Location = new System.Drawing.Point(126, 34);
            this.Depart_combo.Name = "Depart_combo";
            this.Depart_combo.Size = new System.Drawing.Size(317, 29);
            this.Depart_combo.TabIndex = 1;
            this.Depart_combo.UseSelectable = true;
            this.Depart_combo.SelectedValueChanged += new System.EventHandler(this.Depart_combo_SelectedValueChanged);
            // 
            // Depart_label
            // 
            this.Depart_label.AutoSize = true;
            this.Depart_label.Location = new System.Drawing.Point(41, 44);
            this.Depart_label.Name = "Depart_label";
            this.Depart_label.Size = new System.Drawing.Size(60, 19);
            this.Depart_label.TabIndex = 0;
            this.Depart_label.Text = "Depart : ";
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(151, 395);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(63, 23);
            this.btn_first.TabIndex = 5;
            this.btn_first.Text = "<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(220, 395);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(63, 23);
            this.btn_previous.TabIndex = 6;
            this.btn_previous.Text = "<<";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(289, 395);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(63, 23);
            this.btn_next.TabIndex = 7;
            this.btn_next.Text = ">>";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(358, 395);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(63, 23);
            this.btn_last.TabIndex = 8;
            this.btn_last.Text = ">";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // FormDepartureFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 539);
            this.Controls.Add(this.Detaills_grpx);
            this.Controls.Add(this.show_metrordb);
            this.Controls.Add(this.Save_metrordb);
            this.Name = "FormDepartureFiles";
            this.Text = "Fichiers de Departs";
            this.Load += new System.EventHandler(this.FormDepartureFiles_Load);
            this.Detaills_grpx.ResumeLayout(false);
            this.Detaills_grpx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.File_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton Save_metrordb;
        private MetroFramework.Controls.MetroRadioButton show_metrordb;
        private System.Windows.Forms.GroupBox Detaills_grpx;
        private MetroFramework.Controls.MetroComboBox Depart_combo;
        private MetroFramework.Controls.MetroLabel Depart_label;
        private MetroFramework.Controls.MetroButton download_btn;
        private System.Windows.Forms.PictureBox File_picbox;
        private System.Windows.Forms.Label File_label;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_first;
    }
}