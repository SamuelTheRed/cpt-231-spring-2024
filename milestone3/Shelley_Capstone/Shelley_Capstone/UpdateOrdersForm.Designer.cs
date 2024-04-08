namespace Shelley_Capstone
{
    partial class UpdateOrdersForm
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
            System.Windows.Forms.Label orderDateTimeLabel;
            System.Windows.Forms.Label orderNumberLabel;
            System.Windows.Forms.Label userIdLabel;
            System.Windows.Forms.Label tableIdLabel;
            this.closeButton = new System.Windows.Forms.Button();
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
            this.orderFulfilledBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderFulfilledTableAdapter = new Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.OrderFulfilledTableAdapter();
            this.orderDateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pageTitle = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.userIdNumSelect = new System.Windows.Forms.NumericUpDown();
            this.tableIdNumSelect = new System.Windows.Forms.NumericUpDown();
            this.orderNumSelect = new System.Windows.Forms.NumericUpDown();
            orderDateTimeLabel = new System.Windows.Forms.Label();
            orderNumberLabel = new System.Windows.Forms.Label();
            userIdLabel = new System.Windows.Forms.Label();
            tableIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderFulfilledBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIdNumSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableIdNumSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDateTimeLabel
            // 
            orderDateTimeLabel.AutoSize = true;
            orderDateTimeLabel.Location = new System.Drawing.Point(660, 165);
            orderDateTimeLabel.Name = "orderDateTimeLabel";
            orderDateTimeLabel.Size = new System.Drawing.Size(88, 13);
            orderDateTimeLabel.TabIndex = 5;
            orderDateTimeLabel.Text = "Order Date Time:";
            // 
            // orderNumberLabel
            // 
            orderNumberLabel.AutoSize = true;
            orderNumberLabel.Location = new System.Drawing.Point(660, 190);
            orderNumberLabel.Name = "orderNumberLabel";
            orderNumberLabel.Size = new System.Drawing.Size(76, 13);
            orderNumberLabel.TabIndex = 7;
            orderNumberLabel.Text = "Order Number:";
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(660, 216);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(44, 13);
            userIdLabel.TabIndex = 9;
            userIdLabel.Text = "User Id:";
            // 
            // tableIdLabel
            // 
            tableIdLabel.AutoSize = true;
            tableIdLabel.Location = new System.Drawing.Point(660, 242);
            tableIdLabel.Name = "tableIdLabel";
            tableIdLabel.Size = new System.Drawing.Size(49, 13);
            tableIdLabel.TabIndex = 11;
            tableIdLabel.Text = "Table Id:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(383, 416);
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
            this.ordersDataGridView.Location = new System.Drawing.Point(42, 59);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.Size = new System.Drawing.Size(547, 301);
            this.ordersDataGridView.TabIndex = 2;
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
            // orderFulfilledBindingSource
            // 
            this.orderFulfilledBindingSource.DataMember = "OrderFulfilled";
            this.orderFulfilledBindingSource.DataSource = this.shelleyRestaurantDataSet;
            // 
            // orderFulfilledTableAdapter
            // 
            this.orderFulfilledTableAdapter.ClearBeforeFill = true;
            // 
            // orderDateTimeDateTimePicker
            // 
            this.orderDateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "OrderDateTime", true));
            this.orderDateTimeDateTimePicker.Location = new System.Drawing.Point(754, 161);
            this.orderDateTimeDateTimePicker.Name = "orderDateTimeDateTimePicker";
            this.orderDateTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.orderDateTimeDateTimePicker.TabIndex = 6;
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.Location = new System.Drawing.Point(768, 79);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(121, 24);
            this.pageTitle.TabIndex = 13;
            this.pageTitle.Text = "Insert Order";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(805, 292);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add New User";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // userIdNumSelect
            // 
            this.userIdNumSelect.Location = new System.Drawing.Point(754, 216);
            this.userIdNumSelect.Name = "userIdNumSelect";
            this.userIdNumSelect.Size = new System.Drawing.Size(120, 20);
            this.userIdNumSelect.TabIndex = 15;
            // 
            // tableIdNumSelect
            // 
            this.tableIdNumSelect.Location = new System.Drawing.Point(754, 242);
            this.tableIdNumSelect.Name = "tableIdNumSelect";
            this.tableIdNumSelect.Size = new System.Drawing.Size(120, 20);
            this.tableIdNumSelect.TabIndex = 16;
            // 
            // orderNumSelect
            // 
            this.orderNumSelect.Location = new System.Drawing.Point(754, 190);
            this.orderNumSelect.Name = "orderNumSelect";
            this.orderNumSelect.Size = new System.Drawing.Size(120, 20);
            this.orderNumSelect.TabIndex = 17;
            // 
            // UpdateOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 473);
            this.Controls.Add(this.orderNumSelect);
            this.Controls.Add(this.tableIdNumSelect);
            this.Controls.Add(this.userIdNumSelect);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(orderDateTimeLabel);
            this.Controls.Add(this.orderDateTimeDateTimePicker);
            this.Controls.Add(orderNumberLabel);
            this.Controls.Add(userIdLabel);
            this.Controls.Add(tableIdLabel);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.closeButton);
            this.Name = "UpdateOrdersForm";
            this.Text = "UpdateOrdersForm";
            this.Load += new System.EventHandler(this.UpdateOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderFulfilledBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIdNumSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableIdNumSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
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
        private System.Windows.Forms.BindingSource orderFulfilledBindingSource;
        private ShelleyRestaurantDataSetTableAdapters.OrderFulfilledTableAdapter orderFulfilledTableAdapter;
        private System.Windows.Forms.DateTimePicker orderDateTimeDateTimePicker;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.NumericUpDown userIdNumSelect;
        private System.Windows.Forms.NumericUpDown tableIdNumSelect;
        private System.Windows.Forms.NumericUpDown orderNumSelect;
    }
}