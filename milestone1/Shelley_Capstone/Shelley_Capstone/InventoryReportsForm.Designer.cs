namespace Shelley_Capstone
{
    partial class InventoryReportsForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchParamTextBox = new System.Windows.Forms.TextBox();
            this.idSearchButton = new System.Windows.Forms.Button();
            this.nameSearchButton = new System.Windows.Forms.Button();
            this.quantitySearchButton = new System.Windows.Forms.Button();
            this.priceSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(357, 403);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(85, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 199);
            this.dataGridView1.TabIndex = 2;
            // 
            // searchParamTextBox
            // 
            this.searchParamTextBox.Location = new System.Drawing.Point(250, 275);
            this.searchParamTextBox.Name = "searchParamTextBox";
            this.searchParamTextBox.Size = new System.Drawing.Size(290, 20);
            this.searchParamTextBox.TabIndex = 3;
            // 
            // idSearchButton
            // 
            this.idSearchButton.Location = new System.Drawing.Point(176, 328);
            this.idSearchButton.Name = "idSearchButton";
            this.idSearchButton.Size = new System.Drawing.Size(107, 23);
            this.idSearchButton.TabIndex = 4;
            this.idSearchButton.Text = "Search by ID";
            this.idSearchButton.UseVisualStyleBackColor = true;
            // 
            // nameSearchButton
            // 
            this.nameSearchButton.Location = new System.Drawing.Point(289, 328);
            this.nameSearchButton.Name = "nameSearchButton";
            this.nameSearchButton.Size = new System.Drawing.Size(107, 23);
            this.nameSearchButton.TabIndex = 5;
            this.nameSearchButton.Text = "Search by Name";
            this.nameSearchButton.UseVisualStyleBackColor = true;
            // 
            // quantitySearchButton
            // 
            this.quantitySearchButton.Location = new System.Drawing.Point(402, 328);
            this.quantitySearchButton.Name = "quantitySearchButton";
            this.quantitySearchButton.Size = new System.Drawing.Size(107, 23);
            this.quantitySearchButton.TabIndex = 6;
            this.quantitySearchButton.Text = "Search by Quantity";
            this.quantitySearchButton.UseVisualStyleBackColor = true;
            // 
            // priceSearchButton
            // 
            this.priceSearchButton.Location = new System.Drawing.Point(515, 328);
            this.priceSearchButton.Name = "priceSearchButton";
            this.priceSearchButton.Size = new System.Drawing.Size(107, 23);
            this.priceSearchButton.TabIndex = 7;
            this.priceSearchButton.Text = "Search by Price";
            this.priceSearchButton.UseVisualStyleBackColor = true;
            // 
            // InventoryReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.priceSearchButton);
            this.Controls.Add(this.quantitySearchButton);
            this.Controls.Add(this.nameSearchButton);
            this.Controls.Add(this.idSearchButton);
            this.Controls.Add(this.searchParamTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.closeButton);
            this.Name = "InventoryReportsForm";
            this.Text = "InventoryReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchParamTextBox;
        private System.Windows.Forms.Button idSearchButton;
        private System.Windows.Forms.Button nameSearchButton;
        private System.Windows.Forms.Button quantitySearchButton;
        private System.Windows.Forms.Button priceSearchButton;
    }
}