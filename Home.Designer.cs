namespace HealthCare_Plus
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.welcome_text = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.admin_login_btn = new System.Windows.Forms.Button();
            this.welcome_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.welcome_image)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome_text
            // 
            this.welcome_text.AutoSize = true;
            this.welcome_text.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_text.ForeColor = System.Drawing.Color.Black;
            this.welcome_text.Location = new System.Drawing.Point(279, 32);
            this.welcome_text.Name = "welcome_text";
            this.welcome_text.Size = new System.Drawing.Size(243, 19);
            this.welcome_text.TabIndex = 0;
            this.welcome_text.Text = "Welcome To HealthCare Plus";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(255, 345);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(130, 38);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "Staff Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // admin_login_btn
            // 
            this.admin_login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.admin_login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_login_btn.FlatAppearance.BorderSize = 0;
            this.admin_login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_login_btn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_login_btn.Location = new System.Drawing.Point(391, 345);
            this.admin_login_btn.Name = "admin_login_btn";
            this.admin_login_btn.Size = new System.Drawing.Size(140, 38);
            this.admin_login_btn.TabIndex = 2;
            this.admin_login_btn.Text = "Admin Login";
            this.admin_login_btn.UseVisualStyleBackColor = false;
            this.admin_login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // welcome_image
            // 
            this.welcome_image.Image = global::HealthCare_Plus.Properties.Resources.receptionist;
            this.welcome_image.InitialImage = global::HealthCare_Plus.Properties.Resources.receptionist;
            this.welcome_image.Location = new System.Drawing.Point(272, 54);
            this.welcome_image.Name = "welcome_image";
            this.welcome_image.Size = new System.Drawing.Size(259, 274);
            this.welcome_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.welcome_image.TabIndex = 1;
            this.welcome_image.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.admin_login_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.welcome_image);
            this.Controls.Add(this.welcome_text);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home Page";
            ((System.ComponentModel.ISupportInitialize)(this.welcome_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_text;
        private System.Windows.Forms.PictureBox welcome_image;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button admin_login_btn;
    }
}

