namespace mySalseProject
{
    partial class employee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxEmp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbxEmp
            // 
            this.cbxEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxEmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEmp.FormattingEnabled = true;
            this.cbxEmp.Location = new System.Drawing.Point(4, 0);
            this.cbxEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxEmp.Name = "cbxEmp";
            this.cbxEmp.Size = new System.Drawing.Size(206, 37);
            this.cbxEmp.TabIndex = 0;
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxEmp);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "employee";
            this.Size = new System.Drawing.Size(215, 38);
            this.Load += new System.EventHandler(this.Employee_Load);
            this.Resize += new System.EventHandler(this.Employee_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEmp;
    }
}
