using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mySalseProject
{
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void BtnSelectImageEmp_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "اختر صورة";
            ofd.Filter = "Images|*.jpg;.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofd.FileName))
                {
                    txtpathImage.Text = ofd.FileName;
                    Bitmap bmp = new Bitmap(Image.FromFile(ofd.FileName), new Size(100, 100));
                    pbEmpImage.Image = bmp;
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ThePhones1_Load(object sender, EventArgs e)
        {

        }
        private void ClearAndAuto()
        {
            txtEmpNo.Text = DB.getData("select max(emp_no)+1 from employee").Rows[0][0].ToString();
            if (txtEmpNo.Text.Trim() == "") txtEmpNo.Text = "1";
            txtEmpNo.Text = "";
            txtEmpName.Text = "";
            rdbEmpMail.Checked = true;
            txtEmpAddres.Text = "";
            txtEmpIdNum.Text = "";
            txtpathImage.Text = "";
            pbEmpImage.Image = new PictureBox().Image;
            txtEmpName.Select();
        }
        private void BtnNewEmp_Click(object sender, EventArgs e)
        {
            ClearAndAuto();
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            ClearAndAuto();
        }

        private void BtnAddEmp_Click(object sender, EventArgs e)
        {
            if (txtEmpNo.Text.Trim() == "")
            {
                MessageBox.Show("رقم الموظف فارغ");
            }
            else if (txtEmpName.Text.Trim() == "")
            {
                MessageBox.Show("اسم الموظف فارغ");
            }
            else if (txtEmpAddres.Text.Trim() == "")
            {
                MessageBox.Show("عنوان الموظف فارغ");
            }
            else if (txtEmpIdNum.Text.Trim() == "")
            {
                MessageBox.Show("الرقم القومي للموظف فارغ");
            }
            else if (cbEmpQualific.Text.Trim() == "")
            {
                MessageBox.Show("المؤهل  فارغ");
            }
            else if (cbEmpGinder.Text.Trim() == "")
            {
                MessageBox.Show("الحالة الاجتماعية فارغة");

            }
        }
    }
}
