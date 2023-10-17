using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize_final_geçme17._10._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, ortalama;
            vize = Convert.ToDouble(txtVize.Text);
            final = Convert.ToDouble(txtFinal.Text);
            ortalama = (vize * 0.4 + final * 0.6);
            lblOrtalama.Text = "Ortalama: " + ortalama;
            if (ortalama >= 50 && final >= 50) 
            {
                lblDurum.Text = "GEÇTİNİZ";
            }
            else
            {
                lblDurum.Text = "KALDINIZ";
            }
        }
    }
}
