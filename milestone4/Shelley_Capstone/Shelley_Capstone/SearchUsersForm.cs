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
    public partial class SearchUsersForm : Form
    {
        public SearchUsersForm()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shelleyRestaurantDataSet);

        }

        private void SearchUsersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shelleyRestaurantDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.shelleyRestaurantDataSet.Users);
        }

        private void idSearchButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(searchParamTextBox.Text, out id);
            this.usersTableAdapter.SearchId(this.shelleyRestaurantDataSet.Users, id);
        }

        private void nameSearchButton_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.SearchName(this.shelleyRestaurantDataSet.Users, searchParamTextBox.Text);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetSearchButton_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.shelleyRestaurantDataSet.Users);
        }
    }
}
