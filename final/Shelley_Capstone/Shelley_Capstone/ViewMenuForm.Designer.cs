﻿namespace Shelley_Capstone
{
    partial class ViewMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMenuForm));
            this.updateUsersButton = new System.Windows.Forms.Button();
            this.updateMenuItemsButton = new System.Windows.Forms.Button();
            this.updateOrdersButton = new System.Windows.Forms.Button();
            this.ordersReportsButton = new System.Windows.Forms.Button();
            this.inventoryReportsButton = new System.Windows.Forms.Button();
            this.updateInventoryButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.shelleyRestaurantDataSet = new Shelley_Capstone.ShelleyRestaurantDataSet();
            this.menuItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuItemsTableAdapter = new Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.MenuItemsTableAdapter();
            this.tableAdapterManager = new Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.TableAdapterManager();
            this.menuItemsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.menuItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchUsersButton = new System.Windows.Forms.Button();
            this.searchMenuButton = new System.Windows.Forms.Button();
            this.searchOrdersButton = new System.Windows.Forms.Button();
            this.searchInventoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingNavigator)).BeginInit();
            this.menuItemsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // updateUsersButton
            // 
            this.updateUsersButton.Location = new System.Drawing.Point(59, 331);
            this.updateUsersButton.Name = "updateUsersButton";
            this.updateUsersButton.Size = new System.Drawing.Size(110, 23);
            this.updateUsersButton.TabIndex = 1;
            this.updateUsersButton.Text = "Insert Users";
            this.updateUsersButton.UseVisualStyleBackColor = true;
            this.updateUsersButton.Click += new System.EventHandler(this.updateUsersButton_Click);
            // 
            // updateMenuItemsButton
            // 
            this.updateMenuItemsButton.Location = new System.Drawing.Point(204, 331);
            this.updateMenuItemsButton.Name = "updateMenuItemsButton";
            this.updateMenuItemsButton.Size = new System.Drawing.Size(110, 23);
            this.updateMenuItemsButton.TabIndex = 2;
            this.updateMenuItemsButton.Text = "Insert Menu Items";
            this.updateMenuItemsButton.UseVisualStyleBackColor = true;
            this.updateMenuItemsButton.Click += new System.EventHandler(this.updateMenuItemsButton_Click);
            // 
            // updateOrdersButton
            // 
            this.updateOrdersButton.Location = new System.Drawing.Point(341, 331);
            this.updateOrdersButton.Name = "updateOrdersButton";
            this.updateOrdersButton.Size = new System.Drawing.Size(110, 23);
            this.updateOrdersButton.TabIndex = 3;
            this.updateOrdersButton.Text = "Insert Orders";
            this.updateOrdersButton.UseVisualStyleBackColor = true;
            this.updateOrdersButton.Click += new System.EventHandler(this.updateOrdersButton_Click);
            // 
            // ordersReportsButton
            // 
            this.ordersReportsButton.Location = new System.Drawing.Point(642, 331);
            this.ordersReportsButton.Name = "ordersReportsButton";
            this.ordersReportsButton.Size = new System.Drawing.Size(110, 23);
            this.ordersReportsButton.TabIndex = 4;
            this.ordersReportsButton.Text = "Order Reports";
            this.ordersReportsButton.UseVisualStyleBackColor = true;
            this.ordersReportsButton.Click += new System.EventHandler(this.ordersReportsButton_Click);
            // 
            // inventoryReportsButton
            // 
            this.inventoryReportsButton.Location = new System.Drawing.Point(780, 331);
            this.inventoryReportsButton.Name = "inventoryReportsButton";
            this.inventoryReportsButton.Size = new System.Drawing.Size(110, 23);
            this.inventoryReportsButton.TabIndex = 5;
            this.inventoryReportsButton.Text = "Inventory Reports";
            this.inventoryReportsButton.UseVisualStyleBackColor = true;
            this.inventoryReportsButton.Click += new System.EventHandler(this.inventoryReportsButton_Click);
            // 
            // updateInventoryButton
            // 
            this.updateInventoryButton.Location = new System.Drawing.Point(489, 331);
            this.updateInventoryButton.Name = "updateInventoryButton";
            this.updateInventoryButton.Size = new System.Drawing.Size(110, 23);
            this.updateInventoryButton.TabIndex = 6;
            this.updateInventoryButton.Text = "Insert Inventory";
            this.updateInventoryButton.UseVisualStyleBackColor = true;
            this.updateInventoryButton.Click += new System.EventHandler(this.updateInventoryButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(428, 417);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 7;
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
            // menuItemsBindingNavigator
            // 
            this.menuItemsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.menuItemsBindingNavigator.BindingSource = this.menuItemsBindingSource;
            this.menuItemsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.menuItemsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.menuItemsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.menuItemsBindingNavigatorSaveItem});
            this.menuItemsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.menuItemsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.menuItemsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.menuItemsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.menuItemsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.menuItemsBindingNavigator.Name = "menuItemsBindingNavigator";
            this.menuItemsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.menuItemsBindingNavigator.Size = new System.Drawing.Size(954, 25);
            this.menuItemsBindingNavigator.TabIndex = 8;
            this.menuItemsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // menuItemsBindingNavigatorSaveItem
            // 
            this.menuItemsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuItemsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("menuItemsBindingNavigatorSaveItem.Image")));
            this.menuItemsBindingNavigatorSaveItem.Name = "menuItemsBindingNavigatorSaveItem";
            this.menuItemsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.menuItemsBindingNavigatorSaveItem.Text = "Save Data";
            this.menuItemsBindingNavigatorSaveItem.Click += new System.EventHandler(this.menuItemsBindingNavigatorSaveItem_Click);
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
            this.menuItemsDataGridView.Location = new System.Drawing.Point(59, 48);
            this.menuItemsDataGridView.Name = "menuItemsDataGridView";
            this.menuItemsDataGridView.Size = new System.Drawing.Size(831, 261);
            this.menuItemsDataGridView.TabIndex = 8;
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
            // searchUsersButton
            // 
            this.searchUsersButton.Location = new System.Drawing.Point(59, 360);
            this.searchUsersButton.Name = "searchUsersButton";
            this.searchUsersButton.Size = new System.Drawing.Size(110, 23);
            this.searchUsersButton.TabIndex = 9;
            this.searchUsersButton.Text = "Search Users";
            this.searchUsersButton.UseVisualStyleBackColor = true;
            this.searchUsersButton.Click += new System.EventHandler(this.searchUsersButton_Click);
            // 
            // searchMenuButton
            // 
            this.searchMenuButton.Location = new System.Drawing.Point(204, 360);
            this.searchMenuButton.Name = "searchMenuButton";
            this.searchMenuButton.Size = new System.Drawing.Size(110, 23);
            this.searchMenuButton.TabIndex = 10;
            this.searchMenuButton.Text = "Search Menu Items";
            this.searchMenuButton.UseVisualStyleBackColor = true;
            this.searchMenuButton.Click += new System.EventHandler(this.searchMenuButton_Click);
            // 
            // searchOrdersButton
            // 
            this.searchOrdersButton.Location = new System.Drawing.Point(341, 360);
            this.searchOrdersButton.Name = "searchOrdersButton";
            this.searchOrdersButton.Size = new System.Drawing.Size(110, 23);
            this.searchOrdersButton.TabIndex = 11;
            this.searchOrdersButton.Text = "Search Orders";
            this.searchOrdersButton.UseVisualStyleBackColor = true;
            this.searchOrdersButton.Click += new System.EventHandler(this.searchOrdersButton_Click);
            // 
            // searchInventoryButton
            // 
            this.searchInventoryButton.Location = new System.Drawing.Point(489, 360);
            this.searchInventoryButton.Name = "searchInventoryButton";
            this.searchInventoryButton.Size = new System.Drawing.Size(110, 23);
            this.searchInventoryButton.TabIndex = 12;
            this.searchInventoryButton.Text = "Search Inventory";
            this.searchInventoryButton.UseVisualStyleBackColor = true;
            this.searchInventoryButton.Click += new System.EventHandler(this.searchInventoryButton_Click);
            // 
            // ViewMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 526);
            this.Controls.Add(this.searchInventoryButton);
            this.Controls.Add(this.searchOrdersButton);
            this.Controls.Add(this.searchMenuButton);
            this.Controls.Add(this.searchUsersButton);
            this.Controls.Add(this.menuItemsDataGridView);
            this.Controls.Add(this.menuItemsBindingNavigator);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.updateInventoryButton);
            this.Controls.Add(this.inventoryReportsButton);
            this.Controls.Add(this.ordersReportsButton);
            this.Controls.Add(this.updateOrdersButton);
            this.Controls.Add(this.updateMenuItemsButton);
            this.Controls.Add(this.updateUsersButton);
            this.Name = "ViewMenuForm";
            this.Text = "View Menu";
            this.Load += new System.EventHandler(this.ViewMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingNavigator)).EndInit();
            this.menuItemsBindingNavigator.ResumeLayout(false);
            this.menuItemsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button updateUsersButton;
        private System.Windows.Forms.Button updateMenuItemsButton;
        private System.Windows.Forms.Button updateOrdersButton;
        private System.Windows.Forms.Button ordersReportsButton;
        private System.Windows.Forms.Button inventoryReportsButton;
        private System.Windows.Forms.Button updateInventoryButton;
        private System.Windows.Forms.Button closeButton;
        private ShelleyRestaurantDataSet shelleyRestaurantDataSet;
        private System.Windows.Forms.BindingSource menuItemsBindingSource;
        private ShelleyRestaurantDataSetTableAdapters.MenuItemsTableAdapter menuItemsTableAdapter;
        private ShelleyRestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator menuItemsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton menuItemsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView menuItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button searchUsersButton;
        private System.Windows.Forms.Button searchMenuButton;
        private System.Windows.Forms.Button searchOrdersButton;
        private System.Windows.Forms.Button searchInventoryButton;
    }
}