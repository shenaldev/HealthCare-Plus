namespace HealthCare_Plus.Forms.Dashboard.Reports
{
    partial class InvoiceView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceView));
            this.ReportView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReportView
            // 
            this.ReportView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportView.LocalReport.ReportEmbeddedResource = "HealthCare_Plus.Forms.Dashboard.Reports.Invoice.rdlc";
            this.ReportView.Location = new System.Drawing.Point(0, 0);
            this.ReportView.Name = "ReportView";
            this.ReportView.ServerReport.BearerToken = null;
            this.ReportView.Size = new System.Drawing.Size(800, 450);
            this.ReportView.TabIndex = 0;
            // 
            // InvoiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReportView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvoiceView";
            this.Text = "Invoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InvoiceView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportView;
    }
}