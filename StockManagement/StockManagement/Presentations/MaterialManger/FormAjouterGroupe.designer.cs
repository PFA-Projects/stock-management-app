namespace StockManagement
{
    partial class FormAjouterGroupe
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
            System.Windows.Forms.Label serieNumberLabel;
            System.Windows.Forms.Label designationLabel;
            System.Windows.Forms.Label updateServiceDateLabel;
            System.Windows.Forms.Label observationLabel;
            System.Windows.Forms.Label dimensionLabel;
            System.Windows.Forms.Label iNN_NumberLabel;
            System.Windows.Forms.Label physicalStateLabel;
            System.Windows.Forms.Label materialCategoryLabel;
            System.Windows.Forms.Label deliveryLabel;
            this.serieNumberTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_Ajoutr = new System.Windows.Forms.Button();
            this.designationTextBox = new System.Windows.Forms.TextBox();
            this.updateServiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.observationTextBox = new System.Windows.Forms.TextBox();
            this.dimensionTextBox = new System.Windows.Forms.TextBox();
            this.iNN_NumberTextBox = new System.Windows.Forms.TextBox();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.comboBoxstate = new System.Windows.Forms.ComboBox();
            this.comboBoxcategorie = new System.Windows.Forms.ComboBox();
            this.comboBoxdelivry = new System.Windows.Forms.ComboBox();
            serieNumberLabel = new System.Windows.Forms.Label();
            designationLabel = new System.Windows.Forms.Label();
            updateServiceDateLabel = new System.Windows.Forms.Label();
            observationLabel = new System.Windows.Forms.Label();
            dimensionLabel = new System.Windows.Forms.Label();
            iNN_NumberLabel = new System.Windows.Forms.Label();
            physicalStateLabel = new System.Windows.Forms.Label();
            materialCategoryLabel = new System.Windows.Forms.Label();
            deliveryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serieNumberLabel
            // 
            serieNumberLabel.AutoSize = true;
            serieNumberLabel.Location = new System.Drawing.Point(462, 29);
            serieNumberLabel.Name = "serieNumberLabel";
            serieNumberLabel.Size = new System.Drawing.Size(74, 13);
            serieNumberLabel.TabIndex = 115;
            serieNumberLabel.Text = "Serie Number:";
            // 
            // serieNumberTextBox
            // 
            this.serieNumberTextBox.Location = new System.Drawing.Point(561, 26);
            this.serieNumberTextBox.Name = "serieNumberTextBox";
            this.serieNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.serieNumberTextBox.TabIndex = 116;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(465, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(267, 368);
            this.listBox1.TabIndex = 121;
            // 
            // button_Ajoutr
            // 
            this.button_Ajoutr.Location = new System.Drawing.Point(738, 97);
            this.button_Ajoutr.Name = "button_Ajoutr";
            this.button_Ajoutr.Size = new System.Drawing.Size(75, 23);
            this.button_Ajoutr.TabIndex = 122;
            this.button_Ajoutr.Text = "+";
            this.button_Ajoutr.UseVisualStyleBackColor = true;
            // 
            // designationLabel
            // 
            designationLabel.AutoSize = true;
            designationLabel.Location = new System.Drawing.Point(12, 50);
            designationLabel.Name = "designationLabel";
            designationLabel.Size = new System.Drawing.Size(66, 13);
            designationLabel.TabIndex = 123;
            designationLabel.Text = "Designation:";
            // 
            // designationTextBox
            // 
            this.designationTextBox.Location = new System.Drawing.Point(168, 50);
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.Size = new System.Drawing.Size(210, 20);
            this.designationTextBox.TabIndex = 124;
            // 
            // updateServiceDateLabel
            // 
            updateServiceDateLabel.AutoSize = true;
            updateServiceDateLabel.Location = new System.Drawing.Point(12, 96);
            updateServiceDateLabel.Name = "updateServiceDateLabel";
            updateServiceDateLabel.Size = new System.Drawing.Size(110, 13);
            updateServiceDateLabel.TabIndex = 125;
            updateServiceDateLabel.Text = "Update Service Date:";
            // 
            // updateServiceDateDateTimePicker
            // 
            this.updateServiceDateDateTimePicker.Location = new System.Drawing.Point(168, 96);
            this.updateServiceDateDateTimePicker.Name = "updateServiceDateDateTimePicker";
            this.updateServiceDateDateTimePicker.Size = new System.Drawing.Size(210, 20);
            this.updateServiceDateDateTimePicker.TabIndex = 126;
            // 
            // observationLabel
            // 
            observationLabel.AutoSize = true;
            observationLabel.Location = new System.Drawing.Point(12, 129);
            observationLabel.Name = "observationLabel";
            observationLabel.Size = new System.Drawing.Size(67, 13);
            observationLabel.TabIndex = 126;
            observationLabel.Text = "Observation:";
            // 
            // observationTextBox
            // 
            this.observationTextBox.Location = new System.Drawing.Point(168, 126);
            this.observationTextBox.Name = "observationTextBox";
            this.observationTextBox.Size = new System.Drawing.Size(210, 20);
            this.observationTextBox.TabIndex = 127;
            // 
            // dimensionLabel
            // 
            dimensionLabel.AutoSize = true;
            dimensionLabel.Location = new System.Drawing.Point(12, 163);
            dimensionLabel.Name = "dimensionLabel";
            dimensionLabel.Size = new System.Drawing.Size(57, 13);
            dimensionLabel.TabIndex = 127;
            dimensionLabel.Text = "dimension:";
            // 
            // dimensionTextBox
            // 
            this.dimensionTextBox.Location = new System.Drawing.Point(168, 156);
            this.dimensionTextBox.Name = "dimensionTextBox";
            this.dimensionTextBox.Size = new System.Drawing.Size(210, 20);
            this.dimensionTextBox.TabIndex = 128;
            // 
            // iNN_NumberLabel
            // 
            iNN_NumberLabel.AutoSize = true;
            iNN_NumberLabel.Location = new System.Drawing.Point(12, 202);
            iNN_NumberLabel.Name = "iNN_NumberLabel";
            iNN_NumberLabel.Size = new System.Drawing.Size(69, 13);
            iNN_NumberLabel.TabIndex = 128;
            iNN_NumberLabel.Text = "INN Number:";
            // 
            // iNN_NumberTextBox
            // 
            this.iNN_NumberTextBox.Location = new System.Drawing.Point(168, 195);
            this.iNN_NumberTextBox.Name = "iNN_NumberTextBox";
            this.iNN_NumberTextBox.Size = new System.Drawing.Size(210, 20);
            this.iNN_NumberTextBox.TabIndex = 129;
            // 
            // physicalStateLabel
            // 
            physicalStateLabel.AutoSize = true;
            physicalStateLabel.Location = new System.Drawing.Point(12, 234);
            physicalStateLabel.Name = "physicalStateLabel";
            physicalStateLabel.Size = new System.Drawing.Size(77, 13);
            physicalStateLabel.TabIndex = 129;
            physicalStateLabel.Text = "Physical State:";
            // 
            // materialCategoryLabel
            // 
            materialCategoryLabel.AutoSize = true;
            materialCategoryLabel.Location = new System.Drawing.Point(12, 268);
            materialCategoryLabel.Name = "materialCategoryLabel";
            materialCategoryLabel.Size = new System.Drawing.Size(92, 13);
            materialCategoryLabel.TabIndex = 130;
            materialCategoryLabel.Text = "Material Category:";
            // 
            // deliveryLabel
            // 
            deliveryLabel.AutoSize = true;
            deliveryLabel.Location = new System.Drawing.Point(12, 302);
            deliveryLabel.Name = "deliveryLabel";
            deliveryLabel.Size = new System.Drawing.Size(48, 13);
            deliveryLabel.TabIndex = 131;
            deliveryLabel.Text = "Delivery:";
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(738, 158);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 133;
            this.buttonSupprimer.Text = "-";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // comboBoxstate
            // 
            this.comboBoxstate.FormattingEnabled = true;
            this.comboBoxstate.Location = new System.Drawing.Point(168, 231);
            this.comboBoxstate.Name = "comboBoxstate";
            this.comboBoxstate.Size = new System.Drawing.Size(210, 21);
            this.comboBoxstate.TabIndex = 134;
            // 
            // comboBoxcategorie
            // 
            this.comboBoxcategorie.FormattingEnabled = true;
            this.comboBoxcategorie.Location = new System.Drawing.Point(168, 260);
            this.comboBoxcategorie.Name = "comboBoxcategorie";
            this.comboBoxcategorie.Size = new System.Drawing.Size(210, 21);
            this.comboBoxcategorie.TabIndex = 135;
            // 
            // comboBoxdelivry
            // 
            this.comboBoxdelivry.FormattingEnabled = true;
            this.comboBoxdelivry.Location = new System.Drawing.Point(168, 299);
            this.comboBoxdelivry.Name = "comboBoxdelivry";
            this.comboBoxdelivry.Size = new System.Drawing.Size(210, 21);
            this.comboBoxdelivry.TabIndex = 136;
            // 
            // FormAjouterGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(833, 741);
            this.Controls.Add(this.comboBoxdelivry);
            this.Controls.Add(this.comboBoxcategorie);
            this.Controls.Add(this.comboBoxstate);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(deliveryLabel);
            this.Controls.Add(materialCategoryLabel);
            this.Controls.Add(physicalStateLabel);
            this.Controls.Add(iNN_NumberLabel);
            this.Controls.Add(this.iNN_NumberTextBox);
            this.Controls.Add(dimensionLabel);
            this.Controls.Add(this.dimensionTextBox);
            this.Controls.Add(observationLabel);
            this.Controls.Add(this.observationTextBox);
            this.Controls.Add(updateServiceDateLabel);
            this.Controls.Add(this.updateServiceDateDateTimePicker);
            this.Controls.Add(designationLabel);
            this.Controls.Add(this.designationTextBox);
            this.Controls.Add(this.button_Ajoutr);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(serieNumberLabel);
            this.Controls.Add(this.serieNumberTextBox);
            this.Name = "FormAjouterGroupe";
            this.Text = "FormAjouterGroupe";
            this.Load += new System.EventHandler(this.FormAjouterGroupe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox serieNumberTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_Ajoutr;
        private System.Windows.Forms.TextBox designationTextBox;
        private System.Windows.Forms.DateTimePicker updateServiceDateDateTimePicker;
        private System.Windows.Forms.TextBox observationTextBox;
        private System.Windows.Forms.TextBox dimensionTextBox;
        private System.Windows.Forms.TextBox iNN_NumberTextBox;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.ComboBox comboBoxstate;
        private System.Windows.Forms.ComboBox comboBoxcategorie;
        private System.Windows.Forms.ComboBox comboBoxdelivry;
    }
}