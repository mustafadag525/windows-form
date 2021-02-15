namespace MayınTarlasıOyunu
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
            this.btnuret = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblskor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmayın = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnuret
            // 
            this.btnuret.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnuret.Location = new System.Drawing.Point(623, 12);
            this.btnuret.Name = "btnuret";
            this.btnuret.Size = new System.Drawing.Size(110, 110);
            this.btnuret.TabIndex = 0;
            this.btnuret.Text = "Üret";
            this.btnuret.UseVisualStyleBackColor = false;
            this.btnuret.Click += new System.EventHandler(this.btnuret_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(600, 266);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lblskor
            // 
            this.lblskor.AutoSize = true;
            this.lblskor.Location = new System.Drawing.Point(620, 172);
            this.lblskor.Name = "lblskor";
            this.lblskor.Size = new System.Drawing.Size(47, 17);
            this.lblskor.TabIndex = 2;
            this.lblskor.Text = "SKOR";
            this.lblskor.Click += new System.EventHandler(this.lblskor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAYIN";
            this.label1.Click += new System.EventHandler(this.lblskor_Click);
            // 
            // lblmayın
            // 
            this.lblmayın.AutoSize = true;
            this.lblmayın.Location = new System.Drawing.Point(687, 209);
            this.lblmayın.Name = "lblmayın";
            this.lblmayın.Size = new System.Drawing.Size(16, 17);
            this.lblmayın.TabIndex = 3;
            this.lblmayın.Text = "0";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(687, 172);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 17);
            this.lbl.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 282);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblmayın);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblskor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnuret);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnuret;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblskor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmayın;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
    }
}

