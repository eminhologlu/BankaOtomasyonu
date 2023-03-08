using DevExpress.XtraGrid.Views.Grid;
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

namespace Banka_Otomasyonu
{
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
            sqlDataSource1.FillAsync();
        }
        MetotSQL metot = new MetotSQL();
        public void musListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from musteri", metot.baglanti());
            da.Fill(dt);
            gridMusteri.DataSource = dt;
        }
        public bool bosMu()
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTCNo.Text == "" || txtTELNo.Text == "" ||
               cboxSehir.Text == "" || cboxIlce.Text == "" || richTxtAdres.Text == "" || dateDogumTarihi.Text == "")
            {
                return false;
            }
            else
                return true;
        }

        public void temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtId.Text = "";
            txtTCNo.Text = "";
            txtTELNo.Text = "";
            txtEposta.Text = "";
            cboxSehir.Text = "";
            cboxIlce.Text = "";
            richTxtAdres.Text = "";
            dateDogumTarihi.Text = "";
        }
        public void ilEkle()
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM iller", metot.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cboxSehir.Properties.Items.Add(dr[1]);
            }
            metot.baglanti().Close();
        }
        private void frmMusteri_Load_1(object sender, EventArgs e)
        {
            musListele();
            ilEkle();
        }
        private void cboxSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxIlce.Properties.Items.Clear();
            cboxIlce.Text = "";

            SqlCommand komut = new SqlCommand("SELECT * from ilceler WHERE sehir=@p1", metot.baglanti());
            komut.Parameters.AddWithValue("@p1", cboxSehir.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cboxIlce.Properties.Items.Add(dr[1]);
            }
            metot.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (bosMu())
            {
                SqlCommand komut = new SqlCommand("insert into musteri (MUAD,MUSOYAD,MUTC,MUDOGUM,MUTEL,MUEPOSTA,MUIL,MUILCE,MUADRES,BAKIYE) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", metot.baglanti());
                komut.Parameters.AddWithValue("@p1", txtAd.Text.Trim().ToUpper());
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text.Trim().ToUpper());
                komut.Parameters.AddWithValue("@p3", txtTCNo.Text);
                komut.Parameters.AddWithValue("@p4", dateDogumTarihi.DateTime);
                komut.Parameters.AddWithValue("@p5", txtTELNo.Text);
                komut.Parameters.AddWithValue("@p6", txtEposta.Text.Trim().ToUpper());
                komut.Parameters.AddWithValue("@p7", cboxSehir.Text);
                komut.Parameters.AddWithValue("@p8", cboxIlce.Text);
                komut.Parameters.AddWithValue("@p9", richTxtAdres.Text.Trim().ToUpper());
                komut.Parameters.AddWithValue("@p10", 0);
                komut.ExecuteNonQuery();
                metot.baglanti().Close();
                MessageBox.Show("Müşteri eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                musListele();
            }
            else
                MessageBox.Show("Lütfen bilgileri doldurunuz.");
            
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (bosMu())
            {
                SqlCommand komut = new SqlCommand("Update musteri set MUAD=@p1,MUSOYAD=@p2,MUTC=@p3,MUDOGUM=@p4,MUTEL=@p5,MUEPOSTA=@p6,MUIL=@p7,MUILCE=@p8,MUADRES=@p9 where MUID=@p10", metot.baglanti());
                komut.Parameters.AddWithValue("@p1", txtAd.Text.Trim().ToUpper());
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text.Trim().ToUpper());
                komut.Parameters.AddWithValue("@p3", txtTCNo.Text);
                komut.Parameters.AddWithValue("@p4", dateDogumTarihi.DateTime);
                komut.Parameters.AddWithValue("@p5", txtTELNo.Text);
                komut.Parameters.AddWithValue("@p6", txtEposta.Text.Trim().ToUpper());
                komut.Parameters.AddWithValue("@p7", cboxSehir.Text);
                komut.Parameters.AddWithValue("@p8", cboxIlce.Text);
                komut.Parameters.AddWithValue("@p9", richTxtAdres.Text.Trim().ToUpper());
                komut.Parameters.AddWithValue("@p10", txtId.Text);
                komut.ExecuteNonQuery();
                metot.baglanti().Close();
                MessageBox.Show("Müşteri bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                musListele();
            }
            else
                MessageBox.Show("Lütfen bilgileri doldurunuz.");

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Müşteri Silme", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from musteri where MUID=@p1", metot.baglanti());
                komut.Parameters.AddWithValue("@p1", txtId.Text);
                komut.ExecuteNonQuery();
                metot.baglanti().Close();
                MessageBox.Show("Müşteri silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                musListele();
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["MUID"].ToString();
                txtAd.Text = dr["MUAD"].ToString();
                txtSoyad.Text = dr["MUSOYAD"].ToString();
                txtTCNo.Text = dr["MUTC"].ToString();
                txtTELNo.Text = dr["MUTEL"].ToString();
                txtEposta.Text = dr["MUEPOSTA"].ToString();
                richTxtAdres.Text = dr["MUADRES"].ToString();
                cboxSehir.Text = dr["MUIL"].ToString();
                cboxIlce.Text = dr["MUILCE"].ToString();
                dateDogumTarihi.Text = dr["MUDOGUM"].ToString();
            }
        }
    }
}
