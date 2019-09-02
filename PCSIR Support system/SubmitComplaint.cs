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
    public partial class SubmitComplaint : Form
    {

        public int id, dept;
        public SubmitComplaint(int id, int dept)
        {
            InitializeComponent();
            this.id = id;
            this.dept = dept;
        }

        private void ComplaintsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.complaintsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Complaint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Complaints' table. You can move, or remove it, as needed.
            //  this.complaintsTableAdapter.Fill(this.dataSet1.Complaints);
            complaintsBindingSource.AddNew();
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            userIDTextBox.Text = id.ToString();
            departmentTextBox.Text = dept.ToString();
            isResolvedCheckBox.Checked=false;
            this.Validate();
            this.complaintsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

            MessageBox.Show("record saved");
        }

        private void IsResolvedCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ComplaintsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void UserIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
