using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayısalLotoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsayıuret_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi1 = 0, sayi2 = 0, sayi3 = 0, sayi4 = 0;
           
            sayi1 = rnd.Next(1, 15);
            sayi2 = rnd.Next(5, 20);
            sayi3 = rnd.Next(30, 65);
            sayi4 = rnd.Next(21, 45);
            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString();
            label4.Text = sayi4.ToString();

            textBox1.Text = sayi1.ToString();
            textBox2.Text = sayi2.ToString();
            textBox3.Text = sayi3.ToString();
            textBox4.Text = sayi4.ToString();


            if (textBox1.Text==label1.Text)
            {
                textBox1.BackColor = Color.Yellow;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.Yellow;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Yellow;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Yellow;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }










        }
    }
}
