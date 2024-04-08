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
    public partial class ViewMenuForm : Form
    {
        public ViewMenuForm()
        {
            InitializeComponent();
        }

        private void updateUsersButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the update users form
            UpdateUsersForm updateUsersForm = new UpdateUsersForm();
            // Display the form
            updateUsersForm.ShowDialog();
        }

        private void updateMenuItemsButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the update menu items form
            UpdateMenuItemsForm updateMenuItemsForm = new UpdateMenuItemsForm();
            // Display the form
            updateMenuItemsForm.ShowDialog();
        }

        private void updateOrdersButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the update orders form
            UpdateOrdersForm updateOrdersForm = new UpdateOrdersForm();
            // Display the form
            updateOrdersForm.ShowDialog();
        }

        private void updateInventoryButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the update inventory form
            UpdateInventoryForm updateInventoryForm = new UpdateInventoryForm();
            // Display the form
            updateInventoryForm.ShowDialog();
        }

        private void ordersReportsButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the order reports form
            OrderReportsForm orderReportsForm = new OrderReportsForm();
            // Display the form
            orderReportsForm.ShowDialog();
        }

        private void inventoryReportsButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the order reports form
            InventoryReportsForm inventoryReportsForm = new InventoryReportsForm();
            // Display the form
            inventoryReportsForm.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.menuItemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shelleyRestaurantDataSet);

        }

        private void ViewMenuForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shelleyRestaurantDataSet.MenuItems' table. You can move, or remove it, as needed.
            this.menuItemsTableAdapter.Fill(this.shelleyRestaurantDataSet.MenuItems);

        }
    }
}
