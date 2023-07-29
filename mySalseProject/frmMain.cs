using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace mySalseProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void TsBtnModifyEmp_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton10_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void OpenForm(Form form)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (form.Name == "frmstart" || form.Name == "frmMain") continue;
                if(form.Name == frm.Name)
                {
                    frm.Activate();
                    return;
                }
            }
            form.BackColor= Color.FromArgb(v.R, v.G, v.B);
            form.MdiParent = this;
           form.WindowState =v.formCurrentState;
            form.Show();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(255, 255, 255);
            frmChangeBackColor(v.R,v.G,v.B);
            this.WindowState = FormWindowState.Maximized;

        }

        public void frmChangeBackColor(int r,int g,int b)
        {
            
            Color cf = Color.FromArgb(r, g,b);
            foreach (TabPage item in tabCtrlSales.TabPages)
            {
                foreach (Control cn in item.Controls)
                {
                    cn.BackColor = cf;
                }
                item.BackColor = cf;
            }

            this.BackColor = cf;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenForm(new frmlogin());
        }

        private void TsBtnBackgroundColor_Click(object sender, EventArgs e)
        {
            OpenForm(new frmChangeBackColor());
        }

        private void TsBtnShowOpeningForm_Click(object sender, EventArgs e)
        {
            OpenForm(new frmOpenForms());
        }

        private void TsBtnCatg_Click(object sender, EventArgs e)
        {
            OpenForm(new frm_category());
        }

        private void ToolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void TsMIMax_Click(object sender, EventArgs e)
        {
            v.formCurrentState = FormWindowState.Maximized;
            ScreenMode();
        }

        private void TsMINormal_Click(object sender, EventArgs e)
        {
            v.formCurrentState = FormWindowState.Normal;
            ScreenMode();
        }

        private void TsMIMin_Click(object sender, EventArgs e)
        {
            v.formCurrentState = FormWindowState.Minimized;
            ScreenMode();
        }
        public static void ScreenMode()
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "frmstart" || item.Name == "frmMain") continue;
                item.WindowState = v.formCurrentState;
              
            }
        }

        private void TsBtnUnet_Click(object sender, EventArgs e)
        {
            OpenForm(new aaa());
        }

        private void TsBtnEmpoliess_Click(object sender, EventArgs e)
        {
            OpenForm(new frmEmployees());
        }
    }
}