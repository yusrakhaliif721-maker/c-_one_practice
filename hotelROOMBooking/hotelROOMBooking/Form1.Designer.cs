namespace hotelROOMBooking
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
            this.txtguesname = new System.Windows.Forms.Label();
            this.txtnighs = new System.Windows.Forms.Label();
            this.ltxtroomtype = new System.Windows.Forms.Label();
            this.txxpriceNight = new System.Windows.Forms.Label();
            this.txtguestname = new System.Windows.Forms.TextBox();
            this.txtroomtype = new System.Windows.Forms.TextBox();
            this.txtnights = new System.Windows.Forms.TextBox();
            this.txtPriceNight = new System.Windows.Forms.TextBox();
            this.bubtncalculate = new System.Windows.Forms.Button();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.iblservicetax = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.lblsevicetax = new System.Windows.Forms.Label();
            this.ibldiscount = new System.Windows.Forms.Label();
            this.lbltotalamoun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtguesname
            // 
            this.txtguesname.AutoSize = true;
            this.txtguesname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtguesname.Location = new System.Drawing.Point(135, 30);
            this.txtguesname.Name = "txtguesname";
            this.txtguesname.Size = new System.Drawing.Size(179, 25);
            this.txtguesname.TabIndex = 0;
            this.txtguesname.Text = "enter guest name";
            // 
            // txtnighs
            // 
            this.txtnighs.AutoSize = true;
            this.txtnighs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnighs.Location = new System.Drawing.Point(135, 111);
            this.txtnighs.Name = "txtnighs";
            this.txtnighs.Size = new System.Drawing.Size(215, 25);
            this.txtnighs.TabIndex = 1;
            this.txtnighs.Text = "enter number of nihts";
            // 
            // ltxtroomtype
            // 
            this.ltxtroomtype.AutoSize = true;
            this.ltxtroomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxtroomtype.Location = new System.Drawing.Point(135, 67);
            this.ltxtroomtype.Name = "ltxtroomtype";
            this.ltxtroomtype.Size = new System.Drawing.Size(162, 25);
            this.ltxtroomtype.TabIndex = 2;
            this.ltxtroomtype.Text = "enter room type";
            // 
            // txxpriceNight
            // 
            this.txxpriceNight.AutoSize = true;
            this.txxpriceNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txxpriceNight.Location = new System.Drawing.Point(135, 153);
            this.txxpriceNight.Name = "txxpriceNight";
            this.txxpriceNight.Size = new System.Drawing.Size(209, 25);
            this.txxpriceNight.TabIndex = 3;
            this.txxpriceNight.Text = "lenter price per night";
            // 
            // txtguestname
            // 
            this.txtguestname.Location = new System.Drawing.Point(482, 22);
            this.txtguestname.Name = "txtguestname";
            this.txtguestname.Size = new System.Drawing.Size(232, 26);
            this.txtguestname.TabIndex = 4;
            // 
            // txtroomtype
            // 
            this.txtroomtype.Location = new System.Drawing.Point(482, 67);
            this.txtroomtype.Name = "txtroomtype";
            this.txtroomtype.Size = new System.Drawing.Size(232, 26);
            this.txtroomtype.TabIndex = 5;
            // 
            // txtnights
            // 
            this.txtnights.Location = new System.Drawing.Point(482, 112);
            this.txtnights.Name = "txtnights";
            this.txtnights.Size = new System.Drawing.Size(232, 26);
            this.txtnights.TabIndex = 6;
            // 
            // txtPriceNight
            // 
            this.txtPriceNight.Location = new System.Drawing.Point(482, 152);
            this.txtPriceNight.Name = "txtPriceNight";
            this.txtPriceNight.Size = new System.Drawing.Size(232, 26);
            this.txtPriceNight.TabIndex = 7;
            // 
            // bubtncalculate
            // 
            this.bubtncalculate.Location = new System.Drawing.Point(376, 203);
            this.bubtncalculate.Name = "bubtncalculate";
            this.bubtncalculate.Size = new System.Drawing.Size(206, 54);
            this.bubtncalculate.TabIndex = 8;
            this.bubtncalculate.Text = "calculate booking";
            this.bubtncalculate.UseVisualStyleBackColor = true;
            this.bubtncalculate.Click += new System.EventHandler(this.bubtncalculate_Click);
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscount.Location = new System.Drawing.Point(118, 324);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(196, 29);
            this.lbldiscount.TabIndex = 9;
            this.lbldiscount.Text = "discoun amount";
            // 
            // iblservicetax
            // 
            this.iblservicetax.AutoSize = true;
            this.iblservicetax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iblservicetax.Location = new System.Drawing.Point(118, 291);
            this.iblservicetax.Name = "iblservicetax";
            this.iblservicetax.Size = new System.Drawing.Size(137, 29);
            this.iblservicetax.TabIndex = 10;
            this.iblservicetax.Text = "service tax";
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamount.Location = new System.Drawing.Point(118, 363);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(148, 29);
            this.lbltotalamount.TabIndex = 11;
            this.lbltotalamount.Text = "total amoun";
            // 
            // lblsevicetax
            // 
            this.lblsevicetax.AutoSize = true;
            this.lblsevicetax.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblsevicetax.Location = new System.Drawing.Point(429, 282);
            this.lblsevicetax.Name = "lblsevicetax";
            this.lblsevicetax.Size = new System.Drawing.Size(349, 20);
            this.lblsevicetax.TabIndex = 12;
            this.lblsevicetax.Text = "                                                                                 " +
    "    ";
            // 
            // ibldiscount
            // 
            this.ibldiscount.AutoSize = true;
            this.ibldiscount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ibldiscount.Location = new System.Drawing.Point(429, 324);
            this.ibldiscount.Name = "ibldiscount";
            this.ibldiscount.Size = new System.Drawing.Size(349, 20);
            this.ibldiscount.TabIndex = 13;
            this.ibldiscount.Text = "                                                                                 " +
    "    ";
            // 
            // lbltotalamoun
            // 
            this.lbltotalamoun.AutoSize = true;
            this.lbltotalamoun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbltotalamoun.Location = new System.Drawing.Point(429, 363);
            this.lbltotalamoun.Name = "lbltotalamoun";
            this.lbltotalamoun.Size = new System.Drawing.Size(349, 20);
            this.lbltotalamoun.TabIndex = 14;
            this.lbltotalamoun.Text = "                                                                                 " +
    "    ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltotalamoun);
            this.Controls.Add(this.ibldiscount);
            this.Controls.Add(this.lblsevicetax);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.iblservicetax);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.bubtncalculate);
            this.Controls.Add(this.txtPriceNight);
            this.Controls.Add(this.txtnights);
            this.Controls.Add(this.txtroomtype);
            this.Controls.Add(this.txtguestname);
            this.Controls.Add(this.txxpriceNight);
            this.Controls.Add(this.ltxtroomtype);
            this.Controls.Add(this.txtnighs);
            this.Controls.Add(this.txtguesname);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtguesname;
        private System.Windows.Forms.Label txtnighs;
        private System.Windows.Forms.Label ltxtroomtype;
        private System.Windows.Forms.Label txxpriceNight;
        private System.Windows.Forms.TextBox txtguestname;
        private System.Windows.Forms.TextBox txtroomtype;
        private System.Windows.Forms.TextBox txtnights;
        private System.Windows.Forms.TextBox txtPriceNight;
        private System.Windows.Forms.Button bubtncalculate;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.Label iblservicetax;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Label lblsevicetax;
        private System.Windows.Forms.Label ibldiscount;
        private System.Windows.Forms.Label lbltotalamoun;
    }
}

