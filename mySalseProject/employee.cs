using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mySalseProject
{
    public partial class employee : UserControl
    {
        public employee()
        {
            InitializeComponent();
        }

        private void Employee_Resize(object sender, EventArgs e)
        {
            cbxEmp.Left = 0;
            cbxEmp.Width = this.Width;
        }
        private void LoadEmployees()
        {
            if (!this.DesignMode)
            {
                DataTable dt = DB.getData("select emp_no,emp_name from employee");
                cbxEmp.DataSource = dt;
                cbxEmp.ValueMember = "emp_no";
                cbxEmp.DisplayMember = "emp_name";
            }
        }

        public object getValue()
        {
            return cbxEmp.SelectedValue;
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }
        public ComboBox getItems()
        {
            return cbxEmp;
        }
        public bool IsSelected()
        {
            return ((cbxEmp.SelectedIndex<0)?false:true);
        }
        public void SetIndex(int index)
        {
            cbxEmp.SelectedIndex = index;
        }
        public int getIndex(int index)
        {
            return cbxEmp.SelectedIndex;
        }
        public void setEmploeeNotUser()
        {
            if (!this.DesignMode)
            {
                DataTable dt = DB.getData("select emp_no,emp_name from employee_not_user");
                cbxEmp.DataSource = dt;
                cbxEmp.ValueMember = "emp_no";
                cbxEmp.DisplayMember = "emp_name";
            }
        }
        public void SetValue(int index)
        {
            cbxEmp.SelectedValue = index;
        }
        public void setEmployeesAll()
        {
            LoadEmployees();
        }
    }
}
