namespace StockManagement.Presentation.Load_Files
{
    partial class LoadDepartureFile
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
            this.btn_enregistrer = new MetroFramework.Controls.MetroButton();
            this.Charger = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Location = new System.Drawing.Point(99, 103);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(124, 32);
            this.btn_enregistrer.TabIndex = 0;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseSelectable = true;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // Charger
            // 
            this.Charger.Location = new System.Drawing.Point(304, 103);
            this.Charger.Name = "Charger";
            this.Charger.Size = new System.Drawing.Size(124, 32);
            this.Charger.TabIndex = 1;
            this.Charger.Text = "Charger";
            this.Charger.UseSelectable = true;
            // 
            // LoadDepartureFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 225);
            this.Controls.Add(this.Charger);
            this.Controls.Add(this.btn_enregistrer);
            this.Name = "LoadDepartureFile";
            this.Text = "Fichiers";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_enregistrer;
        private MetroFramework.Controls.MetroButton Charger;
    }
}