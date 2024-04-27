namespace Shelley_Capstone
{
    partial class SearchOrdersForm
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
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.TableAdapterManager();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberSearchButton = new System.Windows.Forms.Button();
            this.dateTimeSearchButton = new System.Windows.Forms.Button();
            this.searchParamTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.userSearchButton = new System.Windows.Forms.Button();
            this.tableSearchButton = new System.Windows.Forms.Button();
            this.resetSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.ordersDataGridView.Location = new System.Drawing.Point(27, 52);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.Size = new System.Drawing.Size(707, 220);
            this.ordersDataGridView.TabIndex = 1;
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
            // numberSearchButton
            // 
            this.numberSearchButton.Location = new System.Drawing.Point(268, 323);
            this.numberSearchButton.Name = "numberSearchButton";
            this.numberSearchButton.Size = new System.Drawing.Size(107, 23);
            this.numberSearchButton.TabIndex = 23;
            this.numberSearchButton.Text = "Search by Number";
            this.numberSearchButton.UseVisualStyleBackColor = true;
            this.numberSearchButton.Click += new System.EventHandler(this.numberSearchButton_Click);
            // 
            // dateTimeSearchButton
            // 
            this.dateTimeSearchButton.Location = new System.Drawing.Point(138, 323);
            this.dateTimeSearchButton.Name = "dateTimeSearchButton";
            this.dateTimeSearchButton.Size = new System.Drawing.Size(124, 23);
            this.dateTimeSearchButton.TabIndex = 22;
            this.dateTimeSearchButton.Text = "Search by Date Time";
            this.dateTimeSearchButton.UseVisualStyleBackColor = true;
            this.dateTimeSearchButton.Click += new System.EventHandler(this.dateTimeSearchButton_Click);
            // 
            // searchParamTextBox
            // 
            this.searchParamTextBox.Location = new System.Drawing.Point(232, 297);
            this.searchParamTextBox.Name = "searchParamTextBox";
            this.searchParamTextBox.Size = new System.Drawing.Size(290, 20);
            this.searchParamTextBox.TabIndex = 21;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(344, 402);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 20;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // userSearchButton
            // 
            this.userSearchButton.Location = new System.Drawing.Point(381, 323);
            this.userSearchButton.Name = "userSearchButton";
            this.userSearchButton.Size = new System.Drawing.Size(107, 23);
            this.userSearchButton.TabIndex = 25;
            this.userSearchButton.Text = "Search by User";
            this.userSearchButton.UseVisualStyleBackColor = true;
            this.userSearchButton.Click += new System.EventHandler(this.userSearchButton_Click);
            // 
            // tableSearchButton
            // 
            this.tableSearchButton.Location = new System.Drawing.Point(494, 323);
            this.tableSearchButton.Name = "tableSearchButton";
            this.tableSearchButton.Size = new System.Drawing.Size(107, 23);
            this.tableSearchButton.TabIndex = 26;
            this.tableSearchButton.Text = "Search by Table";
            this.tableSearchButton.UseVisualStyleBackColor = true;
            this.tableSearchButton.Click += new System.EventHandler(this.tableSearchButton_Click);
            // 
            // resetSearchButton
            // 
            this.resetSearchButton.Location = new System.Drawing.Point(284, 352);
            this.resetSearchButton.Name = "resetSearchButton";
            this.resetSearchButton.Size = new System.Drawing.Size(188, 23);
            this.resetSearchButton.TabIndex = 27;
            this.resetSearchButton.Text = "Reset Table View";
            this.resetSearchButton.UseVisualStyleBackColor = true;
            this.resetSearchButton.Click += new System.EventHandler(this.resetSearchButton_Click);
            // 
            // SearchOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetSearchButton);
            this.Controls.Add(this.tableSearchButton);
            this.Controls.Add(this.userSearchButton);
            this.Controls.Add(this.numberSearchButton);
            this.Controls.Add(this.dateTimeSearchButton);
            this.Controls.Add(this.searchParamTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.ordersDataGridView);
            this.Name = "SearchOrdersForm";
            this.Text = "SearchOrdersForm";
            this.Load += new System.EventHandler(this.SearchOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShelleyRestaurantDataSet shelleyRestaurantDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private ShelleyRestaurantDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private ShelleyRestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button numberSearchButton;
        private System.Windows.Forms.Button dateTimeSearchButton;
        private System.Windows.Forms.TextBox searchParamTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button userSearchButton;
        private System.Windows.Forms.Button tableSearchButton;
        private System.Windows.Forms.Button resetSearchButton;
    }
}