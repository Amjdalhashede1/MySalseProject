using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            txtEmpName.Text = "";
            rdbEmpMail.Checked = true;
            txtEmpAddres.Text = "";
            txtEmpIdNum.Text = "";
            txtpathImage.Text = "";
            pbEmpImage.Image = new PictureBox().Image;
            empPhones.Clear();
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
            else if (txtpathImage.Text.Trim() == "")
            {
                MessageBox.Show("لا بجد من اختيار صورة");
            }
            else if (empPhones.GetPhoneAsDataTable().Rows.Count<1)
            {
                MessageBox.Show("لا بجد من اختيار هاتف على الأقل");
            }
            else
            {
                string mesg = "";
               try 
	           {
                    DB.Run("insert into employee  values("+txtEmpNo.Text+ ",'" + txtEmpName.Text + "','"+((rdbEmpMail.Checked)?"ذكر": "انثى") +"','"+txtEmpAddres.Text+"','"+ txtEmpIdNum.Text+ "','" + dtpEmpBirthDate.Text + "','"+cbEmpQualific.Text+"','"+ cbEmpGinder.Text+ "')");
                    mesg += "تم اضافة بيانات الموضف بنجاح";
                    DB.cmd.Parameters.Clear();
                    MemoryStream ms = new MemoryStream();
                    pbEmpImage.Image.Save(ms,ImageFormat.Jpeg );
                    DB.cmd.Parameters.AddWithValue("@img",ms.ToArray());
                    DB.Run("insert into employee_image values (" + txtEmpNo.Text + ",@img)");
                    mesg += "تم اضافة صورة الموضف بنجاح , ";
                    foreach (string item in empPhones.GetPhoneAsStringArray())
                    {
                        DB.Run("insert into employee_phone values ("+ txtEmpNo.Text+ ",'"+item+"')");
                    }
                    mesg += ", تم اضافة " + empPhones.Count()+" هاتف" ;
                  //  ClearAndAuto();
                    
                }
	            catch (Exception ex)
	            {
                    MessageBox.Show(ex.Message);
	            }
                finally
                {
                    MessageBox.Show(mesg);
                }
            }
        }

        private void TxtEmpIdNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
           
        }

        private void Employee1_Load(object sender, EventArgs e)
        {

        }

        private void FrmEmployees_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
