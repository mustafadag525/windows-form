namespace MessageBoxApp
{
    partial class Onizle
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
            this.txttelefonnumara = new System.Windows.Forms.TextBox();
            this.txtemailadres = new System.Windows.Forms.TextBox();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttelefonnumara
            // 
            this.txttelefonnumara.Enabled = false;
            this.txttelefonnumara.Location = new System.Drawing.Point(146, 173);
            this.txttelefonnumara.Name = "txttelefonnumara";
            this.txttelefonnumara.Size = new System.Drawing.Size(152, 22);
            this.txttelefonnumara.TabIndex = 10;
            // 
            // txtemailadres
            // 
            this.txtemailadres.Enabled = false;
            this.txtemailadres.Location = new System.Drawing.Point(146, 121);
            this.txtemailadres.Name = "txtemailadres";
            this.txtemailadres.Size = new System.Drawing.Size(152, 22);
            this.txtemailadres.TabIndex = 8;
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Enabled = false;
            this.txtsoyisim.Location = new System.Drawing.Point(146, 68);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(152, 22);
            this.txtsoyisim.TabIndex = 6;
            // 
            // txtisim
            // 
            this.txtisim.Enabled = false;
            this.txtisim.Location = new System.Drawing.Point(146, 26);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(152, 22);
            this.txtisim.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefon numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyisim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "İsim";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(346, 41);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 102);
            this.btnkaydet.TabIndex = 12;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // Onizle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 323);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txttelefonnumara);
            this.Controls.Add(this.txtemailadres);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Onizle";
            this.Text = "Onizle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttelefonnumara;
        private System.Windows.Forms.TextBox txtemailadres;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkaydet;
    }
}