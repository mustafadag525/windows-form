namespace MessageBoxUygulama
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemailadres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttlfnumaras = new System.Windows.Forms.TextBox();
            this.musteriekle = new System.Windows.Forms.Button();
            this.ltsMusteriler = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.musteriekle);
            this.groupBox1.Controls.Add(this.txttlfnumaras);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtemailadres);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsoyisim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtisim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Müşteri  Kayıt Formu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ltsMusteriler);
            this.groupBox2.Location = new System.Drawing.Point(373, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 418);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Kayıt Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "isim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(141, 78);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(149, 22);
            this.txtisim.TabIndex = 0;
            this.txtisim.TextChanged += new System.EventHandler(this.textisim_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "soyisim";
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(141, 115);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(149, 22);
            this.txtsoyisim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "email adres";
            // 
            // txtemailadres
            // 
            this.txtemailadres.Location = new System.Drawing.Point(141, 159);
            this.txtemailadres.Name = "txtemailadres";
            this.txtemailadres.Size = new System.Drawing.Size(149, 22);
            this.txtemailadres.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "telefon munarası";
            // 
            // txttlfnumaras
            // 
            this.txttlfnumaras.Location = new System.Drawing.Point(141, 200);
            this.txttlfnumaras.Name = "txttlfnumaras";
            this.txttlfnumaras.Size = new System.Drawing.Size(149, 22);
            this.txttlfnumaras.TabIndex = 3;
            // 
            // musteriekle
            // 
            this.musteriekle.Location = new System.Drawing.Point(141, 247);
            this.musteriekle.Name = "musteriekle";
            this.musteriekle.Size = new System.Drawing.Size(149, 35);
            this.musteriekle.TabIndex = 4;
            this.musteriekle.Text = "Yeni Müşteri Ekle";
            this.musteriekle.UseVisualStyleBackColor = true;
            this.musteriekle.Click += new System.EventHandler(this.musteriekle_Click);
            // 
            // ltsMusteriler
            // 
            this.ltsMusteriler.FormattingEnabled = true;
            this.ltsMusteriler.ItemHeight = 16;
            this.ltsMusteriler.Location = new System.Drawing.Point(6, 37);
            this.ltsMusteriler.Name = "ltsMusteriler";
            this.ltsMusteriler.Size = new System.Drawing.Size(270, 148);
            this.ltsMusteriler.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messagebox Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button musteriekle;
        private System.Windows.Forms.TextBox txttlfnumaras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtemailadres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ltsMusteriler;
    }
}

