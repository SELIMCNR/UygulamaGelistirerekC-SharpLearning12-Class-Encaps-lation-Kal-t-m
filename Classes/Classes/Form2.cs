using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            araba rb = new araba();
            rb.renk = "Yeşil";
            rb.hiz = 140;
            rb.motor = 1220.54;
            rb.fiyat = 35850;
            rb.durum = 'i';


            label1.Text = rb.renk;
            label2.Text = rb.hiz.ToString();
            label3.Text = rb .motor.ToString();
            label4.Text = rb.fiyat.ToString();
            label5.Text = rb.durum.ToString();
            pictureBox1.BackColor = Color.LightSeaGreen;

        }
    }
}
