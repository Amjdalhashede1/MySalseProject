namespace mySalseProject
{
    partial class frmUsers
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvShowResult = new System.Windows.Forms.DataGridView();
            this.cbxSearchByShowPassword = new System.Windows.Forms.CheckBox();
            this.cbxSearchByActive = new System.Windows.Forms.CheckBox();
            this.cbxSearch = new System.Windows.Forms.ComboBox();
            this.pcUsers = new System.Windows.Forms.PictureBox();
            this.rdbUserNotActive = new System.Windows.Forms.RadioButton();
            this.rdbUserActive = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cbxEmp = new mySalseProject.employee();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(105, 361);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 42);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnNew.Location = new System.Drawing.Point(264, 361);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(151, 42);
            this.btnNew.TabIndex = 32;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(433, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 42);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(590, 360);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(139, 42);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(745, 361);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 42);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "اضافة ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dgvShowResult
            // 
            this.dgvShowResult.AllowUserToAddRows = false;
            this.dgvShowResult.AllowUserToDeleteRows = false;
            this.dgvShowResult.AllowUserToOrderColumns = true;
            this.dgvShowResult.AllowUserToResizeColumns = false;
            this.dgvShowResult.AllowUserToResizeRows = false;
            this.dgvShowResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShowResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvShowResult.Location = new System.Drawing.Point(11, 143);
            this.dgvShowResult.Name = "dgvShowResult";
            this.dgvShowResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvShowResult.RowTemplate.Height = 29;
            this.dgvShowResult.Size = new System.Drawing.Size(451, 195);
            this.dgvShowResult.TabIndex = 28;
            this.dgvShowResult.SelectionChanged += new System.EventHandler(this.DgvShowResult_SelectionChanged);
            // 
            // cbxSearchByShowPassword
            // 
            this.cbxSearchByShowPassword.AutoSize = true;
            this.cbxSearchByShowPassword.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.cbxSearchByShowPassword.Location = new System.Drawing.Point(14, 54);
            this.cbxSearchByShowPassword.Name = "cbxSearchByShowPassword";
            this.cbxSearchByShowPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxSearchByShowPassword.Size = new System.Drawing.Size(163, 23);
            this.cbxSearchByShowPassword.TabIndex = 27;
            this.cbxSearchByShowPassword.Text = "اظهار كلمة المرور";
            this.cbxSearchByShowPassword.UseVisualStyleBackColor = true;
            this.cbxSearchByShowPassword.CheckedChanged += new System.EventHandler(this.CbxSearchByShowPassword_CheckedChanged);
            // 
            // cbxSearchByActive
            // 
            this.cbxSearchByActive.AutoSize = true;
            this.cbxSearchByActive.Checked = true;
            this.cbxSearchByActive.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbxSearchByActive.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.cbxSearchByActive.Location = new System.Drawing.Point(183, 55);
            this.cbxSearchByActive.Name = "cbxSearchByActive";
            this.cbxSearchByActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxSearchByActive.Size = new System.Drawing.Size(70, 23);
            this.cbxSearchByActive.TabIndex = 26;
            this.cbxSearchByActive.Text = "فعال";
            this.cbxSearchByActive.ThreeState = true;
            this.cbxSearchByActive.UseVisualStyleBackColor = true;
            this.cbxSearchByActive.CheckedChanged += new System.EventHandler(this.CbxSearchByActive_CheckedChanged);
            this.cbxSearchByActive.CheckStateChanged += new System.EventHandler(this.CbxSearchByActive_CheckStateChanged);
            // 
            // cbxSearch
            // 
            this.cbxSearch.FormattingEnabled = true;
            this.cbxSearch.Items.AddRange(new object[] {
            "الموظف",
            "اسم المستخدم"});
            this.cbxSearch.Location = new System.Drawing.Point(264, 55);
            this.cbxSearch.Name = "cbxSearch";
            this.cbxSearch.Size = new System.Drawing.Size(121, 27);
            this.cbxSearch.TabIndex = 25;
            this.cbxSearch.SelectedIndexChanged += new System.EventHandler(this.CbxSearch_SelectedIndexChanged);
            // 
            // pcUsers
            // 
            this.pcUsers.Location = new System.Drawing.Point(566, 41);
            this.pcUsers.Name = "pcUsers";
            this.pcUsers.Size = new System.Drawing.Size(82, 50);
            this.pcUsers.TabIndex = 24;
            this.pcUsers.TabStop = false;
            // 
            // rdbUserNotActive
            // 
            this.rdbUserNotActive.AutoSize = true;
            this.rdbUserNotActive.Location = new System.Drawing.Point(556, 218);
            this.rdbUserNotActive.Name = "rdbUserNotActive";
            this.rdbUserNotActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbUserNotActive.Size = new System.Drawing.Size(91, 23);
            this.rdbUserNotActive.TabIndex = 23;
            this.rdbUserNotActive.Text = "غير فعال";
            this.rdbUserNotActive.UseVisualStyleBackColor = true;
            // 
            // rdbUserActive
            // 
            this.rdbUserActive.AutoSize = true;
            this.rdbUserActive.Location = new System.Drawing.Point(680, 218);
            this.rdbUserActive.Name = "rdbUserActive";
            this.rdbUserActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbUserActive.Size = new System.Drawing.Size(64, 23);
            this.rdbUserActive.TabIndex = 22;
            this.rdbUserActive.Text = "فعال";
            this.rdbUserActive.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(521, 176);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(241, 27);
            this.txtPassword.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(344, 106);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(86, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "نص البحث";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(391, 58);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "بحث ب:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(788, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "حالة المستخدم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(788, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "كلمة المرور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(788, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "كلمة المرور";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(53, 103);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(285, 27);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(521, 143);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(241, 27);
            this.txtUserName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(788, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "اسم المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(788, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "الموظف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(654, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "شاشة المستخدمين";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "emp_no";
            this.Column1.HeaderText = "رقم الموظف";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 126;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "emp_name";
            this.Column2.HeaderText = "الموظف";
            this.Column2.Name = "Column2";
            this.Column2.Width = 97;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "username";
            this.Column3.HeaderText = "اسم المستخدم";
            this.Column3.Name = "Column3";
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "password";
            this.Column4.HeaderText = "كلمة المرور";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            this.Column4.Width = 113;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "is_active";
            this.Column5.HeaderText = "فغال";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 75;
            // 
            // cbxEmp
            // 
            this.cbxEmp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbxEmp.Location = new System.Drawing.Point(521, 99);
            this.cbxEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxEmp.Name = "cbxEmp";
            this.cbxEmp.Size = new System.Drawing.Size(240, 29);
            this.cbxEmp.TabIndex = 21;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvShowResult);
            this.Controls.Add(this.cbxSearchByShowPassword);
            this.Controls.Add(this.cbxSearchByActive);
            this.Controls.Add(this.cbxSearch);
            this.Controls.Add(this.pcUsers);
            this.Controls.Add(this.rdbUserNotActive);
            this.Controls.Add(this.rdbUserActive);
            this.Controls.Add(this.cbxEmp);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUsers";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.FrmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvShowResult;
        private System.Windows.Forms.CheckBox cbxSearchByShowPassword;
        private System.Windows.Forms.CheckBox cbxSearchByActive;
        private System.Windows.Forms.ComboBox cbxSearch;
        private System.Windows.Forms.PictureBox pcUsers;
        private System.Windows.Forms.RadioButton rdbUserNotActive;
        private System.Windows.Forms.RadioButton rdbUserActive;
        private employee cbxEmp;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
    }
}