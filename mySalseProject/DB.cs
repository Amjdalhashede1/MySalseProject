using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace mySalseProject
{ 
    class DB
    {
        public static string DBName = "mySalse";
        public static SqlConnection con = new SqlConnection(@"Server=.;Database="+DBName+"; Integrated Security=true");
        public static SqlCommand cmd = new SqlCommand("", con);
        
        public DB()
        {
            
        }
        public static void ChangeDBName(string DBName)
        {
            if (con.State == ConnectionState.Closed) {
                con.ConnectionString = @"Server=.; Database=" + DBName + "; Integrated Security=true";
            }
        }

     

        private static void Open()
        {
            if(con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
         
            }
        }
        private static void Close()
        {
            if (con.State != System.Data.ConnectionState.Closed)
            {
                con.Close();

            }
        }
        public static DataTable getData(string select)
        {
            Open();
            DataTable dt = new DataTable();
            cmd.CommandText = select;
            dt.Load(cmd.ExecuteReader());
            Close();
            //AddAction(select);
            return dt;
        }
        public static void Run(string SQl)
        {
            Open();
            cmd.CommandText = SQl;
            cmd.ExecuteNonQuery();
            AddAction(SQl);
            Close();
        }

        public static void setBgAndFont()
        {
            DataTable dt = getData("Select * from settings_bg");
           if (dt.Rows.Count <1)
           {
                DB.Run("insert into settings_bg_font values (255,255,255)");
           }
            v.R = Convert.ToInt32(dt.Rows[0][0]);
            v.G = Convert.ToInt32(dt.Rows[0][1]);
            v.B = Convert.ToInt32(dt.Rows[0][2]);
        }
        public static void AddAction(string Sql)
        {
            try
            {
                if (Application.OpenForms["frmMain"] !=null || Application.OpenForms["frmLogin"] != null)
                {
                    return;
                }
                string username = v.username;
                string date = DateTime.Now.ToString("yyyy/MM/dd");
                string time = DateTime.Now.ToString("hh:mm:ss");
                Form frm = new Form();
              
                frm = Application.OpenForms["frmMain"].ActiveMdiChild;
                string formName = "", operationName = "";
                if (frm != null) formName = frm.Name + "," + frm.Text;
                if (Sql.Trim().Substring(0, 6).ToLower() == "select")
                {
                    operationName = "استعلام";
                }
                if (Sql.Trim().Substring(0, 6).ToLower() == "insert")
                {
                    operationName = "اضافة";
                }
                if (Sql.Trim().Substring(0, 6).ToLower() == "delete")
                {
                    operationName = "حذف";
                }
                if (Sql.Trim().Substring(0, 6).ToLower() == "update")
                {
                    operationName = "تعديل";
                }
                string pcName = Environment.MachineName + "," + Environment.UserName;
                string data = Sql.Trim().Replace("", "'");

                MessageBox.Show(username);
                MessageBox.Show(date + "    " + time);
                MessageBox.Show(formName);
                MessageBox.Show(data);
                MessageBox.Show(operationName);
                cmd.CommandText = "insert into  program_actions(username,action_date,action_time,form_name,operation_name,action_data) values('" + username + "','" + date + "','" + time + "','" + formName + "','" + operationName + "','" + data + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message+" ok ");
            }
        }
    }
}
