namespace StockManagement.Presentations.RiskOFStock
{
    partial class MaterialGridUC
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.inventoryNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateServiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acquisitionValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acquisitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acquisitionValueExistDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.physicalStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockExistenceDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dimensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update,
            this.inventoryNumberDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.markDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.updateServiceDateDataGridViewTextBoxColumn,
            this.observationDataGridViewTextBoxColumn,
            this.acquisitionValueDataGridViewTextBoxColumn,
            this.acquisitionDataGridViewTextBoxColumn,
            this.acquisitionValueExistDataGridViewCheckBoxColumn,
            this.physicalStateDataGridViewTextBoxColumn,
            this.stockExistenceDataGridViewCheckBoxColumn,
            this.dimensionDataGridViewTextBoxColumn,
            this.iNNNumberDataGridViewTextBoxColumn,
            this.serieNumberDataGridViewTextBoxColumn,
            this.deliveryDataGridViewTextBoxColumn,
            this.materialCategoryDataGridViewTextBoxColumn,
            this.Delete});
            this.dataGridView1.DataSource = this.materialBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 491);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Update
            // 
            this.Update.DataPropertyName = "InventoryNumber";
            this.Update.HeaderText = "update";
            this.Update.Name = "Update";
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "InventoryNumber";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // inventoryNumberDataGridViewTextBoxColumn
            // 
            this.inventoryNumberDataGridViewTextBoxColumn.DataPropertyName = "InventoryNumber";
            this.inventoryNumberDataGridViewTextBoxColumn.HeaderText = "InventoryNumber";
            this.inventoryNumberDataGridViewTextBoxColumn.Name = "inventoryNumberDataGridViewTextBoxColumn";
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            // 
            // markDataGridViewTextBoxColumn
            // 
            this.markDataGridViewTextBoxColumn.DataPropertyName = "Mark";
            this.markDataGridViewTextBoxColumn.HeaderText = "Mark";
            this.markDataGridViewTextBoxColumn.Name = "markDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // updateServiceDateDataGridViewTextBoxColumn
            // 
            this.updateServiceDateDataGridViewTextBoxColumn.DataPropertyName = "UpdateServiceDate";
            this.updateServiceDateDataGridViewTextBoxColumn.HeaderText = "UpdateServiceDate";
            this.updateServiceDateDataGridViewTextBoxColumn.Name = "updateServiceDateDataGridViewTextBoxColumn";
            // 
            // observationDataGridViewTextBoxColumn
            // 
            this.observationDataGridViewTextBoxColumn.DataPropertyName = "Observation";
            this.observationDataGridViewTextBoxColumn.HeaderText = "Observation";
            this.observationDataGridViewTextBoxColumn.Name = "observationDataGridViewTextBoxColumn";
            // 
            // acquisitionValueDataGridViewTextBoxColumn
            // 
            this.acquisitionValueDataGridViewTextBoxColumn.DataPropertyName = "AcquisitionValue";
            this.acquisitionValueDataGridViewTextBoxColumn.HeaderText = "AcquisitionValue";
            this.acquisitionValueDataGridViewTextBoxColumn.Name = "acquisitionValueDataGridViewTextBoxColumn";
            // 
            // acquisitionDataGridViewTextBoxColumn
            // 
            this.acquisitionDataGridViewTextBoxColumn.DataPropertyName = "Acquisition";
            this.acquisitionDataGridViewTextBoxColumn.HeaderText = "Acquisition";
            this.acquisitionDataGridViewTextBoxColumn.Name = "acquisitionDataGridViewTextBoxColumn";
            // 
            // acquisitionValueExistDataGridViewCheckBoxColumn
            // 
            this.acquisitionValueExistDataGridViewCheckBoxColumn.DataPropertyName = "AcquisitionValueExist";
            this.acquisitionValueExistDataGridViewCheckBoxColumn.HeaderText = "AcquisitionValueExist";
            this.acquisitionValueExistDataGridViewCheckBoxColumn.Name = "acquisitionValueExistDataGridViewCheckBoxColumn";
            // 
            // physicalStateDataGridViewTextBoxColumn
            // 
            this.physicalStateDataGridViewTextBoxColumn.DataPropertyName = "PhysicalState";
            this.physicalStateDataGridViewTextBoxColumn.HeaderText = "PhysicalState";
            this.physicalStateDataGridViewTextBoxColumn.Name = "physicalStateDataGridViewTextBoxColumn";
            // 
            // stockExistenceDataGridViewCheckBoxColumn
            // 
            this.stockExistenceDataGridViewCheckBoxColumn.DataPropertyName = "StockExistence";
            this.stockExistenceDataGridViewCheckBoxColumn.HeaderText = "StockExistence";
            this.stockExistenceDataGridViewCheckBoxColumn.Name = "stockExistenceDataGridViewCheckBoxColumn";
            // 
            // dimensionDataGridViewTextBoxColumn
            // 
            this.dimensionDataGridViewTextBoxColumn.DataPropertyName = "dimension";
            this.dimensionDataGridViewTextBoxColumn.HeaderText = "dimension";
            this.dimensionDataGridViewTextBoxColumn.Name = "dimensionDataGridViewTextBoxColumn";
            // 
            // iNNNumberDataGridViewTextBoxColumn
            // 
            this.iNNNumberDataGridViewTextBoxColumn.DataPropertyName = "INN_Number";
            this.iNNNumberDataGridViewTextBoxColumn.HeaderText = "INN_Number";
            this.iNNNumberDataGridViewTextBoxColumn.Name = "iNNNumberDataGridViewTextBoxColumn";
            // 
            // serieNumberDataGridViewTextBoxColumn
            // 
            this.serieNumberDataGridViewTextBoxColumn.DataPropertyName = "SerieNumber";
            this.serieNumberDataGridViewTextBoxColumn.HeaderText = "SerieNumber";
            this.serieNumberDataGridViewTextBoxColumn.Name = "serieNumberDataGridViewTextBoxColumn";
            // 
            // deliveryDataGridViewTextBoxColumn
            // 
            this.deliveryDataGridViewTextBoxColumn.DataPropertyName = "Delivery";
            this.deliveryDataGridViewTextBoxColumn.HeaderText = "Delivery";
            this.deliveryDataGridViewTextBoxColumn.Name = "deliveryDataGridViewTextBoxColumn";
            // 
            // materialCategoryDataGridViewTextBoxColumn
            // 
            this.materialCategoryDataGridViewTextBoxColumn.DataPropertyName = "MaterialCategory";
            this.materialCategoryDataGridViewTextBoxColumn.HeaderText = "MaterialCategory";
            this.materialCategoryDataGridViewTextBoxColumn.Name = "materialCategoryDataGridViewTextBoxColumn";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(StockManagement.Entities.Material);
            // 
            // MaterialGridUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "MaterialGridUC";
            this.Size = new System.Drawing.Size(895, 614);
            this.Load += new System.EventHandler(this.MaterialGridUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateServiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acquisitionValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acquisitionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acquisitionValueExistDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicalStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stockExistenceDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dimensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
