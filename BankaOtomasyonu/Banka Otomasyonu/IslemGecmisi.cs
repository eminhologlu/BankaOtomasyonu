using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyonu
{
    class IslemGecmisi:MetotSQL
    {
        public void islemEkle(string islem,string g_id,string a_id,decimal miktar,DateTime tarih)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into islemgecmisi (ISLEM,GONDEREN_ID,ALICI_ID,MIKTAR,ISLEM_TARIHI) values(@p1,@p2,@p3,@p4,@p5)", baglanti());
                komut.Parameters.AddWithValue("@p1", islem);
                komut.Parameters.AddWithValue("@p2", g_id);
                komut.Parameters.AddWithValue("@p3", a_id);
                komut.Parameters.AddWithValue("@p4", miktar);
                komut.Parameters.AddWithValue("@p5", tarih);
                komut.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti().Close();
            }
        }
        public DataTable goster()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM islemgecmisi",baglanti());
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti().Close();
            }
            return dt;
        }
    }
}
