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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            

        }

        private void AddUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser form = new AddUser();
            form.MdiParent = this;
            form.Show();
        }

        private void ViewComplaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewComplaints form = new ViewComplaints();
            form.MdiParent = this;
            form.Show();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
