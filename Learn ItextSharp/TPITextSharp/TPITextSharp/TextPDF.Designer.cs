namespace TPITextSharp
{
    partial class TextPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextPDF));
            this.msgpdf_btn = new System.Windows.Forms.Button();
            this.GroupsDataGridView = new System.Windows.Forms.DataGridView();
            this.data_btn = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.readpdf_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // msgpdf_btn
            // 
            this.msgpdf_btn.Location = new System.Drawing.Point(12, 27);
            this.msgpdf_btn.Name = "msgpdf_btn";
            this.msgpdf_btn.Size = new System.Drawing.Size(269, 23);
            this.msgpdf_btn.TabIndex = 0;
            this.msgpdf_btn.Text = "Create Messag Pdf File";
            this.msgpdf_btn.UseVisualStyleBackColor = true;
            this.msgpdf_btn.Click += new System.EventHandler(this.msgpdf_btn_Click);
            // 
            // GroupsDataGridView
            // 
            this.GroupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupsDataGridView.Location = new System.Drawing.Point(1, 192);
            this.GroupsDataGridView.Name = "GroupsDataGridView";
            this.GroupsDataGridView.Size = new System.Drawing.Size(292, 203);
            this.GroupsDataGridView.TabIndex = 1;
            // 
            // data_btn
            // 
            this.data_btn.Location = new System.Drawing.Point(12, 163);
            this.data_btn.Name = "data_btn";
            this.data_btn.Size = new System.Drawing.Size(269, 23);
            this.data_btn.TabIndex = 2;
            this.data_btn.Text = "Get Data To PDF";
            this.data_btn.UseVisualStyleBackColor = true;
            this.data_btn.Click += new System.EventHandler(this.data_btn_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(383, 62);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(192, 333);
            this.axAcroPDF1.TabIndex = 3;
            // 
            // readpdf_btn
            // 
            this.readpdf_btn.Location = new System.Drawing.Point(413, 27);
            this.readpdf_btn.Name = "readpdf_btn";
            this.readpdf_btn.Size = new System.Drawing.Size(140, 23);
            this.readpdf_btn.TabIndex = 4;
            this.readpdf_btn.Text = "Read Pdf File";
            this.readpdf_btn.UseVisualStyleBackColor = true;
            this.readpdf_btn.Click += new System.EventHandler(this.readpdf_btn_Click);
            // 
            // TextPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 396);
            this.Controls.Add(this.readpdf_btn);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.data_btn);
            this.Controls.Add(this.GroupsDataGridView);
            this.Controls.Add(this.msgpdf_btn);
            this.Name = "TextPDF";
            this.Text = "TextPDF";
            this.Load += new System.EventHandler(this.TextPDF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button msgpdf_btn;
        private System.Windows.Forms.DataGridView GroupsDataGridView;
        private System.Windows.Forms.Button data_btn;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button readpdf_btn;
    }
}