namespace Shelley_Capstone
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updateUsersButton = new System.Windows.Forms.Button();
            this.updateMenuItemsButton = new System.Windows.Forms.Button();
            this.updateOrdersButton = new System.Windows.Forms.Button();
            this.ordersReportsButton = new System.Windows.Forms.Button();
            this.inventoryReportsButton = new System.Windows.Forms.Button();
            this.updateInventoryButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(831, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // updateUsersButton
            // 
            this.updateUsersButton.Location = new System.Drawing.Point(59, 331);
            this.updateUsersButton.Name = "updateUsersButton";
            this.updateUsersButton.Size = new System.Drawing.Size(110, 23);
            this.updateUsersButton.TabIndex = 1;
            this.updateUsersButton.Text = "Update Users";
            this.updateUsersButton.UseVisualStyleBackColor = true;
            this.updateUsersButton.Click += new System.EventHandler(this.updateUsersButton_Click);
            // 
            // updateMenuItemsButton
            // 
            this.updateMenuItemsButton.Location = new System.Drawing.Point(204, 331);
            this.updateMenuItemsButton.Name = "updateMenuItemsButton";
            this.updateMenuItemsButton.Size = new System.Drawing.Size(110, 23);
            this.updateMenuItemsButton.TabIndex = 2;
            this.updateMenuItemsButton.Text = "Update Menu Items";
            this.updateMenuItemsButton.UseVisualStyleBackColor = true;
            this.updateMenuItemsButton.Click += new System.EventHandler(this.updateMenuItemsButton_Click);
            // 
            // updateOrdersButton
            // 
            this.updateOrdersButton.Location = new System.Drawing.Point(341, 331);
            this.updateOrdersButton.Name = "updateOrdersButton";
            this.updateOrdersButton.Size = new System.Drawing.Size(110, 23);
            this.updateOrdersButton.TabIndex = 3;
            this.updateOrdersButton.Text = "Update Orders";
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
            this.updateInventoryButton.Text = "Update Inventory";
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
            // ViewMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 526);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.updateInventoryButton);
            this.Controls.Add(this.inventoryReportsButton);
            this.Controls.Add(this.ordersReportsButton);
            this.Controls.Add(this.updateOrdersButton);
            this.Controls.Add(this.updateMenuItemsButton);
            this.Controls.Add(this.updateUsersButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewMenuForm";
            this.Text = "View Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updateUsersButton;
        private System.Windows.Forms.Button updateMenuItemsButton;
        private System.Windows.Forms.Button updateOrdersButton;
        private System.Windows.Forms.Button ordersReportsButton;
        private System.Windows.Forms.Button inventoryReportsButton;
        private System.Windows.Forms.Button updateInventoryButton;
        private System.Windows.Forms.Button closeButton;
    }
}