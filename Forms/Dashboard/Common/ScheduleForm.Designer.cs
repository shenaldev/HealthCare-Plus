namespace HealthCare_Plus.Forms.Dashboard.Common
{
    partial class ScheduleForm
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
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.Search_btn = new System.Windows.Forms.Button();
            this.searchDateInput = new System.Windows.Forms.DateTimePicker();
            this.search_date_label = new System.Windows.Forms.Label();
            this.searchLocationInput = new System.Windows.Forms.ComboBox();
            this.search_doc_label = new System.Windows.Forms.Label();
            this.search_location_label = new System.Windows.Forms.Label();
            this.searchDocInput = new System.Windows.Forms.TextBox();
            this.search_by_label = new System.Windows.Forms.Label();
            this.CrudPanel = new System.Windows.Forms.Panel();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.endDateInput = new System.Windows.Forms.DateTimePicker();
            this.end_time_label = new System.Windows.Forms.Label();
            this.room_number_input = new System.Windows.Forms.ComboBox();
            this.room_no_label = new System.Windows.Forms.Label();
            this.startDate_input = new System.Windows.Forms.DateTimePicker();
            this.date_time_label = new System.Windows.Forms.Label();
            this.location_input = new System.Windows.Forms.ComboBox();
            this.Location_label = new System.Windows.Forms.Label();
            this.doctor_input = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectDoctorDataSet = new HealthCare_Plus.SelectDoctorDataSet();
            this.doctor_label = new System.Windows.Forms.Label();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.ScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.usersTableAdapter = new HealthCare_Plus.SelectDoctorDataSetTableAdapters.UsersTableAdapter();
            this.TopPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.CrudPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDoctorDataSet)).BeginInit();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.SearchPanel);
            this.TopPanel.Controls.Add(this.CrudPanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(884, 272);
            this.TopPanel.TabIndex = 0;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchPanel.Controls.Add(this.Search_btn);
            this.SearchPanel.Controls.Add(this.searchDateInput);
            this.SearchPanel.Controls.Add(this.search_date_label);
            this.SearchPanel.Controls.Add(this.searchLocationInput);
            this.SearchPanel.Controls.Add(this.search_doc_label);
            this.SearchPanel.Controls.Add(this.search_location_label);
            this.SearchPanel.Controls.Add(this.searchDocInput);
            this.SearchPanel.Controls.Add(this.search_by_label);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchPanel.Location = new System.Drawing.Point(0, 192);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(884, 80);
            this.SearchPanel.TabIndex = 1;
            // 
            // Search_btn
            // 
            this.Search_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.Search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_btn.FlatAppearance.BorderSize = 0;
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.Location = new System.Drawing.Point(793, 36);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(80, 30);
            this.Search_btn.TabIndex = 34;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // searchDateInput
            // 
            this.searchDateInput.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchDateInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.searchDateInput.Location = new System.Drawing.Point(620, 46);
            this.searchDateInput.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.searchDateInput.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.searchDateInput.Name = "searchDateInput";
            this.searchDateInput.Size = new System.Drawing.Size(142, 20);
            this.searchDateInput.TabIndex = 37;
            // 
            // search_date_label
            // 
            this.search_date_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.search_date_label.AutoSize = true;
            this.search_date_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_date_label.Location = new System.Drawing.Point(566, 46);
            this.search_date_label.Name = "search_date_label";
            this.search_date_label.Size = new System.Drawing.Size(47, 20);
            this.search_date_label.TabIndex = 36;
            this.search_date_label.Text = "Date:";
            // 
            // searchLocationInput
            // 
            this.searchLocationInput.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchLocationInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchLocationInput.FormattingEnabled = true;
            this.searchLocationInput.Items.AddRange(new object[] {
            "Kandy",
            "Colombo"});
            this.searchLocationInput.Location = new System.Drawing.Point(393, 46);
            this.searchLocationInput.Name = "searchLocationInput";
            this.searchLocationInput.Size = new System.Drawing.Size(152, 21);
            this.searchLocationInput.TabIndex = 34;
            // 
            // search_doc_label
            // 
            this.search_doc_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.search_doc_label.AutoSize = true;
            this.search_doc_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.search_doc_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_doc_label.Location = new System.Drawing.Point(12, 46);
            this.search_doc_label.Name = "search_doc_label";
            this.search_doc_label.Size = new System.Drawing.Size(109, 20);
            this.search_doc_label.TabIndex = 11;
            this.search_doc_label.Text = "Doctor Name:";
            // 
            // search_location_label
            // 
            this.search_location_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.search_location_label.AutoSize = true;
            this.search_location_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_location_label.Location = new System.Drawing.Point(316, 46);
            this.search_location_label.Name = "search_location_label";
            this.search_location_label.Size = new System.Drawing.Size(74, 20);
            this.search_location_label.TabIndex = 35;
            this.search_location_label.Text = "Location:";
            // 
            // searchDocInput
            // 
            this.searchDocInput.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchDocInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchDocInput.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDocInput.Location = new System.Drawing.Point(127, 46);
            this.searchDocInput.MaxLength = 300;
            this.searchDocInput.MinimumSize = new System.Drawing.Size(2, 21);
            this.searchDocInput.Name = "searchDocInput";
            this.searchDocInput.Size = new System.Drawing.Size(171, 21);
            this.searchDocInput.TabIndex = 12;
            // 
            // search_by_label
            // 
            this.search_by_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.search_by_label.AutoSize = true;
            this.search_by_label.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_by_label.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.search_by_label.Location = new System.Drawing.Point(403, 18);
            this.search_by_label.Name = "search_by_label";
            this.search_by_label.Size = new System.Drawing.Size(79, 18);
            this.search_by_label.TabIndex = 5;
            this.search_by_label.Text = "Search By:";
            // 
            // CrudPanel
            // 
            this.CrudPanel.Controls.Add(this.Reset_btn);
            this.CrudPanel.Controls.Add(this.Delete_btn);
            this.CrudPanel.Controls.Add(this.Update_btn);
            this.CrudPanel.Controls.Add(this.Add_btn);
            this.CrudPanel.Controls.Add(this.endDateInput);
            this.CrudPanel.Controls.Add(this.end_time_label);
            this.CrudPanel.Controls.Add(this.room_number_input);
            this.CrudPanel.Controls.Add(this.room_no_label);
            this.CrudPanel.Controls.Add(this.startDate_input);
            this.CrudPanel.Controls.Add(this.date_time_label);
            this.CrudPanel.Controls.Add(this.location_input);
            this.CrudPanel.Controls.Add(this.Location_label);
            this.CrudPanel.Controls.Add(this.doctor_input);
            this.CrudPanel.Controls.Add(this.doctor_label);
            this.CrudPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CrudPanel.Location = new System.Drawing.Point(0, 0);
            this.CrudPanel.Name = "CrudPanel";
            this.CrudPanel.Size = new System.Drawing.Size(884, 192);
            this.CrudPanel.TabIndex = 0;
            // 
            // Reset_btn
            // 
            this.Reset_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset_btn.FlatAppearance.BorderSize = 0;
            this.Reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_btn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reset_btn.Location = new System.Drawing.Point(378, 143);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(100, 30);
            this.Reset_btn.TabIndex = 33;
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
            this.Delete_btn.Location = new System.Drawing.Point(260, 143);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(100, 30);
            this.Delete_btn.TabIndex = 32;
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
            this.Update_btn.Location = new System.Drawing.Point(144, 143);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(100, 30);
            this.Update_btn.TabIndex = 31;
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
            this.Add_btn.Location = new System.Drawing.Point(31, 143);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(100, 30);
            this.Add_btn.TabIndex = 30;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // endDateInput
            // 
            this.endDateInput.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.endDateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateInput.Location = new System.Drawing.Point(260, 101);
            this.endDateInput.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.endDateInput.MinDate = new System.DateTime(2023, 8, 9, 0, 0, 0, 0);
            this.endDateInput.Name = "endDateInput";
            this.endDateInput.Size = new System.Drawing.Size(198, 20);
            this.endDateInput.TabIndex = 14;
            this.endDateInput.Value = new System.DateTime(2023, 9, 8, 10, 53, 18, 0);
            // 
            // end_time_label
            // 
            this.end_time_label.AutoSize = true;
            this.end_time_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_time_label.Location = new System.Drawing.Point(256, 77);
            this.end_time_label.Name = "end_time_label";
            this.end_time_label.Size = new System.Drawing.Size(117, 20);
            this.end_time_label.TabIndex = 29;
            this.end_time_label.Text = "End Date Time";
            // 
            // room_number_input
            // 
            this.room_number_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.room_number_input.FormattingEnabled = true;
            this.room_number_input.Items.AddRange(new object[] {
            "Room 1",
            "Room 2",
            "Room 3",
            "Room 4",
            "Room 5",
            "Room 6"});
            this.room_number_input.Location = new System.Drawing.Point(390, 41);
            this.room_number_input.Name = "room_number_input";
            this.room_number_input.Size = new System.Drawing.Size(152, 21);
            this.room_number_input.TabIndex = 12;
            // 
            // room_no_label
            // 
            this.room_no_label.AutoSize = true;
            this.room_no_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_no_label.Location = new System.Drawing.Point(386, 18);
            this.room_no_label.Name = "room_no_label";
            this.room_no_label.Size = new System.Drawing.Size(116, 20);
            this.room_no_label.TabIndex = 26;
            this.room_no_label.Text = "Room Number";
            // 
            // startDate_input
            // 
            this.startDate_input.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.startDate_input.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate_input.Location = new System.Drawing.Point(31, 101);
            this.startDate_input.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.startDate_input.MinDate = new System.DateTime(2023, 8, 9, 0, 0, 0, 0);
            this.startDate_input.Name = "startDate_input";
            this.startDate_input.Size = new System.Drawing.Size(213, 20);
            this.startDate_input.TabIndex = 13;
            this.startDate_input.Value = new System.DateTime(2023, 9, 8, 10, 53, 18, 0);
            // 
            // date_time_label
            // 
            this.date_time_label.AutoSize = true;
            this.date_time_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_time_label.Location = new System.Drawing.Point(27, 77);
            this.date_time_label.Name = "date_time_label";
            this.date_time_label.Size = new System.Drawing.Size(123, 20);
            this.date_time_label.TabIndex = 25;
            this.date_time_label.Text = "Start Date Time";
            // 
            // location_input
            // 
            this.location_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location_input.FormattingEnabled = true;
            this.location_input.Items.AddRange(new object[] {
            "Kandy",
            "Colombo"});
            this.location_input.Location = new System.Drawing.Point(208, 42);
            this.location_input.Name = "location_input";
            this.location_input.Size = new System.Drawing.Size(152, 21);
            this.location_input.TabIndex = 11;
            // 
            // Location_label
            // 
            this.Location_label.AutoSize = true;
            this.Location_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location_label.Location = new System.Drawing.Point(204, 18);
            this.Location_label.Name = "Location_label";
            this.Location_label.Size = new System.Drawing.Size(71, 20);
            this.Location_label.TabIndex = 15;
            this.Location_label.Text = "Location";
            // 
            // doctor_input
            // 
            this.doctor_input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.doctor_input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.doctor_input.DataSource = this.usersBindingSource;
            this.doctor_input.DisplayMember = "first_name";
            this.doctor_input.FormattingEnabled = true;
            this.doctor_input.Location = new System.Drawing.Point(31, 42);
            this.doctor_input.Name = "doctor_input";
            this.doctor_input.Size = new System.Drawing.Size(149, 21);
            this.doctor_input.TabIndex = 10;
            this.doctor_input.ValueMember = "id";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.selectDoctorDataSet;
            // 
            // selectDoctorDataSet
            // 
            this.selectDoctorDataSet.DataSetName = "SelectDoctorDataSet";
            this.selectDoctorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctor_label
            // 
            this.doctor_label.AutoSize = true;
            this.doctor_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor_label.Location = new System.Drawing.Point(27, 18);
            this.doctor_label.Name = "doctor_label";
            this.doctor_label.Size = new System.Drawing.Size(59, 20);
            this.doctor_label.TabIndex = 13;
            this.doctor_label.Text = "Doctor";
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.ScheduleDataGridView);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 272);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(884, 178);
            this.BodyPanel.TabIndex = 1;
            // 
            // ScheduleDataGridView
            // 
            this.ScheduleDataGridView.AllowUserToAddRows = false;
            this.ScheduleDataGridView.AllowUserToDeleteRows = false;
            this.ScheduleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ScheduleDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.ScheduleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ScheduleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScheduleDataGridView.EnableHeadersVisualStyles = false;
            this.ScheduleDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ScheduleDataGridView.MultiSelect = false;
            this.ScheduleDataGridView.Name = "ScheduleDataGridView";
            this.ScheduleDataGridView.ReadOnly = true;
            this.ScheduleDataGridView.Size = new System.Drawing.Size(884, 178);
            this.ScheduleDataGridView.TabIndex = 1;
            this.ScheduleDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellDoubleClick);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "ScheduleForm";
            this.Text = "ScheduleForm";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.CrudPanel.ResumeLayout(false);
            this.CrudPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDoctorDataSet)).EndInit();
            this.BodyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Label doctor_label;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Panel CrudPanel;
        private System.Windows.Forms.ComboBox doctor_input;
        private SelectDoctorDataSet selectDoctorDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private SelectDoctorDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label Location_label;
        private System.Windows.Forms.DataGridView ScheduleDataGridView;
        private System.Windows.Forms.ComboBox location_input;
        private System.Windows.Forms.ComboBox room_number_input;
        private System.Windows.Forms.Label room_no_label;
        private System.Windows.Forms.DateTimePicker endDateInput;
        private System.Windows.Forms.Label end_time_label;
        private System.Windows.Forms.DateTimePicker startDate_input;
        private System.Windows.Forms.Label date_time_label;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Label search_by_label;
        private System.Windows.Forms.Label search_doc_label;
        private System.Windows.Forms.TextBox searchDocInput;
        private System.Windows.Forms.ComboBox searchLocationInput;
        private System.Windows.Forms.Label search_location_label;
        private System.Windows.Forms.DateTimePicker searchDateInput;
        private System.Windows.Forms.Label search_date_label;
        private System.Windows.Forms.Button Search_btn;
    }
}