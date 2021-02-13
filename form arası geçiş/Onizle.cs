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
    public partial class Onizle : Form
    {
        public Onizle()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if(item.Name=="Form1")
                {
                    foreach (Control FormItem in item.Controls)
                    {
                        if(FormItem is TextBox)
                        {
                            ((TextBox)FormItem).Text = string.Empty;
                        }
                    }
                }
            }
            this.Close();
        }
    }
}
