using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EkstraYapilar
{
    public partial class RandomKomutu : Form
    {
        public RandomKomutu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int sayi;

            sayi = r.Next(1, 100);
            label1.Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)//Formlar Arası Geçiş
        {
            CaptchaOluşturma captchaOluşturma = new CaptchaOluşturma();
            captchaOluşturma.Show();
            this.Close();
        }
    }
}
