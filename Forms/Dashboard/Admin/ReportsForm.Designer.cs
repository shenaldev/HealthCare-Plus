namespace HealthCare_Plus.Forms.Dashboard.Admin
{
    partial class ReportsForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Title_label = new System.Windows.Forms.Label();
            this.DoctorsReportBtn = new System.Windows.Forms.Button();
            this.PatientsReportBtn = new System.Windows.Forms.Button();
            this.PaymentsReportBtn = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.reportsView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BodyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_label
            // 
            this.Title_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.Location = new System.Drawing.Point(371, 18);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(142, 21);
            this.Title_label.TabIndex = 1;
            this.Title_label.Text = "Renerate Reports";
            // 
            // DoctorsReportBtn
            // 
            this.DoctorsReportBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DoctorsReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.DoctorsReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoctorsReportBtn.FlatAppearance.BorderSize = 0;
            this.DoctorsReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoctorsReportBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorsReportBtn.Location = new System.Drawing.Point(184, 60);
            this.DoctorsReportBtn.Name = "DoctorsReportBtn";
            this.DoctorsReportBtn.Size = new System.Drawing.Size(156, 36);
            this.DoctorsReportBtn.TabIndex = 21;
            this.DoctorsReportBtn.Text = "Doctors Report";
            this.DoctorsReportBtn.UseVisualStyleBackColor = false;
            this.DoctorsReportBtn.Click += new System.EventHandler(this.DoctorsReportBtn_Click);
            // 
            // PatientsReportBtn
            // 
            this.PatientsReportBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PatientsReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.PatientsReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientsReportBtn.FlatAppearance.BorderSize = 0;
            this.PatientsReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientsReportBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientsReportBtn.Location = new System.Drawing.Point(364, 60);
            this.PatientsReportBtn.Name = "PatientsReportBtn";
            this.PatientsReportBtn.Size = new System.Drawing.Size(156, 36);
            this.PatientsReportBtn.TabIndex = 22;
            this.PatientsReportBtn.Text = "Patients Report";
            this.PatientsReportBtn.UseVisualStyleBackColor = false;
            this.PatientsReportBtn.Click += new System.EventHandler(this.PatientsReportBtn_Click);
            // 
            // PaymentsReportBtn
            // 
            this.PaymentsReportBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PaymentsReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.PaymentsReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaymentsReportBtn.FlatAppearance.BorderSize = 0;
            this.PaymentsReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentsReportBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentsReportBtn.Location = new System.Drawing.Point(544, 60);
            this.PaymentsReportBtn.Name = "PaymentsReportBtn";
            this.PaymentsReportBtn.Size = new System.Drawing.Size(156, 36);
            this.PaymentsReportBtn.TabIndex = 23;
            this.PaymentsReportBtn.Text = "Payments Report";
            this.PaymentsReportBtn.UseVisualStyleBackColor = false;
            this.PaymentsReportBtn.Click += new System.EventHandler(this.PaymentsReportBtn_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(884, 136);
            this.TopPanel.TabIndex = 24;
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.reportsView);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 136);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(884, 375);
            this.BodyPanel.TabIndex = 25;
            // 
            // reportsView
            // 
            this.reportsView.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DoctorsDataSet";
            reportDataSource2.Value = null;
            this.reportsView.LocalReport.DataSources.Add(reportDataSource2);
            this.reportsView.LocalReport.ReportEmbeddedResource = "HealthCare_Plus.Forms.Dashboard.Reports.DoctorsReport.rdlc";
            this.reportsView.Location = new System.Drawing.Point(0, 0);
            this.reportsView.Name = "reportsView";
            this.reportsView.ServerReport.BearerToken = null;
            this.reportsView.Size = new System.Drawing.Size(884, 375);
            this.reportsView.TabIndex = 0;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.PaymentsReportBtn);
            this.Controls.Add(this.PatientsReportBtn);
            this.Controls.Add(this.DoctorsReportBtn);
            this.Controls.Add(this.Title_label);
            this.Controls.Add(this.TopPanel);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.BodyPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Button DoctorsReportBtn;
        private System.Windows.Forms.Button PatientsReportBtn;
        private System.Windows.Forms.Button PaymentsReportBtn;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel BodyPanel;
        private Microsoft.Reporting.WinForms.ReportViewer reportsView;
    }
}