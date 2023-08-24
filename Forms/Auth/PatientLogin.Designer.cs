namespace HealthCare_Plus.Forms.Auth
{
    partial class PatientLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientLoginForm));
            this.back_to_home_lable = new System.Windows.Forms.Label();
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
            // PatientLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_to_home_lable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientLoginForm";
            this.Text = "Patient Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label back_to_home_lable;
    }
}