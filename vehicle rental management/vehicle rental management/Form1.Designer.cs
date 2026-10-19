namespace vehicle_rental_management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rdoLuxury = new RadioButton();
            rdoEconmy = new RadioButton();
            groupBox3 = new GroupBox();
            RDOSUV = new RadioButton();
            txtyearsDriving = new TextBox();
            txtCustomeragess = new TextBox();
            txtNumberRental = new TextBox();
            chkInsurance = new CheckBox();
            groupBox1 = new GroupBox();
            RentalDetails = new CheckedListBox();
            txtCustomerName = new TextBox();
            txtCustomerAge = new Label();
            txtNumber = new Label();
            txtyearss = new Label();
            lblCustomer = new Label();
            groupBox2 = new GroupBox();
            btnclear = new Button();
            btnexi = new Button();
            btncalculate = new Button();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // rdoLuxury
            // 
            rdoLuxury.AutoSize = true;
            rdoLuxury.BackColor = SystemColors.ButtonShadow;
            rdoLuxury.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoLuxury.Location = new Point(399, 34);
            rdoLuxury.Name = "rdoLuxury";
            rdoLuxury.Size = new Size(102, 32);
            rdoLuxury.TabIndex = 13;
            rdoLuxury.TabStop = true;
            rdoLuxury.Text = "Luxury";
            rdoLuxury.UseVisualStyleBackColor = false;
            // 
            // rdoEconmy
            // 
            rdoEconmy.AutoSize = true;
            rdoEconmy.BackColor = SystemColors.ButtonShadow;
            rdoEconmy.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoEconmy.Location = new Point(15, 34);
            rdoEconmy.Name = "rdoEconmy";
            rdoEconmy.Size = new Size(111, 32);
            rdoEconmy.TabIndex = 11;
            rdoEconmy.TabStop = true;
            rdoEconmy.Text = "Econmy";
            rdoEconmy.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdoLuxury);
            groupBox3.Controls.Add(RDOSUV);
            groupBox3.Controls.Add(rdoEconmy);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(61, 300);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(600, 100);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "vehicle type";
            // 
            // RDOSUV
            // 
            RDOSUV.AutoSize = true;
            RDOSUV.BackColor = SystemColors.ButtonShadow;
            RDOSUV.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RDOSUV.Location = new Point(203, 34);
            RDOSUV.Name = "RDOSUV";
            RDOSUV.Size = new Size(75, 32);
            RDOSUV.TabIndex = 12;
            RDOSUV.TabStop = true;
            RDOSUV.Text = "SUV";
            RDOSUV.UseVisualStyleBackColor = false;
            // 
            // txtyearsDriving
            // 
            txtyearsDriving.AllowDrop = true;
            txtyearsDriving.Location = new Point(370, 173);
            txtyearsDriving.Name = "txtyearsDriving";
            txtyearsDriving.Size = new Size(203, 34);
            txtyearsDriving.TabIndex = 16;
            // 
            // txtCustomeragess
            // 
            txtCustomeragess.AllowDrop = true;
            txtCustomeragess.Location = new Point(370, 78);
            txtCustomeragess.Name = "txtCustomeragess";
            txtCustomeragess.Size = new Size(203, 34);
            txtCustomeragess.TabIndex = 15;
            // 
            // txtNumberRental
            // 
            txtNumberRental.AllowDrop = true;
            txtNumberRental.Location = new Point(367, 127);
            txtNumberRental.Name = "txtNumberRental";
            txtNumberRental.Size = new Size(203, 34);
            txtNumberRental.TabIndex = 14;
            // 
            // chkInsurance
            // 
            chkInsurance.AutoSize = true;
            chkInsurance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkInsurance.ForeColor = SystemColors.ActiveCaptionText;
            chkInsurance.Location = new Point(12, 48);
            chkInsurance.Name = "chkInsurance";
            chkInsurance.Size = new Size(365, 36);
            chkInsurance.TabIndex = 17;
            chkInsurance.Text = "Add insurance (15$ per day)";
            chkInsurance.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkInsurance);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaption;
            groupBox1.Location = new Point(47, 417);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(614, 113);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "insurance option";
            // 
            // RentalDetails
            // 
            RentalDetails.FormattingEnabled = true;
            RentalDetails.Location = new Point(734, 5);
            RentalDetails.Name = "RentalDetails";
            RentalDetails.Size = new Size(329, 508);
            RentalDetails.TabIndex = 22;
            // 
            // txtCustomerName
            // 
            txtCustomerName.AllowDrop = true;
            txtCustomerName.Location = new Point(367, 41);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(203, 34);
            txtCustomerName.TabIndex = 12;
            // 
            // txtCustomerAge
            // 
            txtCustomerAge.AllowDrop = true;
            txtCustomerAge.AutoSize = true;
            txtCustomerAge.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtCustomerAge.Location = new Point(19, 75);
            txtCustomerAge.Name = "txtCustomerAge";
            txtCustomerAge.Size = new Size(176, 32);
            txtCustomerAge.TabIndex = 11;
            txtCustomerAge.Text = "Customer Age";
            // 
            // txtNumber
            // 
            txtNumber.AllowDrop = true;
            txtNumber.AutoSize = true;
            txtNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNumber.Location = new Point(19, 124);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(280, 32);
            txtNumber.TabIndex = 10;
            txtNumber.Text = "Number of Rental Days";
            // 
            // txtyearss
            // 
            txtyearss.AllowDrop = true;
            txtyearss.AutoSize = true;
            txtyearss.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtyearss.Location = new Point(6, 173);
            txtyearss.Name = "txtyearss";
            txtyearss.Size = new Size(325, 32);
            txtyearss.TabIndex = 9;
            txtyearss.Text = "years of driving Experience";
            // 
            // lblCustomer
            // 
            lblCustomer.AllowDrop = true;
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCustomer.Location = new Point(19, 35);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(198, 32);
            lblCustomer.TabIndex = 8;
            lblCustomer.Text = "Customer Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtyearsDriving);
            groupBox2.Controls.Add(txtCustomeragess);
            groupBox2.Controls.Add(txtNumberRental);
            groupBox2.Controls.Add(txtCustomerName);
            groupBox2.Controls.Add(txtCustomerAge);
            groupBox2.Controls.Add(txtNumber);
            groupBox2.Controls.Add(txtyearss);
            groupBox2.Controls.Add(lblCustomer);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(28, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(673, 256);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "customer information";
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnclear.Location = new Point(319, 564);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(146, 68);
            btnclear.TabIndex = 21;
            btnclear.Text = "clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnexi
            // 
            btnexi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnexi.Location = new Point(487, 564);
            btnexi.Name = "btnexi";
            btnexi.Size = new Size(127, 68);
            btnexi.TabIndex = 20;
            btnexi.Text = "exit";
            btnexi.UseVisualStyleBackColor = true;
            btnexi.Click += btnexi_Click;
            // 
            // btncalculate
            // 
            btncalculate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btncalculate.Location = new Point(102, 564);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(195, 74);
            btncalculate.TabIndex = 19;
            btncalculate.Text = "calculate";
            btncalculate.UseVisualStyleBackColor = true;
            btncalculate.Click += btncalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 689);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(RentalDetails);
            Controls.Add(groupBox2);
            Controls.Add(btnclear);
            Controls.Add(btnexi);
            Controls.Add(btncalculate);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rdoLuxury;
        private RadioButton rdoEconmy;
        private GroupBox groupBox3;
        private RadioButton RDOSUV;
        internal TextBox txtyearsDriving;
        internal TextBox txtCustomeragess;
        internal TextBox txtNumberRental;
        private CheckBox chkInsurance;
        private GroupBox groupBox1;
        private CheckedListBox RentalDetails;
        internal TextBox txtCustomerName;
        internal Label txtCustomerAge;
        internal Label txtNumber;
        internal Label txtyearss;
        internal Label lblCustomer;
        private GroupBox groupBox2;
        private Button btnclear;
        private Button btnexi;
        private Button btncalculate;
    }
}
