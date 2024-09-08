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
    public partial class rptStafsfrm : Form
    {
        DataSet1 d1 = new DataSet1();
        public rptStafsfrm()
        {
            InitializeComponent();
        }

        private void UDF_ShowStaffs()
        {
            LSC_BeliteHavaPeymaDataContext db = new LSC_BeliteHavaPeymaDataContext();
            var Query = from Row in db.StaffsTables
                        orderby Row.StaffID ascending
                        select new
                        {
                            Row.StaffID,
                            Row.NameSname,
                            Row.PhoneNum,
                            Row.FaxNum,
                            Row.Notes,

                        };

            /*reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.ZoomPercent = 25;*/


            StaffsTableBindingSource.DataSource = Query;
            //reportViewer1.RefreshReport();
                
        }

        private void rptStafsfrm_Load(object sender, EventArgs e)
        {
            FirstClass db = new FirstClass();

            db.cmd.CommandText = @"SELECT satffID, Namesname, PhoneNum, FaxNum FROM staffs";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(db.cmd);
            da.Fill(dt);

            // Clear the existing columns in the DataGridView
            //dataGridView1.Columns.Clear();

            // Add the columns to the DataGridView with custom header text
            dataGridView1.Columns["column1"].DataPropertyName = "satffID";
            dataGridView1.Columns["column2"].DataPropertyName = "Namesname";
            dataGridView1.Columns["column3"].DataPropertyName = "PhoneNum";
            dataGridView1.Columns["column4"].DataPropertyName = "FaxNum";

            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 8.25F);
            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dt;


        }

    }
}