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
    public partial class Complaint : Form
    {
        public string id;
        public Complaint(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void Complaint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Complaint_view' table. You can move, or remove it, as needed.
            this.complaint_viewTableAdapter.FillByComplaintID(this.dataSet1.Complaint_view,Int32.Parse(this.id));

        }

        private void DeptNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void DeptNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.complaint_viewBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            this.Hide();
        }
    }
}
