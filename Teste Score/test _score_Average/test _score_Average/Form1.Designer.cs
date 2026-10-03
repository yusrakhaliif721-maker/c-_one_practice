namespace test__score_Average
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
            this.txtTest1 = new System.Windows.Forms.Label();
            this.txtTeste3 = new System.Windows.Forms.Label();
            this.txtteste2 = new System.Windows.Forms.Label();
            this.txtTest11 = new System.Windows.Forms.TextBox();
            this.txtTest3 = new System.Windows.Forms.TextBox();
            this.txtTest2 = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lbnAverage = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTest1
            // 
            this.txtTest1.AutoSize = true;
            this.txtTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTest1.Location = new System.Drawing.Point(181, 38);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(180, 29);
            this.txtTest1.TabIndex = 0;
            this.txtTest1.Text = "Teste score#1";
            // 
            // txtTeste3
            // 
            this.txtTeste3.AutoSize = true;
            this.txtTeste3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeste3.Location = new System.Drawing.Point(181, 115);
            this.txtTeste3.Name = "txtTeste3";
            this.txtTeste3.Size = new System.Drawing.Size(180, 29);
            this.txtTeste3.TabIndex = 1;
            this.txtTeste3.Text = "Teste score#3";
            // 
            // txtteste2
            // 
            this.txtteste2.AutoSize = true;
            this.txtteste2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtteste2.Location = new System.Drawing.Point(181, 77);
            this.txtteste2.Name = "txtteste2";
            this.txtteste2.Size = new System.Drawing.Size(180, 29);
            this.txtteste2.TabIndex = 2;
            this.txtteste2.Text = "Teste score#2";
            // 
            // txtTest11
            // 
            this.txtTest11.Location = new System.Drawing.Point(457, 40);
            this.txtTest11.Name = "txtTest11";
            this.txtTest11.Size = new System.Drawing.Size(178, 26);
            this.txtTest11.TabIndex = 3;
            // 
            // txtTest3
            // 
            this.txtTest3.Location = new System.Drawing.Point(457, 119);
            this.txtTest3.Name = "txtTest3";
            this.txtTest3.Size = new System.Drawing.Size(178, 26);
            this.txtTest3.TabIndex = 4;
            // 
            // txtTest2
            // 
            this.txtTest2.Location = new System.Drawing.Point(457, 81);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(178, 26);
            this.txtTest2.TabIndex = 5;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(232, 291);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(88, 99);
            this.btncalculate.TabIndex = 6;
            this.btncalculate.Text = "calculate Average";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(387, 348);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(114, 42);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(387, 291);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(114, 50);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lbnAverage
            // 
            this.lbnAverage.AutoSize = true;
            this.lbnAverage.Location = new System.Drawing.Point(433, 230);
            this.lbnAverage.Name = "lbnAverage";
            this.lbnAverage.Size = new System.Drawing.Size(68, 20);
            this.lbnAverage.TabIndex = 9;
            this.lbnAverage.Text = "Average";
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAverage.CausesValidation = false;
            this.lblAverage.Location = new System.Drawing.Point(540, 208);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(210, 51);
            this.lblAverage.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lbnAverage);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtTest2);
            this.Controls.Add(this.txtTest3);
            this.Controls.Add(this.txtTest11);
            this.Controls.Add(this.txtteste2);
            this.Controls.Add(this.txtTeste3);
            this.Controls.Add(this.txtTest1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTest1;
        private System.Windows.Forms.Label txtTeste3;
        private System.Windows.Forms.Label txtteste2;
        private System.Windows.Forms.TextBox txtTest11;
        private System.Windows.Forms.TextBox txtTest3;
        private System.Windows.Forms.TextBox txtTest2;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lbnAverage;
        private System.Windows.Forms.Label lblAverage;
    }
}

