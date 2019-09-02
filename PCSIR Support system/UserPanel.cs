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
    public partial class UserPanel : Form
    {
        public int id, dept;
        public UserPanel(int id, int dept)
        {
            
            InitializeComponent();
            this.id = id;
            this.dept = dept;
          
        }

        private void SubmitComplaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubmitComplaint comp = new SubmitComplaint(id,dept);
            comp.MdiParent = this;
            comp.Show();

        }

        private void ViewMyComplaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // UserComplaint form = new UserComplaint(dept);
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            
        }
    }
}
