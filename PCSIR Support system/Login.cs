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
    public partial class Form2 : Form
    {
        public string id;
        public string dept;
        public Form2()
        {
            InitializeComponent();
        }

        private void UsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Deparments' table. You can move, or remove it, as needed.
            this.deparmentsTableAdapter.Fill(this.dataSet1.Deparments);
            // TODO: This line of code loads data into the 'dataSet1.Users' table. You can move, or remove it, as needed.
            //  this.usersTableAdapter.Fill(this.dataSet1.Users);

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            this.usersTableAdapter.FillByUserID(this.dataSet1.Users, userNameTextBox.Text, passwordTextBox.Text);

            id = userIDTextBox.Text;
            dept = departmentTextBox1.Text;
                

            int count = 0;
            count= dataSet1.Users.Rows.Count;          
            
          
            if (count > 0)
            {
                if(userTypeTextBox.Text == "admin")
                {
   
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    UserPanel UP = new UserPanel ( Int32.Parse(id), Int32.Parse(dept));
                    UP.Show();
                    this.Hide();
                }

             
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
            
        }

        private void UserIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
