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
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }
        int value = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (value < 100){
                value = value +10;
            }
            progressBar1.Value = value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (value > 9) { 
            value = value -10;
            }
            progressBar1.Value = value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            value++;
            progressBar1.Value = value;
        }
    }
}
