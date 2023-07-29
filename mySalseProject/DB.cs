using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void Open()
        {
            if(con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
         
            }
        }
        public void Close()
        {
            if (con.State != System.Data.ConnectionState.Closed)
            {
                con.Close();

            }
        }
        public static DataTable getData(string select)
        {
            con.Open();
            DataTable dt = new DataTable();
            cmd.CommandText = select;
            dt.Load(cmd.ExecuteReader());
            con.Close ();
            return dt;
        }
        public static void Run(string SQl)
        {
            con.Open();
            cmd.CommandText = SQl;
            cmd.ExecuteNonQuery();
            con.Close();
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
    }
}
