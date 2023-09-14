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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PaymentMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.Title_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 76);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.MakePaymentBtn);
            this.panel2.Controls.Add(this.BalanceAmount);
            this.panel2.Controls.Add(this.TotalAmountMid);
            this.panel2.Controls.Add(this.BalanceLabel);
            this.panel2.Controls.Add(this.TotalLableMid);
            this.panel2.Controls.Add(this.CashLabel);
            this.panel2.Controls.Add(this.CashInput);
            this.panel2.Controls.Add(this.PaymentMethod);
            this.panel2.Controls.Add(this.TotalAmount);
            this.panel2.Controls.Add(this.TotalLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 495);
            this.panel2.TabIndex = 1;
            // 
            // MakePaymentBtn
            // 
            this.MakePaymentBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MakePaymentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.MakePaymentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MakePaymentBtn.FlatAppearance.BorderSize = 0;
            this.MakePaymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakePaymentBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakePaymentBtn.Location = new System.Drawing.Point(308, 305);
            this.MakePaymentBtn.Name = "MakePaymentBtn";
            this.MakePaymentBtn.Size = new System.Drawing.Size(185, 38);
            this.MakePaymentBtn.TabIndex = 33;
            this.MakePaymentBtn.Text = "Make Payment";
            this.MakePaymentBtn.UseVisualStyleBackColor = false;
            // 
            // BalanceAmount
            // 
            this.BalanceAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BalanceAmount.AutoSize = true;
            this.BalanceAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.BalanceAmount.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceAmount.Location = new System.Drawing.Point(399, 253);
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
            this.TotalAmountMid.Location = new System.Drawing.Point(399, 223);
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
            this.BalanceLabel.Location = new System.Drawing.Point(276, 253);
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
            this.TotalLableMid.Location = new System.Drawing.Point(276, 223);
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
            this.CashLabel.Location = new System.Drawing.Point(276, 193);
            this.CashLabel.Name = "CashLabel";
            this.CashLabel.Size = new System.Drawing.Size(110, 20);
            this.CashLabel.TabIndex = 17;
            this.CashLabel.Text = "Cash Amount:";
            // 
            // CashInput
            // 
            this.CashInput.Location = new System.Drawing.Point(403, 193);
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
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PaymentMethod.ResumeLayout(false);
            this.PaymentMethod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Panel panel2;
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
    }
}