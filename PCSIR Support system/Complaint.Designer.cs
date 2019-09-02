namespace PCSIR_Support_system
{
    partial class Complaint
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
            System.Windows.Forms.Label isResolvedLabel;
            System.Windows.Forms.Label subjectLabel;
            System.Windows.Forms.Label complaintLabel;
            System.Windows.Forms.Label deptNameLabel;
            System.Windows.Forms.Label userNameLabel;
            this.dataSet1 = new PCSIR_Support_system.DataSet1();
            this.complaint_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.complaint_viewTableAdapter = new PCSIR_Support_system.DataSet1TableAdapters.Complaint_viewTableAdapter();
            this.tableAdapterManager = new PCSIR_Support_system.DataSet1TableAdapters.TableAdapterManager();
            this.isResolvedCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.subjectLabel1 = new System.Windows.Forms.Label();
            this.complaintLabel1 = new System.Windows.Forms.Label();
            this.deptNameLabel1 = new System.Windows.Forms.Label();
            this.userNameLabel1 = new System.Windows.Forms.Label();
            isResolvedLabel = new System.Windows.Forms.Label();
            subjectLabel = new System.Windows.Forms.Label();
            complaintLabel = new System.Windows.Forms.Label();
            deptNameLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaint_viewBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // isResolvedLabel
            // 
            isResolvedLabel.AutoSize = true;
            isResolvedLabel.Location = new System.Drawing.Point(28, 277);
            isResolvedLabel.Name = "isResolvedLabel";
            isResolvedLabel.Size = new System.Drawing.Size(79, 20);
            isResolvedLabel.TabIndex = 5;
            isResolvedLabel.Text = "Resolved:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // complaint_viewBindingSource
            // 
            this.complaint_viewBindingSource.DataMember = "Complaint_view";
            this.complaint_viewBindingSource.DataSource = this.dataSet1;
            // 
            // complaint_viewTableAdapter
            // 
            this.complaint_viewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComplaintsTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DeparmentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PCSIR_Support_system.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // isResolvedCheckBox
            // 
            this.isResolvedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.complaint_viewBindingSource, "isResolved", true));
            this.isResolvedCheckBox.Location = new System.Drawing.Point(128, 272);
            this.isResolvedCheckBox.Name = "isResolvedCheckBox";
            this.isResolvedCheckBox.Size = new System.Drawing.Size(126, 25);
            this.isResolvedCheckBox.TabIndex = 6;
            this.isResolvedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "USER COMPLAINT";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(subjectLabel);
            this.groupBox1.Controls.Add(this.subjectLabel1);
            this.groupBox1.Controls.Add(complaintLabel);
            this.groupBox1.Controls.Add(this.complaintLabel1);
            this.groupBox1.Controls.Add(deptNameLabel);
            this.groupBox1.Controls.Add(this.deptNameLabel1);
            this.groupBox1.Controls.Add(userNameLabel);
            this.groupBox1.Controls.Add(this.userNameLabel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(isResolvedLabel);
            this.groupBox1.Controls.Add(this.isResolvedCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(39, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 376);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Location = new System.Drawing.Point(28, 85);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new System.Drawing.Size(67, 20);
            subjectLabel.TabIndex = 12;
            subjectLabel.Text = "Subject:";
            // 
            // subjectLabel1
            // 
            this.subjectLabel1.BackColor = System.Drawing.Color.Silver;
            this.subjectLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaint_viewBindingSource, "Subject", true));
            this.subjectLabel1.Location = new System.Drawing.Point(128, 85);
            this.subjectLabel1.Name = "subjectLabel1";
            this.subjectLabel1.Padding = new System.Windows.Forms.Padding(2);
            this.subjectLabel1.Size = new System.Drawing.Size(782, 29);
            this.subjectLabel1.TabIndex = 13;
            // 
            // complaintLabel
            // 
            complaintLabel.AutoSize = true;
            complaintLabel.Location = new System.Drawing.Point(28, 132);
            complaintLabel.Name = "complaintLabel";
            complaintLabel.Size = new System.Drawing.Size(84, 20);
            complaintLabel.TabIndex = 14;
            complaintLabel.Text = "Complaint:";
            // 
            // complaintLabel1
            // 
            this.complaintLabel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.complaintLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaint_viewBindingSource, "Complaint", true));
            this.complaintLabel1.Location = new System.Drawing.Point(128, 132);
            this.complaintLabel1.Name = "complaintLabel1";
            this.complaintLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.complaintLabel1.Size = new System.Drawing.Size(782, 122);
            this.complaintLabel1.TabIndex = 15;
            // 
            // deptNameLabel
            // 
            deptNameLabel.AutoSize = true;
            deptNameLabel.Location = new System.Drawing.Point(498, 41);
            deptNameLabel.Name = "deptNameLabel";
            deptNameLabel.Size = new System.Drawing.Size(144, 20);
            deptNameLabel.TabIndex = 18;
            deptNameLabel.Text = "Department Name:";
            // 
            // deptNameLabel1
            // 
            this.deptNameLabel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deptNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaint_viewBindingSource, "DeptName", true));
            this.deptNameLabel1.Location = new System.Drawing.Point(648, 41);
            this.deptNameLabel1.Name = "deptNameLabel1";
            this.deptNameLabel1.Padding = new System.Windows.Forms.Padding(2);
            this.deptNameLabel1.Size = new System.Drawing.Size(262, 23);
            this.deptNameLabel1.TabIndex = 19;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(28, 41);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(93, 20);
            userNameLabel.TabIndex = 20;
            userNameLabel.Text = "User Name:";
            // 
            // userNameLabel1
            // 
            this.userNameLabel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.userNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaint_viewBindingSource, "UserName", true));
            this.userNameLabel1.Location = new System.Drawing.Point(128, 41);
            this.userNameLabel1.Name = "userNameLabel1";
            this.userNameLabel1.Padding = new System.Windows.Forms.Padding(2);
            this.userNameLabel1.Size = new System.Drawing.Size(337, 23);
            this.userNameLabel1.TabIndex = 21;
            // 
            // Complaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Complaint";
            this.Text = "Complaint";
            this.Load += new System.EventHandler(this.Complaint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaint_viewBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource complaint_viewBindingSource;
        private DataSet1TableAdapters.Complaint_viewTableAdapter complaint_viewTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox isResolvedCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label subjectLabel1;
        private System.Windows.Forms.Label complaintLabel1;
        private System.Windows.Forms.Label deptNameLabel1;
        private System.Windows.Forms.Label userNameLabel1;
    }
}