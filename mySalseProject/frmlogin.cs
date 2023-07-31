using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mySalseProject
{
    public partial class frmlogin : Form
    {
#pragma warning disable CS0414 // The field 'frmlogin.PreClose' is assigned but its value is never used
        private bool PreClose = true;
#pragma warning restore CS0414 // The field 'frmlogin.PreClose' is assigned but its value is never used
        public frmlogin()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DataTable tblLogin = DB.getData("select * from login_program  where username ='" + txtUsername.Text + "' and password ='" + txtPassword.Text + "'");
            if (tblLogin.Rows.Count>0)
            {
                frmMain frm = new frmMain();
                frm.Icon = this.Icon;
                v.username = tblLogin.Rows[0][0].ToString();
                frm.Show();
                PreClose = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيحة");
            }
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}
