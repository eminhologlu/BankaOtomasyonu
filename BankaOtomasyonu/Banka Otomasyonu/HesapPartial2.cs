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
        IslemGecmisi islem = new IslemGecmisi();
        public void paraTransferi(decimal miktar, string muidGonderen, string muidAlici)
        {
            if(miktar<1)
                MessageBox.Show("Minimum para transferi: 1 TL", "Tekrar deneyin.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(muidAlici == muidGonderen)
                MessageBox.Show("İki farklı hesap no girilmeli.", "Tekrar deneyin.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    SqlCommand cmdBakiye = new SqlCommand("SELECT BAKIYE FROM musteri WHERE MUID = @muid", baglanti());
                    cmdBakiye.Parameters.AddWithValue("@muid", muidGonderen);
                    decimal bakiyeGonderen = (decimal)cmdBakiye.ExecuteScalar();

                    if (bakiyeGonderen >= miktar)
                    {
                        string sorguCek = "UPDATE musteri SET BAKIYE = BAKIYE - @miktar WHERE MUID = @muid";
                        SqlCommand cmdCek = new SqlCommand(sorguCek, baglanti());
                        cmdCek.Parameters.AddWithValue("@miktar", miktar / 2);
                        cmdCek.Parameters.AddWithValue("@muid", muidGonderen);
                        cmdCek.ExecuteNonQuery();

                        string sorguYatir = "UPDATE musteri SET BAKIYE = BAKIYE + @miktar WHERE MUID = @muid";
                        SqlCommand cmdYatir = new SqlCommand(sorguYatir, baglanti());
                        cmdYatir.Parameters.AddWithValue("@miktar", miktar / 2);
                        cmdYatir.Parameters.AddWithValue("@muid", muidAlici);
                        cmdYatir.ExecuteNonQuery();

                        int etkilenenSatir = cmdYatir.ExecuteNonQuery() + cmdCek.ExecuteNonQuery();
                        string mesaj = String.Format("{0:C} | {1} nolu hesaptan {2} nolu hesaba transfer edildi.", miktar, muidGonderen,muidAlici);
                        if (etkilenenSatir > 1)
                        {
                            MessageBox.Show(mesaj, "İşlem Başarılı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            islem.islemEkle("Para Transferi", muidGonderen, muidAlici, miktar, DateTime.Now);
                        }   
                        else
                            MessageBox.Show("Para çekilirken sorun oluştu.", "Hata.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        string mesaj2 = String.Format("Bakiyeniz: {0:C}", bakiyeGonderen);
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
