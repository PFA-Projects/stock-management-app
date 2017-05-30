namespace StockManagement.Presentations.Print_BRD_Departure
{
    partial class FormPrintBRD
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Print_MetroTile = new MetroFramework.Controls.MetroTile();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Print_MetroTile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.printPreviewControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.26087F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(908, 276);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Print_MetroTile
            // 
            this.Print_MetroTile.ActiveControl = null;
            this.Print_MetroTile.Location = new System.Drawing.Point(3, 3);
            this.Print_MetroTile.Name = "Print_MetroTile";
            this.Print_MetroTile.Size = new System.Drawing.Size(202, 53);
            this.Print_MetroTile.TabIndex = 0;
            this.Print_MetroTile.Text = "Print";
            this.Print_MetroTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Print_MetroTile.UseSelectable = true;
            this.Print_MetroTile.Click += new System.EventHandler(this.Print_MetroTile_Click);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.AutoZoom = false;
            this.printPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printPreviewControl1.Location = new System.Drawing.Point(3, 62);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(902, 211);
            this.printPreviewControl1.TabIndex = 1;
            this.printPreviewControl1.Zoom = 1D;
            // 
            // FormPrintBRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 356);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormPrintBRD";
            this.Text = "Borderau";
            this.Load += new System.EventHandler(this.FormPrintBRD_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTile Print_MetroTile;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
    }
}