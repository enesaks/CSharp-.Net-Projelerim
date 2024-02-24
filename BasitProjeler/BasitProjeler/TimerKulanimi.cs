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
    public partial class TimerKulanimi : Form
    {
        public TimerKulanimi()
        {
            InitializeComponent();
        }
        int i = 0;
       
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            i++;
            label1.Text = i.ToString();
            if(i == 1)
            {
                this.BackColor = Color.AliceBlue;
            }
            if (i == 3) {
                this.BackColor = Color.Red;
                i = 0;
            }
        }

    }
}
