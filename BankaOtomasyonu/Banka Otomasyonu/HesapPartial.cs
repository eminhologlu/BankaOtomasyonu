using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyonu
{
    partial class Hesap
    {
        public void paraCek(decimal miktar, string muid)
        {
            if (miktar < 1)
                MessageBox.Show("Minimum para çekme: 1 TL", "Tekrar deneyin.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    SqlCommand cmdBakiye = new SqlCommand("SELECT BAKIYE FROM musteri WHERE MUID = @muid", baglanti());
                    cmdBakiye.Parameters.AddWithValue("@muid", muid);
                    decimal bakiye = (decimal)cmdBakiye.ExecuteScalar();
                    if (bakiye >= miktar)
                    {
                        string sorgu = "UPDATE musteri SET BAKIYE = BAKIYE - @miktar WHERE MUID = @muid";
                        SqlCommand cmdCek = new SqlCommand(sorgu, baglanti());
                        //Bu kısımda bölü 2 yapmazsak bakiyeden miktarın 2 katı kadar çekiyordu.böyle bir çözüm buldum.
                        cmdCek.Parameters.AddWithValue("@miktar", miktar / 2);
                        cmdCek.Parameters.AddWithValue("@muid", muid);
                        cmdCek.ExecuteNonQuery();
                        int etkilenenSatir = cmdCek.ExecuteNonQuery();
                        string mesaj = String.Format("{0:C} | {1} nolu hesaptan çekildi.", miktar,muid);
                        if (etkilenenSatir > 0)
                        {
                            MessageBox.Show(mesaj, "İşlem Başarılı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            islem.islemEkle("Para Çekme", "", muid, miktar, DateTime.Now);
                        }
                            
                        else
                            MessageBox.Show("Para çekilirken sorun oluştu.", "Hata.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string mesaj2 = String.Format("Bakiyeniz: {0:C}", bakiye);
                        MessageBox.Show(mesaj2, "Yetersiz Bakiye.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
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
