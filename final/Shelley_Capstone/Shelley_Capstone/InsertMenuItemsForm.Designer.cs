namespace Shelley_Capstone
{
    partial class InsertMenuItemsForm
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
            System.Windows.Forms.Label menuItemNameLabel;
            System.Windows.Forms.Label menuItemDescriptionLabel;
            System.Windows.Forms.Label menuItemCategoryLabel;
            System.Windows.Forms.Label menuItemPriceLabel;
            this.closeButton = new System.Windows.Forms.Button();
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
            this.menuItemNameTextBox = new System.Windows.Forms.TextBox();
            this.menuItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.menuItemCategoryTextBox = new System.Windows.Forms.TextBox();
            this.menuItemPriceTextBox = new System.Windows.Forms.TextBox();
            this.pageTitle = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            menuItemNameLabel = new System.Windows.Forms.Label();
            menuItemDescriptionLabel = new System.Windows.Forms.Label();
            menuItemCategoryLabel = new System.Windows.Forms.Label();
            menuItemPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuItemNameLabel
            // 
            menuItemNameLabel.AutoSize = true;
            menuItemNameLabel.Location = new System.Drawing.Point(622, 163);
            menuItemNameLabel.Name = "menuItemNameLabel";
            menuItemNameLabel.Size = new System.Drawing.Size(91, 13);
            menuItemNameLabel.TabIndex = 4;
            menuItemNameLabel.Text = "Menu Item Name:";
            // 
            // menuItemDescriptionLabel
            // 
            menuItemDescriptionLabel.AutoSize = true;
            menuItemDescriptionLabel.Location = new System.Drawing.Point(622, 189);
            menuItemDescriptionLabel.Name = "menuItemDescriptionLabel";
            menuItemDescriptionLabel.Size = new System.Drawing.Size(116, 13);
            menuItemDescriptionLabel.TabIndex = 6;
            menuItemDescriptionLabel.Text = "Menu Item Description:";
            // 
            // menuItemCategoryLabel
            // 
            menuItemCategoryLabel.AutoSize = true;
            menuItemCategoryLabel.Location = new System.Drawing.Point(622, 215);
            menuItemCategoryLabel.Name = "menuItemCategoryLabel";
            menuItemCategoryLabel.Size = new System.Drawing.Size(105, 13);
            menuItemCategoryLabel.TabIndex = 8;
            menuItemCategoryLabel.Text = "Menu Item Category:";
            // 
            // menuItemPriceLabel
            // 
            menuItemPriceLabel.AutoSize = true;
            menuItemPriceLabel.Location = new System.Drawing.Point(622, 241);
            menuItemPriceLabel.Name = "menuItemPriceLabel";
            menuItemPriceLabel.Size = new System.Drawing.Size(87, 13);
            menuItemPriceLabel.TabIndex = 10;
            menuItemPriceLabel.Text = "Menu Item Price:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(416, 403);
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
            this.menuItemsDataGridView.Location = new System.Drawing.Point(21, 61);
            this.menuItemsDataGridView.Name = "menuItemsDataGridView";
            this.menuItemsDataGridView.Size = new System.Drawing.Size(554, 304);
            this.menuItemsDataGridView.TabIndex = 2;
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
            // menuItemNameTextBox
            // 
            this.menuItemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuItemsBindingSource, "MenuItemName", true));
            this.menuItemNameTextBox.Location = new System.Drawing.Point(744, 160);
            this.menuItemNameTextBox.Name = "menuItemNameTextBox";
            this.menuItemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.menuItemNameTextBox.TabIndex = 5;
            // 
            // menuItemDescriptionTextBox
            // 
            this.menuItemDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuItemsBindingSource, "MenuItemDescription", true));
            this.menuItemDescriptionTextBox.Location = new System.Drawing.Point(744, 186);
            this.menuItemDescriptionTextBox.Name = "menuItemDescriptionTextBox";
            this.menuItemDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.menuItemDescriptionTextBox.TabIndex = 7;
            // 
            // menuItemCategoryTextBox
            // 
            this.menuItemCategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuItemsBindingSource, "MenuItemCategory", true));
            this.menuItemCategoryTextBox.Location = new System.Drawing.Point(744, 212);
            this.menuItemCategoryTextBox.Name = "menuItemCategoryTextBox";
            this.menuItemCategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.menuItemCategoryTextBox.TabIndex = 9;
            // 
            // menuItemPriceTextBox
            // 
            this.menuItemPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuItemsBindingSource, "MenuItemPrice", true));
            this.menuItemPriceTextBox.Location = new System.Drawing.Point(744, 238);
            this.menuItemPriceTextBox.Name = "menuItemPriceTextBox";
            this.menuItemPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.menuItemPriceTextBox.TabIndex = 11;
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.Location = new System.Drawing.Point(649, 106);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(165, 24);
            this.pageTitle.TabIndex = 12;
            this.pageTitle.Text = "Insert Menu Item";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(699, 304);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add New User";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // InsertMenuItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 473);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(menuItemNameLabel);
            this.Controls.Add(this.menuItemNameTextBox);
            this.Controls.Add(menuItemDescriptionLabel);
            this.Controls.Add(this.menuItemDescriptionTextBox);
            this.Controls.Add(menuItemCategoryLabel);
            this.Controls.Add(this.menuItemCategoryTextBox);
            this.Controls.Add(menuItemPriceLabel);
            this.Controls.Add(this.menuItemPriceTextBox);
            this.Controls.Add(this.menuItemsDataGridView);
            this.Controls.Add(this.closeButton);
            this.Name = "InsertMenuItemsForm";
            this.Text = "UpdateMenuItemsForm";
            this.Load += new System.EventHandler(this.UpdateMenuItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
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
        private System.Windows.Forms.TextBox menuItemNameTextBox;
        private System.Windows.Forms.TextBox menuItemDescriptionTextBox;
        private System.Windows.Forms.TextBox menuItemCategoryTextBox;
        private System.Windows.Forms.TextBox menuItemPriceTextBox;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Button addButton;
    }
}