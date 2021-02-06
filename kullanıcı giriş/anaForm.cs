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
    public partial class anaForm : Form
    {
        public anaForm(string kullaniciAdi)
        {
            InitializeComponent();
            lblSelamla.Text = kullaniciAdi;
        }

        private void anaForm_Load(object sender, EventArgs e)
        {
             
        }

        private void lblSelamla_Click(object sender, EventArgs e)
        {

        }
    }
}
