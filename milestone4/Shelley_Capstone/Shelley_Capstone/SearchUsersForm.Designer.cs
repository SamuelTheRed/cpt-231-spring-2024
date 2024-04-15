namespace Shelley_Capstone
{
    partial class SearchUsersForm
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
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shelleyRestaurantDataSet = new Shelley_Capstone.ShelleyRestaurantDataSet();
            this.nameSearchButton = new System.Windows.Forms.Button();
            this.idSearchButton = new System.Windows.Forms.Button();
            this.searchParamTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.usersTableAdapter = new Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.TableAdapterManager();
            this.resetSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.usersDataGridView.DataSource = this.usersBindingSource;
            this.usersDataGridView.Location = new System.Drawing.Point(26, 46);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.Size = new System.Drawing.Size(725, 203);
            this.usersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserId";
            this.dataGridViewTextBoxColumn1.HeaderText = "UserId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn2.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UserPassword";
            this.dataGridViewTextBoxColumn3.HeaderText = "UserPassword";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.shelleyRestaurantDataSet;
            // 
            // shelleyRestaurantDataSet
            // 
            this.shelleyRestaurantDataSet.DataSetName = "ShelleyRestaurantDataSet";
            this.shelleyRestaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameSearchButton
            // 
            this.nameSearchButton.Location = new System.Drawing.Point(378, 320);
            this.nameSearchButton.Name = "nameSearchButton";
            this.nameSearchButton.Size = new System.Drawing.Size(107, 23);
            this.nameSearchButton.TabIndex = 18;
            this.nameSearchButton.Text = "Search by Name";
            this.nameSearchButton.UseVisualStyleBackColor = true;
            this.nameSearchButton.Click += new System.EventHandler(this.nameSearchButton_Click);
            // 
            // idSearchButton
            // 
            this.idSearchButton.Location = new System.Drawing.Point(265, 320);
            this.idSearchButton.Name = "idSearchButton";
            this.idSearchButton.Size = new System.Drawing.Size(107, 23);
            this.idSearchButton.TabIndex = 17;
            this.idSearchButton.Text = "Search by ID";
            this.idSearchButton.UseVisualStyleBackColor = true;
            this.idSearchButton.Click += new System.EventHandler(this.idSearchButton_Click);
            // 
            // searchParamTextBox
            // 
            this.searchParamTextBox.Location = new System.Drawing.Point(228, 294);
            this.searchParamTextBox.Name = "searchParamTextBox";
            this.searchParamTextBox.Size = new System.Drawing.Size(290, 20);
            this.searchParamTextBox.TabIndex = 16;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(337, 399);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 15;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.MenuItemsTableAdapter = null;
            this.tableAdapterManager.OrderFulfilledTableAdapter = null;
            this.tableAdapterManager.OrderItemTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Shelley_Capstone.ShelleyRestaurantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // resetSearchButton
            // 
            this.resetSearchButton.Location = new System.Drawing.Point(285, 349);
            this.resetSearchButton.Name = "resetSearchButton";
            this.resetSearchButton.Size = new System.Drawing.Size(188, 23);
            this.resetSearchButton.TabIndex = 27;
            this.resetSearchButton.Text = "Reset Table View";
            this.resetSearchButton.UseVisualStyleBackColor = true;
            this.resetSearchButton.Click += new System.EventHandler(this.resetSearchButton_Click);
            // 
            // SearchUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetSearchButton);
            this.Controls.Add(this.nameSearchButton);
            this.Controls.Add(this.idSearchButton);
            this.Controls.Add(this.searchParamTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.usersDataGridView);
            this.Name = "SearchUsersForm";
            this.Text = "SearchUsersForm";
            this.Load += new System.EventHandler(this.SearchUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelleyRestaurantDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShelleyRestaurantDataSet shelleyRestaurantDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private ShelleyRestaurantDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private ShelleyRestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button nameSearchButton;
        private System.Windows.Forms.Button idSearchButton;
        private System.Windows.Forms.TextBox searchParamTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button resetSearchButton;
    }
}