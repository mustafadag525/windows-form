using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtMesaj.Text = "metin giriniz";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtMesaj.Text     // değer atayabiliriz
            string txtmesajdegeri = txtMesaj.Text;


            Merhabaform merhabaform = new Merhabaform(txtmesajdegeri);
            merhabaform.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtMesaj.BackColor = Color.DarkBlue;
           
        }

        private void txtMesaj_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender; // text boxa tıklandığındaa metin giriniz kısmı silinir;
            T1.Text = string.Empty;
        }
    }
}
