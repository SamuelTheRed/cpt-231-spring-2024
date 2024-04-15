namespace Shelley_Capstone
{
    partial class OrderReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderReportsForm));
            this.closeButton = new System.Windows.Forms.Button();
            this.totalSearchButton = new System.Windows.Forms.Button();
            this.userSearchButton = new System.Windows.Forms.Button();
            this.dateSearchButton = new System.Windows.Forms.Button();
            this.idSearchButton = new System.Windows.Forms.Button();
            this.searchParamTextBox = new System.Windows.Forms.TextBox();
            this.pastOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.shelleyRestaurantDataSet = new Shelley_Capstone.ShelleyRestaurantDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.TableAdapterManager();
            this.ordersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ordersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).BeginInit();
            this.ordersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(384, 399);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // totalSearchButton
            // 
            this.totalSearchButton.Location = new System.Drawing.Point(535, 345);
            this.totalSearchButton.Name = "totalSearchButton";
            this.totalSearchButton.Size = new System.Drawing.Size(107, 23);
            this.totalSearchButton.TabIndex = 14;
            this.totalSearchButton.Text = "Search by Total";
            this.totalSearchButton.UseVisualStyleBackColor = true;
            // 
            // userSearchButton
            // 
            this.userSearchButton.Location = new System.Drawing.Point(422, 345);
            this.userSearchButton.Name = "userSearchButton";
            this.userSearchButton.Size = new System.Drawing.Size(107, 23);
            this.userSearchButton.TabIndex = 13;
            this.userSearchButton.Text = "Search by User";
            this.userSearchButton.UseVisualStyleBackColor = true;
            // 
            // dateSearchButton
            // 
            this.dateSearchButton.Location = new System.Drawing.Point(309, 345);
            this.dateSearchButton.Name = "dateSearchButton";
            this.dateSearchButton.Size = new System.Drawing.Size(107, 23);
            this.dateSearchButton.TabIndex = 12;
            this.dateSearchButton.Text = "Search by Date";
            this.dateSearchButton.UseVisualStyleBackColor = true;
            // 
            // idSearchButton
            // 
            this.idSearchButton.Location = new System.Drawing.Point(196, 345);
            this.idSearchButton.Name = "idSearchButton";
            this.idSearchButton.Size = new System.Drawing.Size(107, 23);
            this.idSearchButton.TabIndex = 11;
            this.idSearchButton.Text = "Search by ID";
            this.idSearchButton.UseVisualStyleBackColor = true;
            // 
            // searchParamTextBox
            // 
            this.searchParamTextBox.Location = new System.Drawing.Point(196, 292);
            this.searchParamTextBox.Name = "searchParamTextBox";
            this.searchParamTextBox.Size = new System.Drawing.Size(290, 20);
            this.searchParamTextBox.TabIndex = 10;
            // 
            // pastOrderCheckBox
            // 
            this.pastOrderCheckBox.AutoSize = true;
            this.pastOrderCheckBox.Location = new System.Drawing.Point(535, 295);
            this.pastOrderCheckBox.Name = "pastOrderCheckBox";
            this.pastOrderCheckBox.Size = new System.Drawing.Size(119, 17);
            this.pastOrderCheckBox.TabIndex = 15;
            this.pastOrderCheckBox.Text = "Include Past Orders";
            this.pastOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // shelleyRestaurantDataSet
            // 
            this.shelleyRestaurantDataSet.DataSetName = "ShelleyRestaurantDataSet";
            this.shelleyRestaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.shelleyRestaurantDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.MenuItemsTableAdapter = null;
            this.tableAdapterManager.OrderFulfilledTableAdapter = null;
            this.tableAdapterManager.OrderItemTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // ordersBindingNavigator
            // 
            this.ordersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ordersBindingNavigator.BindingSource = this.ordersBindingSource;
            this.ordersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ordersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ordersBindingNavigatorSaveItem});
            this.ordersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ordersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordersBindingNavigator.Name = "ordersBindingNavigator";
            this.ordersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordersBindingNavigator.Size = new System.Drawing.Size(845, 25);
            this.ordersBindingNavigator.TabIndex = 16;
            this.ordersBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // ordersBindingNavigatorSaveItem
            // 
            this.ordersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ordersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordersBindingNavigatorSaveItem.Image")));
            this.ordersBindingNavigatorSaveItem.Name = "ordersBindingNavigatorSaveItem";
            this.ordersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.ordersBindingNavigatorSaveItem.Text = "Save Data";
            this.ordersBindingNavigatorSaveItem.Click += new System.EventHandler(this.ordersBindingNavigatorSaveItem_Click);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.ordersDataGridView.DataSource = this.ordersBindingSource;
            this.ordersDataGridView.Location = new System.Drawing.Point(47, 28);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.Size = new System.Drawing.Size(752, 235);
            this.ordersDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderId";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderDateTime";
            this.dataGridViewTextBoxColumn2.HeaderText = "OrderDateTime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrderNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "OrderNumber";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UserId";
            this.dataGridViewTextBoxColumn4.HeaderText = "UserId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TableId";
            this.dataGridViewTextBoxColumn5.HeaderText = "TableId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // OrderReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 494);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.ordersBindingNavigator);
            this.Controls.Add(this.pastOrderCheckBox);
            this.Controls.Add(this.totalSearchButton);
            this.Controls.Add(this.userSearchButton);
            this.Controls.Add(this.dateSearchButton);
            this.Controls.Add(this.idSearchButton);
            this.Controls.Add(this.searchParamTextBox);
            this.Controls.Add(this.closeButton);
            this.Name = "OrderReportsForm";
            this.Text = "OrderReportsForm";
            this.Load += new System.EventHandler(this.OrderReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).EndInit();
            this.ordersBindingNavigator.ResumeLayout(false);
            this.ordersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button totalSearchButton;
        private System.Windows.Forms.Button userSearchButton;
        private System.Windows.Forms.Button dateSearchButton;
        private System.Windows.Forms.Button idSearchButton;
        private System.Windows.Forms.TextBox searchParamTextBox;
        private System.Windows.Forms.CheckBox pastOrderCheckBox;
        private ShelleyRestaurantDataSet shelleyRestaurantDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private ShelleyRestaurantDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private ShelleyRestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ordersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ordersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}