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
    public partial class FormlarArasiVeriTasisma1 : Form
    {
        public FormlarArasiVeriTasisma1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormlarArasiVeriTasisma2 favt = new FormlarArasiVeriTasisma2();
            favt.mesaj = textBox1.Text;
            favt.Show();

        }
    }
}
