namespace PCSIR_Support_system
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PCSIR_Support_system.DataSet1();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.usersTableAdapter = new PCSIR_Support_system.DataSet1TableAdapters.UsersTableAdapter();
            this.userTypeTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.deparmentsTableAdapter = new PCSIR_Support_system.DataSet1TableAdapters.DeparmentsTableAdapter();
            this.deparmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new PCSIR_Support_system.DataSet1TableAdapters.TableAdapterManager();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deparmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(410, 207);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(93, 20);
            userNameLabel.TabIndex = 3;
            userNameLabel.Text = "User Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(410, 250);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(82, 20);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(514, 201);
            this.userNameTextBox.Multiline = true;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(284, 29);
            this.userNameTextBox.TabIndex = 4;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(514, 250);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(284, 29);
            this.passwordTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(661, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // userTypeTextBox
            // 
            this.userTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserType", true));
            this.userTypeTextBox.Location = new System.Drawing.Point(770, 301);
            this.userTypeTextBox.Name = "userTypeTextBox";
            this.userTypeTextBox.Size = new System.Drawing.Size(21, 26);
            this.userTypeTextBox.TabIndex = 13;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(734, 301);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(30, 26);
            this.departmentTextBox.TabIndex = 14;
            // 
            // deparmentsTableAdapter
            // 
            this.deparmentsTableAdapter.ClearBeforeFill = true;
            // 
            // deparmentsBindingSource
            // 
            this.deparmentsBindingSource.DataMember = "Deparments";
            this.deparmentsBindingSource.DataSource = this.dataSet1;
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
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(514, 201);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(31, 26);
            this.userIDTextBox.TabIndex = 18;
            this.userIDTextBox.TextChanged += new System.EventHandler(this.UserIDTextBox_TextChanged);
            // 
            // departmentTextBox1
            // 
            this.departmentTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Department", true));
            this.departmentTextBox1.Location = new System.Drawing.Point(704, 301);
            this.departmentTextBox1.Name = "departmentTextBox1";
            this.departmentTextBox1.Size = new System.Drawing.Size(24, 26);
            this.departmentTextBox1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 42);
            this.label1.TabIndex = 21;
            this.label1.Text = "PCSIR SUPPORT SYSTEM";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "LOGIN";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(936, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.departmentTextBox1);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.userTypeTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deparmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox userTypeTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.BindingSource deparmentsBindingSource;
        private DataSet1TableAdapters.DeparmentsTableAdapter deparmentsTableAdapter;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox departmentTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}