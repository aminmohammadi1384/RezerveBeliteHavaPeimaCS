using Atf.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace RezerveBeliteHavaPeimaCS
{
    public partial class frmRptChartOfSale : Form
    {
        public frmRptChartOfSale()
        {
            InitializeComponent();
        }

        private void frmRptChartOfSale_Load(object sender, EventArgs e)
        {
            radioButton3.Select();
            panel1.Visible = false;
            /*LSC_BeliteHavaPeymaDataContext db = new LSC_BeliteHavaPeymaDataContext();

            var Query = from Row in db.xtblForooshRoozanes
                        select new
                             {

                                 Row.RezerveDate,
                                 Row.ForooshRoozane,

                             };

            Grd_Foroosh.DataSource = Query;*/
        }

        private void UDF_ShowForooshByDate()
        {
            /*LSC_BeliteHavaPeymaDataContext db = new LSC_BeliteHavaPeymaDataContext();

            var Query1 = from Row in db.xtblForooshRoozanes
                         select new
                         {
                             Row.RezerveDate,
                             Row.ForooshRoozane
                         };

            try
            {
                Int64 int_StartDate = Convert.ToInt64(MTxt_StartDate.Text.Trim().Replace("/", ""));
                Int64 int_EndDate = Convert.ToInt64(MTxt_EndDate.Text.Trim().Replace("/", ""));


                var Query2 = from Row in Query1
                             where ((Convert.ToInt64(Row.RezerveDate.Trim().Replace("/", "")) >= int_StartDate) && (Convert.ToInt64(Row.RezerveDate.Trim().Replace("/", "")) <= int_EndDate))
                             select new
                             {

                                 Row.RezerveDate,
                                 Row.ForooshRoozane

                             };

                *//*reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                reportViewer1.ZoomPercent = 25;


                xtblForooshRoozaneBindingSource.DataSource = Query2;
                reportViewer1.RefreshReport();*//*

            }


            catch
            {
                MessageBox.Show("تاریخ ها را وارد کنید");
            }*/
        }

        private void Grd_Foroosh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*bool bool_ok = false;
            try
            {
                string str_Date = Grd_Foroosh.Rows[e.RowIndex].Cells[0].Value.ToString();

                for (int i = 0; i < Lst_Date.Items.Count; i++)
                {
                    if (Lst_Date.Items[i].ToString() == str_Date)
                    {
                        bool_ok = true;

                    }
                }

                if (bool_ok == false)
                {
                    Lst_Date.Items.Add(str_Date);
                }


            }
            catch
            {
                MessageBox.Show("روی سلول های جدول کلیک کنید");
            }*/

            

      
        }

        private void Btn_ShowChart_Click(object sender, EventArgs e)
        {
                /*List<Int32> ListItems = new List<Int32>();
                for (int i = 0; i < Lst_Date.Items.Count; i++)
                {
                    ListItems.Add(Convert.ToInt32(Lst_Date.Items[i].ToString().Trim().Replace("/", "")));
                }

                LSC_BeliteHavaPeymaDataContext db = new LSC_BeliteHavaPeymaDataContext();
                var Query = from Row in db.xtblForooshRoozanes
                            where ListItems.Contains(Convert.ToInt32(Row.RezerveDate.ToString().Trim().Replace("/", "")))
                            select new
                            {
                                Row.RezerveDate,
                                Row.ForooshRoozane

                            };


                *//*reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                reportViewer1.ZoomPercent = 25;*//*


                xtblForooshRoozaneBindingSource.DataSource = Query;
                //reportViewer1.RefreshReport();*/

        }

        private void Btn_Show_Click_1(object sender, EventArgs e)
        {
            UDF_ShowForooshByDate();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
           /* try
            {
                Lst_Date.Items.RemoveAt(Lst_Date.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("یک تاریخ از لیست انتخاب شود");
            }*/
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string connectionString = "server=(local);Database=reserveairplane;trusted_connection=yes;";
            SqlConnection connection = new SqlConnection(connectionString);

            // تاریخ امروز را به فرمت مناسب برای SQL تبدیل کنید
            string today = DateTime.Now.ToString("yyyy-MM-dd"); // فرمت تاریخ میلادی

            // کوئری SQL با فیلتر تاریخ امروز
            string query = $"SELECT TOP 100 PERCENT FullName AS [نام و نام خانوادگی], PhoneNum AS [شماره تلفن], FaxNum AS ایمیل, mabdaa AS مبدا, maghsad AS مقصد, date AS [تاریخ صدور] FROM rptsale WHERE CAST(date AS DATE) = '{today}'";
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);

            // تبدیل تاریخ میلادی به شمسی
            foreach (DataRow row in dt.Rows)
            {
                DateTime date = Convert.ToDateTime(row["تاریخ صدور"]);
                PersianCalendar pc = new PersianCalendar();
                string shamsiDate = $"{pc.GetYear(date)}/{pc.GetMonth(date):D2}/{pc.GetDayOfMonth(date):D2}";
                row["تاریخ صدور"] = shamsiDate; // جایگزینی تاریخ میلادی با تاریخ شمسی
            }

            // نمایش اطلاعات در DataGridView
            dataGridView1.DataSource = dt;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string connectionString = "server=(local);Database=reserveairplane;trusted_connection=yes;";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT TOP 100 PERCENT FullName AS [نام و نام خانوادگی], PhoneNum AS [شماره تلفن], FaxNum AS ایمیل, mabdaa AS مبدا, maghsad AS مقصد, date AS [تاریخ صدور] FROM rptsale";
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);

            // تبدیل تاریخ میلادی به شمسی
            foreach (DataRow row in dt.Rows)
            {
                DateTime date = Convert.ToDateTime(row["تاریخ صدور"]);
                PersianCalendar pc = new PersianCalendar();
                string shamsiDate = $"{pc.GetYear(date)}/{pc.GetMonth(date):D2}/{pc.GetDayOfMonth(date):D2}";
                row["تاریخ صدور"] = shamsiDate; // جایگزینی تاریخ میلادی با تاریخ شمسی
            }

            // نمایش اطلاعات در DataGridView
            dataGridView1.DataSource = dt;
        }


       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string startDateInput = textBox1.Text; // تکست باکس تاریخ شروع
            string endDateInput = textBox2.Text; // تکست باکس تاریخ پایان

            // اعتبارسنجی فرمت تاریخ شمسی
            string datePattern = @"^\d{4}/\d{2}/\d{2}$";
            if (!Regex.IsMatch(startDateInput, datePattern) || !Regex.IsMatch(endDateInput, datePattern))
            {
                MessageBox.Show("لطفاً تاریخ‌ها را به فرمت YYYY/MM/DD وارد کنید.");
                return;
            }

            // تبدیل تاریخ شمسی به میلادی
            string[] startParts = startDateInput.Split('/');
            int startYear = int.Parse(startParts[0]);
            int startMonth = int.Parse(startParts[1]);
            int startDay = int.Parse(startParts[2]);

            string[] endParts = endDateInput.Split('/');
            int endYear = int.Parse(endParts[0]);
            int endMonth = int.Parse(endParts[1]);
            int endDay = int.Parse(endParts[2]);

            PersianCalendar pc = new PersianCalendar();
            DateTime startDate = pc.ToDateTime(startYear, startMonth, startDay, 0, 0, 0, 0);
            DateTime endDate = pc.ToDateTime(endYear, endMonth, endDay, 0, 0, 0, 0);

            // دریافت رکوردها از دیتابیس
            DataTable dt = new DataTable();
            string connectionString = "server=(local);Database=reserveairplane;trusted_connection=yes;"; // آدرس دیتابیس خود را وارد کنید
            string query = "SELECT * FROM rptsale WHERE date >= @StartDate AND date <= @EndDate";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    conn.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            // نمایش رکوردها در DataGridView
            dataGridView1.DataSource = dt;
        }
    }
}
