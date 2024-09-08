namespace RezerveBeliteHavaPeimaCS
{
    partial class RptPardakhtfrm
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
            //Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Lbl_CustomerName = new System.Windows.Forms.Label();
            this.Cmb_CustomerName = new System.Windows.Forms.ComboBox();
            this.Btn_Show = new System.Windows.Forms.Button();
            //this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtblPardakhtiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtblPardakhtiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_CustomerName
            // 
            this.Lbl_CustomerName.AutoSize = true;
            this.Lbl_CustomerName.Location = new System.Drawing.Point(811, 34);
            this.Lbl_CustomerName.Name = "Lbl_CustomerName";
            this.Lbl_CustomerName.Size = new System.Drawing.Size(60, 13);
            this.Lbl_CustomerName.TabIndex = 16;
            this.Lbl_CustomerName.Text = "نام مشتری";
            // 
            // Cmb_CustomerName
            // 
            this.Cmb_CustomerName.FormattingEnabled = true;
            this.Cmb_CustomerName.Location = new System.Drawing.Point(684, 31);
            this.Cmb_CustomerName.Name = "Cmb_CustomerName";
            this.Cmb_CustomerName.Size = new System.Drawing.Size(121, 21);
            this.Cmb_CustomerName.TabIndex = 15;
            // 
            // Btn_Show
            // 
            this.Btn_Show.Location = new System.Drawing.Point(539, 21);
            this.Btn_Show.Name = "Btn_Show";
            this.Btn_Show.Size = new System.Drawing.Size(59, 39);
            this.Btn_Show.TabIndex = 14;
            this.Btn_Show.Text = "مشاهده";
            this.Btn_Show.UseVisualStyleBackColor = true;
            this.Btn_Show.Click += new System.EventHandler(this.Btn_Show_Click);
            // 
            // reportViewer1
            // 
            /*this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource2.Name = "Pardakht";
            reportDataSource2.Value = this.xtblPardakhtiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RezerveBeliteHavaPeimaCS.RptPardakht.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 79);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(889, 424);
            this.reportViewer1.TabIndex = 17;*/
            // 
            // xtblPardakhtiBindingSource
            // 
            this.xtblPardakhtiBindingSource.DataSource = typeof(RezerveBeliteHavaPeimaCS.xtblPardakhti);
            // 
            // RptPardakhtfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 503);
            //this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Lbl_CustomerName);
            this.Controls.Add(this.Cmb_CustomerName);
            this.Controls.Add(this.Btn_Show);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "RptPardakhtfrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Tag = "";
            this.Text = "لیست پرداخت ها";
            this.Load += new System.EventHandler(this.RptPardakhtfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtblPardakhtiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_CustomerName;
        private System.Windows.Forms.ComboBox Cmb_CustomerName;
        private System.Windows.Forms.Button Btn_Show;
        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource xtblPardakhtiBindingSource;
    }
}