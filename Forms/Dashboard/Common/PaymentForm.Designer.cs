namespace HealthCare_Plus.Forms.Dashboard.Common
{
    partial class PaymentForm
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Title_label = new System.Windows.Forms.Label();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.MakePaymentBtn = new System.Windows.Forms.Button();
            this.BalanceAmount = new System.Windows.Forms.Label();
            this.TotalAmountMid = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.TotalLableMid = new System.Windows.Forms.Label();
            this.CashLabel = new System.Windows.Forms.Label();
            this.CashInput = new System.Windows.Forms.TextBox();
            this.PaymentMethod = new System.Windows.Forms.GroupBox();
            this.method_cash = new System.Windows.Forms.RadioButton();
            this.method_card = new System.Windows.Forms.RadioButton();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.CashPaymentPanel = new System.Windows.Forms.Panel();
            this.CardPaymentPanel = new System.Windows.Forms.Panel();
            this.name_on_card_label = new System.Windows.Forms.Label();
            this.card_number_label = new System.Windows.Forms.Label();
            this.exp_date_label = new System.Windows.Forms.Label();
            this.cvv_label = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.CardNumberInput = new System.Windows.Forms.TextBox();
            this.CVVInput = new System.Windows.Forms.TextBox();
            this.ExpDateInput = new System.Windows.Forms.DateTimePicker();
            this.CardPaymentBtn = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.PaymentMethod.SuspendLayout();
            this.CashPaymentPanel.SuspendLayout();
            this.CardPaymentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(90)))));
            this.TopPanel.Controls.Add(this.Title_label);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 76);
            this.TopPanel.TabIndex = 0;
            // 
            // Title_label
            // 
            this.Title_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.ForeColor = System.Drawing.Color.White;
            this.Title_label.Location = new System.Drawing.Point(320, 27);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(161, 26);
            this.Title_label.TabIndex = 2;
            this.Title_label.Text = "Make Payment";
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.CardPaymentPanel);
            this.BodyPanel.Controls.Add(this.CashPaymentPanel);
            this.BodyPanel.Controls.Add(this.PaymentMethod);
            this.BodyPanel.Controls.Add(this.TotalAmount);
            this.BodyPanel.Controls.Add(this.TotalLabel);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 76);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(800, 495);
            this.BodyPanel.TabIndex = 1;
            // 
            // MakePaymentBtn
            // 
            this.MakePaymentBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MakePaymentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.MakePaymentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MakePaymentBtn.FlatAppearance.BorderSize = 0;
            this.MakePaymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakePaymentBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakePaymentBtn.Location = new System.Drawing.Point(120, 134);
            this.MakePaymentBtn.Name = "MakePaymentBtn";
            this.MakePaymentBtn.Size = new System.Drawing.Size(185, 38);
            this.MakePaymentBtn.TabIndex = 33;
            this.MakePaymentBtn.Text = "Make Payment";
            this.MakePaymentBtn.UseVisualStyleBackColor = false;
            this.MakePaymentBtn.Click += new System.EventHandler(this.MakePaymentBtn_Click);
            // 
            // BalanceAmount
            // 
            this.BalanceAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BalanceAmount.AutoSize = true;
            this.BalanceAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.BalanceAmount.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceAmount.Location = new System.Drawing.Point(211, 82);
            this.BalanceAmount.Name = "BalanceAmount";
            this.BalanceAmount.Size = new System.Drawing.Size(74, 20);
            this.BalanceAmount.TabIndex = 21;
            this.BalanceAmount.Text = "RS: 60.00";
            // 
            // TotalAmountMid
            // 
            this.TotalAmountMid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalAmountMid.AutoSize = true;
            this.TotalAmountMid.Cursor = System.Windows.Forms.Cursors.Default;
            this.TotalAmountMid.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountMid.Location = new System.Drawing.Point(211, 52);
            this.TotalAmountMid.Name = "TotalAmountMid";
            this.TotalAmountMid.Size = new System.Drawing.Size(78, 20);
            this.TotalAmountMid.TabIndex = 20;
            this.TotalAmountMid.Text = "RS: 120.00";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.BalanceLabel.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.Location = new System.Drawing.Point(88, 82);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(70, 20);
            this.BalanceLabel.TabIndex = 19;
            this.BalanceLabel.Text = "Balance:";
            // 
            // TotalLableMid
            // 
            this.TotalLableMid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalLableMid.AutoSize = true;
            this.TotalLableMid.Cursor = System.Windows.Forms.Cursors.Default;
            this.TotalLableMid.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLableMid.Location = new System.Drawing.Point(88, 52);
            this.TotalLableMid.Name = "TotalLableMid";
            this.TotalLableMid.Size = new System.Drawing.Size(46, 20);
            this.TotalLableMid.TabIndex = 18;
            this.TotalLableMid.Text = "Total:";
            // 
            // CashLabel
            // 
            this.CashLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CashLabel.AutoSize = true;
            this.CashLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.CashLabel.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashLabel.Location = new System.Drawing.Point(88, 22);
            this.CashLabel.Name = "CashLabel";
            this.CashLabel.Size = new System.Drawing.Size(110, 20);
            this.CashLabel.TabIndex = 17;
            this.CashLabel.Text = "Cash Amount:";
            // 
            // CashInput
            // 
            this.CashInput.Location = new System.Drawing.Point(215, 22);
            this.CashInput.Name = "CashInput";
            this.CashInput.Size = new System.Drawing.Size(122, 20);
            this.CashInput.TabIndex = 16;
            this.CashInput.TextChanged += new System.EventHandler(this.OnCashAmountChange);
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.Controls.Add(this.method_cash);
            this.PaymentMethod.Controls.Add(this.method_card);
            this.PaymentMethod.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethod.Location = new System.Drawing.Point(297, 69);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(207, 93);
            this.PaymentMethod.TabIndex = 15;
            this.PaymentMethod.TabStop = false;
            this.PaymentMethod.Text = "Payment Method";
            // 
            // method_cash
            // 
            this.method_cash.AutoSize = true;
            this.method_cash.Checked = true;
            this.method_cash.Location = new System.Drawing.Point(17, 35);
            this.method_cash.Name = "method_cash";
            this.method_cash.Size = new System.Drawing.Size(59, 22);
            this.method_cash.TabIndex = 13;
            this.method_cash.TabStop = true;
            this.method_cash.Text = "Cash";
            this.method_cash.UseVisualStyleBackColor = true;
            this.method_cash.CheckedChanged += new System.EventHandler(this.OnCashSelect);
            // 
            // method_card
            // 
            this.method_card.AutoSize = true;
            this.method_card.Location = new System.Drawing.Point(17, 63);
            this.method_card.Name = "method_card";
            this.method_card.Size = new System.Drawing.Size(57, 22);
            this.method_card.TabIndex = 14;
            this.method_card.Text = "Card";
            this.method_card.UseVisualStyleBackColor = true;
            this.method_card.CheckedChanged += new System.EventHandler(this.OnCardSelect);
            // 
            // TotalAmount
            // 
            this.TotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.TotalAmount.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.Location = new System.Drawing.Point(432, 31);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(52, 20);
            this.TotalAmount.TabIndex = 12;
            this.TotalAmount.Text = "120.00";
            // 
            // TotalLabel
            // 
            this.TotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TotalLabel.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(317, 31);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(109, 20);
            this.TotalLabel.TabIndex = 11;
            this.TotalLabel.Text = "Total Amount:";
            // 
            // CashPaymentPanel
            // 
            this.CashPaymentPanel.BackColor = System.Drawing.Color.White;
            this.CashPaymentPanel.Controls.Add(this.CashLabel);
            this.CashPaymentPanel.Controls.Add(this.MakePaymentBtn);
            this.CashPaymentPanel.Controls.Add(this.CashInput);
            this.CashPaymentPanel.Controls.Add(this.BalanceAmount);
            this.CashPaymentPanel.Controls.Add(this.TotalLableMid);
            this.CashPaymentPanel.Controls.Add(this.TotalAmountMid);
            this.CashPaymentPanel.Controls.Add(this.BalanceLabel);
            this.CashPaymentPanel.Location = new System.Drawing.Point(188, 184);
            this.CashPaymentPanel.Name = "CashPaymentPanel";
            this.CashPaymentPanel.Size = new System.Drawing.Size(424, 205);
            this.CashPaymentPanel.TabIndex = 34;
            // 
            // CardPaymentPanel
            // 
            this.CardPaymentPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CardPaymentPanel.BackColor = System.Drawing.Color.White;
            this.CardPaymentPanel.Controls.Add(this.CardPaymentBtn);
            this.CardPaymentPanel.Controls.Add(this.ExpDateInput);
            this.CardPaymentPanel.Controls.Add(this.CVVInput);
            this.CardPaymentPanel.Controls.Add(this.CardNumberInput);
            this.CardPaymentPanel.Controls.Add(this.NameInput);
            this.CardPaymentPanel.Controls.Add(this.cvv_label);
            this.CardPaymentPanel.Controls.Add(this.exp_date_label);
            this.CardPaymentPanel.Controls.Add(this.card_number_label);
            this.CardPaymentPanel.Controls.Add(this.name_on_card_label);
            this.CardPaymentPanel.Location = new System.Drawing.Point(188, 184);
            this.CardPaymentPanel.Name = "CardPaymentPanel";
            this.CardPaymentPanel.Size = new System.Drawing.Size(424, 229);
            this.CardPaymentPanel.TabIndex = 34;
            // 
            // name_on_card_label
            // 
            this.name_on_card_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_on_card_label.AutoSize = true;
            this.name_on_card_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.name_on_card_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_on_card_label.Location = new System.Drawing.Point(42, 32);
            this.name_on_card_label.Name = "name_on_card_label";
            this.name_on_card_label.Size = new System.Drawing.Size(119, 20);
            this.name_on_card_label.TabIndex = 11;
            this.name_on_card_label.Text = "Name On Card:";
            // 
            // card_number_label
            // 
            this.card_number_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.card_number_label.AutoSize = true;
            this.card_number_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.card_number_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_number_label.Location = new System.Drawing.Point(42, 69);
            this.card_number_label.Name = "card_number_label";
            this.card_number_label.Size = new System.Drawing.Size(110, 20);
            this.card_number_label.TabIndex = 12;
            this.card_number_label.Text = "Card Number:";
            // 
            // exp_date_label
            // 
            this.exp_date_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exp_date_label.AutoSize = true;
            this.exp_date_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.exp_date_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_date_label.Location = new System.Drawing.Point(42, 106);
            this.exp_date_label.Name = "exp_date_label";
            this.exp_date_label.Size = new System.Drawing.Size(39, 20);
            this.exp_date_label.TabIndex = 13;
            this.exp_date_label.Text = "Exp:";
            // 
            // cvv_label
            // 
            this.cvv_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cvv_label.AutoSize = true;
            this.cvv_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.cvv_label.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvv_label.Location = new System.Drawing.Point(42, 143);
            this.cvv_label.Name = "cvv_label";
            this.cvv_label.Size = new System.Drawing.Size(42, 20);
            this.cvv_label.TabIndex = 14;
            this.cvv_label.Text = "CVV:";
            // 
            // NameInput
            // 
            this.NameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameInput.Location = new System.Drawing.Point(179, 32);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(182, 20);
            this.NameInput.TabIndex = 15;
            // 
            // CardNumberInput
            // 
            this.CardNumberInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CardNumberInput.Location = new System.Drawing.Point(179, 69);
            this.CardNumberInput.Name = "CardNumberInput";
            this.CardNumberInput.Size = new System.Drawing.Size(182, 20);
            this.CardNumberInput.TabIndex = 16;
            // 
            // CVVInput
            // 
            this.CVVInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CVVInput.Location = new System.Drawing.Point(179, 143);
            this.CVVInput.MaxLength = 4;
            this.CVVInput.Name = "CVVInput";
            this.CVVInput.Size = new System.Drawing.Size(117, 20);
            this.CVVInput.TabIndex = 18;
            // 
            // ExpDateInput
            // 
            this.ExpDateInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExpDateInput.CustomFormat = "MM/yyyy";
            this.ExpDateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpDateInput.Location = new System.Drawing.Point(179, 106);
            this.ExpDateInput.Name = "ExpDateInput";
            this.ExpDateInput.Size = new System.Drawing.Size(117, 20);
            this.ExpDateInput.TabIndex = 19;
            // 
            // CardPaymentBtn
            // 
            this.CardPaymentBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CardPaymentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.CardPaymentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CardPaymentBtn.FlatAppearance.BorderSize = 0;
            this.CardPaymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CardPaymentBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardPaymentBtn.Location = new System.Drawing.Point(120, 188);
            this.CardPaymentBtn.Name = "CardPaymentBtn";
            this.CardPaymentBtn.Size = new System.Drawing.Size(185, 38);
            this.CardPaymentBtn.TabIndex = 34;
            this.CardPaymentBtn.Text = "Make Payment";
            this.CardPaymentBtn.UseVisualStyleBackColor = false;
            this.CardPaymentBtn.Click += new System.EventHandler(this.MakePaymentBtn_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            this.PaymentMethod.ResumeLayout(false);
            this.PaymentMethod.PerformLayout();
            this.CashPaymentPanel.ResumeLayout(false);
            this.CashPaymentPanel.PerformLayout();
            this.CardPaymentPanel.ResumeLayout(false);
            this.CardPaymentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.GroupBox PaymentMethod;
        private System.Windows.Forms.RadioButton method_cash;
        private System.Windows.Forms.RadioButton method_card;
        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TotalAmountMid;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label TotalLableMid;
        private System.Windows.Forms.Label CashLabel;
        private System.Windows.Forms.TextBox CashInput;
        private System.Windows.Forms.Button MakePaymentBtn;
        private System.Windows.Forms.Label BalanceAmount;
        private System.Windows.Forms.Panel CashPaymentPanel;
        private System.Windows.Forms.Panel CardPaymentPanel;
        private System.Windows.Forms.Label name_on_card_label;
        private System.Windows.Forms.DateTimePicker ExpDateInput;
        private System.Windows.Forms.TextBox CVVInput;
        private System.Windows.Forms.TextBox CardNumberInput;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label cvv_label;
        private System.Windows.Forms.Label exp_date_label;
        private System.Windows.Forms.Label card_number_label;
        private System.Windows.Forms.Button CardPaymentBtn;
    }
}