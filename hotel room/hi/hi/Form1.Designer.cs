namespace hi
{
    partial class txtfood1
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
            this.txtguestname = new System.Windows.Forms.Label();
            this.txtroomtype = new System.Windows.Forms.Label();
            this.txtname2 = new System.Windows.Forms.Label();
            this.txtprice2 = new System.Windows.Forms.Label();
            this.txtroom = new System.Windows.Forms.TextBox();
            this.txtnights = new System.Windows.Forms.TextBox();
            this.txtpricenight = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lblsalestax = new System.Windows.Forms.Label();
            this.totalamount = new System.Windows.Forms.Label();
            this.tips = new System.Windows.Forms.Label();
            this.texguestname = new System.Windows.Forms.TextBox();
            this.lbldiscoun = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblsevice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtguestname
            // 
            this.txtguestname.AutoSize = true;
            this.txtguestname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtguestname.Location = new System.Drawing.Point(189, 52);
            this.txtguestname.Name = "txtguestname";
            this.txtguestname.Size = new System.Drawing.Size(197, 26);
            this.txtguestname.TabIndex = 0;
            this.txtguestname.Text = "enter guest name";
            // 
            // txtroomtype
            // 
            this.txtroomtype.AutoSize = true;
            this.txtroomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroomtype.Location = new System.Drawing.Point(189, 87);
            this.txtroomtype.Name = "txtroomtype";
            this.txtroomtype.Size = new System.Drawing.Size(172, 26);
            this.txtroomtype.TabIndex = 1;
            this.txtroomtype.Text = "enter roomtype";
            // 
            // txtname2
            // 
            this.txtname2.AutoSize = true;
            this.txtname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname2.Location = new System.Drawing.Point(189, 117);
            this.txtname2.Name = "txtname2";
            this.txtname2.Size = new System.Drawing.Size(239, 26);
            this.txtname2.TabIndex = 2;
            this.txtname2.Text = "enter number of night";
            // 
            // txtprice2
            // 
            this.txtprice2.AutoSize = true;
            this.txtprice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice2.Location = new System.Drawing.Point(189, 146);
            this.txtprice2.Name = "txtprice2";
            this.txtprice2.Size = new System.Drawing.Size(211, 26);
            this.txtprice2.TabIndex = 3;
            this.txtprice2.Text = "enter price to night";
            // 
            // txtroom
            // 
            this.txtroom.Location = new System.Drawing.Point(497, 69);
            this.txtroom.Name = "txtroom";
            this.txtroom.Size = new System.Drawing.Size(255, 26);
            this.txtroom.TabIndex = 5;
            // 
            // txtnights
            // 
            this.txtnights.Location = new System.Drawing.Point(497, 114);
            this.txtnights.Name = "txtnights";
            this.txtnights.Size = new System.Drawing.Size(255, 26);
            this.txtnights.TabIndex = 6;
            // 
            // txtpricenight
            // 
            this.txtpricenight.Location = new System.Drawing.Point(497, 161);
            this.txtpricenight.Name = "txtpricenight";
            this.txtpricenight.Size = new System.Drawing.Size(255, 26);
            this.txtpricenight.TabIndex = 7;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(260, 208);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(274, 37);
            this.btncalculate.TabIndex = 8;
            this.btncalculate.Text = "calculate booking";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblsalestax
            // 
            this.lblsalestax.AutoSize = true;
            this.lblsalestax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalestax.Location = new System.Drawing.Point(168, 271);
            this.lblsalestax.Name = "lblsalestax";
            this.lblsalestax.Size = new System.Drawing.Size(116, 25);
            this.lblsalestax.TabIndex = 9;
            this.lblsalestax.Text = "service tax";
            // 
            // totalamount
            // 
            this.totalamount.AutoSize = true;
            this.totalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalamount.Location = new System.Drawing.Point(168, 344);
            this.totalamount.Name = "totalamount";
            this.totalamount.Size = new System.Drawing.Size(137, 25);
            this.totalamount.TabIndex = 10;
            this.totalamount.Text = "total amount:";
            // 
            // tips
            // 
            this.tips.AutoSize = true;
            this.tips.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tips.Location = new System.Drawing.Point(189, 308);
            this.tips.Name = "tips";
            this.tips.Size = new System.Drawing.Size(82, 25);
            this.tips.TabIndex = 14;
            this.tips.Text = "dicount";
            // 
            // texguestname
            // 
            this.texguestname.Location = new System.Drawing.Point(497, 25);
            this.texguestname.Name = "texguestname";
            this.texguestname.Size = new System.Drawing.Size(255, 26);
            this.texguestname.TabIndex = 16;
            // 
            // lbldiscoun
            // 
            this.lbldiscoun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldiscoun.Location = new System.Drawing.Point(396, 308);
            this.lbldiscoun.Name = "lbldiscoun";
            this.lbldiscoun.Size = new System.Drawing.Size(243, 36);
            this.lbldiscoun.TabIndex = 18;
            // 
            // lbltotal
            // 
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotal.Location = new System.Drawing.Point(384, 347);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(243, 36);
            this.lbltotal.TabIndex = 19;
            // 
            // lblsevice
            // 
            this.lblsevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsevice.Location = new System.Drawing.Point(396, 260);
            this.lblsevice.Name = "lblsevice";
            this.lblsevice.Size = new System.Drawing.Size(243, 36);
            this.lblsevice.TabIndex = 20;
            // 
            // txtfood1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsevice);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbldiscoun);
            this.Controls.Add(this.texguestname);
            this.Controls.Add(this.tips);
            this.Controls.Add(this.totalamount);
            this.Controls.Add(this.lblsalestax);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtpricenight);
            this.Controls.Add(this.txtnights);
            this.Controls.Add(this.txtroom);
            this.Controls.Add(this.txtprice2);
            this.Controls.Add(this.txtname2);
            this.Controls.Add(this.txtroomtype);
            this.Controls.Add(this.txtguestname);
            this.Name = "txtfood1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtguestname;
        private System.Windows.Forms.Label txtroomtype;
        private System.Windows.Forms.Label txtname2;
        private System.Windows.Forms.Label txtprice2;
        private System.Windows.Forms.TextBox txtroom;
        private System.Windows.Forms.TextBox txtnights;
        private System.Windows.Forms.TextBox txtpricenight;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lblsalestax;
        private System.Windows.Forms.Label totalamount;
        private System.Windows.Forms.Label tips;
        private System.Windows.Forms.TextBox texguestname;
        private System.Windows.Forms.Label lbldiscoun;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblsevice;
    }
}

