namespace HealthCare_Plus.Forms.Dashboard.Common
{
    partial class AddAppointmentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.Title_label = new System.Windows.Forms.Label();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ChargeForLabel = new System.Windows.Forms.Label();
            this.ChargeForInput = new System.Windows.Forms.TextBox();
            this.AppointmentChargesLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountInput = new System.Windows.Forms.TextBox();
            this.AddChargeBtn = new System.Windows.Forms.Button();
            this.BodyCenterPanel = new System.Windows.Forms.Panel();
            this.BodyBottomPanel = new System.Windows.Forms.Panel();
            this.MakeApptBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ChargesGridView = new System.Windows.Forms.DataGridView();
            this.Select_Schedule = new System.Windows.Forms.ComboBox();
            this.Select_Schedule_label = new System.Windows.Forms.Label();
            this.BodyTopPanel = new System.Windows.Forms.Panel();
            this.ApptNumberInput = new System.Windows.Forms.TextBox();
            this.ApptNumberLabel = new System.Windows.Forms.Label();
            this.Select_Patient = new System.Windows.Forms.ComboBox();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.healthcareplusDataSet = new HealthCare_Plus.HealthcareplusDataSet();
            this.search_location_label = new System.Windows.Forms.Label();
            this.search_doc_label = new System.Windows.Forms.Label();
            this.Select_Doc = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectDoctorDataSet = new HealthCare_Plus.SelectDoctorDataSet();
            this.usersTableAdapter = new HealthCare_Plus.SelectDoctorDataSetTableAdapters.UsersTableAdapter();
            this.patientsTableAdapter = new HealthCare_Plus.HealthcareplusDataSetTableAdapters.PatientsTableAdapter();
            this.HeaderPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.BodyBottomPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChargesGridView)).BeginInit();
            this.BodyTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthcareplusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDoctorDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.Title_label);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(884, 65);
            this.HeaderPanel.TabIndex = 3;
            // 
            // Title_label
            // 
            this.Title_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.Location = new System.Drawing.Point(349, 24);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(186, 21);
            this.Title_label.TabIndex = 1;
            this.Title_label.Text = "Add New Appointment";
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.ResetBtn);
            this.BodyPanel.Controls.Add(this.DeleteBtn);
            this.BodyPanel.Controls.Add(this.ChargeForLabel);
            this.BodyPanel.Controls.Add(this.ChargeForInput);
            this.BodyPanel.Controls.Add(this.AppointmentChargesLabel);
            this.BodyPanel.Controls.Add(this.AmountLabel);
            this.BodyPanel.Controls.Add(this.AmountInput);
            this.BodyPanel.Controls.Add(this.AddChargeBtn);
            this.BodyPanel.Controls.Add(this.BodyCenterPanel);
            this.BodyPanel.Controls.Add(this.BodyBottomPanel);
            this.BodyPanel.Controls.Add(this.BottomPanel);
            this.BodyPanel.Controls.Add(this.Select_Schedule);
            this.BodyPanel.Controls.Add(this.Select_Schedule_label);
            this.BodyPanel.Controls.Add(this.BodyTopPanel);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 65);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(884, 446);
            this.BodyPanel.TabIndex = 4;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResetBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetBtn.FlatAppearance.BorderSize = 0;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResetBtn.Location = new System.Drawing.Point(509, 182);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(80, 26);
            this.ResetBtn.TabIndex = 31;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(90)))));
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(405, 182);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(80, 26);
            this.DeleteBtn.TabIndex = 30;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ChargeForLabel
            // 
            this.ChargeForLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChargeForLabel.AutoSize = true;
            this.ChargeForLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.ChargeForLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChargeForLabel.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargeForLabel.Location = new System.Drawing.Point(134, 146);
            this.ChargeForLabel.Name = "ChargeForLabel";
            this.ChargeForLabel.Size = new System.Drawing.Size(100, 20);
            this.ChargeForLabel.TabIndex = 25;
            this.ChargeForLabel.Text = "Charges For:";
            // 
            // ChargeForInput
            // 
            this.ChargeForInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChargeForInput.Location = new System.Drawing.Point(240, 146);
            this.ChargeForInput.Name = "ChargeForInput";
            this.ChargeForInput.Size = new System.Drawing.Size(206, 20);
            this.ChargeForInput.TabIndex = 26;
            // 
            // AppointmentChargesLabel
            // 
            this.AppointmentChargesLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AppointmentChargesLabel.AutoSize = true;
            this.AppointmentChargesLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.AppointmentChargesLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentChargesLabel.Location = new System.Drawing.Point(335, 112);
            this.AppointmentChargesLabel.Name = "AppointmentChargesLabel";
            this.AppointmentChargesLabel.Size = new System.Drawing.Size(214, 21);
            this.AppointmentChargesLabel.TabIndex = 2;
            this.AppointmentChargesLabel.Text = "Add Appointment Charges";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.AmountLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.AmountLabel.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(468, 146);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(71, 20);
            this.AmountLabel.TabIndex = 27;
            this.AmountLabel.Text = "Amount:";
            // 
            // AmountInput
            // 
            this.AmountInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AmountInput.Location = new System.Drawing.Point(545, 146);
            this.AmountInput.Name = "AmountInput";
            this.AmountInput.Size = new System.Drawing.Size(206, 20);
            this.AmountInput.TabIndex = 28;
            // 
            // AddChargeBtn
            // 
            this.AddChargeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddChargeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.AddChargeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddChargeBtn.FlatAppearance.BorderSize = 0;
            this.AddChargeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddChargeBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddChargeBtn.Location = new System.Drawing.Point(296, 182);
            this.AddChargeBtn.Name = "AddChargeBtn";
            this.AddChargeBtn.Size = new System.Drawing.Size(80, 26);
            this.AddChargeBtn.TabIndex = 29;
            this.AddChargeBtn.Text = "Add";
            this.AddChargeBtn.UseVisualStyleBackColor = false;
            this.AddChargeBtn.Click += new System.EventHandler(this.AddChargeBtn_Click);
            // 
            // BodyCenterPanel
            // 
            this.BodyCenterPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.BodyCenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyCenterPanel.Location = new System.Drawing.Point(0, 96);
            this.BodyCenterPanel.Name = "BodyCenterPanel";
            this.BodyCenterPanel.Size = new System.Drawing.Size(884, 128);
            this.BodyCenterPanel.TabIndex = 35;
            // 
            // BodyBottomPanel
            // 
            this.BodyBottomPanel.Controls.Add(this.MakeApptBtn);
            this.BodyBottomPanel.Controls.Add(this.CancelBtn);
            this.BodyBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BodyBottomPanel.Location = new System.Drawing.Point(0, 224);
            this.BodyBottomPanel.Name = "BodyBottomPanel";
            this.BodyBottomPanel.Size = new System.Drawing.Size(884, 82);
            this.BodyBottomPanel.TabIndex = 34;
            // 
            // MakeApptBtn
            // 
            this.MakeApptBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MakeApptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.MakeApptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MakeApptBtn.FlatAppearance.BorderSize = 0;
            this.MakeApptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeApptBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeApptBtn.Location = new System.Drawing.Point(250, 28);
            this.MakeApptBtn.Name = "MakeApptBtn";
            this.MakeApptBtn.Size = new System.Drawing.Size(185, 38);
            this.MakeApptBtn.TabIndex = 32;
            this.MakeApptBtn.Text = "Make Appointment";
            this.MakeApptBtn.UseVisualStyleBackColor = false;
            this.MakeApptBtn.Click += new System.EventHandler(this.MakeApptBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelBtn.BackColor = System.Drawing.Color.SlateGray;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelBtn.Location = new System.Drawing.Point(456, 28);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(163, 38);
            this.CancelBtn.TabIndex = 32;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.ChargesGridView);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 306);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(884, 140);
            this.BottomPanel.TabIndex = 23;
            // 
            // ChargesGridView
            // 
            this.ChargesGridView.AllowUserToAddRows = false;
            this.ChargesGridView.AllowUserToDeleteRows = false;
            this.ChargesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ChargesGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.ChargesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ChargesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ChargesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChargesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChargesGridView.EnableHeadersVisualStyles = false;
            this.ChargesGridView.Location = new System.Drawing.Point(0, 0);
            this.ChargesGridView.MultiSelect = false;
            this.ChargesGridView.Name = "ChargesGridView";
            this.ChargesGridView.ReadOnly = true;
            this.ChargesGridView.Size = new System.Drawing.Size(884, 140);
            this.ChargesGridView.TabIndex = 24;
            this.ChargesGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellDoubleClickHandler);
            // 
            // Select_Schedule
            // 
            this.Select_Schedule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Select_Schedule.DisplayMember = "id";
            this.Select_Schedule.FormattingEnabled = true;
            this.Select_Schedule.Location = new System.Drawing.Point(294, 56);
            this.Select_Schedule.Name = "Select_Schedule";
            this.Select_Schedule.Size = new System.Drawing.Size(383, 21);
            this.Select_Schedule.TabIndex = 22;
            this.Select_Schedule.ValueMember = "id";
            this.Select_Schedule.SelectedIndexChanged += new System.EventHandler(this.OnScheduleChange);
            // 
            // Select_Schedule_label
            // 
            this.Select_Schedule_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Select_Schedule_label.AutoSize = true;
            this.Select_Schedule_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_Schedule_label.Location = new System.Drawing.Point(208, 56);
            this.Select_Schedule_label.Name = "Select_Schedule_label";
            this.Select_Schedule_label.Size = new System.Drawing.Size(80, 20);
            this.Select_Schedule_label.TabIndex = 13;
            this.Select_Schedule_label.Text = "Schedule:";
            // 
            // BodyTopPanel
            // 
            this.BodyTopPanel.BackColor = System.Drawing.Color.Transparent;
            this.BodyTopPanel.Controls.Add(this.ApptNumberInput);
            this.BodyTopPanel.Controls.Add(this.ApptNumberLabel);
            this.BodyTopPanel.Controls.Add(this.Select_Patient);
            this.BodyTopPanel.Controls.Add(this.search_location_label);
            this.BodyTopPanel.Controls.Add(this.search_doc_label);
            this.BodyTopPanel.Controls.Add(this.Select_Doc);
            this.BodyTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BodyTopPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyTopPanel.Name = "BodyTopPanel";
            this.BodyTopPanel.Size = new System.Drawing.Size(884, 96);
            this.BodyTopPanel.TabIndex = 33;
            // 
            // ApptNumberInput
            // 
            this.ApptNumberInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ApptNumberInput.Location = new System.Drawing.Point(728, 17);
            this.ApptNumberInput.Name = "ApptNumberInput";
            this.ApptNumberInput.ReadOnly = true;
            this.ApptNumberInput.Size = new System.Drawing.Size(98, 20);
            this.ApptNumberInput.TabIndex = 36;
            // 
            // ApptNumberLabel
            // 
            this.ApptNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ApptNumberLabel.AutoSize = true;
            this.ApptNumberLabel.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptNumberLabel.Location = new System.Drawing.Point(650, 17);
            this.ApptNumberLabel.Name = "ApptNumberLabel";
            this.ApptNumberLabel.Size = new System.Drawing.Size(72, 20);
            this.ApptNumberLabel.TabIndex = 22;
            this.ApptNumberLabel.Text = "Number:";
            // 
            // Select_Patient
            // 
            this.Select_Patient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Select_Patient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Select_Patient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Select_Patient.DataSource = this.patientsBindingSource;
            this.Select_Patient.DisplayMember = "contact_no";
            this.Select_Patient.FormattingEnabled = true;
            this.Select_Patient.Location = new System.Drawing.Point(423, 17);
            this.Select_Patient.Name = "Select_Patient";
            this.Select_Patient.Size = new System.Drawing.Size(204, 21);
            this.Select_Patient.TabIndex = 21;
            this.Select_Patient.ValueMember = "id";
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
            // search_location_label
            // 
            this.search_location_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.search_location_label.AutoSize = true;
            this.search_location_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_location_label.Location = new System.Drawing.Point(352, 17);
            this.search_location_label.Name = "search_location_label";
            this.search_location_label.Size = new System.Drawing.Size(65, 20);
            this.search_location_label.TabIndex = 11;
            this.search_location_label.Text = "Patient:";
            // 
            // search_doc_label
            // 
            this.search_doc_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.search_doc_label.AutoSize = true;
            this.search_doc_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.search_doc_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_doc_label.Location = new System.Drawing.Point(58, 17);
            this.search_doc_label.Name = "search_doc_label";
            this.search_doc_label.Size = new System.Drawing.Size(62, 20);
            this.search_doc_label.TabIndex = 10;
            this.search_doc_label.Text = "Doctor:";
            // 
            // Select_Doc
            // 
            this.Select_Doc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Select_Doc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Select_Doc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Select_Doc.DataSource = this.usersBindingSource;
            this.Select_Doc.DisplayMember = "first_name";
            this.Select_Doc.DropDownWidth = 204;
            this.Select_Doc.FormattingEnabled = true;
            this.Select_Doc.Location = new System.Drawing.Point(126, 17);
            this.Select_Doc.Name = "Select_Doc";
            this.Select_Doc.Size = new System.Drawing.Size(200, 21);
            this.Select_Doc.TabIndex = 20;
            this.Select_Doc.ValueMember = "id";
            this.Select_Doc.SelectedIndexChanged += new System.EventHandler(this.OnDoctorChangeHandler);
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
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "AddAppointmentForm";
            this.Text = "AddAppointmentForm";
            this.Load += new System.EventHandler(this.AddAppointmentForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            this.BodyBottomPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChargesGridView)).EndInit();
            this.BodyTopPanel.ResumeLayout(false);
            this.BodyTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthcareplusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDoctorDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.ComboBox Select_Schedule;
        private System.Windows.Forms.Label Select_Schedule_label;
        private System.Windows.Forms.ComboBox Select_Patient;
        private System.Windows.Forms.ComboBox Select_Doc;
        private System.Windows.Forms.Label search_doc_label;
        private System.Windows.Forms.Label search_location_label;
        private SelectDoctorDataSet selectDoctorDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private SelectDoctorDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private HealthcareplusDataSet healthcareplusDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private HealthcareplusDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.DataGridView ChargesGridView;
        private System.Windows.Forms.TextBox AmountInput;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox ChargeForInput;
        private System.Windows.Forms.Label ChargeForLabel;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddChargeBtn;
        private System.Windows.Forms.Label AppointmentChargesLabel;
        private System.Windows.Forms.Button MakeApptBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Panel BodyTopPanel;
        private System.Windows.Forms.Panel BodyBottomPanel;
        private System.Windows.Forms.Panel BodyCenterPanel;
        private System.Windows.Forms.TextBox ApptNumberInput;
        private System.Windows.Forms.Label ApptNumberLabel;
    }
}