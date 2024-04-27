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
    public partial class InsertUsersForm : Form
    {
        public InsertUsersForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateUsersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shelleyRestaurantDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.shelleyRestaurantDataSet.Users);

        }

        // Add Button Inserts into DB and saves
        private void addButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            try { 
                this.tableAdapterManager.UsersTableAdapter.Insert(userNameTextBox.Text, userPasswordTextBox.Text);
                this.usersTableAdapter.Fill(this.shelleyRestaurantDataSet.Users);
            } catch(Exception ex) {
                MessageBox.Show((string) ex.Message, "Use Valid Data");
            }
        }
    }
}
