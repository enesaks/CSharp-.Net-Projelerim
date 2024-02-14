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
    public partial class SınavNotları : Form
    {
        public SınavNotları()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ad = textBox1.Text;
            String soyad =textBox2.Text;
            int not1 = Convert.ToInt32(textBox3.Text);
            int not2 = Convert.ToInt32(textBox4.Text);
            int proje1 = Convert.ToInt32(textBox5.Text);

            double ortalama = (not1 + not2 + proje1) / 3;
            label5.Text = ortalama.ToString();
            listBox1.Items.Add(ad + " " + soyad + "--> " + "Ortalama : " + ortalama);

            if (ortalama > 60)
            {
                label3.Text = "Geçti";
            }else
            {
                label3.Text = "Kaldı";
            }

        }
    }
}
