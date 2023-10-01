namespace HealthCare_Plus.Forms.Dashboard.Common
{
    partial class AppoinmentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.selected_apt_no = new System.Windows.Forms.Label();
            this.appointment_selected_label = new System.Windows.Forms.Label();
            this.select_notice_label = new System.Windows.Forms.Label();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.Search_patient_input = new System.Windows.Forms.ComboBox();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.healthcareplusDataSet = new HealthCare_Plus.DataSets.HealthcareplusDataSet();
            this.Search_doc_input = new System.Windows.Forms.ComboBox();
            this.selectDoctorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectDoctorDataSet = new HealthCare_Plus.DataSets.SelectDoctorDataSet();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Search_date_input = new System.Windows.Forms.DateTimePicker();
            this.search_date_label = new System.Windows.Forms.Label();
            this.search_doc_label = new System.Windows.Forms.Label();
            this.search_location_label = new System.Windows.Forms.Label();
            this.search_by_label = new System.Windows.Forms.Label();
            this.View_invoice_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Title_label = new System.Windows.Forms.Label();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.AppointmentsGridView = new System.Windows.Forms.DataGridView();
            this.usersTableAdapter = new HealthCare_Plus.DataSets.SelectDoctorDataSetTableAdapters.UsersTableAdapter();
            this.patientsTableAdapter = new HealthCare_Plus.DataSets.HealthcareplusDataSetTableAdapters.PatientsTableAdapter();
            this.TopPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthcareplusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDoctorDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDoctorDataSet)).BeginInit();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.selected_apt_no);
            this.TopPanel.Controls.Add(this.appointment_selected_label);
            this.TopPanel.Controls.Add(this.select_notice_label);
            this.TopPanel.Controls.Add(this.SearchPanel);
            this.TopPanel.Controls.Add(this.View_invoice_btn);
            this.TopPanel.Controls.Add(this.Update_btn);
            this.TopPanel.Controls.Add(this.Add_btn);
            this.TopPanel.Controls.Add(this.Title_label);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(884, 267);
            this.TopPanel.TabIndex = 0;
            // 
            // selected_apt_no
            // 
            this.selected_apt_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.selected_apt_no.AutoSize = true;
            this.selected_apt_no.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_apt_no.Location = new System.Drawing.Point(502, 67);
            this.selected_apt_no.Name = "selected_apt_no";
            this.selected_apt_no.Size = new System.Drawing.Size(44, 18);
            this.selected_apt_no.TabIndex = 2;
            this.selected_apt_no.Text = "None";
            // 
            // appointment_selected_label
            // 
            this.appointment_selected_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.appointment_selected_label.AutoSize = true;
            this.appointment_selected_label.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointment_selected_label.Location = new System.Drawing.Point(330, 67);
            this.appointment_selected_label.Name = "appointment_selected_label";
            this.appointment_selected_label.Size = new System.Drawing.Size(166, 18);
            this.appointment_selected_label.TabIndex = 1;
            this.appointment_selected_label.Text = "Selected Appointment:";
            // 
            // select_notice_label
            // 
            this.select_notice_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.select_notice_label.AutoSize = true;
            this.select_notice_label.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_notice_label.Location = new System.Drawing.Point(291, 96);
            this.select_notice_label.Name = "select_notice_label";
            this.select_notice_label.Size = new System.Drawing.Size(303, 15);
            this.select_notice_label.TabIndex = 3;
            this.select_notice_label.Text = "Select an appointment for update and view invoice";
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchPanel.Controls.Add(this.Search_patient_input);
            this.SearchPanel.Controls.Add(this.Search_doc_input);
            this.SearchPanel.Controls.Add(this.Search_btn);
            this.SearchPanel.Controls.Add(this.Search_date_input);
            this.SearchPanel.Controls.Add(this.search_date_label);
            this.SearchPanel.Controls.Add(this.search_doc_label);
            this.SearchPanel.Controls.Add(this.search_location_label);
            this.SearchPanel.Controls.Add(this.search_by_label);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SearchPanel.Location = new System.Drawing.Point(0, 187);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(884, 80);
            this.SearchPanel.TabIndex = 23;
            // 
            // Search_patient_input
            // 
            this.Search_patient_input.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Search_patient_input.DataSource = this.patientsBindingSource;
            this.Search_patient_input.DisplayMember = "contact_no";
            this.Search_patient_input.FormattingEnabled = true;
            this.Search_patient_input.Location = new System.Drawing.Point(362, 46);
            this.Search_patient_input.Name = "Search_patient_input";
            this.Search_patient_input.Size = new System.Drawing.Size(160, 21);
            this.Search_patient_input.TabIndex = 36;
            this.Search_patient_input.ValueMember = "id";
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.healthcareplusDataSet;
            // 
            // healthcareplusDataSet
            // 
            this.healthcareplusDataSet.DataSetName = "HealthcareplusDataSet";
            this.healthcareplusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Search_doc_input
            // 
            this.Search_doc_input.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Search_doc_input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Search_doc_input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Search_doc_input.DataSource = this.selectDoctorDataSetBindingSource;
            this.Search_doc_input.DisplayMember = "first_name";
            this.Search_doc_input.FormattingEnabled = true;
            this.Search_doc_input.Location = new System.Drawing.Point(105, 46);
            this.Search_doc_input.Name = "Search_doc_input";
            this.Search_doc_input.Size = new System.Drawing.Size(163, 21);
            this.Search_doc_input.TabIndex = 35;
            this.Search_doc_input.ValueMember = "id";
            // 
            // selectDoctorDataSetBindingSource
            // 
            this.selectDoctorDataSetBindingSource.DataMember = "Users";
            this.selectDoctorDataSetBindingSource.DataSource = this.selectDoctorDataSet;
            // 
            // selectDoctorDataSet
            // 
            this.selectDoctorDataSet.DataSetName = "SelectDoctorDataSet";
            this.selectDoctorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Search_btn
            // 
            this.Search_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.Search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_btn.FlatAppearance.BorderSize = 0;
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.Location = new System.Drawing.Point(768, 41);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(80, 30);
            this.Search_btn.TabIndex = 38;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Search_date_input
            // 
            this.Search_date_input.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Search_date_input.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Search_date_input.Location = new System.Drawing.Point(595, 46);
            this.Search_date_input.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.Search_date_input.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.Search_date_input.Name = "Search_date_input";
            this.Search_date_input.Size = new System.Drawing.Size(142, 20);
            this.Search_date_input.TabIndex = 37;
            // 
            // search_date_label
            // 
            this.search_date_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.search_date_label.AutoSize = true;
            this.search_date_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_date_label.Location = new System.Drawing.Point(541, 46);
            this.search_date_label.Name = "search_date_label";
            this.search_date_label.Size = new System.Drawing.Size(47, 20);
            this.search_date_label.TabIndex = 33;
            this.search_date_label.Text = "Date:";
            // 
            // search_doc_label
            // 
            this.search_doc_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.search_doc_label.AutoSize = true;
            this.search_doc_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.search_doc_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_doc_label.Location = new System.Drawing.Point(37, 46);
            this.search_doc_label.Name = "search_doc_label";
            this.search_doc_label.Size = new System.Drawing.Size(62, 20);
            this.search_doc_label.TabIndex = 30;
            this.search_doc_label.Text = "Doctor:";
            // 
            // search_location_label
            // 
            this.search_location_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.search_location_label.AutoSize = true;
            this.search_location_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_location_label.Location = new System.Drawing.Point(291, 46);
            this.search_location_label.Name = "search_location_label";
            this.search_location_label.Size = new System.Drawing.Size(65, 20);
            this.search_location_label.TabIndex = 32;
            this.search_location_label.Text = "Patient:";
            // 
            // search_by_label
            // 
            this.search_by_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.search_by_label.AutoSize = true;
            this.search_by_label.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_by_label.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.search_by_label.Location = new System.Drawing.Point(403, 18);
            this.search_by_label.Name = "search_by_label";
            this.search_by_label.Size = new System.Drawing.Size(79, 18);
            this.search_by_label.TabIndex = 5;
            this.search_by_label.Text = "Search By:";
            // 
            // View_invoice_btn
            // 
            this.View_invoice_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.View_invoice_btn.BackColor = System.Drawing.Color.SlateBlue;
            this.View_invoice_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.View_invoice_btn.Enabled = false;
            this.View_invoice_btn.FlatAppearance.BorderSize = 0;
            this.View_invoice_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_invoice_btn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_invoice_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.View_invoice_btn.Location = new System.Drawing.Point(503, 140);
            this.View_invoice_btn.Name = "View_invoice_btn";
            this.View_invoice_btn.Size = new System.Drawing.Size(110, 30);
            this.View_invoice_btn.TabIndex = 22;
            this.View_invoice_btn.Text = "View Invoice";
            this.View_invoice_btn.UseVisualStyleBackColor = false;
            this.View_invoice_btn.Click += new System.EventHandler(this.View_invoice_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(81)))));
            this.Update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update_btn.Enabled = false;
            this.Update_btn.FlatAppearance.BorderSize = 0;
            this.Update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_btn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.Location = new System.Drawing.Point(387, 140);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(110, 30);
            this.Update_btn.TabIndex = 21;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.Add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_btn.FlatAppearance.BorderSize = 0;
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_btn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.Location = new System.Drawing.Point(271, 140);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(110, 30);
            this.Add_btn.TabIndex = 20;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Title_label
            // 
            this.Title_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.Location = new System.Drawing.Point(350, 9);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(185, 21);
            this.Title_label.TabIndex = 0;
            this.Title_label.Text = "Manage Appointments";
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.AppointmentsGridView);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 267);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(884, 183);
            this.BodyPanel.TabIndex = 1;
            // 
            // AppointmentsGridView
            // 
            this.AppointmentsGridView.AllowUserToAddRows = false;
            this.AppointmentsGridView.AllowUserToDeleteRows = false;
            this.AppointmentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentsGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.AppointmentsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AppointmentsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AppointmentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppointmentsGridView.EnableHeadersVisualStyles = false;
            this.AppointmentsGridView.Location = new System.Drawing.Point(0, 0);
            this.AppointmentsGridView.MultiSelect = false;
            this.AppointmentsGridView.Name = "AppointmentsGridView";
            this.AppointmentsGridView.ReadOnly = true;
            this.AppointmentsGridView.Size = new System.Drawing.Size(884, 183);
            this.AppointmentsGridView.TabIndex = 6;
            this.AppointmentsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnGridViewCellDubleClick);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // AppoinmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "AppoinmentForm";
            this.Text = "AppoinmentForm";
            this.Load += new System.EventHandler(this.AppoinmentForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthcareplusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDoctorDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDoctorDataSet)).EndInit();
            this.BodyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Button View_invoice_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.DateTimePicker Search_date_input;
        private System.Windows.Forms.Label search_date_label;
        private System.Windows.Forms.Label search_doc_label;
        private System.Windows.Forms.Label search_location_label;
        private System.Windows.Forms.Label search_by_label;
        private System.Windows.Forms.ComboBox Search_doc_input;
        private System.Windows.Forms.BindingSource selectDoctorDataSetBindingSource;
        private DataSets.SelectDoctorDataSet selectDoctorDataSet;
        private DataSets.SelectDoctorDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ComboBox Search_patient_input;
        private DataSets.HealthcareplusDataSet healthcareplusDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private DataSets.HealthcareplusDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.Label appointment_selected_label;
        private System.Windows.Forms.Label select_notice_label;
        private System.Windows.Forms.Label selected_apt_no;
        private System.Windows.Forms.DataGridView AppointmentsGridView;
    }
}