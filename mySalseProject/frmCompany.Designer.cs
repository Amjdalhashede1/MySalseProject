namespace mySalseProject
{
    partial class frmCompany
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pcb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmpNo = new System.Windows.Forms.Label();
            this.txtCompanyDetails = new System.Windows.Forms.TextBox();
            this.txtCompanyCode = new System.Windows.Forms.TextBox();
            this.txtCompanyNo = new System.Windows.Forms.TextBox();
            this.lblEmpHidr = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phones1 = new mySalseProject.phones();
            this.dtCompanyDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(79, 510);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 60);
            this.btnAdd.TabIndex = 64;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnNew.Location = new System.Drawing.Point(451, 510);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(152, 60);
            this.btnNew.TabIndex = 65;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(268, 510);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 60);
            this.btnExit.TabIndex = 66;
            this.btnExit.Text = "اغلاق";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // pcb
            // 
            this.pcb.Location = new System.Drawing.Point(476, 27);
            this.pcb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pcb.Name = "pcb";
            this.pcb.Size = new System.Drawing.Size(65, 59);
            this.pcb.TabIndex = 63;
            this.pcb.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(74, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 61;
            this.label1.Text = "كود  الشركة";
            // 
            // lblEmpNo
            // 
            this.lblEmpNo.AutoSize = true;
            this.lblEmpNo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblEmpNo.Location = new System.Drawing.Point(74, 97);
            this.lblEmpNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpNo.Name = "lblEmpNo";
            this.lblEmpNo.Size = new System.Drawing.Size(97, 19);
            this.lblEmpNo.TabIndex = 62;
            this.lblEmpNo.Text = "رقم الشركة";
            // 
            // txtCompanyDetails
            // 
            this.txtCompanyDetails.Location = new System.Drawing.Point(218, 276);
            this.txtCompanyDetails.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCompanyDetails.Multiline = true;
            this.txtCompanyDetails.Name = "txtCompanyDetails";
            this.txtCompanyDetails.Size = new System.Drawing.Size(536, 191);
            this.txtCompanyDetails.TabIndex = 57;
            // 
            // txtCompanyCode
            // 
            this.txtCompanyCode.Location = new System.Drawing.Point(218, 130);
            this.txtCompanyCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCompanyCode.Name = "txtCompanyCode";
            this.txtCompanyCode.Size = new System.Drawing.Size(536, 27);
            this.txtCompanyCode.TabIndex = 58;
            // 
            // txtCompanyNo
            // 
            this.txtCompanyNo.Enabled = false;
            this.txtCompanyNo.Location = new System.Drawing.Point(218, 97);
            this.txtCompanyNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCompanyNo.Name = "txtCompanyNo";
            this.txtCompanyNo.Size = new System.Drawing.Size(536, 27);
            this.txtCompanyNo.TabIndex = 59;
            // 
            // lblEmpHidr
            // 
            this.lblEmpHidr.AutoSize = true;
            this.lblEmpHidr.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblEmpHidr.Location = new System.Drawing.Point(56, 27);
            this.lblEmpHidr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpHidr.Name = "lblEmpHidr";
            this.lblEmpHidr.Size = new System.Drawing.Size(397, 34);
            this.lblEmpHidr.TabIndex = 56;
            this.lblEmpHidr.Text = "شاشة تعريف شركات المنشأ";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(218, 163);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(536, 27);
            this.txtCompanyName.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(74, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 61;
            this.label3.Text = "اسم الشركة";
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Enabled = false;
            this.txtCompanyAddress.Location = new System.Drawing.Point(218, 201);
            this.txtCompanyAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(536, 27);
            this.txtCompanyAddress.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(74, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 62;
            this.label4.Text = "عنوان الشركة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(74, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 61;
            this.label5.Text = "تاريخ الأنشاء";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(74, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 61;
            this.label6.Text = "تفاصيل اخرى";
            // 
            // phones1
            // 
            this.phones1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.phones1.Location = new System.Drawing.Point(779, 97);
            this.phones1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.phones1.Name = "phones1";
            this.phones1.Size = new System.Drawing.Size(502, 402);
            this.phones1.TabIndex = 67;
            // 
            // dtCompanyDate
            // 
            this.dtCompanyDate.Location = new System.Drawing.Point(218, 238);
            this.dtCompanyDate.Name = "dtCompanyDate";
            this.dtCompanyDate.Size = new System.Drawing.Size(536, 27);
            this.dtCompanyDate.TabIndex = 68;
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 674);
            this.Controls.Add(this.dtCompanyDate);
            this.Controls.Add(this.phones1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pcb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEmpNo);
            this.Controls.Add(this.txtCompanyDetails);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtCompanyAddress);
            this.Controls.Add(this.txtCompanyCode);
            this.Controls.Add(this.txtCompanyNo);
            this.Controls.Add(this.lblEmpHidr);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmCompany";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompany";
            this.Load += new System.EventHandler(this.FrmCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pcb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmpNo;
        private System.Windows.Forms.TextBox txtCompanyDetails;
        private System.Windows.Forms.TextBox txtCompanyCode;
        private System.Windows.Forms.TextBox txtCompanyNo;
        private System.Windows.Forms.Label lblEmpHidr;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompanyAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private phones phones1;
        private System.Windows.Forms.DateTimePicker dtCompanyDate;
    }
}