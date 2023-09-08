namespace HealthCare_Plus.Forms.Auth
{
    partial class StaffLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffLoginForm));
            this.back_to_home_lable = new System.Windows.Forms.Label();
            this.welcome_text = new System.Windows.Forms.Label();
            this.email_input = new System.Windows.Forms.TextBox();
            this.email_address_label = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_to_home_lable
            // 
            this.back_to_home_lable.AutoSize = true;
            this.back_to_home_lable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_to_home_lable.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_to_home_lable.Location = new System.Drawing.Point(332, 409);
            this.back_to_home_lable.Name = "back_to_home_lable";
            this.back_to_home_lable.Size = new System.Drawing.Size(137, 20);
            this.back_to_home_lable.TabIndex = 1;
            this.back_to_home_lable.Text = "Go Back To Home";
            this.back_to_home_lable.Click += new System.EventHandler(this.back_to_home_lable_Click);
            // 
            // welcome_text
            // 
            this.welcome_text.AutoSize = true;
            this.welcome_text.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_text.ForeColor = System.Drawing.Color.Black;
            this.welcome_text.Location = new System.Drawing.Point(303, 21);
            this.welcome_text.Name = "welcome_text";
            this.welcome_text.Size = new System.Drawing.Size(195, 19);
            this.welcome_text.TabIndex = 2;
            this.welcome_text.Text = "Login To Staff Account";
            // 
            // email_input
            // 
            this.email_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_input.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_input.Location = new System.Drawing.Point(291, 162);
            this.email_input.MaxLength = 300;
            this.email_input.MinimumSize = new System.Drawing.Size(2, 21);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(222, 21);
            this.email_input.TabIndex = 5;
            // 
            // email_address_label
            // 
            this.email_address_label.AutoSize = true;
            this.email_address_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.email_address_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_address_label.Location = new System.Drawing.Point(287, 139);
            this.email_address_label.Name = "email_address_label";
            this.email_address_label.Size = new System.Drawing.Size(112, 20);
            this.email_address_label.TabIndex = 4;
            this.email_address_label.Text = "Email Address";
            // 
            // password_input
            // 
            this.password_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_input.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_input.Location = new System.Drawing.Point(291, 224);
            this.password_input.MaxLength = 300;
            this.password_input.MinimumSize = new System.Drawing.Size(2, 21);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(222, 21);
            this.password_input.TabIndex = 7;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.password_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(287, 201);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(79, 20);
            this.password_label.TabIndex = 6;
            this.password_label.Text = "Password";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(314, 277);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(173, 38);
            this.login_btn.TabIndex = 8;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // StaffLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_input);
            this.Controls.Add(this.email_address_label);
            this.Controls.Add(this.welcome_text);
            this.Controls.Add(this.back_to_home_lable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Login";
            this.Load += new System.EventHandler(this.StaffLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label back_to_home_lable;
        private System.Windows.Forms.Label welcome_text;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.Label email_address_label;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button login_btn;
    }
}