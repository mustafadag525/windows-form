using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikFormElemanları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnuret_Click(object sender, EventArgs e)
        {
            for(int i=1;i<=50;i++)
            {
                Button btntemp = new Button();
                btntemp.Name = "btn" + i.ToString();
                btntemp.Size= new System.Drawing.Size(35, 35);
                btntemp.Text = i.ToString();
                btntemp.UseVisualStyleBackColor = true;
                flowLayoutPanel1.Controls.Add(btntemp);

            }
        }
    }
}
 //this.btntemp.Location = new System.Drawing.Point(3, 3);
 //           this.btntemp.Name = "btntemp";
 //           this.btntemp.Size = new System.Drawing.Size(35, 35);
 //           this.btntemp.TabIndex = 2;
 //           this.btntemp.Text = "1";
 //           this.btntemp.UseVisualStyleBackColor = true;