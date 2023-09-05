namespace HealthCare_Plus.Forms.Dashboard.Admin
{
    partial class PatientsForm
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
            this.dataPanel = new System.Windows.Forms.Panel();
            this.PatientDataGridView = new System.Windows.Forms.DataGridView();
            this.reset_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_doc_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Last_name_input = new System.Windows.Forms.TextBox();
            this.Address_input = new System.Windows.Forms.TextBox();
            this.Phone_no_input = new System.Windows.Forms.TextBox();
            this.Email_input = new System.Windows.Forms.TextBox();
            this.First_name_input = new System.Windows.Forms.TextBox();
            this.Last_name_label = new System.Windows.Forms.Label();
            this.Address_label = new System.Windows.Forms.Label();
            this.Phone_no_label = new System.Windows.Forms.Label();
            this.Email_address_label = new System.Windows.Forms.Label();
            this.First_name_label = new System.Windows.Forms.Label();
            this.crudPanel = new System.Windows.Forms.Panel();
            this.Disease_input = new System.Windows.Forms.TextBox();
            this.Diseases_label = new System.Windows.Forms.Label();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataGridView)).BeginInit();
            this.crudPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.PatientDataGridView);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(0, 260);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(800, 190);
            this.dataPanel.TabIndex = 3;
            // 
            // PatientDataGridView
            // 
            this.PatientDataGridView.AllowUserToAddRows = false;
            this.PatientDataGridView.AllowUserToDeleteRows = false;
            this.PatientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.PatientDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientDataGridView.EnableHeadersVisualStyles = false;
            this.PatientDataGridView.Location = new System.Drawing.Point(0, 0);
            this.PatientDataGridView.MultiSelect = false;
            this.PatientDataGridView.Name = "PatientDataGridView";
            this.PatientDataGridView.ReadOnly = true;
            this.PatientDataGridView.Size = new System.Drawing.Size(800, 190);
            this.PatientDataGridView.TabIndex = 0;
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_btn.FlatAppearance.BorderSize = 0;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reset_btn.Location = new System.Drawing.Point(369, 196);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(119, 38);
            this.reset_btn.TabIndex = 27;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = false;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(90)))));
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(244, 196);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(119, 38);
            this.delete_btn.TabIndex = 26;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            // 
            // update_doc_btn
            // 
            this.update_doc_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(81)))));
            this.update_doc_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_doc_btn.FlatAppearance.BorderSize = 0;
            this.update_doc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_doc_btn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_doc_btn.Location = new System.Drawing.Point(119, 196);
            this.update_doc_btn.Name = "update_doc_btn";
            this.update_doc_btn.Size = new System.Drawing.Size(119, 38);
            this.update_doc_btn.TabIndex = 25;
            this.update_doc_btn.Text = "Update";
            this.update_doc_btn.UseVisualStyleBackColor = false;
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
            this.Add_btn.TabIndex = 24;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = false;
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
            this.Phone_no_input.Location = new System.Drawing.Point(271, 99);
            this.Phone_no_input.MaxLength = 300;
            this.Phone_no_input.MinimumSize = new System.Drawing.Size(2, 21);
            this.Phone_no_input.Name = "Phone_no_input";
            this.Phone_no_input.Size = new System.Drawing.Size(222, 21);
            this.Phone_no_input.TabIndex = 17;
            // 
            // Email_input
            // 
            this.Email_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email_input.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_input.Location = new System.Drawing.Point(16, 99);
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
            this.Phone_no_label.Location = new System.Drawing.Point(267, 76);
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
            this.Email_address_label.Location = new System.Drawing.Point(12, 76);
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
            this.crudPanel.Controls.Add(this.Disease_input);
            this.crudPanel.Controls.Add(this.Diseases_label);
            this.crudPanel.Controls.Add(this.reset_btn);
            this.crudPanel.Controls.Add(this.delete_btn);
            this.crudPanel.Controls.Add(this.update_doc_btn);
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
            this.crudPanel.TabIndex = 2;
            // 
            // Disease_input
            // 
            this.Disease_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Disease_input.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disease_input.Location = new System.Drawing.Point(271, 153);
            this.Disease_input.MaxLength = 300;
            this.Disease_input.MinimumSize = new System.Drawing.Size(2, 21);
            this.Disease_input.Name = "Disease_input";
            this.Disease_input.Size = new System.Drawing.Size(222, 21);
            this.Disease_input.TabIndex = 29;
            // 
            // Diseases_label
            // 
            this.Diseases_label.AutoSize = true;
            this.Diseases_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Diseases_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diseases_label.Location = new System.Drawing.Point(267, 130);
            this.Diseases_label.Name = "Diseases_label";
            this.Diseases_label.Size = new System.Drawing.Size(104, 20);
            this.Diseases_label.TabIndex = 28;
            this.Diseases_label.Text = "Main Disease";
            // 
            // PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.crudPanel);
            this.Name = "PatientsForm";
            this.Text = "PatientsForm";
            this.Load += new System.EventHandler(this.PatientsForm_Load);
            this.dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataGridView)).EndInit();
            this.crudPanel.ResumeLayout(false);
            this.crudPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.DataGridView PatientDataGridView;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_doc_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.TextBox Last_name_input;
        private System.Windows.Forms.TextBox Address_input;
        private System.Windows.Forms.TextBox Phone_no_input;
        private System.Windows.Forms.TextBox Email_input;
        private System.Windows.Forms.TextBox First_name_input;
        private System.Windows.Forms.Label Last_name_label;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Label Phone_no_label;
        private System.Windows.Forms.Label Email_address_label;
        private System.Windows.Forms.Label First_name_label;
        private System.Windows.Forms.Panel crudPanel;
        private System.Windows.Forms.TextBox Disease_input;
        private System.Windows.Forms.Label Diseases_label;
    }
}