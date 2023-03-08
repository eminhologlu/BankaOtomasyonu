using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyonu
{
    class SifremiUnuttum
    {
        public void sifreGonder(int pno,string email)
        {
            MetotSQL met = new MetotSQL();
            string sorgu = "SELECT * FROM personel WHERE pno=@pno";
            SqlCommand cmd = new SqlCommand(sorgu, met.baglanti());
            cmd.Parameters.AddWithValue("@pno", pno);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                SmtpClient smtpserver = new SmtpClient();
                MailMessage mail = new MailMessage();
                string mailadresim = "m.emin165@outlook.com";
                string sifre = "c.ronaldo";
                string smtpsrvr = "smtp-mail.outlook.com";
                string kime = email;
                string konu = "Şifre Hatırlatma";
                string yaz = "Şifreniz: " + dr["psifre"].ToString();
                smtpserver.Credentials = new NetworkCredential(mailadresim, sifre);
                smtpserver.Port = 587;
                smtpserver.Host = smtpsrvr;
                smtpserver.EnableSsl = true;
                mail.From = new MailAddress(mailadresim);
                mail.To.Add(kime);
                mail.Subject = konu;
                mail.Body = yaz;
                smtpserver.Send(mail);

                MessageBox.Show("Şifreniz sistemde kayıtlı olan e-posta adresinize gönderildi.");
                met.baglanti().Close();
            }
            else
            {
                MessageBox.Show("Personel no ve e-posta eşleşmiyor.");
                met.baglanti().Close();
            }
        }
    }
}
