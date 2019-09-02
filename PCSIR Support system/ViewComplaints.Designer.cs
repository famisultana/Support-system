namespace PCSIR_Support_system
{
    partial class ViewComplaints
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataSet1 = new PCSIR_Support_system.DataSet1();
            this.complaintsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.complaintsTableAdapter = new PCSIR_Support_system.DataSet1TableAdapters.ComplaintsTableAdapter();
            this.tableAdapterManager = new PCSIR_Support_system.DataSet1TableAdapters.TableAdapterManager();
            this.deparmentsTableAdapter = new PCSIR_Support_system.DataSet1TableAdapters.DeparmentsTableAdapter();
            this.usersTableAdapter = new PCSIR_Support_system.DataSet1TableAdapters.UsersTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.complaintIDLabel1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.complaint_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.complaint_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deparmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.complaint_viewTableAdapter = new PCSIR_Support_system.DataSet1TableAdapters.Complaint_viewTableAdapter();
            this.complaintIDLabel2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.complaint_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaint_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deparmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // complaintsBindingSource
            // 
            this.complaintsBindingSource.DataMember = "Complaints";
            this.complaintsBindingSource.DataSource = this.dataSet1;
            // 
            // complaintsTableAdapter
            // 
            this.complaintsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComplaintsTableAdapter = this.complaintsTableAdapter;
            this.tableAdapterManager.DeparmentsTableAdapter = this.deparmentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = PCSIR_Support_system.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // deparmentsTableAdapter
            // 
            this.deparmentsTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.complaintIDLabel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.complaint_viewDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(45, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 355);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // complaintIDLabel1
            // 
            this.complaintIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaintsBindingSource, "ComplaintID", true));
            this.complaintIDLabel1.Location = new System.Drawing.Point(50, 470);
            this.complaintIDLabel1.Name = "complaintIDLabel1";
            this.complaintIDLabel1.Size = new System.Drawing.Size(115, 23);
            this.complaintIDLabel1.TabIndex = 9;
            this.complaintIDLabel1.Text = "Complaint no.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1069, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "View Complaint";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // complaint_viewDataGridView
            // 
            this.complaint_viewDataGridView.AllowUserToDeleteRows = false;
            this.complaint_viewDataGridView.AutoGenerateColumns = false;
            this.complaint_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.complaint_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.complaint_viewDataGridView.DataSource = this.complaint_viewBindingSource;
            this.complaint_viewDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.complaint_viewDataGridView.Location = new System.Drawing.Point(3, 22);
            this.complaint_viewDataGridView.Name = "complaint_viewDataGridView";
            this.complaint_viewDataGridView.ReadOnly = true;
            this.complaint_viewDataGridView.RowHeadersWidth = 62;
            this.complaint_viewDataGridView.RowTemplate.Height = 28;
            this.complaint_viewDataGridView.Size = new System.Drawing.Size(1012, 330);
            this.complaint_viewDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ComplaintID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ComplaintID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn5.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DeptName";
            this.dataGridViewTextBoxColumn4.HeaderText = "DeptName";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Subject";
            this.dataGridViewTextBoxColumn2.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Complaint";
            this.dataGridViewTextBoxColumn3.HeaderText = "Complaint";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "isResolved";
            this.dataGridViewCheckBoxColumn1.HeaderText = "isResolved";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // complaint_viewBindingSource
            // 
            this.complaint_viewBindingSource.DataMember = "Complaint_view";
            this.complaint_viewBindingSource.DataSource = this.dataSet1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(784, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Search by Department";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 123);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(716, 33);
            this.textBox2.TabIndex = 10;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dataSet1;
            // 
            // deparmentsBindingSource
            // 
            this.deparmentsBindingSource.DataMember = "Deparments";
            this.deparmentsBindingSource.DataSource = this.dataSet1;
            // 
            // complaint_viewTableAdapter
            // 
            this.complaint_viewTableAdapter.ClearBeforeFill = true;
            // 
            // complaintIDLabel2
            // 
            this.complaintIDLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaint_viewBindingSource, "ComplaintID", true));
            this.complaintIDLabel2.Location = new System.Drawing.Point(44, 539);
            this.complaintIDLabel2.Name = "complaintIDLabel2";
            this.complaintIDLabel2.Size = new System.Drawing.Size(113, 26);
            this.complaintIDLabel2.TabIndex = 12;
            this.complaintIDLabel2.Text = "Complaint No.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(858, 533);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 32);
            this.button3.TabIndex = 13;
            this.button3.Text = "View Complaint";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 47);
            this.label1.TabIndex = 14;
            this.label1.Text = "USER COMPLAINTS";
            // 
            // ViewComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.complaintIDLabel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Name = "ViewComplaints";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewComplaints";
            this.Load += new System.EventHandler(this.ViewComplaints_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.complaint_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaint_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deparmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource complaintsBindingSource;
        private DataSet1TableAdapters.ComplaintsTableAdapter complaintsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label complaintIDLabel1;
        private System.Windows.Forms.Button button1;
        private DataSet1TableAdapters.DeparmentsTableAdapter deparmentsTableAdapter;
        private System.Windows.Forms.BindingSource deparmentsBindingSource;
        private DataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource complaint_viewBindingSource;
        private DataSet1TableAdapters.Complaint_viewTableAdapter complaint_viewTableAdapter;
        private System.Windows.Forms.DataGridView complaint_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label complaintIDLabel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}