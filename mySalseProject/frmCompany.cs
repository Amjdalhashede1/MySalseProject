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
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
        }
        private void ClearAndAuto()
        {
            txtCompanyNo.Text = DB.getData("select max(Company_no)+1 from Company").Rows[0][0].ToString();
            if (txtCompanyNo.Text.Trim() == "") txtCompanyNo.Text = "1";
             txtCompanyName.Text = "";
             txtCompanyDetails.Text = "";
             txtCompanyName.Select();
        }
        private void FrmCompany_Load(object sender, EventArgs e)
        {
            ClearAndAuto();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtCompanyNo.Text.Trim() == "")
            {
                MessageBox.Show("رقم الوحدة فارغ");
            }
            else if (txtCompanyName.Text.Trim() == "")
            {
                MessageBox.Show("اسم الوحدة فارغ");
                txtCompanyName.Select();
            }
            else if (txtCompanyDetails.Text.Trim() == "")
            {
                MessageBox.Show("وصف الوحدة فارغ");
                txtCompanyDetails.Select();
            }
            else
            {
                try
                {
                    DB.Run("insert into Company values (" + Convert.ToInt32(txtCompanyNo.Text) + "," +
                                                         "'" + txtCompanyName.Text + "'," +
                                                         "'" + txtCompanyDetails.Text + "')");
                    MessageBox.Show("تم اضافة وحدة بنجاح");
                    ClearAndAuto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
