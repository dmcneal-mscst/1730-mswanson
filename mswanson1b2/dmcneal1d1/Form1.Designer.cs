namespace dmcneal1d1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalUSD = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUSDEuro = new System.Windows.Forms.TextBox();
            this.txtUSDCostaRica = new System.Windows.Forms.TextBox();
            this.txtUSDBhutan = new System.Windows.Forms.TextBox();
            this.txtUSDAustralia = new System.Windows.Forms.TextBox();
            this.txtRateEuro = new System.Windows.Forms.TextBox();
            this.txtRateCostaRica = new System.Windows.Forms.TextBox();
            this.txtRateBhutan = new System.Windows.Forms.TextBox();
            this.txtRateAustralia = new System.Windows.Forms.TextBox();
            this.txtAmountEuro = new System.Windows.Forms.TextBox();
            this.txtAmountCostaRica = new System.Windows.Forms.TextBox();
            this.txtAmountBhutan = new System.Windows.Forms.TextBox();
            this.txtAmountAustralia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 84;
            this.label12.Text = "$US";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 83;
            this.label11.Text = "Rate:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 82;
            this.label10.Text = "Amount:";
            // 
            // txtTotalUSD
            // 
            this.txtTotalUSD.Location = new System.Drawing.Point(754, 219);
            this.txtTotalUSD.Name = "txtTotalUSD";
            this.txtTotalUSD.ReadOnly = true;
            this.txtTotalUSD.Size = new System.Drawing.Size(155, 20);
            this.txtTotalUSD.TabIndex = 81;
            this.txtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalUSD.TextChanged += new System.EventHandler(this.usdTextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 66;
            this.button2.Text = "E&xit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 64;
            this.button1.Text = "&Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(709, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 80;
            this.label9.Text = "+";
            // 
            // txtUSDEuro
            // 
            this.txtUSDEuro.Location = new System.Drawing.Point(524, 219);
            this.txtUSDEuro.Name = "txtUSDEuro";
            this.txtUSDEuro.ReadOnly = true;
            this.txtUSDEuro.Size = new System.Drawing.Size(149, 20);
            this.txtUSDEuro.TabIndex = 79;
            this.txtUSDEuro.Text = "0.00";
            this.txtUSDEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDCostaRica
            // 
            this.txtUSDCostaRica.Location = new System.Drawing.Point(374, 219);
            this.txtUSDCostaRica.Name = "txtUSDCostaRica";
            this.txtUSDCostaRica.ReadOnly = true;
            this.txtUSDCostaRica.Size = new System.Drawing.Size(144, 20);
            this.txtUSDCostaRica.TabIndex = 78;
            this.txtUSDCostaRica.Text = "0.00";
            this.txtUSDCostaRica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDBhutan
            // 
            this.txtUSDBhutan.Location = new System.Drawing.Point(218, 219);
            this.txtUSDBhutan.Name = "txtUSDBhutan";
            this.txtUSDBhutan.ReadOnly = true;
            this.txtUSDBhutan.Size = new System.Drawing.Size(150, 20);
            this.txtUSDBhutan.TabIndex = 77;
            this.txtUSDBhutan.Text = "0.00";
            this.txtUSDBhutan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDAustralia
            // 
            this.txtUSDAustralia.Location = new System.Drawing.Point(56, 219);
            this.txtUSDAustralia.Name = "txtUSDAustralia";
            this.txtUSDAustralia.ReadOnly = true;
            this.txtUSDAustralia.Size = new System.Drawing.Size(156, 20);
            this.txtUSDAustralia.TabIndex = 76;
            this.txtUSDAustralia.Text = "0.00";
            this.txtUSDAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRateEuro
            // 
            this.txtRateEuro.Location = new System.Drawing.Point(524, 193);
            this.txtRateEuro.Name = "txtRateEuro";
            this.txtRateEuro.Size = new System.Drawing.Size(149, 20);
            this.txtRateEuro.TabIndex = 70;
            this.txtRateEuro.Text = "1.16322";
            this.txtRateEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRateCostaRica
            // 
            this.txtRateCostaRica.Location = new System.Drawing.Point(374, 193);
            this.txtRateCostaRica.Name = "txtRateCostaRica";
            this.txtRateCostaRica.Size = new System.Drawing.Size(144, 20);
            this.txtRateCostaRica.TabIndex = 69;
            this.txtRateCostaRica.Text = "0.00172137";
            this.txtRateCostaRica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateCostaRica.TextChanged += new System.EventHandler(this.costaricaTextChanged);
            // 
            // txtRateBhutan
            // 
            this.txtRateBhutan.Location = new System.Drawing.Point(218, 193);
            this.txtRateBhutan.Name = "txtRateBhutan";
            this.txtRateBhutan.Size = new System.Drawing.Size(150, 20);
            this.txtRateBhutan.TabIndex = 68;
            this.txtRateBhutan.Text = "0.0138935";
            this.txtRateBhutan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateBhutan.TextChanged += new System.EventHandler(this.bhutanTextChanged);
            // 
            // txtRateAustralia
            // 
            this.txtRateAustralia.Location = new System.Drawing.Point(56, 193);
            this.txtRateAustralia.Name = "txtRateAustralia";
            this.txtRateAustralia.Size = new System.Drawing.Size(156, 20);
            this.txtRateAustralia.TabIndex = 67;
            this.txtRateAustralia.Text = "0.716190";
            this.txtRateAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateAustralia.TextChanged += new System.EventHandler(this.australiaTextChanged);
            // 
            // txtAmountEuro
            // 
            this.txtAmountEuro.Location = new System.Drawing.Point(524, 167);
            this.txtAmountEuro.Name = "txtAmountEuro";
            this.txtAmountEuro.Size = new System.Drawing.Size(149, 20);
            this.txtAmountEuro.TabIndex = 62;
            this.txtAmountEuro.Text = "0.00";
            this.txtAmountEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountEuro.TextChanged += new System.EventHandler(this.euroTextChanged);
            // 
            // txtAmountCostaRica
            // 
            this.txtAmountCostaRica.Location = new System.Drawing.Point(374, 167);
            this.txtAmountCostaRica.Name = "txtAmountCostaRica";
            this.txtAmountCostaRica.Size = new System.Drawing.Size(144, 20);
            this.txtAmountCostaRica.TabIndex = 60;
            this.txtAmountCostaRica.Text = "0.00";
            this.txtAmountCostaRica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountCostaRica.TextChanged += new System.EventHandler(this.costaricaTextChanged);
            // 
            // txtAmountBhutan
            // 
            this.txtAmountBhutan.Location = new System.Drawing.Point(218, 167);
            this.txtAmountBhutan.Name = "txtAmountBhutan";
            this.txtAmountBhutan.Size = new System.Drawing.Size(150, 20);
            this.txtAmountBhutan.TabIndex = 58;
            this.txtAmountBhutan.Text = "0.00";
            this.txtAmountBhutan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountBhutan.TextChanged += new System.EventHandler(this.bhutanTextChanged);
            // 
            // txtAmountAustralia
            // 
            this.txtAmountAustralia.Location = new System.Drawing.Point(56, 167);
            this.txtAmountAustralia.Name = "txtAmountAustralia";
            this.txtAmountAustralia.Size = new System.Drawing.Size(156, 20);
            this.txtAmountAustralia.TabIndex = 57;
            this.txtAmountAustralia.Text = "0.00";
            this.txtAmountAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountAustralia.TextAlignChanged += new System.EventHandler(this.australiaTextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(805, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "US Dollar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Euro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Costa Rican Colon ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Bhutanese Ngultrum";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(754, 34);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(155, 130);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 65;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(374, 34);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(144, 130);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 63;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(524, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(149, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 61;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(218, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Australian Dollar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 303);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotalUSD);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUSDEuro);
            this.Controls.Add(this.txtUSDCostaRica);
            this.Controls.Add(this.txtUSDBhutan);
            this.Controls.Add(this.txtUSDAustralia);
            this.Controls.Add(this.txtRateEuro);
            this.Controls.Add(this.txtRateCostaRica);
            this.Controls.Add(this.txtRateBhutan);
            this.Controls.Add(this.txtRateAustralia);
            this.Controls.Add(this.txtAmountEuro);
            this.Controls.Add(this.txtAmountCostaRica);
            this.Controls.Add(this.txtAmountBhutan);
            this.Controls.Add(this.txtAmountAustralia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "dmcneal1d1 Currency Converter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalUSD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUSDEuro;
        private System.Windows.Forms.TextBox txtUSDCostaRica;
        private System.Windows.Forms.TextBox txtUSDBhutan;
        private System.Windows.Forms.TextBox txtUSDAustralia;
        private System.Windows.Forms.TextBox txtRateEuro;
        private System.Windows.Forms.TextBox txtRateCostaRica;
        private System.Windows.Forms.TextBox txtRateBhutan;
        private System.Windows.Forms.TextBox txtRateAustralia;
        private System.Windows.Forms.TextBox txtAmountEuro;
        private System.Windows.Forms.TextBox txtAmountCostaRica;
        private System.Windows.Forms.TextBox txtAmountBhutan;
        private System.Windows.Forms.TextBox txtAmountAustralia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

