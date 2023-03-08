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
        public void bakiyeSorgula(string muid)
        {
            SqlCommand cmdBakiye = new SqlCommand("SELECT BAKIYE FROM musteri WHERE MUID = @muid", baglanti());
            cmdBakiye.Parameters.AddWithValue("@muid", muid);
            decimal bakiye = (decimal)cmdBakiye.ExecuteScalar();
            string mesaj = String.Format("{0} nolu hesabın bakiyesi: {1:C}", muid, bakiye);
            MessageBox.Show(mesaj, "Bakiye Sorgusu.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
