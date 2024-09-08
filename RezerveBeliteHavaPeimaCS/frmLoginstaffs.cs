using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezerveBeliteHavaPeimaCS
{
    public partial class frmLoginstaffs : Form
    {
        public frmLoginstaffs()
        {
            InitializeComponent();
        }

        private void دربارهبرنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("شرکت هواپیمایی QOM FLY نسخه1.1");
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void مسافرجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCostumers frm = new frmCostumers();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void رزروبلیتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRezerveSale frm = new frmRezerveSale();
            //frm.MdiParent = this;
            frm.Show();
        }
    }
}
