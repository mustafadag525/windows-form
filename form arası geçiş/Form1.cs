using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnonizle_Click(object sender, EventArgs e)
        {
            Onizle onizle = new Onizle();
            ((TextBox)onizle.Controls["txtisim"]).Text = txtisim.Text;
            ((TextBox)onizle.Controls["txtsoyisim"]).Text = txtsoyisim.Text;
            ((TextBox)onizle.Controls["txtemailadres"]).Text = txtemailadres.Text;
            ((TextBox)onizle.Controls["txttelefonnumara"]).Text = txttelefonnumara.Text;





            onizle.ShowDialog();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            
           DialogResult res= MessageBox.Show("silmek istediğinizden eminmisimiz?", "mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(res==DialogResult.Yes)
            {
                temizle();
            }
            else
            {

            }


        }

        private void ındextemizle()
        {
            ((TextBox)this.Controls["txtisim"]).Text = string.Empty;
        }

        private void temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox T = (TextBox)item;
                    T.Text = string.Empty;
                }

            }
       
        
        
        }
    }

}
