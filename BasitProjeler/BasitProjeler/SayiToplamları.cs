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
    public partial class SayiToplamları : Form
    {
        public SayiToplamları()
        {
            InitializeComponent();
        }

        private void Topla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            int toplam = 0;
            for(int i = 1; i <= sayi; i++) {
                toplam = toplam + i;
            }
            label2.Text = "Cevap : " + toplam;
        }
    }
}
