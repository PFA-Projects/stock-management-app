namespace StockManagement
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.societeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialsCategoryManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.societeToolStripMenuItem,
            this.materialsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(975, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // societeToolStripMenuItem
            // 
            this.societeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviceManagementToolStripMenuItem,
            this.locationManagementToolStripMenuItem,
            this.personnesManagementToolStripMenuItem});
            this.societeToolStripMenuItem.Name = "societeToolStripMenuItem";
            this.societeToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.societeToolStripMenuItem.Text = "Societe";
            // 
            // serviceManagementToolStripMenuItem
            // 
            this.serviceManagementToolStripMenuItem.Name = "serviceManagementToolStripMenuItem";
            this.serviceManagementToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.serviceManagementToolStripMenuItem.Text = "Service Management";
            this.serviceManagementToolStripMenuItem.Click += new System.EventHandler(this.serviceManagementToolStripMenuItem_Click);
            // 
            // locationManagementToolStripMenuItem
            // 
            this.locationManagementToolStripMenuItem.Name = "locationManagementToolStripMenuItem";
            this.locationManagementToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.locationManagementToolStripMenuItem.Text = "Location Management";
            this.locationManagementToolStripMenuItem.Click += new System.EventHandler(this.locationManagementToolStripMenuItem_Click);
            // 
            // personnesManagementToolStripMenuItem
            // 
            this.personnesManagementToolStripMenuItem.Name = "personnesManagementToolStripMenuItem";
            this.personnesManagementToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.personnesManagementToolStripMenuItem.Text = "Personnes Management";
            this.personnesManagementToolStripMenuItem.Click += new System.EventHandler(this.personnesManagementToolStripMenuItem_Click);
            // 
            // materialsToolStripMenuItem
            // 
            this.materialsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materialsCategoryManagementToolStripMenuItem,
            this.materialsManagementToolStripMenuItem});
            this.materialsToolStripMenuItem.Name = "materialsToolStripMenuItem";
            this.materialsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.materialsToolStripMenuItem.Text = "Materials";
            // 
            // materialsCategoryManagementToolStripMenuItem
            // 
            this.materialsCategoryManagementToolStripMenuItem.Name = "materialsCategoryManagementToolStripMenuItem";
            this.materialsCategoryManagementToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.materialsCategoryManagementToolStripMenuItem.Text = "Materials Category Management";
            this.materialsCategoryManagementToolStripMenuItem.Click += new System.EventHandler(this.materialsCategoryManagementToolStripMenuItem_Click);
            // 
            // materialsManagementToolStripMenuItem
            // 
            this.materialsManagementToolStripMenuItem.Name = "materialsManagementToolStripMenuItem";
            this.materialsManagementToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.materialsManagementToolStripMenuItem.Text = "Materials Management";
            this.materialsManagementToolStripMenuItem.Click += new System.EventHandler(this.materialsManagementToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 125);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Stock Management ";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem societeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnesManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialsCategoryManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialsManagementToolStripMenuItem;
    }
}