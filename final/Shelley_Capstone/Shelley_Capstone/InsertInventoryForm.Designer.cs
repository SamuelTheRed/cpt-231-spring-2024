namespace Shelley_Capstone
{
    partial class InsertInventoryForm
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
            System.Windows.Forms.Label inventoryCodeLabel;
            System.Windows.Forms.Label inventoryDescriptionLabel;
            System.Windows.Forms.Label inventoryQuantityLabel;
            this.closeButton = new System.Windows.Forms.Button();
            this.shelleyRestaurantDataSet = new Shelley_Capstone.ShelleyRestaurantDataSet();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.InventoryTableAdapter();
            this.tableAdapterManager = new Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.TableAdapterManager();
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryCodeTextBox = new System.Windows.Forms.TextBox();
            this.inventoryDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.pageTitle = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.quantityNumSelect = new System.Windows.Forms.NumericUpDown();
            inventoryCodeLabel = new System.Windows.Forms.Label();
            inventoryDescriptionLabel = new System.Windows.Forms.Label();
            inventoryQuantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryCodeLabel
            // 
            inventoryCodeLabel.AutoSize = true;
            inventoryCodeLabel.Location = new System.Drawing.Point(557, 179);
            inventoryCodeLabel.Name = "inventoryCodeLabel";
            inventoryCodeLabel.Size = new System.Drawing.Size(82, 13);
            inventoryCodeLabel.TabIndex = 5;
            inventoryCodeLabel.Text = "Inventory Code:";
            // 
            // inventoryDescriptionLabel
            // 
            inventoryDescriptionLabel.AutoSize = true;
            inventoryDescriptionLabel.Location = new System.Drawing.Point(557, 205);
            inventoryDescriptionLabel.Name = "inventoryDescriptionLabel";
            inventoryDescriptionLabel.Size = new System.Drawing.Size(110, 13);
            inventoryDescriptionLabel.TabIndex = 7;
            inventoryDescriptionLabel.Text = "Inventory Description:";
            // 
            // inventoryQuantityLabel
            // 
            inventoryQuantityLabel.AutoSize = true;
            inventoryQuantityLabel.Location = new System.Drawing.Point(557, 231);
            inventoryQuantityLabel.Name = "inventoryQuantityLabel";
            inventoryQuantityLabel.Size = new System.Drawing.Size(96, 13);
            inventoryQuantityLabel.TabIndex = 9;
            inventoryQuantityLabel.Text = "Inventory Quantity:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(370, 365);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            this.inventoryDataGridView.Location = new System.Drawing.Point(40, 62);
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.Size = new System.Drawing.Size(451, 262);
            this.inventoryDataGridView.TabIndex = 2;
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
            // inventoryCodeTextBox
            // 
            this.inventoryCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "InventoryCode", true));
            this.inventoryCodeTextBox.Location = new System.Drawing.Point(673, 176);
            this.inventoryCodeTextBox.Name = "inventoryCodeTextBox";
            this.inventoryCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.inventoryCodeTextBox.TabIndex = 6;
            // 
            // inventoryDescriptionTextBox
            // 
            this.inventoryDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "InventoryDescription", true));
            this.inventoryDescriptionTextBox.Location = new System.Drawing.Point(673, 202);
            this.inventoryDescriptionTextBox.Name = "inventoryDescriptionTextBox";
            this.inventoryDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.inventoryDescriptionTextBox.TabIndex = 8;
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.Location = new System.Drawing.Point(578, 123);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(152, 24);
            this.pageTitle.TabIndex = 13;
            this.pageTitle.Text = "Insert Inventory";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(632, 273);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add New User";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // quantityNumSelect
            // 
            this.quantityNumSelect.Location = new System.Drawing.Point(673, 229);
            this.quantityNumSelect.Name = "quantityNumSelect";
            this.quantityNumSelect.Size = new System.Drawing.Size(120, 20);
            this.quantityNumSelect.TabIndex = 15;
            // 
            // UpdateInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 444);
            this.Controls.Add(this.quantityNumSelect);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(inventoryCodeLabel);
            this.Controls.Add(this.inventoryCodeTextBox);
            this.Controls.Add(inventoryDescriptionLabel);
            this.Controls.Add(this.inventoryDescriptionTextBox);
            this.Controls.Add(inventoryQuantityLabel);
            this.Controls.Add(this.inventoryDataGridView);
            this.Controls.Add(this.closeButton);
            this.Name = "UpdateInventoryForm";
            this.Text = "UpdateInventoryForm";
            this.Load += new System.EventHandler(this.UpdateInventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        private ShelleyRestaurantDataSet shelleyRestaurantDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private ShelleyRestaurantDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private ShelleyRestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox inventoryCodeTextBox;
        private System.Windows.Forms.TextBox inventoryDescriptionTextBox;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.NumericUpDown quantityNumSelect;
    }
}