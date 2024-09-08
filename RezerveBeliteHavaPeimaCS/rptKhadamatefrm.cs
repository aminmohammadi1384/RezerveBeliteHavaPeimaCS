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



namespace RezerveBeliteHavaPeimaCS
{
    public partial class rptKhadamatefrm : Form
    {
       // DataSet1 d1 = new DataSet1();
        public rptKhadamatefrm()
        {
            InitializeComponent();
        }

        private void rptKhadamatefrm_Load(object sender, EventArgs e)
        {
            //FirstClass db = new FirstClass();
            //db.cmd.CommandText = @"SELECT     ServiceID, ServiceDescript, ServiceDate, Quantity, ExpireBit FROM ServicesDef ORDER BY ServiceID";

            //SqlDataAdapter da = new SqlDataAdapter(db.cmd);
            //da.Fill(d1, "ServicesDef");
            ////rptServisHaCris c1 = new rptServisHaCris();

            ////c1.SetDataSource(d1);
            ////crystalReportViewer1.ReportSource = c1;
            ////crystalReportViewer1.Refresh();
            //this.reportViewer1.RefreshReport();
        }


        private void UDF_ShowExpired()
        {
            LSC_BeliteHavaPeymaDataContext db = new LSC_BeliteHavaPeymaDataContext();
            var Query = from Row in db.xtblServices
                        where Row.ExpireBit == true
                        select new
                        {
                            Row.ServiceID,
                            Row.ServiceDescript,
                            Row.ServiceDate,
                            Row.Quantity,
                            Row.Expr1,
                            Row.ExpireBit
                        };

            /*reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.ZoomPercent = 25;*/


            xtblServiceBindingSource.DataSource = Query;
            //reportViewer1.RefreshReport();
        
        }

        private void UDF_ShowByDate()
        {
            /*LSC_BeliteHavaPeymaDataContext db = new LSC_BeliteHavaPeymaDataContext();

            var Query1 = from Row in db.xtblServices
                         select new
                         {
                             Row.ServiceID,
                             Row.ServiceDescript,
                             Row.ServiceDate,
                             Row.Quantity,
                             Row.Expr1,
                             Row.ExpireBit
                         };

            try
            {
                Int64 int_StartDate = Convert.ToInt64(MTxt_StartDate.Text.Trim().Replace("/", ""));
                Int64 int_EndDate = Convert.ToInt64(MTxt_EndDate.Text.Trim().Replace("/", ""));


                var Query2 = from Row in Query1
                             where ((Convert.ToInt64(Row.ServiceDate.Trim().Replace("/", "")) >= int_StartDate) && (Convert.ToInt64(Row.ServiceDate.Trim().Replace("/", "")) <= int_EndDate))
                             select new
                             {
                                 Row.ServiceID,
                                 Row.ServiceDescript,
                                 Row.ServiceDate,
                                 Row.Quantity,
                                 Row.Expr1,
                                 Row.ExpireBit

                             };

                *//*reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                reportViewer1.ZoomPercent = 25;*//*


                xtblServiceBindingSource.DataSource = Query2;
                //reportViewer1.RefreshReport();

            }

            catch
            {
                MessageBox.Show("تاریخ ها را وارد کنید");
            }*/


        }


        private void Btn_Show_Click(object sender, EventArgs e)
        {
            /*if (Rdo_Expired.Checked==true)
            {
                UDF_ShowExpired();
            }

            else if (Rdo_Date.Checked==true)
            {
                UDF_ShowByDate();                
            }*/
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=(local);Database=reserveairplane;trusted_connection=yes;";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT     TOP 100 PERCENT SeatNumber AS [شماره صندلی], FullName AS [نام و نام خانوادگی], PhoneNumber AS [شماره تلفن], FaxNumber AS ایمیل FROM   tehmash31tir";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);

            // نمایش اطلاعات در DataGridView
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "server=(local);Database=reserveairplane;trusted_connection=yes;";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT     TOP 100 PERCENT SeatNumber AS [شماره صندلی], FullName AS [نام و نام خانوادگی], PhoneNumber AS [شماره تلفن], FaxNumber AS ایمیل FROM   tehah31tir";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);

            // نمایش اطلاعات در DataGridView
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "server=(local);Database=reserveairplane;trusted_connection=yes;";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT     TOP 100 PERCENT SeatNumber AS [شماره صندلی], FullName AS [نام و نام خانوادگی], PhoneNumber AS [شماره تلفن], FaxNumber AS ایمیل FROM   tehmash1mordad";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);

            // نمایش اطلاعات در DataGridView
            dataGridView1.DataSource = dt;
        }
    }
}