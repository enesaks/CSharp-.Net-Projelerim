using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasitProjeler
{
    public partial class BasitHesap : Form
    {

       

        public BasitHesap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1 = Convert.ToDouble(textBox1.Text);
            double sayı2 = Convert.ToDouble(textBox2.Text);
            double toplam = sayı1 + sayı2;
            label5.Text = Convert.ToString(toplam);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            double sayı1 = Convert.ToDouble(textBox1.Text);
            double sayı2 = Convert.ToDouble(textBox2.Text);
            double bolum = sayı1 / sayı2;
            label5.Text = Convert.ToString(bolum);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sayı1 = Convert.ToDouble(textBox1.Text);
            double sayı2 = Convert.ToDouble(textBox2.Text);
            double fark = sayı1 - sayı2;
            label5.Text = Convert.ToString(fark);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayı1 = Convert.ToDouble(textBox1.Text);
            double sayı2 = Convert.ToDouble(textBox2.Text);
            double carpim = sayı1 * sayı2;
            label5.Text = Convert.ToString(carpim);

        }
    }
}
