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
    public partial class BasitSaat : Form
    {
        public BasitSaat()
        {
            InitializeComponent();
        }
        int saniyeInt = 0;
        int dakikaInt = 0;
        int saatInt = 0;

        private void BasitSaat_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniyeInt++;
            saniye.Text = saniyeInt.ToString();

            if (saniyeInt == 60) {
                saniyeInt = 0;
                dakikaInt++;
                dakika.Text = dakikaInt.ToString();

                if(dakikaInt == 60)
                {
                    dakikaInt = 0;
                    saatInt++;
                    saat.Text = saatInt.ToString();
                 
                }
            }



        }
    }
}
