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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=ENES;Initial Catalog=PersonelVeriTabani;Integrated Security=True;");


        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand komut1 = new SqlCommand("SELECT COUNT(*) FROM Tbl_Personel", sqlConnection);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                PerSay.Text = dr1[0].ToString();
            }

            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand komut2 = new SqlCommand("SELECT COUNT(*) FROM Tbl_Personel WHERE PerDurum=1", sqlConnection);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                EvliSay.Text = dr2[0].ToString();
            }
            BekarSay.Text = (Convert.ToInt16(PerSay.Text) - Convert.ToInt16(EvliSay.Text)).ToString();

            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand komut3 = new SqlCommand("SELECT COUNT(distinct(PerSehir)) FROM Tbl_Personel", sqlConnection);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                SehirSay.Text = dr3[0].ToString();
            }

            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand komut4 = new SqlCommand("SELECT PerMaas FROM Tbl_Personel", sqlConnection);
            SqlDataReader dr4 = komut4.ExecuteReader();
            int i = 0, sum = 0;

            while (dr4.Read())
            {
                sum = sum + Convert.ToInt16(dr4[i]);
            }
            TopMaas.Text = sum.ToString();
            OrtMaas.Text = (sum / Convert.ToInt16(PerSay.Text)).ToString();

            sqlConnection.Close();

        }
    }
}
