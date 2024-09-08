using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RezerveBeliteHavaPeimaCS
{
    public partial class frmForoosh : Form
    {
        public frmForoosh()
        {
            InitializeComponent();
        }


        private void UDF_ShowForooshByDate()
        {
            LSC_BeliteHavaPeymaDataContext db = new LSC_BeliteHavaPeymaDataContext();

            var Query1 = from Row in db.xtblForooshRoozanes
                         select new
                        {
                            Row.RezerveDate,
                            Row.ForooshRoozane,
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
                                 Row.ForooshRoozane,

                             };

                /*reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                reportViewer1.ZoomPercent = 25;


                xtblForooshRoozaneBindingSource.DataSource = Query2;
                reportViewer1.RefreshReport();*/

            }


            catch
            {
                MessageBox.Show("تاریخ ها را وارد کنید");
            }
        }


        private void Btn_Show_Click(object sender, EventArgs e)
        {
            UDF_ShowForooshByDate();
        }

    
    }
}
