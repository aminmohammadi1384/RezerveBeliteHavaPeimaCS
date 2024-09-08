using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RezerveBeliteHavaPeimaCS
{
    class FirstClass
    {
        SqlConnection con;
        public SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        public FirstClass()
        {
            con = new SqlConnection("server=(local);Database=reserveairplane;trusted_connection=yes;");
            //con = new SqlConnection("Data Source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDbFilename=|DataDirectory|\\RezerveBelitTotal_Data.MDF;Initial Catalog=RezerveBelitTotal;User Instance=True");
            //con = new SqlConnection(@"Data Source=.\sqlexpress;AttachDbFilename=G:\DB-1002\Barnameh_Nevisi\C#\RezerveBeliteHavaPeimaCS\RezerveBeliteHavaPeimaCS\bin\Debug\RezerveBelitTotal_Data.MDF;Integrated Security=SSPI;");
            cmd = new SqlCommand();
            dt = new DataTable();
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
        }

        public DataTable dbOut(string sql)
        {
            cmd.CommandText = sql;
            con.Open();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public void exeCommand(string strName)
        {
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = strName;
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void exeCommand1(string strName)
        {
            try
            {
                cmd.CommandText = strName;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                con.Close();
            }

        }

        public string dtShamsi()
        {
            string strMydate;
            PersianCalendar calFar1 = new PersianCalendar();
            strMydate = calFar1.GetYear(DateTime.Now).ToString() + "/" + calFar1.GetMonth(DateTime.Now).ToString("00") + "/" + calFar1.GetDayOfMonth(DateTime.Now).ToString("00");
            return strMydate;
        }
    }

}
