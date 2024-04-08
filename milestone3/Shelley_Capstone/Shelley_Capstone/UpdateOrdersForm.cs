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
    public partial class UpdateOrdersForm : Form
    {
        public UpdateOrdersForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UpdateOrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shelleyRestaurantDataSet.OrderFulfilled' table. You can move, or remove it, as needed.
            this.orderFulfilledTableAdapter.Fill(this.shelleyRestaurantDataSet.OrderFulfilled);
            // TODO: This line of code loads data into the 'shelleyRestaurantDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.shelleyRestaurantDataSet.Orders);

        }

        // Add Button Inserts into DB and saves
        private void addButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            try { 
                this.tableAdapterManager.OrdersTableAdapter.Insert(DateTime.Parse(orderDateTimeDateTimePicker.Text), (int) orderNumSelect.Value, (int) userIdNumSelect.Value, (int) tableIdNumSelect.Value);
                this.ordersTableAdapter.Fill(this.shelleyRestaurantDataSet.Orders);
            } catch(Exception ex) {
                MessageBox.Show((string)ex.Message, "Use Valid Data including Foreign Keys Ids");
            }
        }
    }
}
