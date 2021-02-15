using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayınTarlasıOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblskor.Text = "0";
        }

        private void btnuret_Click(object sender, EventArgs e)
        {
            int mayın1 = 0;
           int mayın2 = 0;
           int  mayın3 = 0;

            Random rnd = new Random();
           mayın1= rnd.Next(1, 20);
           mayın2= rnd.Next(21, 40);
           mayın3= rnd.Next(41, 50);


            for(int i=1;i<=50;i++)
            {
                Button btntemp = new Button();
                btntemp.Name = "btn" + i.ToString();
                btntemp.Size = new System.Drawing.Size(35, 35);
                btntemp.Text = i.ToString();
                btntemp.UseVisualStyleBackColor = true;
                if(mayın1==i || mayın2==i || mayın3==i)
                {
                    btntemp.Tag = true;
                }
                else
                {
                    btntemp.Tag = false;
                }

                
                btntemp.Click += Btntemp_Click;
                flowLayoutPanel1.Controls.Add(btntemp);

            }

        }
        private void Btntemp_Click(object sender, EventArgs e)
        {
            Button basılan = ((Button)sender);
            bool mayınbulundumu =(bool)basılan.Tag;

            if(mayınbulundumu)
            {
                MessageBox.Show("Maalesef mayına bastınız");
                basılan.BackColor = Color.Red;
                int skorınt = int.Parse(lblmayın.Text);
                skorınt++;
                lblmayın.Text = skorınt.ToString();
            }
            else
            {
                basılan.BackColor = Color.Green;
                int skorınt = int.Parse(lblskor.Text);
                skorınt++;
                lblskor.Text = skorınt.ToString();
            }
        }

        private void lblskor_Click(object sender, EventArgs e)
        {

        }
    }
}
//this.btntemp.Location = new System.Drawing.Point(3, 3);
//            this.btntemp.Name = "btntemp";
//            this.btntemp.Size = new System.Drawing.Size(35, 35);
//            this.btntemp.TabIndex = 0;
//            this.btntemp.Text = "1";
//            this.btntemp.UseVisualStyleBackColor = true;