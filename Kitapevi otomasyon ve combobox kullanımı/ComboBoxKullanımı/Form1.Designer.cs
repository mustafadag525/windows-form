namespace ComboBoxKullanımı
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmburunliste = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pcturunresim = new System.Windows.Forms.PictureBox();
            this.txturunadı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkategori = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstokadet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtyazar = new System.Windows.Forms.TextBox();
            this.txturunaciklama = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcturunresim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Listesi";
            // 
            // cmburunliste
            // 
            this.cmburunliste.FormattingEnabled = true;
            this.cmburunliste.Location = new System.Drawing.Point(189, 16);
            this.cmburunliste.Name = "cmburunliste";
            this.cmburunliste.Size = new System.Drawing.Size(417, 24);
            this.cmburunliste.TabIndex = 1;
            this.cmburunliste.SelectedIndexChanged += new System.EventHandler(this.cmburunliste_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txturunaciklama);
            this.groupBox1.Controls.Add(this.txtyazar);
            this.groupBox1.Controls.Add(this.txtstokadet);
            this.groupBox1.Controls.Add(this.txtkategori);
            this.groupBox1.Controls.Add(this.txturunadı);
            this.groupBox1.Controls.Add(this.pcturunresim);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 425);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçilen Ürün Detay Bilgisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Adı";
            // 
            // pcturunresim
            // 
            this.pcturunresim.Location = new System.Drawing.Point(6, 49);
            this.pcturunresim.Name = "pcturunresim";
            this.pcturunresim.Size = new System.Drawing.Size(115, 103);
            this.pcturunresim.TabIndex = 4;
            this.pcturunresim.TabStop = false;
            // 
            // txturunadı
            // 
            this.txturunadı.Enabled = false;
            this.txturunadı.Location = new System.Drawing.Point(323, 49);
            this.txturunadı.Name = "txturunadı";
            this.txturunadı.Size = new System.Drawing.Size(268, 22);
            this.txturunadı.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Kategorisi";
            // 
            // txtkategori
            // 
            this.txtkategori.Enabled = false;
            this.txtkategori.Location = new System.Drawing.Point(323, 84);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.Size = new System.Drawing.Size(268, 22);
            this.txtkategori.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok Adeti";
            // 
            // txtstokadet
            // 
            this.txtstokadet.Enabled = false;
            this.txtstokadet.Location = new System.Drawing.Point(323, 120);
            this.txtstokadet.Name = "txtstokadet";
            this.txtstokadet.Size = new System.Drawing.Size(268, 22);
            this.txtstokadet.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Yazar";
            // 
            // txtyazar
            // 
            this.txtyazar.Enabled = false;
            this.txtyazar.Location = new System.Drawing.Point(323, 155);
            this.txtyazar.Name = "txtyazar";
            this.txtyazar.Size = new System.Drawing.Size(268, 22);
            this.txtyazar.TabIndex = 5;
            // 
            // txturunaciklama
            // 
            this.txturunaciklama.Location = new System.Drawing.Point(32, 221);
            this.txturunaciklama.Name = "txturunaciklama";
            this.txturunaciklama.Size = new System.Drawing.Size(559, 188);
            this.txturunaciklama.TabIndex = 6;
            this.txturunaciklama.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmburunliste);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox Kullanımı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcturunresim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmburunliste;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcturunresim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtyazar;
        private System.Windows.Forms.TextBox txtstokadet;
        private System.Windows.Forms.TextBox txtkategori;
        private System.Windows.Forms.TextBox txturunadı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txturunaciklama;
    }
}

