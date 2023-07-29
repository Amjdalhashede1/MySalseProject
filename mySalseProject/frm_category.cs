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
    public partial class frm_category : Form
    {
        public frm_category()
        {
            InitializeComponent();
        }
        private void ClearAndAuto()
        {
            txtCatNo.Text = "";
            try
            {
                txtCatNo.Text = DB.getData("select max(category_no)+1 from category").Rows[0][0].ToString();
                if (txtCatNo.Text.Trim() == "") txtCatNo.Text = "1";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtCatName.Text = "";
            txtCatdetail.Text = "";
            txtCatName.Select();
        }
        private void BtnCatNew_Click(object sender, EventArgs e)
        {
            ClearAndAuto();
        }

        private void BtnCatAdd_Click(object sender, EventArgs e)
        {
            if (txtCatNo.Text.Trim() == "")
            {
                MessageBox.Show("رقم التصنيف فارغ");
            }
            else if (txtCatName.Text.Trim() == "")
            {
                MessageBox.Show("اسم التصنيف فارغ");
                txtCatName.Select();
            }
            else if (txtCatdetail.Text.Trim() == "")
             {
                MessageBox.Show("وصف التصنيف فارغ");
                txtCatdetail.Select();
            }
            else
            {
                try
                {
                    DB.Run("insert into category values (" + Convert.ToInt32(txtCatNo.Text) + "," +
                                                         "'" + txtCatName.Text + "'," +
                                                         "'"+txtCatdetail.Text+"')");
                     
                    MessageBox.Show("تم اضافة تصنيف بنجاح");
                    ClearAndAuto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Frm_category_Load(object sender, EventArgs e)
        {
            ClearAndAuto();
            
            //if (txtCatNo.Text.Trim() == "") txtCatNo.Text = "1";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
