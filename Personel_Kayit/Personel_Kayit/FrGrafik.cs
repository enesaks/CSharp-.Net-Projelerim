using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Kayit
{
    public partial class FrGrafik : Form
    {
        public FrGrafik()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Data Source=ENES;Initial Catalog=PersonelVeriTabani;Integrated Security=True;");


        private void FrGrafik_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand komutg1 = new SqlCommand("SELECT PerSehir,Count( * ) FROM Tbl_Personel group by PerSehir", sqlConnection);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }

            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand komutg2 = new SqlCommand("SELECT PerMeslek,AVG( PerMaas ) FROM Tbl_Personel group by PerMeslek", sqlConnection);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["MeslekMaas"].Points.AddXY(dr2[0],s dr2[1]);
            }

            sqlConnection.Close();
        }
    }
}
