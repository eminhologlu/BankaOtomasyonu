using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyonu
{
    class IstatistikCek:MetotSQL
    {
        public string istatistik(string sorgu)
        {
            SqlCommand cmd = new SqlCommand(sorgu, baglanti());
            object sonuc = cmd.ExecuteScalar();
            return sonuc.ToString();
        }
    }
}
