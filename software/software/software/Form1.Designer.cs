namespace software
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
            txtnumbe = new Label();
            txtprice = new Label();
            txtPackages = new TextBox();
            txtPricePer = new TextBox();
            btncalculate = new Button();
            btnexits = new Button();
            btnclear = new Button();
            txtResults = new ListBox();
            lblquantit = new Label();
            lbldiscount = new Label();
            SuspendLayout();
            // 
            // txtnumbe
            // 
            txtnumbe.AutoSize = true;
            txtnumbe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtnumbe.Location = new Point(12, 22);
            txtnumbe.Name = "txtnumbe";
            txtnumbe.Size = new Size(254, 32);
            txtnumbe.TabIndex = 0;
            txtnumbe.Text = "number of packages:";
            // 
            // txtprice
            // 
            txtprice.AutoSize = true;
            txtprice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtprice.Location = new Point(12, 67);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(228, 32);
            txtprice.TabIndex = 1;
            txtprice.Text = "price per packages";
            // 
            // txtPackages
            // 
            txtPackages.Location = new Point(272, 25);
            txtPackages.Name = "txtPackages";
            txtPackages.Size = new Size(224, 31);
            txtPackages.TabIndex = 2;
            txtPackages.TextChanged += txtPackages_TextChanged;
            // 
            // txtPricePer
            // 
            txtPricePer.Location = new Point(272, 82);
            txtPricePer.Name = "txtPricePer";
            txtPricePer.Size = new Size(224, 31);
            txtPricePer.TabIndex = 3;
            txtPricePer.TextChanged += txtPricePer_TextChanged;
            // 
            // btncalculate
            // 
            btncalculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncalculate.Location = new Point(31, 210);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(140, 52);
            btncalculate.TabIndex = 4;
            btncalculate.Text = "calculate";
            btncalculate.UseVisualStyleBackColor = true;
            btncalculate.Click += btncalculate_Click;
            // 
            // btnexits
            // 
            btnexits.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnexits.Location = new Point(413, 210);
            btnexits.Name = "btnexits";
            btnexits.Size = new Size(140, 52);
            btnexits.TabIndex = 5;
            btnexits.Text = "exits";
            btnexits.UseVisualStyleBackColor = true;
            btnexits.Click += btnexits_Click;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(202, 210);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(140, 52);
            btnclear.TabIndex = 6;
            btnclear.Text = "clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // txtResults
            // 
            txtResults.FormattingEnabled = true;
            txtResults.ItemHeight = 25;
            txtResults.Location = new Point(587, 25);
            txtResults.Name = "txtResults";
            txtResults.Size = new Size(558, 304);
            txtResults.TabIndex = 16;
            txtResults.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblquantit
            // 
            lblquantit.AutoSize = true;
            lblquantit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblquantit.Location = new Point(31, 376);
            lblquantit.Name = "lblquantit";
            lblquantit.Size = new Size(95, 32);
            lblquantit.TabIndex = 17;
            lblquantit.Text = "quatity";
            // 
            // lbldiscount
            // 
            lbldiscount.AutoSize = true;
            lbldiscount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldiscount.Location = new Point(304, 391);
            lbldiscount.Name = "lbldiscount";
            lbldiscount.Size = new Size(113, 32);
            lbldiscount.TabIndex = 18;
            lbldiscount.Text = "discount";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 616);
            Controls.Add(lbldiscount);
            Controls.Add(lblquantit);
            Controls.Add(txtResults);
            Controls.Add(btnclear);
            Controls.Add(btnexits);
            Controls.Add(btncalculate);
            Controls.Add(txtPricePer);
            Controls.Add(txtPackages);
            Controls.Add(txtprice);
            Controls.Add(txtnumbe);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtnumbe;
        private Label txtprice;
        private TextBox txtPackages;
        private TextBox txtPricePer;
        private Button btncalculate;
        private Button btnexits;
        private Button btnclear;
        private ListBox txtResults;
        private Label lblquantit;
        private Label lbldiscount;
    }
}
