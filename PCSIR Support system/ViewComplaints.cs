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
    public partial class ViewComplaints : Form
    {
        public ViewComplaints()
        {
            InitializeComponent();
        }

        private void ComplaintsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.complaintsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void ViewComplaints_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Complaint_view' table. You can move, or remove it, as needed.
            this.complaint_viewTableAdapter.Fill(this.dataSet1.Complaint_view);
            // TODO: This line of code loads data into the 'dataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dataSet1.Users);
            // TODO: This line of code loads data into the 'dataSet1.Deparments' table. You can move, or remove it, as needed.
            this.deparmentsTableAdapter.Fill(this.dataSet1.Deparments);
            // TODO: This line of code loads data into the 'dataSet1.Complaints' table. You can move, or remove it, as needed.
            this.complaintsTableAdapter.Fill(this.dataSet1.Complaints);

        }

        private void ComplaintsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComplaintIDLabel1_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.complaint_viewTableAdapter.FillByDeptName(this.dataSet1.Complaint_view, "%"+textBox2.Text+"%");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Complaint comp = new Complaint(complaintIDLabel2.Text);
            comp.Show();
            this.Hide();
        }
    }
}
