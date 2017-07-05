namespace StockManagement.Presentation.ArrivalFiles
{
    partial class FormArrivalFiles
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
            this.Save_mRDB = new MetroFramework.Controls.MetroRadioButton();
            this.show_mrdb = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.last_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.previous_btn = new System.Windows.Forms.Button();
            this.first_btn = new System.Windows.Forms.Button();
            this.download_btn = new MetroFramework.Controls.MetroButton();
            this.Arrival_picbox = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Arriv_cmbx = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Arrival_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Save_mRDB
            // 
            this.Save_mRDB.AutoSize = true;
            this.Save_mRDB.Location = new System.Drawing.Point(51, 219);
            this.Save_mRDB.Name = "Save_mRDB";
            this.Save_mRDB.Size = new System.Drawing.Size(79, 15);
            this.Save_mRDB.TabIndex = 0;
            this.Save_mRDB.Text = "Enregistrer";
            this.Save_mRDB.UseSelectable = true;
            this.Save_mRDB.CheckedChanged += new System.EventHandler(this.Save_mRDB_CheckedChanged);
            // 
            // show_mrdb
            // 
            this.show_mrdb.AutoSize = true;
            this.show_mrdb.Location = new System.Drawing.Point(51, 271);
            this.show_mrdb.Name = "show_mrdb";
            this.show_mrdb.Size = new System.Drawing.Size(74, 15);
            this.show_mrdb.TabIndex = 1;
            this.show_mrdb.Text = "Consulter";
            this.show_mrdb.UseSelectable = true;
            this.show_mrdb.CheckedChanged += new System.EventHandler(this.show_mrdb_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.last_btn);
            this.groupBox1.Controls.Add(this.next_btn);
            this.groupBox1.Controls.Add(this.previous_btn);
            this.groupBox1.Controls.Add(this.first_btn);
            this.groupBox1.Controls.Add(this.download_btn);
            this.groupBox1.Controls.Add(this.Arrival_picbox);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.Arriv_cmbx);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(179, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 463);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detaills";
            // 
            // last_btn
            // 
            this.last_btn.Location = new System.Drawing.Point(381, 428);
            this.last_btn.Name = "last_btn";
            this.last_btn.Size = new System.Drawing.Size(59, 23);
            this.last_btn.TabIndex = 8;
            this.last_btn.Text = ">";
            this.last_btn.UseVisualStyleBackColor = true;
            this.last_btn.Click += new System.EventHandler(this.last_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(316, 429);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(59, 23);
            this.next_btn.TabIndex = 7;
            this.next_btn.Text = ">>";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // previous_btn
            // 
            this.previous_btn.Location = new System.Drawing.Point(251, 429);
            this.previous_btn.Name = "previous_btn";
            this.previous_btn.Size = new System.Drawing.Size(59, 23);
            this.previous_btn.TabIndex = 6;
            this.previous_btn.Text = "<<";
            this.previous_btn.UseVisualStyleBackColor = true;
            this.previous_btn.Click += new System.EventHandler(this.previous_btn_Click);
            // 
            // first_btn
            // 
            this.first_btn.Location = new System.Drawing.Point(186, 429);
            this.first_btn.Name = "first_btn";
            this.first_btn.Size = new System.Drawing.Size(59, 23);
            this.first_btn.TabIndex = 5;
            this.first_btn.Text = "<";
            this.first_btn.UseVisualStyleBackColor = true;
            this.first_btn.Click += new System.EventHandler(this.first_btn_Click);
            // 
            // download_btn
            // 
            this.download_btn.Location = new System.Drawing.Point(49, 390);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(94, 31);
            this.download_btn.TabIndex = 4;
            this.download_btn.Text = "Charger";
            this.download_btn.UseSelectable = true;
            this.download_btn.Click += new System.EventHandler(this.download_btn_Click);
            // 
            // Arrival_picbox
            // 
            this.Arrival_picbox.Location = new System.Drawing.Point(164, 131);
            this.Arrival_picbox.Name = "Arrival_picbox";
            this.Arrival_picbox.Size = new System.Drawing.Size(293, 291);
            this.Arrival_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Arrival_picbox.TabIndex = 3;
            this.Arrival_picbox.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(49, 131);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Fichier : ";
            // 
            // Arriv_cmbx
            // 
            this.Arriv_cmbx.FormattingEnabled = true;
            this.Arriv_cmbx.ItemHeight = 23;
            this.Arriv_cmbx.Location = new System.Drawing.Point(164, 54);
            this.Arriv_cmbx.Name = "Arriv_cmbx";
            this.Arriv_cmbx.Size = new System.Drawing.Size(293, 29);
            this.Arriv_cmbx.TabIndex = 1;
            this.Arriv_cmbx.UseSelectable = true;
            this.Arriv_cmbx.SelectedValueChanged += new System.EventHandler(this.Arriv_cmbx_SelectedValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(49, 57);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Arrivee : ";
            // 
            // FormArrivalFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.show_mrdb);
            this.Controls.Add(this.Save_mRDB);
            this.Name = "FormArrivalFiles";
            this.Text = "Fichiers d\'arrivee";
            this.Load += new System.EventHandler(this.FormArrivalFiles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Arrival_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton Save_mRDB;
        private MetroFramework.Controls.MetroRadioButton show_mrdb;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox Arriv_cmbx;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox Arrival_picbox;
        private System.Windows.Forms.Button last_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button previous_btn;
        private System.Windows.Forms.Button first_btn;
        private MetroFramework.Controls.MetroButton download_btn;
    }
}