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
    public partial class frmChangeBackColor : Form
    {
        public frmChangeBackColor()
        {
            InitializeComponent();
        }

        private void FrmChangeBackColor_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            panel8.BackColor= ((Panel)sender).BackColor;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int R = panel8.BackColor.R;
            int G = panel8.BackColor.G;
            int B = panel8.BackColor.B;
            try
            {
                DB.Run("UPdate settings_bg set r=" + R + ",g=" + G + ",B=" + B + "");
                v.R = R; v.G = G; v.B=B;
                new frmMain().frmChangeBackColor(v.R, v.G, v.B);


                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
    }
}
