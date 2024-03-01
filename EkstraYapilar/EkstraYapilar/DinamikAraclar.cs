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
    public partial class DinamikAraclar : Form
    {
        public DinamikAraclar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnKonum = new Point(20, 10);
            btn.Location = btnKonum;
            btn.Size = new Size(100, 50);
            btn.Name = "Button1";
            btn.Text = "Tıkla";
            btn.BackColor = Color.White;
            this.Controls.Add(btn);


        }
    }
}
