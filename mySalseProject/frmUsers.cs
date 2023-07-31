using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mySalseProject
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable tblUsers = new DataTable();
        public void showData()
        {
            tblUsers.Clear();
            tblUsers = DB.getData("select * from login_program_data");
            dgvShowResult.DataSource = tblUsers;
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            cbxSearch.SelectedIndex = 0;
            ClearData();
            showData();
        }
        public void ClearData()
        {
            dgvShowResult.ClearSelection();
            cbxEmp.setEmploeeNotUser();
            txtUserName.Text = "";
            txtPassword.Text = "";
            rdbUserActive.Checked = true;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtUserName.Select();
            cbxEmp.Enabled = true;
            txtUserName.Enabled = true;
        }


        private void DgvShowResult_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShowResult.CurrentRow != null) {
                cbxEmp.setEmployeesAll();
                cbxEmp.SetValue((int)dgvShowResult.CurrentRow.Cells[0].Value);
                txtUserName.Text = dgvShowResult.CurrentRow.Cells[2].Value.ToString();
                txtPassword.Text = dgvShowResult.CurrentRow.Cells[3].Value.ToString();
                if ((bool)dgvShowResult.CurrentRow.Cells[4].Value)
                    rdbUserActive.Checked = true;
                else
                    rdbUserNotActive.Checked = true;
                btnAdd.Enabled = false;
                cbxEmp.Enabled = false;
                txtUserName.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!cbxEmp.IsSelected())
            {
                MessageBox.Show("الرجاء اختيار موظف");
            } else if (txtUserName.Text.Trim() == "") {
                MessageBox.Show("اسم السمتخدم فارغ");
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("كلمة المرور فارغ");
            }
            else
            {
                try
                {
                    DB.Run("insert into login_program values('" + txtUserName.Text + "','" + txtPassword.Text + "','" + ((rdbUserActive.Checked) ? true : false) + "','" + cbxEmp.getValue() + "')");
                    MessageBox.Show("تم اضافة بيانات المستخدم بنجاح");
                    showData();
                    ClearData();

                }
                catch (SqlException ex)

                {
                    MessageBox.Show(ex.Number + "");
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DB.Run("update login_program set password='" + txtPassword.Text + "',is_active='" + ((rdbUserActive.Checked) ? true : false) + "',empno=" + cbxEmp.getValue() + " where username ='" + txtUserName.Text + "'");
                showData();
                ClearData();
                MessageBox.Show("تمت  عملية التعديل بنجاح");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 207)
                    MessageBox.Show("من فضلك اختار اسم مستخدم آخر لان هذا المستخدم مستخدم بالقعل");
                else
                    MessageBox.Show(ex.Message + "");
            }
        }
    

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف هذا المستخدم؟","رسالة تاكيد الحذف ", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2,MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                try
                {
                    DB.Run("delete from login_program where username ='"+txtUserName.Text+"'");
                    MessageBox.Show("تم حذف المستخدم نهائياً");
                    showData();
                    ClearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CbxSearchByShowPassword_CheckedChanged(object sender, EventArgs e)
        {
           dgvShowResult.Columns[3].Visible = cbxSearchByShowPassword.Checked;

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string strPatt = "";
            if (cbxSearch.SelectedItem.ToString() == "الموظف") strPatt += "emp_name";
            else if (cbxSearch.SelectedItem.ToString() == "اسم المستخدم") strPatt += "username";
            strPatt += " like '%"+txtSearch.Text+ "%' and  is_active in ";
            if (cbxSearchByActive.CheckState.ToString().ToLower() == "checked") strPatt += "  ('True')";
            else if (cbxSearchByActive.CheckState.ToString().ToLower() == "unchecked") strPatt += " ('False')";
            else
            {
                strPatt += " ('True','False') ";
            }
            DataView dv = new DataView(tblUsers);
            dv.RowFilter = strPatt;
            dgvShowResult.DataSource = dv;
        }

        private void CbxSearchByActive_CheckedChanged(object sender, EventArgs e)
        {
           // TxtSearch_TextChanged(null, null);
        }

        private void CbxSearchByActive_CheckStateChanged(object sender, EventArgs e)
        {
            TxtSearch_TextChanged(null, null);
        }

        private void CbxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
