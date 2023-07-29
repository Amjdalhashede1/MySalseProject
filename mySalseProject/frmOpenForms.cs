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
    public partial class frmOpenForms : Form
    {
        public frmOpenForms()
        {
            InitializeComponent();
        }
        private  void formWindowState()
        {
            lblCount.Text = "يوجد" + (Application.OpenForms.Count - 2) + " شاشة مفتوحة";
            lbxTextForm.Items.Clear();
            lbxNameForm.Items.Clear();
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "frmstart" || item.Name == "frmMain") continue;
                lbxNameForm.Items.Add(item.Name);
                lbxTextForm.Items.Add(item.Text);
            }
        }
        private void FrmOpenForms_Load(object sender, EventArgs e)
        {
            formWindowState();
        }

        private void LbxTextForm_DoubleClick(object sender, EventArgs e)
        {
            Application.OpenForms[lbxNameForm.Items[lbxTextForm.SelectedIndex].ToString()].Activate();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            formWindowState();
        }
    }
}
