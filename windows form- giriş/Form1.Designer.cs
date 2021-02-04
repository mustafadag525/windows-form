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
            this.btnAc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAc
            // 
            this.btnAc.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAc.Location = new System.Drawing.Point(260, 166);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(193, 60);
            this.btnAc.TabIndex = 0;
            this.btnAc.Text = "merhaba formu aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(257, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "ikinci form üzerinde yazmasını\r\n istediğiniz metni giriniz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(260, 111);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(193, 22);
            this.txtMesaj.TabIndex = 2;
            this.txtMesaj.Text = "bir metin değeri giriniz";
            this.txtMesaj.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtMesaj.Enter += new System.EventHandler(this.txtMesaj_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 356);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAc);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "merhaba form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMesaj;
    }
}

