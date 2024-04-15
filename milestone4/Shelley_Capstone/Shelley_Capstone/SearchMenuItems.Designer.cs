namespace Shelley_Capstone
{
    partial class SearchMenuItems
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
            this.menuItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuItemsTableAdapter = new Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.MenuItemsTableAdapter();
            this.tableAdapterManager = new Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.TableAdapterManager();
            this.menuItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSearchButton = new System.Windows.Forms.Button();
            this.categorySearchButton = new System.Windows.Forms.Button();
            this.searchParamTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.priceSearchButton = new System.Windows.Forms.Button();
            this.resetSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shelleyRestaurantDataSet
            // 
            this.shelleyRestaurantDataSet.DataSetName = "ShelleyRestaurantDataSet";
            this.shelleyRestaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuItemsBindingSource
            // 
            this.menuItemsBindingSource.DataMember = "MenuItems";
            this.menuItemsBindingSource.DataSource = this.shelleyRestaurantDataSet;
            // 
            // menuItemsTableAdapter
            // 
            this.menuItemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.MenuItemsTableAdapter = this.menuItemsTableAdapter;
            this.tableAdapterManager.OrderFulfilledTableAdapter = null;
            this.tableAdapterManager.OrderItemTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // menuItemsDataGridView
            // 
            this.menuItemsDataGridView.AutoGenerateColumns = false;
            this.menuItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.menuItemsDataGridView.DataSource = this.menuItemsBindingSource;
            this.menuItemsDataGridView.Location = new System.Drawing.Point(57, 57);
            this.menuItemsDataGridView.Name = "menuItemsDataGridView";
            this.menuItemsDataGridView.Size = new System.Drawing.Size(671, 208);
            this.menuItemsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MenuItemId";
            this.dataGridViewTextBoxColumn1.HeaderText = "MenuItemId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MenuItemName";
            this.dataGridViewTextBoxColumn2.HeaderText = "MenuItemName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MenuItemDescription";
            this.dataGridViewTextBoxColumn3.HeaderText = "MenuItemDescription";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MenuItemCategory";
            this.dataGridViewTextBoxColumn4.HeaderText = "MenuItemCategory";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MenuItemPrice";
            this.dataGridViewTextBoxColumn5.HeaderText = "MenuItemPrice";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // nameSearchButton
            // 
            this.nameSearchButton.Location = new System.Drawing.Point(336, 324);
            this.nameSearchButton.Name = "nameSearchButton";
            this.nameSearchButton.Size = new System.Drawing.Size(107, 23);
            this.nameSearchButton.TabIndex = 23;
            this.nameSearchButton.Text = "Search by Name";
            this.nameSearchButton.UseVisualStyleBackColor = true;
            this.nameSearchButton.Click += new System.EventHandler(this.nameSearchButton_Click);
            // 
            // categorySearchButton
            // 
            this.categorySearchButton.Location = new System.Drawing.Point(212, 324);
            this.categorySearchButton.Name = "categorySearchButton";
            this.categorySearchButton.Size = new System.Drawing.Size(118, 23);
            this.categorySearchButton.TabIndex = 22;
            this.categorySearchButton.Text = "Search by Category";
            this.categorySearchButton.UseVisualStyleBackColor = true;
            this.categorySearchButton.Click += new System.EventHandler(this.categorySearchButton_Click);
            // 
            // searchParamTextBox
            // 
            this.searchParamTextBox.Location = new System.Drawing.Point(243, 298);
            this.searchParamTextBox.Name = "searchParamTextBox";
            this.searchParamTextBox.Size = new System.Drawing.Size(290, 20);
            this.searchParamTextBox.TabIndex = 21;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(348, 397);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 20;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // priceSearchButton
            // 
            this.priceSearchButton.Location = new System.Drawing.Point(449, 324);
            this.priceSearchButton.Name = "priceSearchButton";
            this.priceSearchButton.Size = new System.Drawing.Size(107, 23);
            this.priceSearchButton.TabIndex = 25;
            this.priceSearchButton.Text = "Search by Price";
            this.priceSearchButton.UseVisualStyleBackColor = true;
            this.priceSearchButton.Click += new System.EventHandler(this.priceSearchButton_Click);
            // 
            // resetSearchButton
            // 
            this.resetSearchButton.Location = new System.Drawing.Point(295, 353);
            this.resetSearchButton.Name = "resetSearchButton";
            this.resetSearchButton.Size = new System.Drawing.Size(188, 23);
            this.resetSearchButton.TabIndex = 26;
            this.resetSearchButton.Text = "Reset Table View";
            this.resetSearchButton.UseVisualStyleBackColor = true;
            this.resetSearchButton.Click += new System.EventHandler(this.resetSearchButton_Click);
            // 
            // SearchMenuItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetSearchButton);
            this.Controls.Add(this.priceSearchButton);
            this.Controls.Add(this.nameSearchButton);
            this.Controls.Add(this.categorySearchButton);
            this.Controls.Add(this.searchParamTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.menuItemsDataGridView);
            this.Name = "SearchMenuItems";
            this.Text = "SearchMenuItems";
            this.Load += new System.EventHandler(this.SearchMenuItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShelleyRestaurantDataSet shelleyRestaurantDataSet;
        private System.Windows.Forms.BindingSource menuItemsBindingSource;
        private ShelleyRestaurantDataSetTableAdapters.MenuItemsTableAdapter menuItemsTableAdapter;
        private ShelleyRestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView menuItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button nameSearchButton;
        private System.Windows.Forms.Button categorySearchButton;
        private System.Windows.Forms.TextBox searchParamTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button priceSearchButton;
        private System.Windows.Forms.Button resetSearchButton;
    }
}