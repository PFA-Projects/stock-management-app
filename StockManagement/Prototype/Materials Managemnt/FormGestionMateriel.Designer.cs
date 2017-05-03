namespace GestionMagasin.GestionMatriel
{
    partial class FormGestionMateriel
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
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabMatriel = new System.Windows.Forms.TabControl();
            this.materielGrid1 = new GestionMagasin.GestionMatriel.MaterielGrid();
            this.tabPage1.SuspendLayout();
            this.tabMatriel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.Location = new System.Drawing.Point(902, 89);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(118, 67);
            this.button_Ajouter.TabIndex = 1;
            this.button_Ajouter.Text = "Ajouter un matriel";
            this.button_Ajouter.UseVisualStyleBackColor = true;
            this.button_Ajouter.Click += new System.EventHandler(this.button_Ajouter_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materielGrid1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(855, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Matriel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabMatriel
            // 
            this.tabMatriel.Controls.Add(this.tabPage1);
            this.tabMatriel.Location = new System.Drawing.Point(12, 23);
            this.tabMatriel.Name = "tabMatriel";
            this.tabMatriel.SelectedIndex = 0;
            this.tabMatriel.Size = new System.Drawing.Size(863, 358);
            this.tabMatriel.TabIndex = 2;
            // 
            // materielGrid1
            // 
            this.materielGrid1.Location = new System.Drawing.Point(16, 9);
            this.materielGrid1.Name = "materielGrid1";
            this.materielGrid1.Size = new System.Drawing.Size(1118, 320);
            this.materielGrid1.TabIndex = 0;
            // 
            // FormGestionMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 446);
            this.Controls.Add(this.tabMatriel);
            this.Controls.Add(this.button_Ajouter);
            this.Name = "FormGestionMateriel";
            this.Text = "FormGestionMateriel";
            this.Load += new System.EventHandler(this.FormGestionMateriel_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabMatriel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterielGrid materielGrid1;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabMatriel;
    }
}