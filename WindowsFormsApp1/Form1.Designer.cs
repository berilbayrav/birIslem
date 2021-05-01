namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSayi_uret = new System.Windows.Forms.Button();
            this.txtSayi_bir = new System.Windows.Forms.TextBox();
            this.txtSayi_iki = new System.Windows.Forms.TextBox();
            this.txtSayi_uc = new System.Windows.Forms.TextBox();
            this.txtSayi_dort = new System.Windows.Forms.TextBox();
            this.txtSayi_bes = new System.Windows.Forms.TextBox();
            this.txtSayi_alti = new System.Windows.Forms.TextBox();
            this.txtHedef_sayi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKullaniciGiris = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCozum = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnKural = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSayi_uret
            // 
            this.btnSayi_uret.BackColor = System.Drawing.Color.Transparent;
            this.btnSayi_uret.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSayi_uret.Location = new System.Drawing.Point(29, 247);
            this.btnSayi_uret.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSayi_uret.Name = "btnSayi_uret";
            this.btnSayi_uret.Size = new System.Drawing.Size(101, 63);
            this.btnSayi_uret.TabIndex = 0;
            this.btnSayi_uret.Text = "SAYI ÜRET";
            this.btnSayi_uret.UseVisualStyleBackColor = false;
            this.btnSayi_uret.Click += new System.EventHandler(this.btnSayi_uret_Click);
            // 
            // txtSayi_bir
            // 
            this.txtSayi_bir.Location = new System.Drawing.Point(22, 71);
            this.txtSayi_bir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSayi_bir.Name = "txtSayi_bir";
            this.txtSayi_bir.Size = new System.Drawing.Size(46, 28);
            this.txtSayi_bir.TabIndex = 1;
            // 
            // txtSayi_iki
            // 
            this.txtSayi_iki.Location = new System.Drawing.Point(87, 71);
            this.txtSayi_iki.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSayi_iki.Name = "txtSayi_iki";
            this.txtSayi_iki.Size = new System.Drawing.Size(46, 28);
            this.txtSayi_iki.TabIndex = 2;
            // 
            // txtSayi_uc
            // 
            this.txtSayi_uc.Location = new System.Drawing.Point(150, 71);
            this.txtSayi_uc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSayi_uc.Name = "txtSayi_uc";
            this.txtSayi_uc.Size = new System.Drawing.Size(46, 28);
            this.txtSayi_uc.TabIndex = 3;
            // 
            // txtSayi_dort
            // 
            this.txtSayi_dort.Location = new System.Drawing.Point(214, 71);
            this.txtSayi_dort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSayi_dort.Name = "txtSayi_dort";
            this.txtSayi_dort.Size = new System.Drawing.Size(46, 28);
            this.txtSayi_dort.TabIndex = 4;
            // 
            // txtSayi_bes
            // 
            this.txtSayi_bes.Location = new System.Drawing.Point(278, 71);
            this.txtSayi_bes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSayi_bes.Name = "txtSayi_bes";
            this.txtSayi_bes.Size = new System.Drawing.Size(46, 28);
            this.txtSayi_bes.TabIndex = 5;
            // 
            // txtSayi_alti
            // 
            this.txtSayi_alti.Location = new System.Drawing.Point(347, 71);
            this.txtSayi_alti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSayi_alti.Name = "txtSayi_alti";
            this.txtSayi_alti.Size = new System.Drawing.Size(46, 28);
            this.txtSayi_alti.TabIndex = 6;
            // 
            // txtHedef_sayi
            // 
            this.txtHedef_sayi.Location = new System.Drawing.Point(186, 172);
            this.txtHedef_sayi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHedef_sayi.Name = "txtHedef_sayi";
            this.txtHedef_sayi.Size = new System.Drawing.Size(46, 28);
            this.txtHedef_sayi.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnKullaniciGiris);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCozum);
            this.groupBox1.Controls.Add(this.txtSayi_bir);
            this.groupBox1.Controls.Add(this.btnSayi_uret);
            this.groupBox1.Controls.Add(this.txtHedef_sayi);
            this.groupBox1.Controls.Add(this.txtSayi_iki);
            this.groupBox1.Controls.Add(this.txtSayi_alti);
            this.groupBox1.Controls.Add(this.txtSayi_uc);
            this.groupBox1.Controls.Add(this.txtSayi_bes);
            this.groupBox1.Controls.Add(this.txtSayi_dort);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(280, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(416, 496);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bir İşlem";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 17;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(58, 211);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(169, 24);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "KULLANICI GİRİŞİ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Puan:";
            // 
            // btnKullaniciGiris
            // 
            this.btnKullaniciGiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKullaniciGiris.Location = new System.Drawing.Point(275, 247);
            this.btnKullaniciGiris.Name = "btnKullaniciGiris";
            this.btnKullaniciGiris.Size = new System.Drawing.Size(118, 63);
            this.btnKullaniciGiris.TabIndex = 13;
            this.btnKullaniciGiris.Text = "KULLANICI ";
            this.btnKullaniciGiris.UseVisualStyleBackColor = true;
            this.btnKullaniciGiris.Click += new System.EventHandler(this.btnKullaniciGiris_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(71, 340);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(286, 104);
            this.listBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(146, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hedeflenen Sayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(118, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kullanılacak Sayılar";
            // 
            // btnCozum
            // 
            this.btnCozum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCozum.Location = new System.Drawing.Point(156, 247);
            this.btnCozum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCozum.Name = "btnCozum";
            this.btnCozum.Size = new System.Drawing.Size(101, 63);
            this.btnCozum.TabIndex = 8;
            this.btnCozum.Text = "ÇÖZÜM";
            this.btnCozum.UseVisualStyleBackColor = true;
            this.btnCozum.Click += new System.EventHandler(this.btnCozum_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.Location = new System.Drawing.Point(0, 182);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(212, 63);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "YENİ OYUN";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Location = new System.Drawing.Point(686, 0);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(43, 53);
            this.btnCikis.TabIndex = 12;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.btnBaslat.ForeColor = System.Drawing.Color.Black;
            this.btnBaslat.Image = ((System.Drawing.Image)(resources.GetObject("btnBaslat.Image")));
            this.btnBaslat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaslat.Location = new System.Drawing.Point(0, 65);
            this.btnBaslat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(212, 65);
            this.btnBaslat.TabIndex = 13;
            this.btnBaslat.Text = "BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnKural
            // 
            this.btnKural.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.btnKural.Image = ((System.Drawing.Image)(resources.GetObject("btnKural.Image")));
            this.btnKural.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKural.Location = new System.Drawing.Point(0, 282);
            this.btnKural.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKural.Name = "btnKural";
            this.btnKural.Size = new System.Drawing.Size(212, 67);
            this.btnKural.TabIndex = 11;
            this.btnKural.Text = "OYUN  KURALLARI";
            this.btnKural.UseVisualStyleBackColor = false;
            this.btnKural.Click += new System.EventHandler(this.btnKural_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.btnKural);
            this.panel1.Controls.Add(this.btnBaslat);
            this.panel1.Location = new System.Drawing.Point(1, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 386);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnCikis);
            this.panel2.Location = new System.Drawing.Point(1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 53);
            this.panel2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(201, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "BİR İŞLEM OYUNU";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Bir İşlem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSayi_uret;
        private System.Windows.Forms.TextBox txtSayi_bir;
        private System.Windows.Forms.TextBox txtSayi_iki;
        private System.Windows.Forms.TextBox txtSayi_uc;
        private System.Windows.Forms.TextBox txtSayi_dort;
        private System.Windows.Forms.TextBox txtSayi_bes;
        private System.Windows.Forms.TextBox txtSayi_alti;
        private System.Windows.Forms.TextBox txtHedef_sayi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCozum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnKural;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKullaniciGiris;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

