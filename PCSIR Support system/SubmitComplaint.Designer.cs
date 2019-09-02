namespace PCSIR_Support_system
{
    partial class SubmitComplaint
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
            System.Windows.Forms.Label subjectLabel;
            System.Windows.Forms.Label complaintLabel;
            this.complaintsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PCSIR_Support_system.DataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.complaintTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.complaintsTableAdapter = new PCSIR_Support_system.DataSet1TableAdapters.ComplaintsTableAdapter();
            this.tableAdapterManager = new PCSIR_Support_system.DataSet1TableAdapters.TableAdapterManager();
            this.isResolvedCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            subjectLabel = new System.Windows.Forms.Label();
            complaintLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.complaintsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Location = new System.Drawing.Point(60, 133);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new System.Drawing.Size(67, 20);
            subjectLabel.TabIndex = 15;
            subjectLabel.Text = "Subject:";
            // 
            // complaintLabel
            // 
            complaintLabel.AutoSize = true;
            complaintLabel.Location = new System.Drawing.Point(59, 189);
            complaintLabel.Name = "complaintLabel";
            complaintLabel.Size = new System.Drawing.Size(84, 20);
            complaintLabel.TabIndex = 17;
            complaintLabel.Text = "Complaint:";
            // 
            // complaintsBindingSource
            // 
            this.complaintsBindingSource.DataMember = "Complaints";
            this.complaintsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaintsBindingSource, "UserID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(418, 240);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(66, 26);
            this.userIDTextBox.TabIndex = 14;
            this.userIDTextBox.TextChanged += new System.EventHandler(this.UserIDTextBox_TextChanged);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaintsBindingSource, "Subject", true));
            this.subjectTextBox.Location = new System.Drawing.Point(171, 130);
            this.subjectTextBox.Multiline = true;
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(583, 38);
            this.subjectTextBox.TabIndex = 16;
            // 
            // complaintTextBox
            // 
            this.complaintTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaintsBindingSource, "Complaint", true));
            this.complaintTextBox.Location = new System.Drawing.Point(170, 189);
            this.complaintTextBox.Multiline = true;
            this.complaintTextBox.Name = "complaintTextBox";
            this.complaintTextBox.Size = new System.Drawing.Size(583, 189);
            this.complaintTextBox.TabIndex = 18;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaintsBindingSource, "Department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(506, 240);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(111, 26);
            this.departmentTextBox.TabIndex = 20;
            // 
            // complaintsTableAdapter
            // 
            this.complaintsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComplaintsTableAdapter = this.complaintsTableAdapter;
            this.tableAdapterManager.DeparmentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PCSIR_Support_system.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // isResolvedCheckBox
            // 
            this.isResolvedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.complaintsBindingSource, "isResolved", true));
            this.isResolvedCheckBox.Location = new System.Drawing.Point(689, 411);
            this.isResolvedCheckBox.Name = "isResolvedCheckBox";
            this.isResolvedCheckBox.Size = new System.Drawing.Size(43, 34);
            this.isResolvedCheckBox.TabIndex = 24;
            this.isResolvedCheckBox.Text = "checkBox1";
            this.isResolvedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 47);
            this.label1.TabIndex = 25;
            this.label1.Text = "SUBMIT YOUR COMPLAINT";
            // 
            // SubmitComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.isResolvedCheckBox);
            this.Controls.Add(this.complaintTextBox);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(subjectLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(complaintLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Name = "SubmitComplaint";
            this.Text = "Complaint";
            this.Load += new System.EventHandler(this.Complaint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.complaintsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource complaintsBindingSource;
        private DataSet1TableAdapters.ComplaintsTableAdapter complaintsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox complaintTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.CheckBox isResolvedCheckBox;
        private System.Windows.Forms.Label label1;
    }
}