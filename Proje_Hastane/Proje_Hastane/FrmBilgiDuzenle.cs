using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TCno;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTCKayit.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTc = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1" , mskTCKayit.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                MskTelefon.Text = dr[4].ToString();
                txtSifreKayit.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnBilgiDüzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd = @p1,HastaSoyad = @p2, HastaTelefon = @p3, HastaSifre = @p4", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtAd.Text);
            komut2.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", MskTelefon.Text);
            komut2.Parameters.AddWithValue("@p4", txtSifreKayit.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
        }
    }
}
