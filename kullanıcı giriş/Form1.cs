using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanıcıGirisApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtKullaniciAdi.Text;
            string parola = txtParola.Text;
            if(kullaniciadi=="admin" &&  parola=="12345")
            {
                anaForm aform = new anaForm(kullaniciadi);
                aform.Show();

            }
            else if(kullaniciadi=="admin" && parola!="12345")
            {
                MessageBox.Show("yanlış parola");
            }
            else if(kullaniciadi!="admin" && parola=="12345")
            {
                MessageBox.Show("yanlış kullanıcı adı");
            }
            else
            {
                MessageBox.Show("hatalı kullanıcı bilgileri");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtParola_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
