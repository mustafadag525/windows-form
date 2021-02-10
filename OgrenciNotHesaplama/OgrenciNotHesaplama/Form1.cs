using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, ortalama;
            vize = Convert.ToDouble(txtvize.Text);
            final = Convert.ToDouble(txtfinal.Text);
            ortalama = vize * 0.4 + final * 0.6;
            lblortalama.Text = ortalama.ToString();
            if(ortalama<60)
            {
                lbldurum.Text = "kaldınız";
                this.BackColor = Color.Red;
            }
            else
            {
                lbldurum.Text = "geçtiniz";
                this.BackColor = Color.Green;
            }
        }
    }
}
