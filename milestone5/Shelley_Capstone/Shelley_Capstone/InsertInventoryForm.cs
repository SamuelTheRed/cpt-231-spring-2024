using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shelley_Capstone
{
    public partial class InsertInventoryForm : Form
    {
        public InsertInventoryForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateInventoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shelleyRestaurantDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.shelleyRestaurantDataSet.Inventory);

        }

        // Add Button Inserts into DB and saves
        private void addButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            try { 
                this.tableAdapterManager.InventoryTableAdapter.Insert(inventoryCodeTextBox.Text, inventoryDescriptionTextBox.Text, (int) quantityNumSelect.Value);
                this.inventoryTableAdapter.Fill(this.shelleyRestaurantDataSet.Inventory);
            } catch(Exception ex) {
                MessageBox.Show((string) ex.Message, "Use Valid Data including Foreign Keys Ids");
            }
        }
    }
}
