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
            System.Windows.Forms.Label orderDateTimeLabel;
            this.orderFulfilledDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderFulfilledBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shelleyRestaurantDataSet = new Shelley_Capstone.ShelleyRestaurantDataSet();
            this.orderfulfilledSearchButton = new System.Windows.Forms.Button();
            this.dateBeforeTime = new System.Windows.Forms.Button();
            this.dateAfterSearchButton = new System.Windows.Forms.Button();
            this.orderFulfilledTableAdapter = new Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.OrderFulfilledTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.TableAdapterManager();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            orderDateTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderFulfilledDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderFulfilledBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDateTimeLabel
            // 
            orderDateTimeLabel.AutoSize = true;
            orderDateTimeLabel.Location = new System.Drawing.Point(485, 290);
            orderDateTimeLabel.Name = "orderDateTimeLabel";
            orderDateTimeLabel.Size = new System.Drawing.Size(59, 13);
            orderDateTimeLabel.TabIndex = 18;
            orderDateTimeLabel.Text = "Date Time:";
            // 
            // orderFulfilledDataGridView
            // 
            this.orderFulfilledDataGridView.AutoGenerateColumns = false;
            this.orderFulfilledDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderFulfilledDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.orderFulfilledDataGridView.DataSource = this.orderFulfilledBindingSource;
            this.orderFulfilledDataGridView.Location = new System.Drawing.Point(29, 268);
            this.orderFulfilledDataGridView.Name = "orderFulfilledDataGridView";
            this.orderFulfilledDataGridView.Size = new System.Drawing.Size(450, 174);
            this.orderFulfilledDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OrderId";
            this.dataGridViewTextBoxColumn6.HeaderText = "OrderId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FulfilledDateTime";
            this.dataGridViewTextBoxColumn7.HeaderText = "FulfilledDateTime";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // orderFulfilledBindingSource
            // 
            this.orderFulfilledBindingSource.DataMember = "OrderFulfilled";
            this.orderFulfilledBindingSource.DataSource = this.shelleyRestaurantDataSet;
            // 
            // shelleyRestaurantDataSet
            // 
            this.shelleyRestaurantDataSet.DataSetName = "ShelleyRestaurantDataSet";
            this.shelleyRestaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderfulfilledSearchButton
            // 
            this.orderfulfilledSearchButton.Location = new System.Drawing.Point(506, 326);
            this.orderfulfilledSearchButton.Name = "orderfulfilledSearchButton";
            this.orderfulfilledSearchButton.Size = new System.Drawing.Size(204, 23);
            this.orderfulfilledSearchButton.TabIndex = 16;
            this.orderfulfilledSearchButton.Text = "Search Orders Fulfilled After Date";
            this.orderfulfilledSearchButton.UseVisualStyleBackColor = true;
            this.orderfulfilledSearchButton.Click += new System.EventHandler(this.orderfulfilledSearchButton_Click);
            // 
            // dateBeforeTime
            // 
            this.dateBeforeTime.Location = new System.Drawing.Point(506, 355);
            this.dateBeforeTime.Name = "dateBeforeTime";
            this.dateBeforeTime.Size = new System.Drawing.Size(204, 23);
            this.dateBeforeTime.TabIndex = 17;
            this.dateBeforeTime.Text = "Order Date Before Time";
            this.dateBeforeTime.UseVisualStyleBackColor = true;
            this.dateBeforeTime.Click += new System.EventHandler(this.dateBeforeTime_Click);
            // 
            // dateAfterSearchButton
            // 
            this.dateAfterSearchButton.Location = new System.Drawing.Point(506, 384);
            this.dateAfterSearchButton.Name = "dateAfterSearchButton";
            this.dateAfterSearchButton.Size = new System.Drawing.Size(204, 23);
            this.dateAfterSearchButton.TabIndex = 18;
            this.dateAfterSearchButton.Text = "Order Date After Time";
            this.dateAfterSearchButton.UseVisualStyleBackColor = true;
            this.dateAfterSearchButton.Click += new System.EventHandler(this.dateAfterSearchButton_Click);
            // 
            // orderFulfilledTableAdapter
            // 
            this.orderFulfilledTableAdapter.ClearBeforeFill = true;
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
            this.ordersDataGridView.Location = new System.Drawing.Point(29, 42);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.Size = new System.Drawing.Size(736, 220);
            this.ordersDataGridView.TabIndex = 20;
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
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(550, 284);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // OrderReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(orderDateTimeLabel);
            this.Controls.Add(this.dateAfterSearchButton);
            this.Controls.Add(this.dateBeforeTime);
            this.Controls.Add(this.orderfulfilledSearchButton);
            this.Controls.Add(this.orderFulfilledDataGridView);
            this.Name = "OrderReportsForm";
            this.Text = "OrderReportsForm";
            this.Load += new System.EventHandler(this.OrderReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderFulfilledDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderFulfilledBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShelleyRestaurantDataSet shelleyRestaurantDataSet;
        private ShelleyRestaurantDataSetTableAdapters.OrderFulfilledTableAdapter orderFulfilledTableAdapter;
        private System.Windows.Forms.BindingSource orderFulfilledBindingSource;
        private System.Windows.Forms.DataGridView orderFulfilledDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button orderfulfilledSearchButton;
        private System.Windows.Forms.Button dateBeforeTime;
        private System.Windows.Forms.Button dateAfterSearchButton;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private ShelleyRestaurantDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private ShelleyRestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
    }
}