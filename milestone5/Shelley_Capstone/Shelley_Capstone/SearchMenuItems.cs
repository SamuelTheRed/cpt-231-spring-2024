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
    public partial class SearchMenuItems : Form
    {
        public SearchMenuItems()
        {
            InitializeComponent();
        }

        private void menuItemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.menuItemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shelleyRestaurantDataSet);
        }

        private void SearchMenuItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shelleyRestaurantDataSet.MenuItems' table. You can move, or remove it, as needed.
            this.menuItemsTableAdapter.Fill(this.shelleyRestaurantDataSet.MenuItems);
        }

        private void categorySearchButton_Click(object sender, EventArgs e)
        {
            this.menuItemsTableAdapter.SearchCategory(this.shelleyRestaurantDataSet.MenuItems, searchParamTextBox.Text);
        }

        private void nameSearchButton_Click(object sender, EventArgs e)
        {
            this.menuItemsTableAdapter.SearchName(this.shelleyRestaurantDataSet.MenuItems, searchParamTextBox.Text);
        }

        private void priceSearchButton_Click(object sender, EventArgs e)
        {
            double num;
            double.TryParse(searchParamTextBox.Text, out num);
            this.menuItemsTableAdapter.SearchPrice(this.shelleyRestaurantDataSet.MenuItems, num);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetSearchButton_Click(object sender, EventArgs e)
        {
            this.menuItemsTableAdapter.Fill(this.shelleyRestaurantDataSet.MenuItems);
        }
    }
}
