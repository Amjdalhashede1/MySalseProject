namespace mySalseProject
{
    partial class frmEmployees
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
            this.btnNewEmp = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.txtpathImage = new System.Windows.Forms.TextBox();
            this.pbEmpImage = new System.Windows.Forms.PictureBox();
            this.lblEmpImage = new System.Windows.Forms.Label();
            this.cbEmpGinder = new System.Windows.Forms.ComboBox();
            this.cbEmpQualific = new System.Windows.Forms.ComboBox();
            this.lblEmpState = new System.Windows.Forms.Label();
            this.lblEmpQualifica = new System.Windows.Forms.Label();
            this.dtpEmpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmpBirthDate = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpIdNum = new System.Windows.Forms.TextBox();
            this.rdbEmpFamal = new System.Windows.Forms.RadioButton();
            this.rdbEmpMail = new System.Windows.Forms.RadioButton();
            this.lblEmpAddres = new System.Windows.Forms.Label();
            this.txtEmpAddres = new System.Windows.Forms.TextBox();
            this.lblEmpGendr = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pcb = new System.Windows.Forms.PictureBox();
            this.btnSelectImageEmp = new System.Windows.Forms.Button();
            this.lblEmpNo = new System.Windows.Forms.Label();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.lblEmpHidr = new System.Windows.Forms.Label();
            this.empPhones = new mySalseProject.phones();
            this.employee1 = new mySalseProject.employee();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewEmp
            // 
            this.btnNewEmp.Location = new System.Drawing.Point(21, 426);
            this.btnNewEmp.Name = "btnNewEmp";
            this.btnNewEmp.Size = new System.Drawing.Size(139, 49);
            this.btnNewEmp.TabIndex = 74;
            this.btnNewEmp.Text = "موظف جديد";
            this.btnNewEmp.UseVisualStyleBackColor = true;
            this.btnNewEmp.Click += new System.EventHandler(this.BtnNewEmp_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(162, 426);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(170, 49);
            this.btnAddEmp.TabIndex = 73;
            this.btnAddEmp.Text = "اضافة موظف";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.BtnAddEmp_Click);
            // 
            // txtpathImage
            // 
            this.txtpathImage.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtpathImage.Location = new System.Drawing.Point(263, 317);
            this.txtpathImage.Multiline = true;
            this.txtpathImage.Name = "txtpathImage";
            this.txtpathImage.Size = new System.Drawing.Size(186, 45);
            this.txtpathImage.TabIndex = 72;
            // 
            // pbEmpImage
            // 
            this.pbEmpImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEmpImage.Location = new System.Drawing.Point(170, 262);
            this.pbEmpImage.Name = "pbEmpImage";
            this.pbEmpImage.Size = new System.Drawing.Size(87, 100);
            this.pbEmpImage.TabIndex = 71;
            this.pbEmpImage.TabStop = false;
            // 
            // lblEmpImage
            // 
            this.lblEmpImage.AutoSize = true;
            this.lblEmpImage.Location = new System.Drawing.Point(18, 262);
            this.lblEmpImage.Name = "lblEmpImage";
            this.lblEmpImage.Size = new System.Drawing.Size(147, 29);
            this.lblEmpImage.TabIndex = 70;
            this.lblEmpImage.Text = "صورة الموظف";
            // 
            // cbEmpGinder
            // 
            this.cbEmpGinder.FormattingEnabled = true;
            this.cbEmpGinder.Items.AddRange(new object[] {
            "عازب",
            "متزوج",
            "ارمل"});
            this.cbEmpGinder.Location = new System.Drawing.Point(643, 219);
            this.cbEmpGinder.Name = "cbEmpGinder";
            this.cbEmpGinder.Size = new System.Drawing.Size(277, 37);
            this.cbEmpGinder.TabIndex = 69;
            this.cbEmpGinder.Text = "عازب";
            // 
            // cbEmpQualific
            // 
            this.cbEmpQualific.FormattingEnabled = true;
            this.cbEmpQualific.Items.AddRange(new object[] {
            "بكالوريوس",
            "دبلوم",
            "شهادة متوسطة"});
            this.cbEmpQualific.Location = new System.Drawing.Point(166, 219);
            this.cbEmpQualific.Name = "cbEmpQualific";
            this.cbEmpQualific.Size = new System.Drawing.Size(279, 37);
            this.cbEmpQualific.TabIndex = 68;
            this.cbEmpQualific.Text = "بكالوريوس";
            // 
            // lblEmpState
            // 
            this.lblEmpState.AutoSize = true;
            this.lblEmpState.Location = new System.Drawing.Point(465, 222);
            this.lblEmpState.Name = "lblEmpState";
            this.lblEmpState.Size = new System.Drawing.Size(181, 29);
            this.lblEmpState.TabIndex = 67;
            this.lblEmpState.Text = "الحالة الاجتماعية";
            // 
            // lblEmpQualifica
            // 
            this.lblEmpQualifica.AutoSize = true;
            this.lblEmpQualifica.Location = new System.Drawing.Point(18, 228);
            this.lblEmpQualifica.Name = "lblEmpQualifica";
            this.lblEmpQualifica.Size = new System.Drawing.Size(85, 29);
            this.lblEmpQualifica.TabIndex = 66;
            this.lblEmpQualifica.Text = "المؤهل";
            // 
            // dtpEmpBirthDate
            // 
            this.dtpEmpBirthDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpEmpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmpBirthDate.Location = new System.Drawing.Point(642, 170);
            this.dtpEmpBirthDate.Name = "dtpEmpBirthDate";
            this.dtpEmpBirthDate.RightToLeftLayout = true;
            this.dtpEmpBirthDate.Size = new System.Drawing.Size(278, 36);
            this.dtpEmpBirthDate.TabIndex = 65;
            // 
            // lblEmpBirthDate
            // 
            this.lblEmpBirthDate.AutoSize = true;
            this.lblEmpBirthDate.Location = new System.Drawing.Point(486, 170);
            this.lblEmpBirthDate.Name = "lblEmpBirthDate";
            this.lblEmpBirthDate.Size = new System.Drawing.Size(132, 29);
            this.lblEmpBirthDate.TabIndex = 64;
            this.lblEmpBirthDate.Text = "تاريخ الميلاد";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(643, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(278, 36);
            this.textBox4.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 29);
            this.label4.TabIndex = 62;
            this.label4.Text = "الرقم القومي";
            // 
            // txtEmpIdNum
            // 
            this.txtEmpIdNum.Location = new System.Drawing.Point(172, 170);
            this.txtEmpIdNum.Name = "txtEmpIdNum";
            this.txtEmpIdNum.Size = new System.Drawing.Size(278, 36);
            this.txtEmpIdNum.TabIndex = 61;
            this.txtEmpIdNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmpIdNum_KeyPress);
            // 
            // rdbEmpFamal
            // 
            this.rdbEmpFamal.AutoSize = true;
            this.rdbEmpFamal.Location = new System.Drawing.Point(166, 123);
            this.rdbEmpFamal.Name = "rdbEmpFamal";
            this.rdbEmpFamal.Size = new System.Drawing.Size(83, 33);
            this.rdbEmpFamal.TabIndex = 60;
            this.rdbEmpFamal.TabStop = true;
            this.rdbEmpFamal.Text = "انثى";
            this.rdbEmpFamal.UseVisualStyleBackColor = true;
            // 
            // rdbEmpMail
            // 
            this.rdbEmpMail.AutoSize = true;
            this.rdbEmpMail.Checked = true;
            this.rdbEmpMail.Location = new System.Drawing.Point(94, 123);
            this.rdbEmpMail.Name = "rdbEmpMail";
            this.rdbEmpMail.Size = new System.Drawing.Size(71, 33);
            this.rdbEmpMail.TabIndex = 59;
            this.rdbEmpMail.TabStop = true;
            this.rdbEmpMail.Text = "ذكر";
            this.rdbEmpMail.UseVisualStyleBackColor = true;
            // 
            // lblEmpAddres
            // 
            this.lblEmpAddres.AutoSize = true;
            this.lblEmpAddres.Location = new System.Drawing.Point(486, 120);
            this.lblEmpAddres.Name = "lblEmpAddres";
            this.lblEmpAddres.Size = new System.Drawing.Size(79, 29);
            this.lblEmpAddres.TabIndex = 58;
            this.lblEmpAddres.Text = "العنوان";
            // 
            // txtEmpAddres
            // 
            this.txtEmpAddres.Location = new System.Drawing.Point(643, 116);
            this.txtEmpAddres.Name = "txtEmpAddres";
            this.txtEmpAddres.Size = new System.Drawing.Size(277, 36);
            this.txtEmpAddres.TabIndex = 57;
            // 
            // lblEmpGendr
            // 
            this.lblEmpGendr.AutoSize = true;
            this.lblEmpGendr.Location = new System.Drawing.Point(16, 132);
            this.lblEmpGendr.Name = "lblEmpGendr";
            this.lblEmpGendr.Size = new System.Drawing.Size(60, 29);
            this.lblEmpGendr.TabIndex = 56;
            this.lblEmpGendr.Text = "النوع";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(486, 80);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(152, 29);
            this.lblEmpName.TabIndex = 55;
            this.lblEmpName.Text = "اسم الموظف ";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(644, 72);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(277, 36);
            this.txtEmpName.TabIndex = 54;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(338, 426);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 49);
            this.btnExit.TabIndex = 53;
            this.btnExit.Text = "اغلاق";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pcb
            // 
            this.pcb.Location = new System.Drawing.Point(323, 9);
            this.pcb.Name = "pcb";
            this.pcb.Size = new System.Drawing.Size(65, 59);
            this.pcb.TabIndex = 52;
            this.pcb.TabStop = false;
            // 
            // btnSelectImageEmp
            // 
            this.btnSelectImageEmp.Location = new System.Drawing.Point(263, 262);
            this.btnSelectImageEmp.Name = "btnSelectImageEmp";
            this.btnSelectImageEmp.Size = new System.Drawing.Size(185, 49);
            this.btnSelectImageEmp.TabIndex = 51;
            this.btnSelectImageEmp.Text = "اختر صورة";
            this.btnSelectImageEmp.UseVisualStyleBackColor = true;
            this.btnSelectImageEmp.Click += new System.EventHandler(this.BtnSelectImageEmp_Click);
            // 
            // lblEmpNo
            // 
            this.lblEmpNo.AutoSize = true;
            this.lblEmpNo.Location = new System.Drawing.Point(17, 76);
            this.lblEmpNo.Name = "lblEmpNo";
            this.lblEmpNo.Size = new System.Drawing.Size(133, 29);
            this.lblEmpNo.TabIndex = 50;
            this.lblEmpNo.Text = "رقم الموظف";
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.Location = new System.Drawing.Point(172, 76);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(278, 36);
            this.txtEmpNo.TabIndex = 49;
            // 
            // lblEmpHidr
            // 
            this.lblEmpHidr.AutoSize = true;
            this.lblEmpHidr.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblEmpHidr.Location = new System.Drawing.Point(10, 6);
            this.lblEmpHidr.Name = "lblEmpHidr";
            this.lblEmpHidr.Size = new System.Drawing.Size(307, 34);
            this.lblEmpHidr.TabIndex = 48;
            this.lblEmpHidr.Text = "شاشة تعريف الموظف";
            // 
            // empPhones
            // 
            this.empPhones.Font = new System.Drawing.Font("Tahoma", 12F);
            this.empPhones.Location = new System.Drawing.Point(491, 281);
            this.empPhones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.empPhones.Name = "empPhones";
            this.empPhones.Size = new System.Drawing.Size(416, 262);
            this.empPhones.TabIndex = 75;
            // 
            // employee1
            // 
            this.employee1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.employee1.Location = new System.Drawing.Point(56, 492);
            this.employee1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employee1.Name = "employee1";
            this.employee1.Size = new System.Drawing.Size(225, 84);
            this.employee1.TabIndex = 76;
            this.employee1.Load += new System.EventHandler(this.Employee1_Load);
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 566);
            this.Controls.Add(this.employee1);
            this.Controls.Add(this.empPhones);
            this.Controls.Add(this.btnNewEmp);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.txtpathImage);
            this.Controls.Add(this.pbEmpImage);
            this.Controls.Add(this.lblEmpImage);
            this.Controls.Add(this.cbEmpGinder);
            this.Controls.Add(this.cbEmpQualific);
            this.Controls.Add(this.lblEmpState);
            this.Controls.Add(this.lblEmpQualifica);
            this.Controls.Add(this.dtpEmpBirthDate);
            this.Controls.Add(this.lblEmpBirthDate);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmpIdNum);
            this.Controls.Add(this.rdbEmpFamal);
            this.Controls.Add(this.rdbEmpMail);
            this.Controls.Add(this.lblEmpAddres);
            this.Controls.Add(this.txtEmpAddres);
            this.Controls.Add(this.lblEmpGendr);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pcb);
            this.Controls.Add(this.btnSelectImageEmp);
            this.Controls.Add(this.lblEmpNo);
            this.Controls.Add(this.txtEmpNo);
            this.Controls.Add(this.lblEmpHidr);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEmployees";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شاشة تعريف الموظف";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEmployees_FormClosed);
            this.Load += new System.EventHandler(this.FrmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewEmp;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.TextBox txtpathImage;
        private System.Windows.Forms.PictureBox pbEmpImage;
        private System.Windows.Forms.Label lblEmpImage;
        private System.Windows.Forms.ComboBox cbEmpGinder;
        private System.Windows.Forms.ComboBox cbEmpQualific;
        private System.Windows.Forms.Label lblEmpState;
        private System.Windows.Forms.Label lblEmpQualifica;
        private System.Windows.Forms.DateTimePicker dtpEmpBirthDate;
        private System.Windows.Forms.Label lblEmpBirthDate;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpIdNum;
        private System.Windows.Forms.RadioButton rdbEmpFamal;
        private System.Windows.Forms.RadioButton rdbEmpMail;
        private System.Windows.Forms.Label lblEmpAddres;
        private System.Windows.Forms.TextBox txtEmpAddres;
        private System.Windows.Forms.Label lblEmpGendr;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pcb;
        private System.Windows.Forms.Button btnSelectImageEmp;
        private System.Windows.Forms.Label lblEmpNo;
        private System.Windows.Forms.TextBox txtEmpNo;
        private System.Windows.Forms.Label lblEmpHidr;
        private phones empPhones;
        private employee employee1;
    }
}