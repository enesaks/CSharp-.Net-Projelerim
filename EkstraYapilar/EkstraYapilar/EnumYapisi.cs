using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkstraYapilar
{
    public partial class EnumYapisi : Form
    {
        public EnumYapisi()
        {
            InitializeComponent();
        }
        enum Sehirler {x, Adana, Adıyaman, Afyon, Ağrı ,Amasya, Ankara, Antalya, Artvin, Aydın }
        private void button1_Click(object sender, EventArgs e)
        {
            int plaka = Convert.ToInt16(textBox1.Text);
            Sehirler s;
            s = (Sehirler)plaka;
            label1.Text = s.ToString();
        }
    }
}
