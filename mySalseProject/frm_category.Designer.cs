namespace mySalseProject
{
    partial class frm_category
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
            this.lblCatHidr = new System.Windows.Forms.Label();
            this.txtCatNo = new System.Windows.Forms.TextBox();
            this.lblCatNo = new System.Windows.Forms.Label();
            this.lblCatName = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.lblCatdetail = new System.Windows.Forms.Label();
            this.txtCatdetail = new System.Windows.Forms.TextBox();
            this.btnCatNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCatAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCatHidr
            // 
            this.lblCatHidr.AutoSize = true;
            this.lblCatHidr.Location = new System.Drawing.Point(48, 23);
            this.lblCatHidr.Name = "lblCatHidr";
            this.lblCatHidr.Size = new System.Drawing.Size(334, 34);
            this.lblCatHidr.TabIndex = 0;
            this.lblCatHidr.Text = "شاشة تعريف التصنيفات";
            // 
            // txtCatNo
            // 
            this.txtCatNo.Location = new System.Drawing.Point(275, 113);
            this.txtCatNo.Name = "txtCatNo";
            this.txtCatNo.ReadOnly = true;
            this.txtCatNo.Size = new System.Drawing.Size(451, 41);
            this.txtCatNo.TabIndex = 1;
            // 
            // lblCatNo
            // 
            this.lblCatNo.AutoSize = true;
            this.lblCatNo.Location = new System.Drawing.Point(48, 116);
            this.lblCatNo.Name = "lblCatNo";
            this.lblCatNo.Size = new System.Drawing.Size(181, 34);
            this.lblCatNo.TabIndex = 2;
            this.lblCatNo.Text = "رقم التصنيف";
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(48, 172);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(193, 34);
            this.lblCatName.TabIndex = 4;
            this.lblCatName.Text = "اسم التصنيف";
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(275, 172);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(451, 41);
            this.txtCatName.TabIndex = 3;
            // 
            // lblCatdetail
            // 
            this.lblCatdetail.AutoSize = true;
            this.lblCatdetail.Location = new System.Drawing.Point(48, 237);
            this.lblCatdetail.Name = "lblCatdetail";
            this.lblCatdetail.Size = new System.Drawing.Size(220, 34);
            this.lblCatdetail.TabIndex = 6;
            this.lblCatdetail.Text = "تفصيل التصنيف";
            // 
            // txtCatdetail
            // 
            this.txtCatdetail.Location = new System.Drawing.Point(275, 230);
            this.txtCatdetail.Multiline = true;
            this.txtCatdetail.Name = "txtCatdetail";
            this.txtCatdetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCatdetail.Size = new System.Drawing.Size(451, 103);
            this.txtCatdetail.TabIndex = 5;
            // 
            // btnCatNew
            // 
            this.btnCatNew.Location = new System.Drawing.Point(27, 349);
            this.btnCatNew.Name = "btnCatNew";
            this.btnCatNew.Size = new System.Drawing.Size(253, 49);
            this.btnCatNew.TabIndex = 7;
            this.btnCatNew.Text = "تصنيف جديد";
            this.btnCatNew.UseVisualStyleBackColor = true;
            this.btnCatNew.Click += new System.EventHandler(this.BtnCatNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(403, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnCatAdd
            // 
            this.btnCatAdd.Location = new System.Drawing.Point(286, 349);
            this.btnCatAdd.Name = "btnCatAdd";
            this.btnCatAdd.Size = new System.Drawing.Size(253, 49);
            this.btnCatAdd.TabIndex = 8;
            this.btnCatAdd.Text = "اضافة تصنيف";
            this.btnCatAdd.UseVisualStyleBackColor = true;
            this.btnCatAdd.Click += new System.EventHandler(this.BtnCatAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(545, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(253, 49);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "اغلاق";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frm_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 442);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCatAdd);
            this.Controls.Add(this.btnCatNew);
            this.Controls.Add(this.lblCatdetail);
            this.Controls.Add(this.txtCatdetail);
            this.Controls.Add(this.lblCatName);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.lblCatNo);
            this.Controls.Add(this.txtCatNo);
            this.Controls.Add(this.lblCatHidr);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frm_category";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة تعريف التصنيفات";
            this.Load += new System.EventHandler(this.Frm_category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCatHidr;
        private System.Windows.Forms.TextBox txtCatNo;
        private System.Windows.Forms.Label lblCatNo;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label lblCatdetail;
        private System.Windows.Forms.TextBox txtCatdetail;
        private System.Windows.Forms.Button btnCatNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCatAdd;
        private System.Windows.Forms.Button btnExit;
    }
}