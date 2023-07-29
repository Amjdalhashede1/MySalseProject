namespace mySalseProject
{
    partial class frmOpenForms
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
            this.lblCount = new System.Windows.Forms.Label();
            this.lbxTextForm = new System.Windows.Forms.ListBox();
            this.lbxNameForm = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(52, 44);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(51, 19);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "label1";
            // 
            // lbxTextForm
            // 
            this.lbxTextForm.FormattingEnabled = true;
            this.lbxTextForm.ItemHeight = 19;
            this.lbxTextForm.Location = new System.Drawing.Point(21, 124);
            this.lbxTextForm.Name = "lbxTextForm";
            this.lbxTextForm.Size = new System.Drawing.Size(412, 270);
            this.lbxTextForm.TabIndex = 1;
            this.lbxTextForm.DoubleClick += new System.EventHandler(this.LbxTextForm_DoubleClick);
            // 
            // lbxNameForm
            // 
            this.lbxNameForm.FormattingEnabled = true;
            this.lbxNameForm.ItemHeight = 19;
            this.lbxNameForm.Location = new System.Drawing.Point(567, 124);
            this.lbxNameForm.Name = "lbxNameForm";
            this.lbxNameForm.Size = new System.Drawing.Size(278, 270);
            this.lbxNameForm.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 77);
            this.button1.TabIndex = 2;
            this.button1.Text = "إغلاق";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(52, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "أنقر نقر مزدوج على اسم الشاشة لفتحها";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(738, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frmOpenForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 595);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbxNameForm);
            this.Controls.Add(this.lbxTextForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCount);
            this.Name = "frmOpenForms";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "عرض الشاشات المفتوحة";
            this.Load += new System.EventHandler(this.FrmOpenForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ListBox lbxTextForm;
        private System.Windows.Forms.ListBox lbxNameForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}