namespace mySalseProject
{
    partial class frmUnit
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
            this.lblEmpNo = new System.Windows.Forms.Label();
            this.txtUnitNo = new System.Windows.Forms.TextBox();
            this.lblEmpHidr = new System.Windows.Forms.Label();
            this.pcb = new System.Windows.Forms.PictureBox();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnitDetails = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpNo
            // 
            this.lblEmpNo.AutoSize = true;
            this.lblEmpNo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblEmpNo.Location = new System.Drawing.Point(37, 67);
            this.lblEmpNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpNo.Name = "lblEmpNo";
            this.lblEmpNo.Size = new System.Drawing.Size(90, 19);
            this.lblEmpNo.TabIndex = 53;
            this.lblEmpNo.Text = "رقم الوحدة";
            // 
            // txtUnitNo
            // 
            this.txtUnitNo.Enabled = false;
            this.txtUnitNo.Location = new System.Drawing.Point(137, 67);
            this.txtUnitNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUnitNo.Name = "txtUnitNo";
            this.txtUnitNo.Size = new System.Drawing.Size(372, 27);
            this.txtUnitNo.TabIndex = 52;
            // 
            // lblEmpHidr
            // 
            this.lblEmpHidr.AutoSize = true;
            this.lblEmpHidr.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblEmpHidr.Location = new System.Drawing.Point(25, 21);
            this.lblEmpHidr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpHidr.Name = "lblEmpHidr";
            this.lblEmpHidr.Size = new System.Drawing.Size(309, 34);
            this.lblEmpHidr.TabIndex = 51;
            this.lblEmpHidr.Text = "شاشة تعريف الوحدات";
            // 
            // pcb
            // 
            this.pcb.Location = new System.Drawing.Point(347, 21);
            this.pcb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcb.Name = "pcb";
            this.pcb.Size = new System.Drawing.Size(45, 39);
            this.pcb.TabIndex = 54;
            this.pcb.TabStop = false;
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(137, 104);
            this.txtUnitName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(372, 27);
            this.txtUnitName.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "اسم الوحدة";
            // 
            // txtUnitDetails
            // 
            this.txtUnitDetails.Location = new System.Drawing.Point(137, 140);
            this.txtUnitDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUnitDetails.Multiline = true;
            this.txtUnitDetails.Name = "txtUnitDetails";
            this.txtUnitDetails.Size = new System.Drawing.Size(372, 127);
            this.txtUnitDetails.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "تفاصيل الوحدة";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(161, 317);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 39);
            this.btnExit.TabIndex = 55;
            this.btnExit.Text = "اغلاق";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(29, 317);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 39);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnNew.Location = new System.Drawing.Point(287, 317);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(105, 39);
            this.btnNew.TabIndex = 55;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // frmUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 406);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pcb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmpNo);
            this.Controls.Add(this.txtUnitDetails);
            this.Controls.Add(this.txtUnitName);
            this.Controls.Add(this.txtUnitNo);
            this.Controls.Add(this.lblEmpHidr);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Name = "frmUnit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة تعريف الوحدات";
            this.Load += new System.EventHandler(this.FrmUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpNo;
        private System.Windows.Forms.TextBox txtUnitNo;
        private System.Windows.Forms.Label lblEmpHidr;
        private System.Windows.Forms.PictureBox pcb;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnitDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
    }
}