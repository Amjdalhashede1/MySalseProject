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
            this.Name = "Phones";
            this.ResumeLayout(false);
        }
        private DataTable tblPhones = new DataTable();

        public int S { get; private set; }
        private void Phones_Load(object sender, EventArgs e)
        {
            ClearData();
        }

        private void PhonesToGrid()
        {
            tblPhones = tblPhones.DefaultView.ToTable(true, "phone");
            dgvPhones.DataSource = tblPhones;
        }
        private void addPhones(string phone)
        {
            if (tblPhones.Columns.Count < 1) tblPhones.Columns.Add("phone");
            tblPhones.Rows.Add(FilterPhone(phone));
            PhonesToGrid();
        }

        private DataRow FindRow(string phone)
        {
            if (tblPhones.Constraints.Count < 1)
            {
                tblPhones.Constraints.Add("phone_pk", tblPhones.Columns[0], true);
            }
            return tblPhones.Rows.Find(phone);
        }
        private void ClearData()
        {
            txtPhone.Text = "";
            txtPhone.Select();
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnChange.Enabled = false;
        }
        private string FilterPhone(string phone)
        {
            string phoneAfterFilter = "";
            foreach (char c in phone)
            {
                if (char.IsDigit(c))
                {
                    phoneAfterFilter += c;
                }
            }
            return phoneAfterFilter;
        }

        public void Clear()
        {
            tblPhones.Rows.Clear();
           // PhonesToGrid();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text.Trim() != "")
            {
                addPhones(txtPhone.Text);
                ClearData();
            }
        }
        private void TxtPhone_MouseDown(object sender, MouseEventArgs e)
        {
        }
        private void TxtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && btnAdd.Enabled)
            {
                btnAdd.PerformClick();
            }
        }
        private void DgvPhones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void DgvPhones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhones.CurrentRow != null)
            {
                txtPhone.Text = dgvPhones.CurrentRow.Cells[0].Value.ToString();
                btnAdd.Enabled = false;
                btnChange.Enabled = true;
                btnDelete.Enabled = true;
            }
        }


        private void BtnChange_Click(object sender, EventArgs e)
        {
            if (dgvPhones.CurrentRow != null)
            {
                DataRow rowForEdit = FindRow(dgvPhones.CurrentRow.Cells[0].Value.ToString());
                if (rowForEdit != null)
                {
                    tblPhones.Constraints.Clear();
                    rowForEdit[0] = FilterPhone(txtPhone.Text);
                }
                PhonesToGrid();
                ClearData();
            }
        }
    

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (dgvPhones.CurrentRow != null)
            {
                DataRow rowForDelete = FindRow(dgvPhones.CurrentRow.Cells[0].Value.ToString());
                if (rowForDelete != null)
                {
                    rowForDelete.Delete();
                }
                PhonesToGrid();
                ClearData();
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        public DataTable GetPhoneAsDataTable()
        {
            return tblPhones;
        }
        public DataRow[] GetPhoneAsDataRowArray()
        {
            return tblPhones.Select();
        }
        public object[] GetPhoneAsObjectArray()
        {
            object[] o = new object[tblPhones.Rows.Count];
            DataRow[] rows = GetPhoneAsDataRowArray();
            for (int i = 0; i < tblPhones.Rows.Count; i += 1)
            {
                o[i] = rows[i][0];
            }
            return o;
        }
        public string[] GetPhoneAsStringArray()
        {
            string[] o = new string[tblPhones.Rows.Count];
            DataRow[] rows = GetPhoneAsDataRowArray();
            for (int i = 0; i < tblPhones.Rows.Count; i += 1)
            {
                o[i] = rows[i][0].ToString();
            }
            return o;
        }
        public string GetPhoneAsString()
        {
            string allPhone = "";
            string[] str = GetPhoneAsStringArray();
            for (int i = 0; i < str.Count(); i += 1)
            {
                allPhone += str[i] + ((i < str.Count() - 1) ? " , " : "");
            }
            return allPhone;
        }
        public int Count()
        {
            return tblPhones.Rows.Count;
        }

        private void Phones_Resize(object sender, EventArgs e)
        {

            if (this.Width < 345) this.Width = 345;
            txtPhone.Left = 10;
            txtPhone.Width = this.Width - lblPhone.Width - 20;
            lblPhone.Left = txtPhone.Width + 10;


            int SpaceButtons = 10;
            int btnWidth = (this.Width / 4) - (SpaceButtons * 2);
            btnNew.Width = btnWidth;
            btnAdd.Width = btnWidth;
            btnChange.Width = btnWidth;
            btnDelete.Width = btnWidth;
            btnDelete.Left = SpaceButtons;
            btnChange.Left = btnDelete.Left + btnDelete.Width + SpaceButtons;
            btnAdd.Left = btnChange.Left + btnChange.Width + SpaceButtons;
            btnNew.Left = btnAdd.Left + btnAdd.Width + SpaceButtons;
            dgvPhones.Left = 10;
            dgvPhones.Width = this.Width;
            dgvPhones.Height = (this.Height)-(btnAdd.Top+btnAdd.Height+150);

        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblPhone_Click(object sender, EventArgs e)
        {

        }
    }
}

