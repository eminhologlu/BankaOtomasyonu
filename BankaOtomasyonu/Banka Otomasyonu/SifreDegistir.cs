using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyonu
{
    class SifreDegistir
    {
        MetotSQL met = new MetotSQL();
        private bool personelVarMi(int pno, string sifre)
        {
            string sorgu = "SELECT * FROM personel WHERE pno=@pno AND psifre=@psifre";
            SqlCommand cmd = new SqlCommand(sorgu, met.baglanti());
            cmd.Parameters.AddWithValue("@pno", pno);
            cmd.Parameters.AddWithValue("@psifre", sifre);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                met.baglanti().Close();
                return true;
            }
            else
            {
                met.baglanti().Close(); return false;
            }
        }
        public void sifreDegis(int pno,string eski,string yeni)
        {
            if (personelVarMi(pno, eski))
            {
                try
                {
                    string sorgu = "UPDATE personel SET psifre = @psifre WHERE pno = @pno";
                    SqlCommand cmd = new SqlCommand(sorgu, met.baglanti());
                    cmd.Parameters.AddWithValue("@psifre", yeni);
                    cmd.Parameters.AddWithValue("@pno", pno);
                    cmd.ExecuteNonQuery();
                    int etkilenenSatir = cmd.ExecuteNonQuery();
                    if (etkilenenSatir > 0)
                    {
                        MessageBox.Show("Şifre değiştirildi.", "İşlem Başarılı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Şifre değiştirilirken sorun oluştu.", "Hata.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Veritabanı Hatası! " + ex.Message);
                }
                finally
                {
                    met.baglanti().Close();
                }
            }
            else
                MessageBox.Show("Personel bulunamadı!", "Hata.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
