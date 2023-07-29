using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace mySalseProject
{
    public partial class phones : UserControl
    {
        public phones()
        {
            InitializeComponent();
        }
        private void clearData()
        {
            txtPhone.Text = "";
            changeEnabeld(true, true, true, false, false);
            txtPhone.Select();
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            clearData();
        }
        public void addPhones(string phone)
        {
            phonesToGrid(phone);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text.Trim() != "")
            {
                if (!FilerPhone(txtPhone.Text).Equals(""))
                {
                    addPhones(FilerPhone(txtPhone.Text));
                }
                else
                {
                    MessageBox.Show("لايمكن ادخال قيمة فارغة");
                }
                clearData();
            }
        }
        private void TxtPhone_MouseDown(object sender, MouseEventArgs e)
        {
        }
        private string FilerPhone(string phone)
        {
            string phoneF = "";
            foreach (char c in phone)
            {
                if (char.IsDigit(c))
                {
                    phoneF += c;
                }
            }
            return phoneF;
        }
        private void TxtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && btnAdd.Enabled == true)
            {
                btnAdd.PerformClick();
            }
            else if (e.KeyData == Keys.Enter && btnChange.Enabled)
            {
                btnChange.PerformClick();
            }
        }
        private void DgvPhones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void DgvPhones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhones.Rows.Count > 0)
            {
                txtPhone.Text = dgvPhones.CurrentRow.Cells["phone"].Value.ToString();
                changeEnabeld(true, true, false, true, true);
                txtPhone.Select();
            }
        }
        private void phonesToGrid(string phone)
        {
            bool vl = false;
            foreach (DataGridViewRow r in dgvPhones.Rows)
            {
                if (r.Cells["phone"].Value.ToString().Equals(txtPhone.Text))
                {
                    vl = true;
                    break;
                }
            }
            if (!vl)
            {
                dgvPhones.Rows.Add(phone);
            }
            else
            {
                clearData();
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            bool vb = false;
            string oldText = dgvPhones.Rows[dgvPhones.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string newText = txtPhone.Text;
            foreach (DataGridViewRow r in dgvPhones.Rows)
            {
                if (r.Cells["phone"].Value.ToString().Equals(newText))
                {
                    vb = true;
                    break;
                }
            }
            bool a = false;
            foreach (DataGridViewRow r in dgvPhones.Rows)
            {
                if (r.Cells[0].Value.ToString().Equals(oldText) && !vb)
                {
                    a = true;
                    break;
                }
            }
            if (a)
            {
                if (!newText.Equals(""))
                    dgvPhones.CurrentRow.Cells[0].Value = newText;
                else
                    MessageBox.Show("لايمكن ادخال قيمة فارغة");
            }
            else if (newText.Equals(oldText))
            {
                MessageBox.Show("لم تقم بتغيير الرقم");
                txtPhone.Text = "";
            }
            else
            {
                MessageBox.Show("هذا الرقم موجود مسبقاً");
                txtPhone.Select();
                return;
            }
            txtPhone.Text = "";
            txtPhone.Select();
        }
        private void DgvPhones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            dgvPhones.Rows.Remove(dgvPhones.CurrentRow);
            MessageBox.Show("تم الحذف بنجاح");
            txtPhone.Select();
            txtPhone.Text = "";
            changeEnabeld(false, true, false, false, false);
            btnNew.Focus();
        }
        private void changeEnabeld(bool txtPhon, bool New, bool add, bool change, bool delete)
        {
            txtPhone.Enabled = txtPhon;
            btnNew.Enabled = New;
            btnAdd.Enabled = add;
            btnChange.Enabled = change;
            btnDelete.Enabled = delete;
        }

        public DataTable getPhonesAsDataTable()
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn item in dgvPhones.Columns)
            {
                dt.Columns.Add();
            }
            var cell = new Object[dgvPhones.Columns.Count];
            foreach (DataGridViewRow item in dgvPhones.Rows)
            {
                for (int i = 0; i < item.Cells.Count; i++)
                {
                    cell[i] = item.Cells[i].Value;
                }
                dt.Rows.Add(cell);
            }
            return dt;
        }
        public DataRow[] getPhonesAsDataRowArray()
        {
            var selectRow = new List<DataRow>();
            foreach (DataGridViewRow item in dgvPhones.Rows)
            {
                MessageBox.Show("hekko");
                // var dataRow = ((DataRowView)item).Row;
                // selectRow.Add(dataRow);
            }

            return selectRow.ToArray();
        }
        public object[] getPhonesAsObjectArray()
        {
            object[] o = new object[dgvPhones.Rows.Count];
            DataRow[] rows = getPhonesAsDataRowArray();
            for (int i = 0; i < dgvPhones.Rows.Count; i++)
            {
                o[i] = rows[i][0];
            }
            return o;
        }
        public string[] getPhonesAsStringArray()
        {
            string[] o = new string[dgvPhones.Rows.Count];
            DataRow[] rows = getPhonesAsDataRowArray();
            for (int i = 0; i < dgvPhones.Rows.Count - 1; i += 1)
            {
                o[i] = rows[1][0].ToString();
                MessageBox.Show(o[i] + "");
            }
            return o;
        }
        public string getPhonesAsString()
        {
            string allPhones = "";
            string[] str = getPhonesAsStringArray();
            for (int i = 0; i < str.Count(); i++)
            {
                allPhones += str[i] + ((i < str.Count() - 1) ? "," : "");
            }
            return allPhones;
        }

        private void Phones_Load(object sender, EventArgs e)
        {

        }

        private void Phones_Resize(object sender, EventArgs e)
        {

            txtPhone.Left = 10;
            txtPhone.Width = this.Width - lblPhone.Width - 20;
            lblPhone.Left = txtPhone.Width + 10;
        }
    }
}

