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
    public partial class UserComplaint : Form
    {
        public string dept;
        public UserComplaint(string dept)
        {
            InitializeComponent();
            this.dept = dept;
        }

        private void UserComplaint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Complaint_view' table. You can move, or remove it, as needed.
            this.complaint_viewTableAdapter.FillByDeptName(this.dataSet1.Complaint_view,this.dept);

        }
    }
}
