namespace payroll_with_overtime_form
{
    partial class Form1
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
            this.lblGrosss = new System.Windows.Forms.Label();
            this.lbnGross = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtHourlyPay = new System.Windows.Forms.TextBox();
            this.txtHourse = new System.Windows.Forms.TextBox();
            this.txtteste2 = new System.Windows.Forms.Label();
            this.txtTest1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGrosss
            // 
            this.lblGrosss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrosss.CausesValidation = false;
            this.lblGrosss.Location = new System.Drawing.Point(462, 191);
            this.lblGrosss.Name = "lblGrosss";
            this.lblGrosss.Size = new System.Drawing.Size(210, 51);
            this.lblGrosss.TabIndex = 21;
            // 
            // lbnGross
            // 
            this.lbnGross.AutoSize = true;
            this.lbnGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnGross.Location = new System.Drawing.Point(248, 210);
            this.lbnGross.Name = "lbnGross";
            this.lbnGross.Size = new System.Drawing.Size(160, 32);
            this.lbnGross.TabIndex = 20;
            this.lbnGross.Text = "Gross pay:";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(322, 302);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(114, 50);
            this.btnclear.TabIndex = 19;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(322, 359);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(114, 42);
            this.btnexit.TabIndex = 18;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(170, 302);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(126, 99);
            this.btncalculate.TabIndex = 17;
            this.btncalculate.Text = "calculate Gross pay:";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txtHourlyPay
            // 
            this.txtHourlyPay.Location = new System.Drawing.Point(392, 92);
            this.txtHourlyPay.Name = "txtHourlyPay";
            this.txtHourlyPay.Size = new System.Drawing.Size(178, 26);
            this.txtHourlyPay.TabIndex = 16;
            // 
            // txtHourse
            // 
            this.txtHourse.Location = new System.Drawing.Point(392, 51);
            this.txtHourse.Name = "txtHourse";
            this.txtHourse.Size = new System.Drawing.Size(178, 26);
            this.txtHourse.TabIndex = 14;
            // 
            // txtteste2
            // 
            this.txtteste2.AutoSize = true;
            this.txtteste2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtteste2.Location = new System.Drawing.Point(117, 88);
            this.txtteste2.Name = "txtteste2";
            this.txtteste2.Size = new System.Drawing.Size(195, 29);
            this.txtteste2.TabIndex = 13;
            this.txtteste2.Text = "Hourly pay rate:";
            // 
            // txtTest1
            // 
            this.txtTest1.AutoSize = true;
            this.txtTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTest1.Location = new System.Drawing.Point(117, 49);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(171, 29);
            this.txtTest1.TabIndex = 11;
            this.txtTest1.Text = "hours worked";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGrosss);
            this.Controls.Add(this.lbnGross);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtHourlyPay);
            this.Controls.Add(this.txtHourse);
            this.Controls.Add(this.txtteste2);
            this.Controls.Add(this.txtTest1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrosss;
        private System.Windows.Forms.Label lbnGross;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtHourlyPay;
        private System.Windows.Forms.TextBox txtHourse;
        private System.Windows.Forms.Label txtteste2;
        private System.Windows.Forms.Label txtTest1;
    }
}

