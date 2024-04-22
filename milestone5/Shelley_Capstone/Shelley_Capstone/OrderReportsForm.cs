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
    public partial class OrderReportsForm : Form
    {
        public OrderReportsForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shelleyRestaurantDataSet);

        }

        private void OrderReportsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shelleyRestaurantDataSet.OrderFulfilled' table. You can move, or remove it, as needed.
            this.orderFulfilledTableAdapter.Fill(this.shelleyRestaurantDataSet.OrderFulfilled);
            // TODO: This line of code loads data into the 'shelleyRestaurantDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.shelleyRestaurantDataSet.Orders);

        }

        private void ordersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shelleyRestaurantDataSet);

        }

        private void orderfulfilledSearchButton_Click(object sender, EventArgs e)
        {
            this.orderFulfilledTableAdapter.FillBy(this.shelleyRestaurantDataSet.OrderFulfilled, dateTimePicker.Value.ToString());
            label1.Text = dateTimePicker.Value.ToString().Substring(0,17);
        }

        private void dateBeforeTime_Click(object sender, EventArgs e)
        {
            this.ordersTableAdapter.FillByDateBefore(this.shelleyRestaurantDataSet.Orders, dateTimePicker.Value.ToString());
            label1.Text = dateTimePicker.Value.ToString().Substring(0, 17);
        }

        private void dateAfterSearchButton_Click(object sender, EventArgs e)
        {
            this.ordersTableAdapter.FillByDateAfter(this.shelleyRestaurantDataSet.Orders, dateTimePicker.Value.ToString());
            label1.Text = dateTimePicker.Value.ToString().Substring(0, 17);
        }
    }
}
