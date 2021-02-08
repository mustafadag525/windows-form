using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textisim_TextChanged(object sender, EventArgs e)
        {

        }

        private void musteriekle_Click(object sender, EventArgs e)
        {
         int islem=   yenimusteriekle(new Musteri()
            {
                id = Guid.NewGuid(),
                isim=txtisim.Text,
                soyisim = txtsoyisim.Text,
                emailadres=txtemailadres.Text,
                telefonumarasi=txttlfnumaras.Text,


            }) ;

            MessageBox.Show("musteri ekleme başarılı, yeni müşteri eklemek istermisin", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private int   yenimusteriekle(Musteri data)
        {
            sanaldatabase.musteriler.Add(data);
            return 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
