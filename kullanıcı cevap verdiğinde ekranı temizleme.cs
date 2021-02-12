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

                temizle();
            }
            else
            {
                
            }
        }


      
        private void temizle()
        {
            foreach (Control item in this.Controls)
            {
                if(item is Control)
                {
                    TextBox T = (TextBox)item;
                    T.Text = string.Empty;
                }

            }
        }
       


    }
}

