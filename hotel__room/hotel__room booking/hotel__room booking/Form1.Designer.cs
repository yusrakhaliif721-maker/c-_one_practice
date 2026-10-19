namespace hotel__room_booking
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
            groupBox1 = new GroupBox();
            txtNumberoff = new TextBox();
            txtNumberof = new TextBox();
            txtGuesteAges = new TextBox();
            txtGuestenNAme = new TextBox();
            txtguest = new Label();
            txtNumber = new Label();
            txtNumbergueste = new Label();
            txtGuestes = new Label();
            rdostandard = new RadioButton();
            rdoHight = new RadioButton();
            rdoNormal = new RadioButton();
            btncalculate = new Button();
            btnexit = new Button();
            btnclear = new Button();
            chcBreakFaste = new CheckBox();
            lblRoomtype = new Label();
            lblAditional = new Label();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNumberoff);
            groupBox1.Controls.Add(txtNumberof);
            groupBox1.Controls.Add(txtGuesteAges);
            groupBox1.Controls.Add(txtGuestenNAme);
            groupBox1.Controls.Add(txtguest);
            groupBox1.Controls.Add(txtNumber);
            groupBox1.Controls.Add(txtNumbergueste);
            groupBox1.Controls.Add(txtGuestes);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(577, 259);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "personal information";
            // 
            // txtNumberoff
            // 
            txtNumberoff.Location = new Point(270, 187);
            txtNumberoff.Name = "txtNumberoff";
            txtNumberoff.Size = new Size(216, 31);
            txtNumberoff.TabIndex = 7;
            // 
            // txtNumberof
            // 
            txtNumberof.Location = new Point(270, 142);
            txtNumberof.Name = "txtNumberof";
            txtNumberof.Size = new Size(216, 31);
            txtNumberof.TabIndex = 6;
            // 
            // txtGuesteAges
            // 
            txtGuesteAges.Location = new Point(270, 91);
            txtGuesteAges.Name = "txtGuesteAges";
            txtGuesteAges.Size = new Size(216, 31);
            txtGuesteAges.TabIndex = 5;
            // 
            // txtGuestenNAme
            // 
            txtGuestenNAme.Location = new Point(270, 49);
            txtGuestenNAme.Name = "txtGuestenNAme";
            txtGuestenNAme.Size = new Size(216, 31);
            txtGuestenNAme.TabIndex = 4;
            // 
            // txtguest
            // 
            txtguest.AutoSize = true;
            txtguest.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtguest.Location = new Point(31, 97);
            txtguest.Name = "txtguest";
            txtguest.Size = new Size(114, 28);
            txtguest.TabIndex = 3;
            txtguest.Text = "Guest Age:";
            // 
            // txtNumber
            // 
            txtNumber.AutoSize = true;
            txtNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtNumber.Location = new Point(31, 142);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(189, 28);
            txtNumber.TabIndex = 2;
            txtNumber.Text = "Number of Nights:";
            // 
            // txtNumbergueste
            // 
            txtNumbergueste.AutoSize = true;
            txtNumbergueste.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtNumbergueste.Location = new Point(31, 193);
            txtNumbergueste.Name = "txtNumbergueste";
            txtNumbergueste.Size = new Size(185, 28);
            txtNumbergueste.TabIndex = 1;
            txtNumbergueste.Text = "Number OF Guest:";
            // 
            // txtGuestes
            // 
            txtGuestes.AutoSize = true;
            txtGuestes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtGuestes.Location = new Point(31, 49);
            txtGuestes.Name = "txtGuestes";
            txtGuestes.Size = new Size(144, 28);
            txtGuestes.TabIndex = 0;
            txtGuestes.Text = "Gueste Name:";
            // 
            // rdostandard
            // 
            rdostandard.AutoSize = true;
            rdostandard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdostandard.Location = new Point(37, 340);
            rdostandard.Name = "rdostandard";
            rdostandard.Size = new Size(140, 36);
            rdostandard.TabIndex = 1;
            rdostandard.TabStop = true;
            rdostandard.Text = "standard";
            rdostandard.UseVisualStyleBackColor = true;
            // 
            // rdoHight
            // 
            rdoHight.AutoSize = true;
            rdoHight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoHight.Location = new Point(366, 340);
            rdoHight.Name = "rdoHight";
            rdoHight.Size = new Size(102, 36);
            rdoHight.TabIndex = 2;
            rdoHight.TabStop = true;
            rdoHight.Text = "Hight";
            rdoHight.UseVisualStyleBackColor = true;
            // 
            // rdoNormal
            // 
            rdoNormal.AutoSize = true;
            rdoNormal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoNormal.Location = new Point(201, 340);
            rdoNormal.Name = "rdoNormal";
            rdoNormal.Size = new Size(125, 36);
            rdoNormal.TabIndex = 3;
            rdoNormal.TabStop = true;
            rdoNormal.Text = "Normal";
            rdoNormal.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            btncalculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncalculate.Location = new Point(78, 522);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(140, 58);
            btncalculate.TabIndex = 4;
            btncalculate.Text = "calculate";
            btncalculate.UseVisualStyleBackColor = true;
            btncalculate.Click += btncalculate_Click;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnexit.Location = new Point(436, 522);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(140, 58);
            btnexit.TabIndex = 5;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(255, 522);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(140, 58);
            btnclear.TabIndex = 6;
            btnclear.Text = "clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // chcBreakFaste
            // 
            chcBreakFaste.AutoSize = true;
            chcBreakFaste.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chcBreakFaste.Location = new Point(97, 451);
            chcBreakFaste.Name = "chcBreakFaste";
            chcBreakFaste.Size = new Size(341, 36);
            chcBreakFaste.TabIndex = 7;
            chcBreakFaste.Text = "BreakFaste (10 per Nights)";
            chcBreakFaste.UseVisualStyleBackColor = true;
            // 
            // lblRoomtype
            // 
            lblRoomtype.AutoSize = true;
            lblRoomtype.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRoomtype.Location = new Point(27, 292);
            lblRoomtype.Name = "lblRoomtype";
            lblRoomtype.Size = new Size(115, 28);
            lblRoomtype.TabIndex = 8;
            lblRoomtype.Text = "Room type";
            // 
            // lblAditional
            // 
            lblAditional.AutoSize = true;
            lblAditional.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAditional.Location = new Point(12, 401);
            lblAditional.Name = "lblAditional";
            lblAditional.Size = new Size(167, 28);
            lblAditional.TabIndex = 9;
            lblAditional.Text = "Aditional option";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(691, 24);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(355, 504);
            listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 651);
            Controls.Add(listBox1);
            Controls.Add(lblAditional);
            Controls.Add(lblRoomtype);
            Controls.Add(chcBreakFaste);
            Controls.Add(btnclear);
            Controls.Add(btnexit);
            Controls.Add(btncalculate);
            Controls.Add(rdoNormal);
            Controls.Add(rdoHight);
            Controls.Add(rdostandard);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNumberoff;
        private TextBox txtNumberof;
        private TextBox txtGuesteAges;
        private TextBox txtGuestenNAme;
        private Label txtguest;
        private Label txtNumber;
        private Label txtNumbergueste;
        private Label txtGuestes;
        private RadioButton rdostandard;
        private RadioButton rdoHight;
        private RadioButton rdoNormal;
        private Button btncalculate;
        private Button btnexit;
        private Button btnclear;
        private CheckBox chcBreakFaste;
        private Label lblRoomtype;
        private Label lblAditional;
        private ListBox listBox1;
    }
}
