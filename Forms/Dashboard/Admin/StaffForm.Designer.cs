namespace HealthCare_Plus.Forms.Dashboard.Admin
{
    partial class StaffForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Password_input = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Last_name_input = new System.Windows.Forms.TextBox();
            this.Address_input = new System.Windows.Forms.TextBox();
            this.Phone_no_input = new System.Windows.Forms.TextBox();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.StaffDataGridView = new System.Windows.Forms.DataGridView();
            this.Email_input = new System.Windows.Forms.TextBox();
            this.First_name_input = new System.Windows.Forms.TextBox();
            this.Last_name_label = new System.Windows.Forms.Label();
            this.Address_label = new System.Windows.Forms.Label();
            this.Phone_no_label = new System.Windows.Forms.Label();
            this.Email_address_label = new System.Windows.Forms.Label();
            this.First_name_label = new System.Windows.Forms.Label();
            this.crudPanel = new System.Windows.Forms.Panel();
            this.RoleComoboBox = new System.Windows.Forms.ComboBox();
            this.Role_label = new System.Windows.Forms.Label();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGridView)).BeginInit();
            this.crudPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Password_input
            // 
            this.Password_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password_input.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_input.Location = new System.Drawing.Point(271, 153);
            this.Password_input.MaxLength = 300;
            this.Password_input.MinimumSize = new System.Drawing.Size(2, 21);
            this.Password_input.Name = "Password_input";
            this.Password_input.Size = new System.Drawing.Size(222, 21);
            this.Password_input.TabIndex = 19;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Password_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.Location = new System.Drawing.Point(267, 130);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(79, 20);
            this.Password_label.TabIndex = 28;
            this.Password_label.Text = "Password";
            // 
            // Reset_btn
            // 
            this.Reset_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset_btn.FlatAppearance.BorderSize = 0;
            this.Reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_btn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reset_btn.Location = new System.Drawing.Point(369, 196);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(119, 38);
            this.Reset_btn.TabIndex = 23;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = false;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(90)))));
            this.Delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_btn.FlatAppearance.BorderSize = 0;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.Location = new System.Drawing.Point(244, 196);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(119, 38);
            this.Delete_btn.TabIndex = 22;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(81)))));
            this.Update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update_btn.FlatAppearance.BorderSize = 0;
            this.Update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_btn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.Location = new System.Drawing.Point(119, 196);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(119, 38);
            this.Update_btn.TabIndex = 21;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.Add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_btn.FlatAppearance.BorderSize = 0;
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_btn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.Location = new System.Drawing.Point(16, 196);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(97, 38);
            this.Add_btn.TabIndex = 20;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Last_name_input
            // 
            this.Last_name_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Last_name_input.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last_name_input.Location = new System.Drawing.Point(271, 32);
            this.Last_name_input.MaxLength = 300;
            this.Last_name_input.MinimumSize = new System.Drawing.Size(2, 21);
            this.Last_name_input.Name = "Last_name_input";
            this.Last_name_input.Size = new System.Drawing.Size(222, 21);
            this.Last_name_input.TabIndex = 14;
            // 
            // Address_input
            // 
            this.Address_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Address_input.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_input.Location = new System.Drawing.Point(16, 153);
            this.Address_input.MaxLength = 300;
            this.Address_input.MinimumSize = new System.Drawing.Size(2, 21);
            this.Address_input.Name = "Address_input";
            this.Address_input.Size = new System.Drawing.Size(222, 21);
            this.Address_input.TabIndex = 18;
            // 
            // Phone_no_input
            // 
            this.Phone_no_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Phone_no_input.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_no_input.Location = new System.Drawing.Point(271, 93);
            this.Phone_no_input.MaxLength = 300;
            this.Phone_no_input.MinimumSize = new System.Drawing.Size(2, 21);
            this.Phone_no_input.Name = "Phone_no_input";
            this.Phone_no_input.Size = new System.Drawing.Size(222, 21);
            this.Phone_no_input.TabIndex = 17;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.StaffDataGridView);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(0, 260);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(800, 190);
            this.dataPanel.TabIndex = 5;
            // 
            // StaffDataGridView
            // 
            this.StaffDataGridView.AllowUserToAddRows = false;
            this.StaffDataGridView.AllowUserToDeleteRows = false;
            this.StaffDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.StaffDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffDataGridView.EnableHeadersVisualStyles = false;
            this.StaffDataGridView.Location = new System.Drawing.Point(0, 0);
            this.StaffDataGridView.MultiSelect = false;
            this.StaffDataGridView.Name = "StaffDataGridView";
            this.StaffDataGridView.ReadOnly = true;
            this.StaffDataGridView.Size = new System.Drawing.Size(800, 190);
            this.StaffDataGridView.TabIndex = 0;
            this.StaffDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellDoubleClick);
            // 
            // Email_input
            // 
            this.Email_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email_input.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_input.Location = new System.Drawing.Point(16, 93);
            this.Email_input.MaxLength = 300;
            this.Email_input.MinimumSize = new System.Drawing.Size(2, 21);
            this.Email_input.Name = "Email_input";
            this.Email_input.Size = new System.Drawing.Size(222, 21);
            this.Email_input.TabIndex = 15;
            // 
            // First_name_input
            // 
            this.First_name_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.First_name_input.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_name_input.Location = new System.Drawing.Point(16, 32);
            this.First_name_input.MaxLength = 300;
            this.First_name_input.MinimumSize = new System.Drawing.Size(2, 21);
            this.First_name_input.Name = "First_name_input";
            this.First_name_input.Size = new System.Drawing.Size(222, 21);
            this.First_name_input.TabIndex = 13;
            // 
            // Last_name_label
            // 
            this.Last_name_label.AutoSize = true;
            this.Last_name_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Last_name_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last_name_label.Location = new System.Drawing.Point(267, 9);
            this.Last_name_label.Name = "Last_name_label";
            this.Last_name_label.Size = new System.Drawing.Size(85, 20);
            this.Last_name_label.TabIndex = 7;
            this.Last_name_label.Text = "Last Name";
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Address_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_label.Location = new System.Drawing.Point(12, 130);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(68, 20);
            this.Address_label.TabIndex = 9;
            this.Address_label.Text = "Address";
            // 
            // Phone_no_label
            // 
            this.Phone_no_label.AutoSize = true;
            this.Phone_no_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Phone_no_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_no_label.Location = new System.Drawing.Point(267, 70);
            this.Phone_no_label.Name = "Phone_no_label";
            this.Phone_no_label.Size = new System.Drawing.Size(121, 20);
            this.Phone_no_label.TabIndex = 10;
            this.Phone_no_label.Text = "Phone Number";
            // 
            // Email_address_label
            // 
            this.Email_address_label.AutoSize = true;
            this.Email_address_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Email_address_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_address_label.Location = new System.Drawing.Point(12, 70);
            this.Email_address_label.Name = "Email_address_label";
            this.Email_address_label.Size = new System.Drawing.Size(112, 20);
            this.Email_address_label.TabIndex = 11;
            this.Email_address_label.Text = "Email Address";
            // 
            // First_name_label
            // 
            this.First_name_label.AutoSize = true;
            this.First_name_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.First_name_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_name_label.Location = new System.Drawing.Point(12, 9);
            this.First_name_label.Name = "First_name_label";
            this.First_name_label.Size = new System.Drawing.Size(88, 20);
            this.First_name_label.TabIndex = 12;
            this.First_name_label.Text = "First Name";
            // 
            // crudPanel
            // 
            this.crudPanel.Controls.Add(this.RoleComoboBox);
            this.crudPanel.Controls.Add(this.Role_label);
            this.crudPanel.Controls.Add(this.Password_input);
            this.crudPanel.Controls.Add(this.Password_label);
            this.crudPanel.Controls.Add(this.Reset_btn);
            this.crudPanel.Controls.Add(this.Delete_btn);
            this.crudPanel.Controls.Add(this.Update_btn);
            this.crudPanel.Controls.Add(this.Add_btn);
            this.crudPanel.Controls.Add(this.Last_name_input);
            this.crudPanel.Controls.Add(this.Address_input);
            this.crudPanel.Controls.Add(this.Phone_no_input);
            this.crudPanel.Controls.Add(this.Email_input);
            this.crudPanel.Controls.Add(this.First_name_input);
            this.crudPanel.Controls.Add(this.Last_name_label);
            this.crudPanel.Controls.Add(this.Address_label);
            this.crudPanel.Controls.Add(this.Phone_no_label);
            this.crudPanel.Controls.Add(this.Email_address_label);
            this.crudPanel.Controls.Add(this.First_name_label);
            this.crudPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.crudPanel.Location = new System.Drawing.Point(0, 0);
            this.crudPanel.Name = "crudPanel";
            this.crudPanel.Size = new System.Drawing.Size(800, 260);
            this.crudPanel.TabIndex = 4;
            // 
            // RoleComoboBox
            // 
            this.RoleComoboBox.BackColor = System.Drawing.Color.White;
            this.RoleComoboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleComoboBox.ForeColor = System.Drawing.Color.Black;
            this.RoleComoboBox.FormattingEnabled = true;
            this.RoleComoboBox.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.RoleComoboBox.Location = new System.Drawing.Point(532, 31);
            this.RoleComoboBox.Name = "RoleComoboBox";
            this.RoleComoboBox.Size = new System.Drawing.Size(121, 21);
            this.RoleComoboBox.TabIndex = 30;
            // 
            // Role_label
            // 
            this.Role_label.AutoSize = true;
            this.Role_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Role_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role_label.Location = new System.Drawing.Point(528, 9);
            this.Role_label.Name = "Role_label";
            this.Role_label.Size = new System.Drawing.Size(41, 20);
            this.Role_label.TabIndex = 29;
            this.Role_label.Text = "Role";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.crudPanel);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGridView)).EndInit();
            this.crudPanel.ResumeLayout(false);
            this.crudPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Password_input;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.TextBox Last_name_input;
        private System.Windows.Forms.TextBox Address_input;
        private System.Windows.Forms.TextBox Phone_no_input;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.DataGridView StaffDataGridView;
        private System.Windows.Forms.TextBox Email_input;
        private System.Windows.Forms.TextBox First_name_input;
        private System.Windows.Forms.Label Last_name_label;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Label Phone_no_label;
        private System.Windows.Forms.Label Email_address_label;
        private System.Windows.Forms.Label First_name_label;
        private System.Windows.Forms.Panel crudPanel;
        private System.Windows.Forms.ComboBox RoleComoboBox;
        private System.Windows.Forms.Label Role_label;
    }
}