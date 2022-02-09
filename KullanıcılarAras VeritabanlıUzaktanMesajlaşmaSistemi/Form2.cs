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

namespace KullanıcılarAras_VeritabanlıUzaktanMesajlaşmaSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FG36IKJ\SQLEXPRESS;Initial Catalog=Mesajlaşma Veri Tabanı;Integrated Security=True");
        void gelenkutusu()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tblmesajlar WHERE alıcı=" + numara, baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridViewGelen.DataSource = dt1
;        }
        void gidenkutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tblmesajlar WHERE gonderen =" + numara, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dtaGidenktsu.DataSource = dt2
;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;
            gelenkutusu();
            gidenkutusu();

            //AD-SOYAD Çekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Ad,Soyad from TBLKISILER where numara=" + numara, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            baglanti.Close();
; ;        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMESAJLAR(gonderen,alıcı,baslık,ıcerık) values(@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            komut.Parameters.AddWithValue("@p2", maskedAlıcı.Text);
            komut.Parameters.AddWithValue("@p3", txtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", richMesaj.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesajınız iletildi");
            gidenkutusu();
        }
    }
}
