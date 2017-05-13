namespace StockManagement.Presentations.RiskOFStock.MaterialCategories
{
    partial class MaterialCategoryUC
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Descriptiontextbox = new System.Windows.Forms.TextBox();
            this.DesignationtextBox = new System.Windows.Forms.TextBox();
            this.MaterialCategorygrpbox = new System.Windows.Forms.GroupBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.MaterialCategorygrpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Designation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // Descriptiontextbox
            // 
            this.Descriptiontextbox.Location = new System.Drawing.Point(232, 116);
            this.Descriptiontextbox.Name = "Descriptiontextbox";
            this.Descriptiontextbox.Size = new System.Drawing.Size(270, 22);
            this.Descriptiontextbox.TabIndex = 2;
            // 
            // DesignationtextBox
            // 
            this.DesignationtextBox.Location = new System.Drawing.Point(232, 215);
            this.DesignationtextBox.Name = "DesignationtextBox";
            this.DesignationtextBox.Size = new System.Drawing.Size(270, 22);
            this.DesignationtextBox.TabIndex = 3;
            // 
            // MaterialCategorygrpbox
            // 
            this.MaterialCategorygrpbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MaterialCategorygrpbox.Controls.Add(this.Descriptiontextbox);
            this.MaterialCategorygrpbox.Controls.Add(this.label2);
            this.MaterialCategorygrpbox.Controls.Add(this.DesignationtextBox);
            this.MaterialCategorygrpbox.Controls.Add(this.label1);
            this.MaterialCategorygrpbox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialCategorygrpbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaterialCategorygrpbox.Location = new System.Drawing.Point(3, 3);
            this.MaterialCategorygrpbox.Name = "MaterialCategorygrpbox";
            this.MaterialCategorygrpbox.Size = new System.Drawing.Size(652, 355);
            this.MaterialCategorygrpbox.TabIndex = 4;
            this.MaterialCategorygrpbox.TabStop = false;
            this.MaterialCategorygrpbox.Text = "Add new materialCategory";
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(76, 376);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(94, 39);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(430, 376);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(99, 39);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // MaterialCategoryUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.MaterialCategorygrpbox);
            this.Name = "MaterialCategoryUC";
            this.Size = new System.Drawing.Size(659, 434);
            this.Load += new System.EventHandler(this.MaterialCategoryUC_Load);
            this.MaterialCategorygrpbox.ResumeLayout(false);
            this.MaterialCategorygrpbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Descriptiontextbox;
        private System.Windows.Forms.TextBox DesignationtextBox;
        private System.Windows.Forms.GroupBox MaterialCategorygrpbox;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}
