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
    public partial class InsertMenuItemsForm : Form
    {
        public InsertMenuItemsForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateMenuItemsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shelleyRestaurantDataSet.MenuItems' table. You can move, or remove it, as needed.
            this.menuItemsTableAdapter.Fill(this.shelleyRestaurantDataSet.MenuItems);

        }

        // Add Button Inserts into DB and saves
        private void addButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.menuItemsBindingSource.EndEdit();
            try { 
                this.tableAdapterManager.MenuItemsTableAdapter.Insert(menuItemNameTextBox.Text, menuItemDescriptionTextBox.Text, menuItemCategoryTextBox.Text, double.Parse(menuItemPriceTextBox.Text));
                this.menuItemsTableAdapter.Fill(this.shelleyRestaurantDataSet.MenuItems);
            } catch(Exception ex) {
                MessageBox.Show((string) ex.Message, "Use Valid Data such as Foreign Key Ids");
            }
        }
    }
}
