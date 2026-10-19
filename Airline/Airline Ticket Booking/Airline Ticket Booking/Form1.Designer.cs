namespace Airline_Ticket_Booking
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
            lblAditional = new Label();
            chcAddTravel = new CheckBox();
            groupBox1 = new GroupBox();
            txtPassengerAgess = new TextBox();
            texttxtNumber = new TextBox();
            txtbaggagewheigh = new TextBox();
            txtPassenger = new TextBox();
            txtpassengerName = new Label();
            txtpassengerAge = new Label();
            txtNumberTickets = new Label();
            txtbaggage = new Label();
            ListBox1 = new ListBox();
            rdoNormalClass = new RadioButton();
            rdoBusnessClass = new RadioButton();
            rdoFiristClass = new RadioButton();
            lblTravel = new Label();
            label1 = new Label();
            btncalculate = new Button();
            btnclear = new Button();
            btnexit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAditional
            // 
            lblAditional.AutoSize = true;
            lblAditional.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAditional.ImageAlign = ContentAlignment.BottomLeft;
            lblAditional.Location = new Point(63, 427);
            lblAditional.Margin = new Padding(4, 0, 4, 0);
            lblAditional.Name = "lblAditional";
            lblAditional.Size = new Size(213, 32);
            lblAditional.TabIndex = 21;
            lblAditional.Text = "Aditional options";
            // 
            // chcAddTravel
            // 
            chcAddTravel.AutoSize = true;
            chcAddTravel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chcAddTravel.Location = new Point(130, 472);
            chcAddTravel.Name = "chcAddTravel";
            chcAddTravel.Size = new Size(357, 29);
            chcAddTravel.TabIndex = 30;
            chcAddTravel.Text = "Add Travel insurance ($ 25 per ticket)";
            chcAddTravel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(txtPassengerAgess);
            groupBox1.Controls.Add(texttxtNumber);
            groupBox1.Controls.Add(txtbaggagewheigh);
            groupBox1.Controls.Add(txtPassenger);
            groupBox1.Controls.Add(txtpassengerName);
            groupBox1.Controls.Add(txtpassengerAge);
            groupBox1.Controls.Add(txtNumberTickets);
            groupBox1.Controls.Add(txtbaggage);
            groupBox1.Location = new Point(103, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(792, 264);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "personal information";
            // 
            // txtPassengerAgess
            // 
            txtPassengerAgess.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtPassengerAgess.Location = new Point(430, 111);
            txtPassengerAgess.Name = "txtPassengerAgess";
            txtPassengerAgess.Size = new Size(263, 39);
            txtPassengerAgess.TabIndex = 8;
            // 
            // texttxtNumber
            // 
            texttxtNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            texttxtNumber.Location = new Point(430, 160);
            texttxtNumber.Name = "texttxtNumber";
            texttxtNumber.Size = new Size(263, 39);
            texttxtNumber.TabIndex = 7;
            // 
            // txtbaggagewheigh
            // 
            txtbaggagewheigh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtbaggagewheigh.Location = new Point(430, 209);
            txtbaggagewheigh.Name = "txtbaggagewheigh";
            txtbaggagewheigh.Size = new Size(263, 39);
            txtbaggagewheigh.TabIndex = 6;
            // 
            // txtPassenger
            // 
            txtPassenger.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtPassenger.Location = new Point(430, 68);
            txtPassenger.Name = "txtPassenger";
            txtPassenger.Size = new Size(263, 39);
            txtPassenger.TabIndex = 5;
            // 
            // txtpassengerName
            // 
            txtpassengerName.AutoSize = true;
            txtpassengerName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtpassengerName.Location = new Point(124, 68);
            txtpassengerName.Margin = new Padding(4, 0, 4, 0);
            txtpassengerName.Name = "txtpassengerName";
            txtpassengerName.Size = new Size(204, 32);
            txtpassengerName.TabIndex = 4;
            txtpassengerName.Text = "passenger Name";
            // 
            // txtpassengerAge
            // 
            txtpassengerAge.AutoSize = true;
            txtpassengerAge.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtpassengerAge.Location = new Point(124, 114);
            txtpassengerAge.Margin = new Padding(4, 0, 4, 0);
            txtpassengerAge.Name = "txtpassengerAge";
            txtpassengerAge.Size = new Size(182, 32);
            txtpassengerAge.TabIndex = 3;
            txtpassengerAge.Text = "passenger Age";
            // 
            // txtNumberTickets
            // 
            txtNumberTickets.AutoSize = true;
            txtNumberTickets.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNumberTickets.ImageAlign = ContentAlignment.BottomLeft;
            txtNumberTickets.Location = new Point(124, 160);
            txtNumberTickets.Margin = new Padding(4, 0, 4, 0);
            txtNumberTickets.Name = "txtNumberTickets";
            txtNumberTickets.Size = new Size(225, 32);
            txtNumberTickets.TabIndex = 2;
            txtNumberTickets.Text = "Number of Tickets";
            // 
            // txtbaggage
            // 
            txtbaggage.AutoSize = true;
            txtbaggage.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtbaggage.ImageAlign = ContentAlignment.BottomLeft;
            txtbaggage.Location = new Point(124, 209);
            txtbaggage.Margin = new Padding(4, 0, 4, 0);
            txtbaggage.Name = "txtbaggage";
            txtbaggage.Size = new Size(248, 32);
            txtbaggage.TabIndex = 1;
            txtbaggage.Text = "Baggage wheigh(kg)";
            // 
            // ListBox1
            // 
            ListBox1.FormattingEnabled = true;
            ListBox1.ItemHeight = 25;
            ListBox1.Location = new Point(927, 32);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(330, 454);
            ListBox1.TabIndex = 26;
            // 
            // rdoNormalClass
            // 
            rdoNormalClass.AutoSize = true;
            rdoNormalClass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rdoNormalClass.Location = new Point(239, 369);
            rdoNormalClass.Name = "rdoNormalClass";
            rdoNormalClass.Size = new Size(159, 32);
            rdoNormalClass.TabIndex = 25;
            rdoNormalClass.TabStop = true;
            rdoNormalClass.Text = "Normal class";
            rdoNormalClass.UseVisualStyleBackColor = true;
            // 
            // rdoBusnessClass
            // 
            rdoBusnessClass.AutoSize = true;
            rdoBusnessClass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rdoBusnessClass.Location = new Point(430, 369);
            rdoBusnessClass.Name = "rdoBusnessClass";
            rdoBusnessClass.Size = new Size(163, 32);
            rdoBusnessClass.TabIndex = 24;
            rdoBusnessClass.TabStop = true;
            rdoBusnessClass.Text = "Busness class";
            rdoBusnessClass.UseVisualStyleBackColor = true;
            // 
            // rdoFiristClass
            // 
            rdoFiristClass.AutoSize = true;
            rdoFiristClass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rdoFiristClass.Location = new Point(83, 369);
            rdoFiristClass.Name = "rdoFiristClass";
            rdoFiristClass.Size = new Size(135, 32);
            rdoFiristClass.TabIndex = 23;
            rdoFiristClass.TabStop = true;
            rdoFiristClass.Text = "Firist class";
            rdoFiristClass.UseVisualStyleBackColor = true;
            // 
            // lblTravel
            // 
            lblTravel.AutoSize = true;
            lblTravel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTravel.Location = new Point(20, 321);
            lblTravel.Name = "lblTravel";
            lblTravel.Size = new Size(163, 38);
            lblTravel.TabIndex = 22;
            lblTravel.Text = "Travel class";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(337, 45);
            label1.TabIndex = 20;
            label1.Text = "personal information";
            // 
            // btncalculate
            // 
            btncalculate.Location = new Point(128, 539);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(188, 78);
            btncalculate.TabIndex = 31;
            btncalculate.Text = "calculate";
            btncalculate.UseVisualStyleBackColor = true;
            btncalculate.Click += btncalculate_Click_1;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(339, 539);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(148, 78);
            btnclear.TabIndex = 32;
            btnclear.Text = "clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click_1;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(533, 539);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(148, 78);
            btnexit.TabIndex = 33;
            btnexit.Text = "exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 637);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(btncalculate);
            Controls.Add(lblAditional);
            Controls.Add(chcAddTravel);
            Controls.Add(groupBox1);
            Controls.Add(ListBox1);
            Controls.Add(rdoNormalClass);
            Controls.Add(rdoBusnessClass);
            Controls.Add(rdoFiristClass);
            Controls.Add(lblTravel);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAditional;
        private CheckBox chcAddTravel;
        private GroupBox groupBox1;
        private TextBox txtPassengerAgess;
        private TextBox texttxtNumber;
        private TextBox txtbaggagewheigh;
        private TextBox txtPassenger;
        private Label txtpassengerName;
        private Label txtpassengerAge;
        private Label txtNumberTickets;
        private Label txtbaggage;
        private ListBox ListBox1;
        private RadioButton rdoNormalClass;
        private RadioButton rdoBusnessClass;
        private RadioButton rdoFiristClass;
        private Label lblTravel;
        private Label label1;
        private Button btncalculate;
        private Button btnclear;
        private Button btnexit;
    }
}
