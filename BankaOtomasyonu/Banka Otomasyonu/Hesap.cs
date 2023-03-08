using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyonu
{
    partial class Hesap:MetotSQL
    {
        public void ilkBakiye(string muid)
        {
            string sorgu = "UPDATE musteri SET BAKIYE = BAKIYE + @miktar WHERE MUID = @muid";
            SqlCommand cmdYatir = new SqlCommand(sorgu, baglanti());
            cmdYatir.Parameters.AddWithValue("@miktar", 0);
            cmdYatir.Parameters.AddWithValue("@muid", muid);
            cmdYatir.ExecuteNonQuery();
        }
        public void paraYatir(decimal miktar, string muid)
        {
            if (miktar < 1)
                MessageBox.Show("Minimum para yatırma: 1 TL", "Tekrar deneyin.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    string sorgu = "UPDATE musteri SET BAKIYE = BAKIYE + @miktar WHERE MUID = @muid";
                    SqlCommand cmdYatir = new SqlCommand(sorgu, baglanti());

                    //Bu kısımda bölü 2 yapmazsak bakiyeye miktarın 2 katı kadar ekleniyordu.böyle bir çözüm buldum.
                    cmdYatir.Parameters.AddWithValue("@miktar", miktar / 2);
                    cmdYatir.Parameters.AddWithValue("@muid", muid);
                    cmdYatir.ExecuteNonQuery();
                    int etkilenenSatir = cmdYatir.ExecuteNonQuery();
                    string mesaj = String.Format("{0:C} | {1} nolu hesaba yatırıldı.", miktar, muid);
                    if (etkilenenSatir > 0)
                    {
                        MessageBox.Show(mesaj, "İşlem Başarılı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        islem.islemEkle("Para Yatırma", "", muid, miktar, DateTime.Now);
                    }
                        
                    else
                        MessageBox.Show("Para yatırılırken sorun oluştu.", "Hata.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Veritabanı Hatası! " + ex.Message);
                }
                finally
                {
                    baglanti().Close();
                }
            }
        }
    }
}
