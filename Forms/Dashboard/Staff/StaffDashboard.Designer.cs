namespace HealthCare_Plus.Forms.Dashboard
{
    partial class StaffDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashboard));
            this.logout_btn = new System.Windows.Forms.Button();
            this.username_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcome_text = new System.Windows.Forms.Label();
            this.staffDashboardTabs = new System.Windows.Forms.TabControl();
            this.doctorsTab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.staffDashboardTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Location = new System.Drawing.Point(997, 576);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(75, 23);
            this.logout_btn.TabIndex = 18;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.ForestGreen;
            this.username_label.Location = new System.Drawing.Point(1022, 61);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(50, 15);
            this.username_label.TabIndex = 17;
            this.username_label.Text = "System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HealthCare_Plus.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(1022, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // welcome_text
            // 
            this.welcome_text.AutoSize = true;
            this.welcome_text.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_text.ForeColor = System.Drawing.Color.Black;
            this.welcome_text.Location = new System.Drawing.Point(471, 18);
            this.welcome_text.Name = "welcome_text";
            this.welcome_text.Size = new System.Drawing.Size(142, 19);
            this.welcome_text.TabIndex = 15;
            this.welcome_text.Text = "Staff Dashboard";
            // 
            // staffDashboardTabs
            // 
            this.staffDashboardTabs.Controls.Add(this.doctorsTab);
            this.staffDashboardTabs.Controls.Add(this.tabPage2);
            this.staffDashboardTabs.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffDashboardTabs.Location = new System.Drawing.Point(15, 88);
            this.staffDashboardTabs.Name = "staffDashboardTabs";
            this.staffDashboardTabs.SelectedIndex = 0;
            this.staffDashboardTabs.Size = new System.Drawing.Size(1055, 476);
            this.staffDashboardTabs.TabIndex = 19;
            // 
            // doctorsTab
            // 
            this.doctorsTab.Location = new System.Drawing.Point(4, 31);
            this.doctorsTab.Name = "doctorsTab";
            this.doctorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.doctorsTab.Size = new System.Drawing.Size(1047, 441);
            this.doctorsTab.TabIndex = 0;
            this.doctorsTab.Text = "Doctors";
            this.doctorsTab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1047, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // StaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.staffDashboardTabs);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.welcome_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Dashboard";
            this.Load += new System.EventHandler(this.StaffDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.staffDashboardTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcome_text;
        private System.Windows.Forms.TabControl staffDashboardTabs;
        private System.Windows.Forms.TabPage doctorsTab;
        private System.Windows.Forms.TabPage tabPage2;
    }
}