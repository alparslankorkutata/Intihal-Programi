namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.worddoc = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BeyanTarihAd = new System.Windows.Forms.Button();
            this.OnsozTarihAd = new System.Windows.Forms.Button();
            this.OnsozTesekkur = new System.Windows.Forms.Button();
            this.TezOnay = new System.Windows.Forms.Button();
            this.TablolarListesi = new System.Windows.Forms.Button();
            this.KaynakcaKontrol = new System.Windows.Forms.Button();
            this.BaslikSayfaNumaralari = new System.Windows.Forms.Button();
            this.SekillerListesi = new System.Windows.Forms.Button();
            this.AlintiKontrol = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.worddocx = new System.Windows.Forms.Button();
            this.metintxt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sonuclar = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 310);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(769, 366);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // worddoc
            // 
            this.worddoc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.worddoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.worddoc.ForeColor = System.Drawing.SystemColors.Control;
            this.worddoc.Location = new System.Drawing.Point(16, 54);
            this.worddoc.Name = "worddoc";
            this.worddoc.Size = new System.Drawing.Size(88, 63);
            this.worddoc.TabIndex = 1;
            this.worddoc.Text = "Word Dosyası .doc";
            this.worddoc.UseVisualStyleBackColor = false;
            this.worddoc.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BeyanTarihAd);
            this.groupBox1.Controls.Add(this.OnsozTarihAd);
            this.groupBox1.Controls.Add(this.OnsozTesekkur);
            this.groupBox1.Controls.Add(this.TezOnay);
            this.groupBox1.Controls.Add(this.TablolarListesi);
            this.groupBox1.Controls.Add(this.KaynakcaKontrol);
            this.groupBox1.Controls.Add(this.BaslikSayfaNumaralari);
            this.groupBox1.Controls.Add(this.SekillerListesi);
            this.groupBox1.Controls.Add(this.AlintiKontrol);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(377, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(424, 245);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TEST KONTROLLERİ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            this.groupBox1.MouseHover += new System.EventHandler(this.groupBox1_MouseHover);
            // 
            // BeyanTarihAd
            // 
            this.BeyanTarihAd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BeyanTarihAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BeyanTarihAd.ForeColor = System.Drawing.SystemColors.Control;
            this.BeyanTarihAd.Location = new System.Drawing.Point(276, 172);
            this.BeyanTarihAd.Name = "BeyanTarihAd";
            this.BeyanTarihAd.Size = new System.Drawing.Size(101, 52);
            this.BeyanTarihAd.TabIndex = 24;
            this.BeyanTarihAd.Text = "Beyan Tarih ve Ad";
            this.BeyanTarihAd.UseVisualStyleBackColor = false;
            this.BeyanTarihAd.Click += new System.EventHandler(this.BeyanTarihAd_Click);
            // 
            // OnsozTarihAd
            // 
            this.OnsozTarihAd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OnsozTarihAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OnsozTarihAd.ForeColor = System.Drawing.SystemColors.Control;
            this.OnsozTarihAd.Location = new System.Drawing.Point(157, 172);
            this.OnsozTarihAd.Name = "OnsozTarihAd";
            this.OnsozTarihAd.Size = new System.Drawing.Size(101, 52);
            this.OnsozTarihAd.TabIndex = 23;
            this.OnsozTarihAd.Text = "Önsöz Tarih ve Ad";
            this.OnsozTarihAd.UseVisualStyleBackColor = false;
            this.OnsozTarihAd.Click += new System.EventHandler(this.OnsozTarihAd_Click);
            // 
            // OnsozTesekkur
            // 
            this.OnsozTesekkur.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OnsozTesekkur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OnsozTesekkur.ForeColor = System.Drawing.SystemColors.Control;
            this.OnsozTesekkur.Location = new System.Drawing.Point(40, 172);
            this.OnsozTesekkur.Name = "OnsozTesekkur";
            this.OnsozTesekkur.Size = new System.Drawing.Size(101, 52);
            this.OnsozTesekkur.TabIndex = 22;
            this.OnsozTesekkur.Text = "Önsöz Teşekkür";
            this.OnsozTesekkur.UseVisualStyleBackColor = false;
            this.OnsozTesekkur.Click += new System.EventHandler(this.OnsozTesekkur_Click);
            // 
            // TezOnay
            // 
            this.TezOnay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TezOnay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TezOnay.ForeColor = System.Drawing.SystemColors.Control;
            this.TezOnay.Location = new System.Drawing.Point(276, 102);
            this.TezOnay.Name = "TezOnay";
            this.TezOnay.Size = new System.Drawing.Size(101, 51);
            this.TezOnay.TabIndex = 21;
            this.TezOnay.Text = "Tez Onay";
            this.TezOnay.UseVisualStyleBackColor = false;
            this.TezOnay.Click += new System.EventHandler(this.TezOnay_Click);
            // 
            // TablolarListesi
            // 
            this.TablolarListesi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TablolarListesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TablolarListesi.ForeColor = System.Drawing.SystemColors.Control;
            this.TablolarListesi.Location = new System.Drawing.Point(157, 102);
            this.TablolarListesi.Name = "TablolarListesi";
            this.TablolarListesi.Size = new System.Drawing.Size(101, 51);
            this.TablolarListesi.TabIndex = 20;
            this.TablolarListesi.Text = "Tablolar Listesi";
            this.TablolarListesi.UseVisualStyleBackColor = false;
            this.TablolarListesi.Click += new System.EventHandler(this.TablolarListesi_Click);
            // 
            // KaynakcaKontrol
            // 
            this.KaynakcaKontrol.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KaynakcaKontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KaynakcaKontrol.ForeColor = System.Drawing.SystemColors.Control;
            this.KaynakcaKontrol.Location = new System.Drawing.Point(40, 102);
            this.KaynakcaKontrol.Name = "KaynakcaKontrol";
            this.KaynakcaKontrol.Size = new System.Drawing.Size(101, 51);
            this.KaynakcaKontrol.TabIndex = 19;
            this.KaynakcaKontrol.Text = "Kaynakça";
            this.KaynakcaKontrol.UseVisualStyleBackColor = false;
            this.KaynakcaKontrol.Click += new System.EventHandler(this.KaynakcaKontrol_Click);
            // 
            // BaslikSayfaNumaralari
            // 
            this.BaslikSayfaNumaralari.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BaslikSayfaNumaralari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BaslikSayfaNumaralari.ForeColor = System.Drawing.SystemColors.Control;
            this.BaslikSayfaNumaralari.Location = new System.Drawing.Point(276, 32);
            this.BaslikSayfaNumaralari.Name = "BaslikSayfaNumaralari";
            this.BaslikSayfaNumaralari.Size = new System.Drawing.Size(101, 51);
            this.BaslikSayfaNumaralari.TabIndex = 18;
            this.BaslikSayfaNumaralari.Text = "Başlık Sayfa";
            this.BaslikSayfaNumaralari.UseVisualStyleBackColor = false;
            this.BaslikSayfaNumaralari.Click += new System.EventHandler(this.BaslikSayfaNumaralari_Click_1);
            // 
            // SekillerListesi
            // 
            this.SekillerListesi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SekillerListesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SekillerListesi.ForeColor = System.Drawing.SystemColors.Control;
            this.SekillerListesi.Location = new System.Drawing.Point(157, 32);
            this.SekillerListesi.Name = "SekillerListesi";
            this.SekillerListesi.Size = new System.Drawing.Size(101, 52);
            this.SekillerListesi.TabIndex = 17;
            this.SekillerListesi.Text = "Şekiller Listesi";
            this.SekillerListesi.UseVisualStyleBackColor = false;
            this.SekillerListesi.Click += new System.EventHandler(this.SekillerListesi_Click_1);
            // 
            // AlintiKontrol
            // 
            this.AlintiKontrol.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AlintiKontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlintiKontrol.ForeColor = System.Drawing.SystemColors.Control;
            this.AlintiKontrol.Location = new System.Drawing.Point(40, 32);
            this.AlintiKontrol.Name = "AlintiKontrol";
            this.AlintiKontrol.Size = new System.Drawing.Size(101, 52);
            this.AlintiKontrol.TabIndex = 16;
            this.AlintiKontrol.Text = "Alıntı";
            this.AlintiKontrol.UseVisualStyleBackColor = false;
            this.AlintiKontrol.Click += new System.EventHandler(this.AlintiKontrol_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.worddocx);
            this.groupBox2.Controls.Add(this.metintxt);
            this.groupBox2.Controls.Add(this.worddoc);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(32, 44);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(332, 153);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kontrol Edilecek Tez Dosyası Ekleme";
            // 
            // worddocx
            // 
            this.worddocx.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.worddocx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.worddocx.ForeColor = System.Drawing.SystemColors.Control;
            this.worddocx.Location = new System.Drawing.Point(122, 54);
            this.worddocx.Name = "worddocx";
            this.worddocx.Size = new System.Drawing.Size(88, 63);
            this.worddocx.TabIndex = 6;
            this.worddocx.Text = "Word Dosyası .docx";
            this.worddocx.UseVisualStyleBackColor = false;
            this.worddocx.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // metintxt
            // 
            this.metintxt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metintxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metintxt.ForeColor = System.Drawing.SystemColors.Control;
            this.metintxt.Location = new System.Drawing.Point(229, 54);
            this.metintxt.Name = "metintxt";
            this.metintxt.Size = new System.Drawing.Size(88, 63);
            this.metintxt.TabIndex = 5;
            this.metintxt.Text = "Metin Dosyası .txt";
            this.metintxt.UseVisualStyleBackColor = false;
            this.metintxt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(750, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sonuclar
            // 
            this.sonuclar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sonuclar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sonuclar.ForeColor = System.Drawing.SystemColors.Control;
            this.sonuclar.Location = new System.Drawing.Point(276, 216);
            this.sonuclar.Name = "sonuclar";
            this.sonuclar.Size = new System.Drawing.Size(88, 52);
            this.sonuclar.TabIndex = 26;
            this.sonuclar.Text = "Sonuç Kontrol";
            this.sonuclar.UseVisualStyleBackColor = false;
            this.sonuclar.Click += new System.EventHandler(this.sonuclar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tez Kontrol Programı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(838, 678);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sonuclar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button worddoc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sonuclar;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button metintxt;
        private System.Windows.Forms.Button AlintiKontrol;
        private System.Windows.Forms.Button worddocx;
        private System.Windows.Forms.Button BaslikSayfaNumaralari;
        private System.Windows.Forms.Button SekillerListesi;
        private System.Windows.Forms.Button KaynakcaKontrol;
        private System.Windows.Forms.Button TablolarListesi;
        private System.Windows.Forms.Button TezOnay;
        private System.Windows.Forms.Button OnsozTesekkur;
        private System.Windows.Forms.Button OnsozTarihAd;
        private System.Windows.Forms.Button BeyanTarihAd;
    }
}

