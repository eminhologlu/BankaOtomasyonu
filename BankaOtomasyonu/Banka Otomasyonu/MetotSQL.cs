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
    class MetotSQL
    {
        public SqlConnection baglanti()
        {
            string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Banka.mdf;Integrated Security=True";
            SqlConnection baglan = new SqlConnection(conn);
            baglan.Open();
            return baglan;
        }
        public bool giris(int pno,string sifre)
        {
            string sorgu = "SELECT * FROM personel WHERE pno=@pno AND psifre=@psifre";
            SqlCommand cmd = new SqlCommand(sorgu, baglanti());
            cmd.Parameters.AddWithValue("@pno", pno);
            cmd.Parameters.AddWithValue("@psifre", sifre);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                baglanti().Close();
                return true;
            }
            else
            {
                MessageBox.Show("Personel numarası ve şifrenizi kontrol ediniz.");
                baglanti().Close();
                return false;
            }
            
        }
    }
}
