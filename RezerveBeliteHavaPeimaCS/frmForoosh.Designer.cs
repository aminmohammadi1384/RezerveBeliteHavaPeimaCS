namespace RezerveBeliteHavaPeimaCS
{
    partial class frmForoosh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            //Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.xtblForooshRoozaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Lbl_StartDate = new System.Windows.Forms.Label();
            this.Lbl_EndDate = new System.Windows.Forms.Label();
            this.MTxt_EndDate = new System.Windows.Forms.MaskedTextBox();
            this.MTxt_StartDate = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xtblForooshRoozaneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // xtblForooshRoozaneBindingSource
            // 
            this.xtblForooshRoozaneBindingSource.DataSource = typeof(RezerveBeliteHavaPeimaCS.xtblForooshRoozane);
            // 
            // reportViewer1
            // 
            //this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            /*reportDataSource1.Name = "Foroosh";
            reportDataSource1.Value = this.xtblForooshRoozaneBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);*/
            /*this.reportViewer1.LocalReport.ReportEmbeddedResource = "RezerveBeliteHavaPeimaCS.RptForooshRoozane.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 98);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(659, 370);
            this.reportViewer1.TabIndex = 0;*/
            // 
            // Lbl_StartDate
            // 
            this.Lbl_StartDate.AutoSize = true;
            this.Lbl_StartDate.Location = new System.Drawing.Point(576, 37);
            this.Lbl_StartDate.Name = "Lbl_StartDate";
            this.Lbl_StartDate.Size = new System.Drawing.Size(38, 13);
            this.Lbl_StartDate.TabIndex = 16;
            this.Lbl_StartDate.Text = "از تاریخ";
            // 
            // Lbl_EndDate
            // 
            this.Lbl_EndDate.AutoSize = true;
            this.Lbl_EndDate.Location = new System.Drawing.Point(577, 64);
            this.Lbl_EndDate.Name = "Lbl_EndDate";
            this.Lbl_EndDate.Size = new System.Drawing.Size(37, 13);
            this.Lbl_EndDate.TabIndex = 15;
            this.Lbl_EndDate.Text = "تا تاریخ";
            // 
            // MTxt_EndDate
            // 
            this.MTxt_EndDate.Location = new System.Drawing.Point(441, 61);
            this.MTxt_EndDate.Mask = "0000/00/00";
            this.MTxt_EndDate.Name = "MTxt_EndDate";
            this.MTxt_EndDate.Size = new System.Drawing.Size(119, 21);
            this.MTxt_EndDate.TabIndex = 14;
            // 
            // MTxt_StartDate
            // 
            this.MTxt_StartDate.Location = new System.Drawing.Point(441, 34);
            this.MTxt_StartDate.Mask = "0000/00/00";
            this.MTxt_StartDate.Name = "MTxt_StartDate";
            this.MTxt_StartDate.Size = new System.Drawing.Size(119, 21);
            this.MTxt_StartDate.TabIndex = 13;
            // 
            // Btn_Show
            // 
            this.Btn_Show.Location = new System.Drawing.Point(315, 47);
            this.Btn_Show.Name = "Btn_Show";
            this.Btn_Show.Size = new System.Drawing.Size(64, 35);
            this.Btn_Show.TabIndex = 17;
            this.Btn_Show.Text = "مشاهده";
            this.Btn_Show.UseVisualStyleBackColor = true;
            this.Btn_Show.Click += new System.EventHandler(this.Btn_Show_Click);
            // 
            // frmForoosh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 468);
            this.Controls.Add(this.Btn_Show);
            this.Controls.Add(this.Lbl_StartDate);
            this.Controls.Add(this.Lbl_EndDate);
            this.Controls.Add(this.MTxt_EndDate);
            this.Controls.Add(this.MTxt_StartDate);
            //this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "frmForoosh";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "میزان فروش روزانه";
            ((System.ComponentModel.ISupportInitialize)(this.xtblForooshRoozaneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

/*        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
*/        private System.Windows.Forms.BindingSource xtblForooshRoozaneBindingSource;
        private System.Windows.Forms.Label Lbl_StartDate;
        private System.Windows.Forms.Label Lbl_EndDate;
        private System.Windows.Forms.MaskedTextBox MTxt_EndDate;
        private System.Windows.Forms.MaskedTextBox MTxt_StartDate;
        private System.Windows.Forms.Button Btn_Show;
    }
}