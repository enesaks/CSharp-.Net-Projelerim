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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Data Source=ENES;Initial Catalog=PersonelVeriTabani;Integrated Security=True;");
        public int perDurum = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", sqlConnection);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboSehir.Text);
            komut.Parameters.AddWithValue("@p4", Convert.ToInt16(txtMaas.Text));
            komut.Parameters.AddWithValue("@p5", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", perDurum);

            komut.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Personel Eklendi");
        }

        private void radioEvli_CheckedChanged(object sender, EventArgs e)
        {
            perDurum = 1;
        }

        private void radioBekar_CheckedChanged(object sender, EventArgs e)
        {
            perDurum = 0;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            comboSehir.Text = "";
            txtMaas.Text = "";
            txtMeslek.Text = "";
            radioEvli.Checked = false;
            radioBekar.Checked = false;
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            String durum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            Console.WriteLine("durumm : " + durum);
            if (durum.Equals("True"))
            {
                radioEvli.Checked= true;
            }
            else
            {
                radioBekar.Checked= true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand komutsil = new SqlCommand("DELETE FROM Tbl_Personel WHERE PerId=@p1", sqlConnection);
            komutsil.Parameters.AddWithValue("@p1", txtId.Text);
            komutsil.ExecuteNonQuery(); 
            sqlConnection.Close();
            MessageBox.Show("Personel Silindi");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand kommutGuncelle = new SqlCommand("UPDATE Tbl_Personel SET PerAd=@p1,PerSoyad=@p2,PerSehir=@p3,PerMaas=@p4,PerDurum=@p5,PerMeslek=@p6 WHERE PerId=@p7", sqlConnection);
            kommutGuncelle.Parameters.AddWithValue("@p1", txtAd.Text);
            kommutGuncelle.Parameters.AddWithValue("@p2", txtSoyad.Text);
            kommutGuncelle.Parameters.AddWithValue("@p3", comboSehir.Text);
            kommutGuncelle.Parameters.AddWithValue("@p4", txtMaas.Text);
            kommutGuncelle.Parameters.AddWithValue("@p5", perDurum);
            kommutGuncelle.Parameters.AddWithValue("@p6", txtMeslek.Text);
            kommutGuncelle.Parameters.AddWithValue("@p7", txtId.Text);
            kommutGuncelle.ExecuteNonQuery();

            sqlConnection.Close ();

            MessageBox.Show("Güncellendi");
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik fr = new FrmIstatistik();
            fr.Show();

        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            FrGrafik fr = new FrGrafik();
            fr.Show();
        }
    }
}
