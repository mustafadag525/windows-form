using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messageboxinceleme
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

        private void btnmesajgoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kullanıcıya göstermek istediğiniz bilgi", "fenerbahçe", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            
        }

        private void btnsorusor_Click(object sender, EventArgs e)
        {
           DialogResult res= MessageBox.Show("yeniden denemek istermisiniz ?","soru",MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if(res==DialogResult.Yes)
            {

            }
            else if(res==DialogResult.No)
            {

            }
            else if(res==DialogResult.Cancel)
            {

            }


            /*
             * 1. parametre soracağımız soruları
             * 2. parametre ise başlık
             * 3. parametre evet hayır seçenekleri
             * 4 .parametre ise yanda çıkacak iconları gösterir
             * 
             * 
             * 
             *  DialogResult:
             *  
             * 
             * DialogResult bize herhangi bir durumda programın önüne (ShowDialog açar gibi) bir uyarı mesajından sonucu verir.
             * Örneğin bir Word dokümanını değiştirdikten sonra programı kapatmaya çalıştığınızda 
             * “Yaptığınız değişiklikleri kaydetmek istiyor musunuz?” gibi bir soru soruyor. 
             * “Evet” denildiğinde değişiklikler kaydediliyor, “Hayır” denildiğinde kaydedilmiyor. İşte burada DialogResult devreye giriyor.
             * Dönüş değeri bir iletişim kutusu göstermek için tanımlayıcıları belirler.
             * 
             * 
             */

        }
    }
}
