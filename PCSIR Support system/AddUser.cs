using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCSIR_Support_system
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void UsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Deparments' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dataSet1.Users);
            // TODO: This line of code loads data into the 'dataSet1.Users' table. You can move, or remove it, as needed.
            usersBindingSource.AddNew();
            
           this.deparmentsTableAdapter.Fill(this.dataSet1.Deparments);

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            MessageBox.Show("New User added");
            this.Hide();
        }

        private void UsersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
