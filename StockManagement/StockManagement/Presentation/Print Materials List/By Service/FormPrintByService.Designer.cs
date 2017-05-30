namespace StockManagement.Presentations.Print_Materials_List_By_Service
{
    partial class FormPrintByService
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
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.print_btn = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.printPreviewControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.print_btn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.52988F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.47012F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(959, 251);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.AutoZoom = false;
            this.printPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printPreviewControl1.Location = new System.Drawing.Point(3, 47);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(953, 201);
            this.printPreviewControl1.TabIndex = 0;
            this.printPreviewControl1.Zoom = 1D;
            // 
            // print_btn
            // 
            this.print_btn.ActiveControl = null;
            this.print_btn.Location = new System.Drawing.Point(3, 3);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(154, 38);
            this.print_btn.TabIndex = 1;
            this.print_btn.Text = "Print";
            this.print_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.print_btn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.print_btn.UseSelectable = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // FormPrintByService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 331);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormPrintByService";
            this.Text = "Print Materials by Service";
            this.Load += new System.EventHandler(this.FormPrintByService_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private MetroFramework.Controls.MetroTile print_btn;
    }
}