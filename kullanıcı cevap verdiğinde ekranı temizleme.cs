using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesaageboxapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            DialogResult res= MessageBox.Show("temizlemek istediğinizden emin misiniz ?", "mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(res==DialogResult.Yes)
            {
                //temizle();
               
            }
            else
            {
                
            }
        }
        

        //private void temizle()       [[1. yol]]
        //{
        //    foreach (Control item in this.Controls) form ekranını evet denildiğinde silmek için
        //    {
        //        if(item is TextBox)
        //        {
        //            TextBox T = (TextBox)item;
        //            T.Text = string.Empty;
        //        }

        //    }
        //}


        //private void temizle2()  2. yol
        //{
        //    ((TextBox)this.Controls["txtisim"]).Text = string.Empty;
        //}


    }
}

