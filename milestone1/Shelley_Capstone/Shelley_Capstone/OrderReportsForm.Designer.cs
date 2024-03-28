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
            this.closeButton = new System.Windows.Forms.Button();
            this.totalSearchButton = new System.Windows.Forms.Button();
            this.userSearchButton = new System.Windows.Forms.Button();
            this.dateSearchButton = new System.Windows.Forms.Button();
            this.idSearchButton = new System.Windows.Forms.Button();
            this.searchParamTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pastOrderCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(105, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 199);
            this.dataGridView1.TabIndex = 9;
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
            // OrderReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 494);
            this.Controls.Add(this.pastOrderCheckBox);
            this.Controls.Add(this.totalSearchButton);
            this.Controls.Add(this.userSearchButton);
            this.Controls.Add(this.dateSearchButton);
            this.Controls.Add(this.idSearchButton);
            this.Controls.Add(this.searchParamTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.closeButton);
            this.Name = "OrderReportsForm";
            this.Text = "OrderReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox pastOrderCheckBox;
    }
}