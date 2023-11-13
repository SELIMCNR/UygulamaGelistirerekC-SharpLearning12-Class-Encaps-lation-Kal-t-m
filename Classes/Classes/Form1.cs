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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            araba rb = new araba();
            rb.renk = "Mavi";
            rb.hiz = 160;
            rb.motor = 1545.54;
            rb.fiyat = 5000;
            rb.durum = 's';
            rb.Yıl = -2023;
            rb.Markası = "golf";
            rb.muayene = 2017;
            rb.plaka = "46 Km 1881";
            rb.sahip = "Sertaç Bey";

            label1.Text = rb.renk;
            label2.Text = rb.hiz.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.fiyat.ToString();
            label5.Text = rb.durum.ToString();
            label6.Text = rb.Yıl.ToString();
            label7.Text = rb.Markası;
            label8.Text = rb.muayene.ToString();
            label9.Text = rb.plaka;
            label10.Text = rb.sahip;

            pictureBox1.BackColor = Color.CadetBlue;

        }
    }
}
