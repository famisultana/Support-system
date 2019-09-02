namespace PCSIR_Support_system
{
    partial class AddUser
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
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label userTypeLabel1;
            this.dataSet1 = new PCSIR_Support_system.DataSet1();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new PCSIR_Support_system.DataSet1TableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new PCSIR_Support_system.DataSet1TableAdapters.TableAdapterManager();
            this.deparmentsTableAdapter = new PCSIR_Support_system.DataSet1TableAdapters.DeparmentsTableAdapter();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.deparmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.userTypeComboBox = new System.Windows.Forms.ComboBox();
            userNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            userTypeLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deparmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(161, 109);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(93, 20);
            userNameLabel.TabIndex = 3;
            userNameLabel.Text = "User Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(161, 147);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(82, 20);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(161, 230);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(98, 20);
            departmentLabel.TabIndex = 9;
            departmentLabel.Text = "Department:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dataSet1;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComplaintsTableAdapter = null;
            this.tableAdapterManager.DeparmentsTableAdapter = this.deparmentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = PCSIR_Support_system.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // deparmentsTableAdapter
            // 
            this.deparmentsTableAdapter.ClearBeforeFill = true;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(272, 106);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(235, 26);
            this.userNameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(272, 144);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(235, 26);
            this.passwordTextBox.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource, "Department", true));
            this.comboBox1.DataSource = this.deparmentsBindingSource;
            this.comboBox1.DisplayMember = "DeptName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(272, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 28);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "DeptID";
            // 
            // deparmentsBindingSource
            // 
            this.deparmentsBindingSource.DataMember = "Deparments";
            this.deparmentsBindingSource.DataSource = this.dataSet1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add New User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // userTypeLabel1
            // 
            userTypeLabel1.AutoSize = true;
            userTypeLabel1.Location = new System.Drawing.Point(161, 191);
            userTypeLabel1.Name = "userTypeLabel1";
            userTypeLabel1.Size = new System.Drawing.Size(85, 20);
            userTypeLabel1.TabIndex = 12;
            userTypeLabel1.Text = "User Type:";
            // 
            // userTypeComboBox
            // 
            this.userTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserType", true));
            this.userTypeComboBox.FormattingEnabled = true;
            this.userTypeComboBox.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.userTypeComboBox.Location = new System.Drawing.Point(272, 188);
            this.userTypeComboBox.Name = "userTypeComboBox";
            this.userTypeComboBox.Size = new System.Drawing.Size(235, 28);
            this.userTypeComboBox.TabIndex = 13;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 420);
            this.Controls.Add(userTypeLabel1);
            this.Controls.Add(this.userTypeComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(departmentLabel);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deparmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private DataSet1TableAdapters.DeparmentsTableAdapter deparmentsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource deparmentsBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox userTypeComboBox;
    }
}