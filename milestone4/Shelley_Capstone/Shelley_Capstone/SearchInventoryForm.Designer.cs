namespace Shelley_Capstone
{
    partial class SearchInventoryForm
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
            this.components = new System.ComponentModel.Container();
            this.shelleyRestaurantDataSet = new Shelley_Capstone.ShelleyRestaurantDataSet();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.InventoryTableAdapter();
            this.tableAdapterManager = new Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.TableAdapterManager();
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitySearchButton = new System.Windows.Forms.Button();
            this.codeSearchButton = new System.Windows.Forms.Button();
            this.searchParamTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.resetSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shelleyRestaurantDataSet
            // 
            this.shelleyRestaurantDataSet.DataSetName = "ShelleyRestaurantDataSet";
            this.shelleyRestaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.shelleyRestaurantDataSet;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InventoryTableAdapter = this.inventoryTableAdapter;
            this.tableAdapterManager.MenuItemsTableAdapter = null;
            this.tableAdapterManager.OrderFulfilledTableAdapter = null;
            this.tableAdapterManager.OrderItemTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.AutoGenerateColumns = false;
            this.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.inventoryDataGridView.DataSource = this.inventoryBindingSource;
            this.inventoryDataGridView.Location = new System.Drawing.Point(41, 56);
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.Size = new System.Drawing.Size(690, 224);
            this.inventoryDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InventoryId";
            this.dataGridViewTextBoxColumn1.HeaderText = "InventoryId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "InventoryCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "InventoryCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "InventoryDescription";
            this.dataGridViewTextBoxColumn3.HeaderText = "InventoryDescription";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "InventoryQuantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "InventoryQuantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // quantitySearchButton
            // 
            this.quantitySearchButton.Location = new System.Drawing.Point(396, 337);
            this.quantitySearchButton.Name = "quantitySearchButton";
            this.quantitySearchButton.Size = new System.Drawing.Size(107, 23);
            this.quantitySearchButton.TabIndex = 23;
            this.quantitySearchButton.Text = "Search by Quantity";
            this.quantitySearchButton.UseVisualStyleBackColor = true;
            this.quantitySearchButton.Click += new System.EventHandler(this.quantitySearchButton_Click);
            // 
            // codeSearchButton
            // 
            this.codeSearchButton.Location = new System.Drawing.Point(283, 337);
            this.codeSearchButton.Name = "codeSearchButton";
            this.codeSearchButton.Size = new System.Drawing.Size(107, 23);
            this.codeSearchButton.TabIndex = 22;
            this.codeSearchButton.Text = "Search by Code";
            this.codeSearchButton.UseVisualStyleBackColor = true;
            this.codeSearchButton.Click += new System.EventHandler(this.codeSearchButton_Click);
            // 
            // searchParamTextBox
            // 
            this.searchParamTextBox.Location = new System.Drawing.Point(246, 311);
            this.searchParamTextBox.Name = "searchParamTextBox";
            this.searchParamTextBox.Size = new System.Drawing.Size(290, 20);
            this.searchParamTextBox.TabIndex = 21;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(355, 416);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 20;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // resetSearchButton
            // 
            this.resetSearchButton.Location = new System.Drawing.Point(302, 366);
            this.resetSearchButton.Name = "resetSearchButton";
            this.resetSearchButton.Size = new System.Drawing.Size(188, 23);
            this.resetSearchButton.TabIndex = 28;
            this.resetSearchButton.Text = "Reset Table View";
            this.resetSearchButton.UseVisualStyleBackColor = true;
            this.resetSearchButton.Click += new System.EventHandler(this.resetSearchButton_Click);
            // 
            // SearchInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.resetSearchButton);
            this.Controls.Add(this.quantitySearchButton);
            this.Controls.Add(this.codeSearchButton);
            this.Controls.Add(this.searchParamTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.inventoryDataGridView);
            this.Name = "SearchInventoryForm";
            this.Text = "SearchInventoryForm";
            this.Load += new System.EventHandler(this.SearchInventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShelleyRestaurantDataSet shelleyRestaurantDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private ShelleyRestaurantDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private ShelleyRestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button quantitySearchButton;
        private System.Windows.Forms.Button codeSearchButton;
        private System.Windows.Forms.TextBox searchParamTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button resetSearchButton;
    }
}