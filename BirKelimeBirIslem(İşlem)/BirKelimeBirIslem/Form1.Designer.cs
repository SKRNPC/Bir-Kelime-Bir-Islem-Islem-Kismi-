namespace BirKelimeBirIslem
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKatsayi = new System.Windows.Forms.TextBox();
            this.txtSayi5 = new System.Windows.Forms.TextBox();
            this.txtSayi4 = new System.Windows.Forms.TextBox();
            this.txtSayi3 = new System.Windows.Forms.TextBox();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRastgele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHedefSayi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtIslem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(133, 75);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(24, 22);
            this.txtSayi2.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Kullanılacak Sayılar 1-9";
            // 
            // txtKatsayi
            // 
            this.txtKatsayi.Location = new System.Drawing.Point(538, 75);
            this.txtKatsayi.Name = "txtKatsayi";
            this.txtKatsayi.Size = new System.Drawing.Size(30, 22);
            this.txtKatsayi.TabIndex = 14;
            // 
            // txtSayi5
            // 
            this.txtSayi5.Location = new System.Drawing.Point(375, 75);
            this.txtSayi5.Name = "txtSayi5";
            this.txtSayi5.Size = new System.Drawing.Size(24, 22);
            this.txtSayi5.TabIndex = 15;
            // 
            // txtSayi4
            // 
            this.txtSayi4.Location = new System.Drawing.Point(288, 75);
            this.txtSayi4.Name = "txtSayi4";
            this.txtSayi4.Size = new System.Drawing.Size(24, 22);
            this.txtSayi4.TabIndex = 16;
            this.txtSayi4.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtSayi3
            // 
            this.txtSayi3.Location = new System.Drawing.Point(208, 75);
            this.txtSayi3.Name = "txtSayi3";
            this.txtSayi3.Size = new System.Drawing.Size(24, 22);
            this.txtSayi3.TabIndex = 17;
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(63, 75);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(24, 22);
            this.txtSayi1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kullanılacak sayı 10\'un Katları";
            // 
            // btnRastgele
            // 
            this.btnRastgele.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRastgele.Location = new System.Drawing.Point(538, 147);
            this.btnRastgele.Name = "btnRastgele";
            this.btnRastgele.Size = new System.Drawing.Size(172, 45);
            this.btnRastgele.TabIndex = 20;
            this.btnRastgele.Text = "RASTGELE SAYI";
            this.btnRastgele.UseVisualStyleBackColor = false;
            this.btnRastgele.Click += new System.EventHandler(this.btnRastgele_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(60, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "HEDEF SAYI";
            // 
            // txtHedefSayi
            // 
            this.txtHedefSayi.Location = new System.Drawing.Point(63, 147);
            this.txtHedefSayi.Name = "txtHedefSayi";
            this.txtHedefSayi.Size = new System.Drawing.Size(43, 22);
            this.txtHedefSayi.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "YAPILAN İŞLEMLER: ";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHesapla.Location = new System.Drawing.Point(538, 208);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(172, 43);
            this.btnHesapla.TabIndex = 24;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtIslem
            // 
            this.txtIslem.Location = new System.Drawing.Point(203, 307);
            this.txtIslem.Name = "txtIslem";
            this.txtIslem.Size = new System.Drawing.Size(140, 22);
            this.txtIslem.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "İŞLEM SONUCU: ";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(480, 307);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(42, 22);
            this.txtSonuc.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(538, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 43);
            this.button1.TabIndex = 28;
            this.button1.Text = "TEMİZLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIslem);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHedefSayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRastgele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.txtSayi3);
            this.Controls.Add(this.txtSayi4);
            this.Controls.Add(this.txtSayi5);
            this.Controls.Add(this.txtKatsayi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSayi2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKatsayi;
        private System.Windows.Forms.TextBox txtSayi5;
        private System.Windows.Forms.TextBox txtSayi4;
        private System.Windows.Forms.TextBox txtSayi3;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRastgele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHedefSayi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtIslem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button button1;
    }
}

