using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Atf.UI;



namespace RezerveBeliteHavaPeimaCS
{
    public partial class RptPardakhtfrm : Form
    {
        public RptPardakhtfrm()
        {
            InitializeComponent();
        }

        private void RptPardakhtfrm_Load(object sender, EventArgs e)
        {
            UDF_Cmb_ShowNames();
            DateTimeSelector pers = new DateTimeSelector();
            pers.UsePersianFormat = true;
            pers.Location = new System.Drawing.Point(0,0);

        }


        private void UDF_Cmb_ShowNames()
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

        }

        private void UDF_ShowByCustomerName()
        {
            LSC_BeliteHavaPeymaDataContext db = new LSC_BeliteHavaPeymaDataContext();
            int int_CustomerID = int.Parse(Cmb_CustomerName.SelectedValue.ToString());
            var Query = from Row in db.xtblPardakhtis
                        where Row.CustomerID == int_CustomerID
                        select new
                        {
                            Row.CustomerID,
                            Row.NameSname,
                            Row.RezerverID,
                            Row.RezerveDate,
                            Row.ServiceDescript,
                            Row.BianehPardakhti
                        };

/*            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.ZoomPercent = 25;*/

            xtblPardakhtiBindingSource.DataSource = Query;
            //reportViewer1.RefreshReport();

        }

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            UDF_ShowByCustomerName();
        }
    }
}
