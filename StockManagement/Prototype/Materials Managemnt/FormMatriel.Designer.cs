using StockManagement.Entities;

namespace GestionMagasin.GestionMatriel
{
    partial class FormMatriel
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label categorieLabel;
            System.Windows.Forms.Label acquisitionLabel;
            System.Windows.Forms.Label dateMiseServiceLabel;
            System.Windows.Forms.Label designationLabel;
            System.Windows.Forms.Label dimensionLabel;
            System.Windows.Forms.Label etatPhysiqueLabel;
            System.Windows.Forms.Label isExistStokLabel;
            System.Windows.Forms.Label isValeurAcquisitionExistLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label numero_INNLabel;
            System.Windows.Forms.Label numero_SerieLabel;
            System.Windows.Forms.Label numeroInvontaireLabel;
            System.Windows.Forms.Label observationLabel;
            System.Windows.Forms.Label valeurAcquisitionLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.matrielBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.isExistStokRadioButton = new System.Windows.Forms.RadioButton();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.br_enregistrer = new System.Windows.Forms.Button();
            this.categorieComboBox = new System.Windows.Forms.ComboBox();
            this.categorieMatrielBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acquisitionTextBox = new System.Windows.Forms.TextBox();
            this.dateMiseServiceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.designationTextBox = new System.Windows.Forms.TextBox();
            this.dimensionTextBox = new System.Windows.Forms.TextBox();
            this.etatPhysiqueTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.numero_INNTextBox = new System.Windows.Forms.TextBox();
            this.numero_SerieTextBox = new System.Windows.Forms.TextBox();
            this.numeroInvontaireTextBox = new System.Windows.Forms.TextBox();
            this.observationTextBox = new System.Windows.Forms.TextBox();
            this.valeurAcquisitionTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            categorieLabel = new System.Windows.Forms.Label();
            acquisitionLabel = new System.Windows.Forms.Label();
            dateMiseServiceLabel = new System.Windows.Forms.Label();
            designationLabel = new System.Windows.Forms.Label();
            dimensionLabel = new System.Windows.Forms.Label();
            etatPhysiqueLabel = new System.Windows.Forms.Label();
            isExistStokLabel = new System.Windows.Forms.Label();
            isValeurAcquisitionExistLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            numero_INNLabel = new System.Windows.Forms.Label();
            numero_SerieLabel = new System.Windows.Forms.Label();
            numeroInvontaireLabel = new System.Windows.Forms.Label();
            observationLabel = new System.Windows.Forms.Label();
            valeurAcquisitionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrielBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorieMatrielBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categorieLabel
            // 
            categorieLabel.AutoSize = true;
            categorieLabel.Location = new System.Drawing.Point(85, 387);
            categorieLabel.Name = "categorieLabel";
            categorieLabel.Size = new System.Drawing.Size(54, 13);
            categorieLabel.TabIndex = 55;
            categorieLabel.Text = "categorie:";
            // 
            // acquisitionLabel
            // 
            acquisitionLabel.AutoSize = true;
            acquisitionLabel.Location = new System.Drawing.Point(85, 41);
            acquisitionLabel.Name = "acquisitionLabel";
            acquisitionLabel.Size = new System.Drawing.Size(60, 13);
            acquisitionLabel.TabIndex = 29;
            acquisitionLabel.Text = "acquisition:";
            // 
            // dateMiseServiceLabel
            // 
            dateMiseServiceLabel.AutoSize = true;
            dateMiseServiceLabel.Location = new System.Drawing.Point(85, 68);
            dateMiseServiceLabel.Name = "dateMiseServiceLabel";
            dateMiseServiceLabel.Size = new System.Drawing.Size(97, 13);
            dateMiseServiceLabel.TabIndex = 31;
            dateMiseServiceLabel.Text = "Date Mise Service:";
            // 
            // designationLabel
            // 
            designationLabel.AutoSize = true;
            designationLabel.Location = new System.Drawing.Point(85, 93);
            designationLabel.Name = "designationLabel";
            designationLabel.Size = new System.Drawing.Size(66, 13);
            designationLabel.TabIndex = 33;
            designationLabel.Text = "Designation:";
            // 
            // dimensionLabel
            // 
            dimensionLabel.AutoSize = true;
            dimensionLabel.Location = new System.Drawing.Point(85, 119);
            dimensionLabel.Name = "dimensionLabel";
            dimensionLabel.Size = new System.Drawing.Size(59, 13);
            dimensionLabel.TabIndex = 35;
            dimensionLabel.Text = "Dimension:";
            // 
            // etatPhysiqueLabel
            // 
            etatPhysiqueLabel.AutoSize = true;
            etatPhysiqueLabel.Location = new System.Drawing.Point(85, 145);
            etatPhysiqueLabel.Name = "etatPhysiqueLabel";
            etatPhysiqueLabel.Size = new System.Drawing.Size(75, 13);
            etatPhysiqueLabel.TabIndex = 37;
            etatPhysiqueLabel.Text = "Etat Physique:";
            // 
            // isExistStokLabel
            // 
            isExistStokLabel.AutoSize = true;
            isExistStokLabel.Location = new System.Drawing.Point(85, 174);
            isExistStokLabel.Name = "isExistStokLabel";
            isExistStokLabel.Size = new System.Drawing.Size(100, 13);
            isExistStokLabel.TabIndex = 39;
            isExistStokLabel.Text = "existe dans le stock";
            // 
            // isValeurAcquisitionExistLabel
            // 
            isValeurAcquisitionExistLabel.AutoSize = true;
            isValeurAcquisitionExistLabel.Location = new System.Drawing.Point(85, 204);
            isValeurAcquisitionExistLabel.Name = "isValeurAcquisitionExistLabel";
            isValeurAcquisitionExistLabel.Size = new System.Drawing.Size(101, 13);
            isValeurAcquisitionExistLabel.TabIndex = 41;
            isValeurAcquisitionExistLabel.Text = " existe d\'acquisition ";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(85, 231);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 43;
            modelLabel.Text = "Model:";
            // 
            // numero_INNLabel
            // 
            numero_INNLabel.AutoSize = true;
            numero_INNLabel.Location = new System.Drawing.Point(85, 257);
            numero_INNLabel.Name = "numero_INNLabel";
            numero_INNLabel.Size = new System.Drawing.Size(69, 13);
            numero_INNLabel.TabIndex = 45;
            numero_INNLabel.Text = "Numero INN:";
            // 
            // numero_SerieLabel
            // 
            numero_SerieLabel.AutoSize = true;
            numero_SerieLabel.Location = new System.Drawing.Point(85, 283);
            numero_SerieLabel.Name = "numero_SerieLabel";
            numero_SerieLabel.Size = new System.Drawing.Size(74, 13);
            numero_SerieLabel.TabIndex = 47;
            numero_SerieLabel.Text = "Numero Serie:";
            // 
            // numeroInvontaireLabel
            // 
            numeroInvontaireLabel.AutoSize = true;
            numeroInvontaireLabel.Location = new System.Drawing.Point(85, 309);
            numeroInvontaireLabel.Name = "numeroInvontaireLabel";
            numeroInvontaireLabel.Size = new System.Drawing.Size(97, 13);
            numeroInvontaireLabel.TabIndex = 49;
            numeroInvontaireLabel.Text = "Numero Invontaire:";
            // 
            // observationLabel
            // 
            observationLabel.AutoSize = true;
            observationLabel.Location = new System.Drawing.Point(85, 335);
            observationLabel.Name = "observationLabel";
            observationLabel.Size = new System.Drawing.Size(67, 13);
            observationLabel.TabIndex = 51;
            observationLabel.Text = "Observation:";
            // 
            // valeurAcquisitionLabel
            // 
            valeurAcquisitionLabel.AutoSize = true;
            valeurAcquisitionLabel.Location = new System.Drawing.Point(85, 361);
            valeurAcquisitionLabel.Name = "valeurAcquisitionLabel";
            valeurAcquisitionLabel.Size = new System.Drawing.Size(93, 13);
            valeurAcquisitionLabel.TabIndex = 53;
            valeurAcquisitionLabel.Text = "valeur Acquisition:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(isExistStokLabel);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.bt_annuler);
            this.groupBox1.Controls.Add(this.br_enregistrer);
            this.groupBox1.Controls.Add(categorieLabel);
            this.groupBox1.Controls.Add(this.categorieComboBox);
            this.groupBox1.Controls.Add(acquisitionLabel);
            this.groupBox1.Controls.Add(this.acquisitionTextBox);
            this.groupBox1.Controls.Add(dateMiseServiceLabel);
            this.groupBox1.Controls.Add(this.dateMiseServiceDateTimePicker);
            this.groupBox1.Controls.Add(designationLabel);
            this.groupBox1.Controls.Add(this.designationTextBox);
            this.groupBox1.Controls.Add(dimensionLabel);
            this.groupBox1.Controls.Add(this.dimensionTextBox);
            this.groupBox1.Controls.Add(etatPhysiqueLabel);
            this.groupBox1.Controls.Add(this.etatPhysiqueTextBox);
            this.groupBox1.Controls.Add(isValeurAcquisitionExistLabel);
            this.groupBox1.Controls.Add(modelLabel);
            this.groupBox1.Controls.Add(this.modelTextBox);
            this.groupBox1.Controls.Add(numero_INNLabel);
            this.groupBox1.Controls.Add(this.numero_INNTextBox);
            this.groupBox1.Controls.Add(numero_SerieLabel);
            this.groupBox1.Controls.Add(this.numero_SerieTextBox);
            this.groupBox1.Controls.Add(numeroInvontaireLabel);
            this.groupBox1.Controls.Add(this.numeroInvontaireTextBox);
            this.groupBox1.Controls.Add(observationLabel);
            this.groupBox1.Controls.Add(this.observationTextBox);
            this.groupBox1.Controls.Add(valeurAcquisitionLabel);
            this.groupBox1.Controls.Add(this.valeurAcquisitionTextBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriel";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Location = new System.Drawing.Point(221, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 31);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.matrielBindingSource, "IsExistStok", true));
            this.radioButton2.Location = new System.Drawing.Point(99, 6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 18);
            this.radioButton2.TabIndex = 41;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Non";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // matrielBindingSource
            // 
            this.matrielBindingSource.DataSource = typeof(Material);
            // 
            // radioButton3
            // 
            this.radioButton3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.matrielBindingSource, "IsExistStok", true));
            this.radioButton3.Location = new System.Drawing.Point(6, 6);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(87, 18);
            this.radioButton3.TabIndex = 40;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Oui";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.isExistStokRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(221, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 31);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.matrielBindingSource, "IsExistStok", true));
            this.radioButton1.Location = new System.Drawing.Point(99, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 18);
            this.radioButton1.TabIndex = 41;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Non";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // isExistStokRadioButton
            // 
            this.isExistStokRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.matrielBindingSource, "IsExistStok", true));
            this.isExistStokRadioButton.Location = new System.Drawing.Point(0, 7);
            this.isExistStokRadioButton.Name = "isExistStokRadioButton";
            this.isExistStokRadioButton.Size = new System.Drawing.Size(87, 18);
            this.isExistStokRadioButton.TabIndex = 40;
            this.isExistStokRadioButton.TabStop = true;
            this.isExistStokRadioButton.Text = "Oui";
            this.isExistStokRadioButton.UseVisualStyleBackColor = true;
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(294, 429);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(75, 23);
            this.bt_annuler.TabIndex = 58;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // br_enregistrer
            // 
            this.br_enregistrer.Location = new System.Drawing.Point(173, 429);
            this.br_enregistrer.Name = "br_enregistrer";
            this.br_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.br_enregistrer.TabIndex = 57;
            this.br_enregistrer.Text = "Enregistrer";
            this.br_enregistrer.UseVisualStyleBackColor = true;
            this.br_enregistrer.Click += new System.EventHandler(this.br_enregistrer_Click);
            // 
            // categorieComboBox
            // 
            this.categorieComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matrielBindingSource, "categorie", true));
            this.categorieComboBox.DataSource = this.categorieMatrielBindingSource;
            this.categorieComboBox.DisplayMember = "Designation";
            this.categorieComboBox.FormattingEnabled = true;
            this.categorieComboBox.Location = new System.Drawing.Point(221, 387);
            this.categorieComboBox.Name = "categorieComboBox";
            this.categorieComboBox.Size = new System.Drawing.Size(200, 21);
            this.categorieComboBox.TabIndex = 56;
            this.categorieComboBox.ValueMember = "id";
            // 
            // categorieMatrielBindingSource
            // 
            this.categorieMatrielBindingSource.DataSource = typeof(MaterialCategory);
            // 
            // acquisitionTextBox
            // 
            this.acquisitionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matrielBindingSource, "acquisition", true));
            this.acquisitionTextBox.Location = new System.Drawing.Point(221, 38);
            this.acquisitionTextBox.Name = "acquisitionTextBox";
            this.acquisitionTextBox.Size = new System.Drawing.Size(200, 20);
            this.acquisitionTextBox.TabIndex = 30;
            // 
            // dateMiseServiceDateTimePicker
            // 
            this.dateMiseServiceDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.matrielBindingSource, "DateMiseService", true));
            this.dateMiseServiceDateTimePicker.Location = new System.Drawing.Point(221, 64);
            this.dateMiseServiceDateTimePicker.Name = "dateMiseServiceDateTimePicker";
            this.dateMiseServiceDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateMiseServiceDateTimePicker.TabIndex = 32;
            // 
            // designationTextBox
            // 
            this.designationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matrielBindingSource, "Designation", true));
            this.designationTextBox.Location = new System.Drawing.Point(221, 90);
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.Size = new System.Drawing.Size(200, 20);
            this.designationTextBox.TabIndex = 34;
            // 
            // dimensionTextBox
            // 
            this.dimensionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matrielBindingSource, "Dimension", true));
            this.dimensionTextBox.Location = new System.Drawing.Point(221, 116);
            this.dimensionTextBox.Name = "dimensionTextBox";
            this.dimensionTextBox.Size = new System.Drawing.Size(200, 20);
            this.dimensionTextBox.TabIndex = 36;
            // 
            // etatPhysiqueTextBox
            // 
            this.etatPhysiqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matrielBindingSource, "EtatPhysique", true));
            this.etatPhysiqueTextBox.Location = new System.Drawing.Point(221, 142);
            this.etatPhysiqueTextBox.Name = "etatPhysiqueTextBox";
            this.etatPhysiqueTextBox.Size = new System.Drawing.Size(200, 20);
            this.etatPhysiqueTextBox.TabIndex = 38;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matrielBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(221, 228);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(200, 20);
            this.modelTextBox.TabIndex = 44;
            // 
            // numero_INNTextBox
            // 
            this.numero_INNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matrielBindingSource, "Numero_INN", true));
            this.numero_INNTextBox.Location = new System.Drawing.Point(221, 254);
            this.numero_INNTextBox.Name = "numero_INNTextBox";
            this.numero_INNTextBox.Size = new System.Drawing.Size(200, 20);
            this.numero_INNTextBox.TabIndex = 46;
            // 
            // numero_SerieTextBox
            // 
            this.numero_SerieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matrielBindingSource, "Numero_Serie", true));
            this.numero_SerieTextBox.Location = new System.Drawing.Point(221, 280);
            this.numero_SerieTextBox.Name = "numero_SerieTextBox";
            this.numero_SerieTextBox.Size = new System.Drawing.Size(200, 20);
            this.numero_SerieTextBox.TabIndex = 48;
            // 
            // numeroInvontaireTextBox
            // 
            this.numeroInvontaireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matrielBindingSource, "NumeroInvontaire", true));
            this.numeroInvontaireTextBox.Location = new System.Drawing.Point(221, 306);
            this.numeroInvontaireTextBox.Name = "numeroInvontaireTextBox";
            this.numeroInvontaireTextBox.Size = new System.Drawing.Size(200, 20);
            this.numeroInvontaireTextBox.TabIndex = 50;
            // 
            // observationTextBox
            // 
            this.observationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matrielBindingSource, "Observation", true));
            this.observationTextBox.Location = new System.Drawing.Point(221, 332);
            this.observationTextBox.Name = "observationTextBox";
            this.observationTextBox.Size = new System.Drawing.Size(200, 20);
            this.observationTextBox.TabIndex = 52;
            // 
            // valeurAcquisitionTextBox
            // 
            this.valeurAcquisitionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matrielBindingSource, "valeurAcquisition", true));
            this.valeurAcquisitionTextBox.Location = new System.Drawing.Point(221, 358);
            this.valeurAcquisitionTextBox.Name = "valeurAcquisitionTextBox";
            this.valeurAcquisitionTextBox.Size = new System.Drawing.Size(200, 20);
            this.valeurAcquisitionTextBox.TabIndex = 54;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormMatriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMatriel";
            this.Size = new System.Drawing.Size(494, 496);
            this.Load += new System.EventHandler(this.FormMatriel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matrielBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categorieMatrielBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource matrielBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox categorieComboBox;
        private System.Windows.Forms.TextBox acquisitionTextBox;
        private System.Windows.Forms.DateTimePicker dateMiseServiceDateTimePicker;
        private System.Windows.Forms.TextBox designationTextBox;
        private System.Windows.Forms.TextBox dimensionTextBox;
        private System.Windows.Forms.TextBox etatPhysiqueTextBox;
        private System.Windows.Forms.RadioButton isExistStokRadioButton;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox numero_INNTextBox;
        private System.Windows.Forms.TextBox numero_SerieTextBox;
        private System.Windows.Forms.TextBox numeroInvontaireTextBox;
        private System.Windows.Forms.TextBox observationTextBox;
        private System.Windows.Forms.TextBox valeurAcquisitionTextBox;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.Button br_enregistrer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingSource categorieMatrielBindingSource;
    }
}
