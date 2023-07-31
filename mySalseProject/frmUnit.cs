using System;
using System.Windows.Forms;

namespace mySalseProject
{
    public partial class frmUnit : Form
    {
        public frmUnit()
        {
            InitializeComponent();
        }
        private void ClearAndAuto()
        {
            txtUnitNo.Text = DB.getData("select max(unit_no)+1 from Unit").Rows[0][0].ToString();
            if (txtUnitNo.Text.Trim() == "") txtUnitNo.Text = "1";
            txtUnitName.Text = "";
            txtUnitDetails.Text = "";
            txtUnitName.Select();
        }
        

        private void FrmUnit_Load(object sender, EventArgs e)
        {
            ClearAndAuto();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearAndAuto();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtUnitNo.Text.Trim() == "")
            {
                MessageBox.Show("رقم الوحدة فارغ");
            }
            else if (txtUnitName.Text.Trim() == "")
            {
                MessageBox.Show("اسم الوحدة فارغ");
                txtUnitName.Select();
            }
            else if (txtUnitDetails.Text.Trim() == "")
            {
                MessageBox.Show("وصف الوحدة فارغ");
                txtUnitDetails.Select();
            }
            else
            {
                try
                {
                    DB.Run("insert into Unit values (" + Convert.ToInt32(txtUnitNo.Text) + "," +
                                                         "'" + txtUnitName.Text + "'," +
                                                         "'" + txtUnitDetails.Text + "')");
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

