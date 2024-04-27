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
    public partial class SearchOrdersForm : Form
    {
        public SearchOrdersForm()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shelleyRestaurantDataSet);

        }

        private void SearchOrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shelleyRestaurantDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.shelleyRestaurantDataSet.Orders);

        }

        private void dateTimeSearchButton_Click(object sender, EventArgs e)
        {
            this.ordersTableAdapter.SearchDateTime(this.shelleyRestaurantDataSet.Orders, searchParamTextBox.Text);
        }

        private void numberSearchButton_Click(object sender, EventArgs e)
        {
            int num;
            int.TryParse(searchParamTextBox.Text, out num);
            this.ordersTableAdapter.SearchNumber(this.shelleyRestaurantDataSet.Orders, num);
        }

        private void userSearchButton_Click(object sender, EventArgs e)
        {
            int num;
            int.TryParse(searchParamTextBox.Text, out num);
            this.ordersTableAdapter.SearchUser(this.shelleyRestaurantDataSet.Orders, num);
        }

        private void tableSearchButton_Click(object sender, EventArgs e)
        {
            int num;
            int.TryParse(searchParamTextBox.Text, out num);
            this.ordersTableAdapter.SearchTable(this.shelleyRestaurantDataSet.Orders, num);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetSearchButton_Click(object sender, EventArgs e)
        {
            this.ordersTableAdapter.Fill(this.shelleyRestaurantDataSet.Orders);
        }
    }
}
