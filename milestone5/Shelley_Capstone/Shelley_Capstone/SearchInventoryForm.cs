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
    public partial class SearchInventoryForm : Form
    {
        public SearchInventoryForm()
        {
            InitializeComponent();
        }

        private void inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shelleyRestaurantDataSet);

        }

        private void SearchInventoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shelleyRestaurantDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.shelleyRestaurantDataSet.Inventory);

        }

        private void codeSearchButton_Click(object sender, EventArgs e)
        {
            this.inventoryTableAdapter.SearchCode(this.shelleyRestaurantDataSet.Inventory, searchParamTextBox.Text);
        }

        private void quantitySearchButton_Click(object sender, EventArgs e)
        {
            int num;
            int.TryParse(searchParamTextBox.Text, out num);
            this.inventoryTableAdapter.SearchQuantity(this.shelleyRestaurantDataSet.Inventory, num);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetSearchButton_Click(object sender, EventArgs e)
        {
            this.inventoryTableAdapter.Fill(this.shelleyRestaurantDataSet.Inventory);
        }
    }
}
