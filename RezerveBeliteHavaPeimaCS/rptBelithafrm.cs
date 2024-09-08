using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;
using System.Linq;
using System.Globalization;



namespace RezerveBeliteHavaPeimaCS
{
    public partial class rptBelithafrm : Form
    {
        //DataSet1 d1 = new DataSet1();
        public rptBelithafrm()
        {
            InitializeComponent();
        }
       

        /*private void UDF_Cmb_ShowNames()
        {
            LSC_BeliteHavaPeymaDataContext db = new LSC_BeliteHavaPeymaDataContext();
            var Query = from Row in db.Custumers
                        select new
                        {
                            Row.CustomerID,
                            Row.NameSname
                        };


            Cmb_CustomerName.ValueMember = "CustomerID";
            Cmb_CustomerName.DisplayMember = "NameSname";
            Cmb_CustomerName.DataSource = Query;
        
        }*/


        private void rptBelithafrm_Load(object sender, EventArgs e)
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


        /*private void UDF_ShowByName()
        {
            LSC_BeliteHavaPeymaDataContext db = new LSC_BeliteHavaPeymaDataContext();
            int int_CustomerID = int.Parse(Cmb_CustomerName.SelectedValue.ToString());
            var Query = from Row in db.xtblBelithas
                        where Row.CustomerID == int_CustomerID
                        select new
                        {
                            Row.NameSname,
                            Row.PhoneNum,
                            Row.RezerveID,
                            Row.QuanTity,
                            Row.RezerveDate,
                            Row.ServiceDescript
                        };

            *//*reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.ZoomPercent = 25;*//*


            xtblBelithaBindingSource.DataSource = Query;
            //reportViewer1.RefreshReport();
        
        }*/


        /*private void UDF_ShowByDate()
        {
            LSC_BeliteHavaPeymaDataContext db = new LSC_BeliteHavaPeymaDataContext();

            var Query1 = from Row in db.xtblBelithas
                         select new
                        {
                            Row.NameSname,
                            Row.PhoneNum,
                            Row.RezerveID,
                            Row.QuanTity,
                            Row.RezerveDate,
                            Row.ServiceDescript,
                            Row.CustomerID
                        };

            try
            {
                Int64 int_StartDate = Convert.ToInt64(MTxt_StartDate.Text.Trim().Replace("/", ""));
                Int64 int_EndDate = Convert.ToInt64(MTxt_EndDate.Text.Trim().Replace("/", ""));


                int int_CustomerID = int.Parse(Cmb_CustomerName.SelectedValue.ToString());
                var Query2 = from Row in Query1
                             where ((Convert.ToInt64(Row.RezerveDate.Trim().Replace("/", "")) >= int_StartDate) && (Convert.ToInt64(Row.RezerveDate.Trim().Replace("/", "")) <= int_EndDate) &&
                            (Row.CustomerID == int_CustomerID))
                             select new
                             {

                                 Row.NameSname,
                                 Row.PhoneNum,
                                 Row.RezerveID,
                                 Row.QuanTity,
                                 Row.RezerveDate,
                                 Row.ServiceDescript

                             };

                *//*reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                reportViewer1.ZoomPercent = 25;*//*


                xtblBelithaBindingSource.DataSource = Query2;
                //reportViewer1.RefreshReport();

            }

            catch
            {
                MessageBox.Show("تاریخ ها را وارد کنید");
            }
        }*/


       /* private void Btn_Show_Click(object sender, EventArgs e)
        {
            if (Rdo_CustomerName.Checked==true)
            {

                UDF_ShowByName();

            }

            else if (Rdo_Date.Checked==true)
            {
            
                UDF_ShowByDate();
            
            }

            
        }*/





    }
}