using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboboxdoldurv1(); 1.yol = items.add kullanılarak yapıldı;
            comboboxdoldurv2();
        }

        private void comboboxdoldurv2()
        {
            cmburunliste.DataSource = Database.uruntablo; // 2. yol datasource item yerine geçer ve burada yine tostringin overridena ihtiyaç duyarız
        }

        void comboboxdoldurv1()
        {
            foreach (var item in Database.uruntablo)
            {
                cmburunliste.Items.Add(item);
            }
        }

        private void cmburunliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            // selectedIndexChanged değişen comboboxın değişen değerini yakalamk için ve detayları aktarmak için;
            // 1.yöntem

            object o1 = cmburunliste.SelectedItem;
            Urun u1 = (Urun)o1;

            // 1. yöntemin daha kısası
            //u1 = cmburunliste.SelectedItem==null ? null:cmburunliste.SelectedItem as Urun; // null hatasının önüne geçmek için

            pcturunresim.Image = Image.FromFile(u1.resim);
            pcturunresim.SizeMode = PictureBoxSizeMode.StretchImage;
            txturunadı.Text = u1.urunadi;
            txtkategori.Text = u1.urunkategori;
            txtstokadet.Text = u1.stokadet.ToString();
            txtyazar.Text = u1.yazar;
            txturunaciklama.Text = u1.aciklama;




        }
    }
}
