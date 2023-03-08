using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyonu
{
    public partial class frmIstatistikler : Form
    {
        public frmIstatistikler()
        {
            InitializeComponent();
        }

        private void frmIstatistikler_Load(object sender, EventArgs e)
        {
            guncelle();
        }
        IstatistikCek ist = new IstatistikCek();
        public void guncelle()
        {
            txtMusSayisi.Text = ist.istatistik("SELECT COUNT(*) FROM musteri");
            txtMusBakiyesi.Text = ist.istatistik("SELECT SUM(BAKIYE) FROM musteri");
            txtEnYuksekIsim.Text = ist.istatistik("SELECT MUAD FROM musteri WHERE BAKIYE=(select MAX(BAKIYE) from musteri)") + " " + ist.istatistik("SELECT MUSOYAD FROM musteri WHERE BAKIYE=(select MAX(BAKIYE) from musteri)");
            txtEnYuksekBakiye.Text = ist.istatistik("SELECT MAX(BAKIYE) FROM musteri");
            txtEnDusukIsim.Text = ist.istatistik("SELECT MUAD FROM musteri WHERE BAKIYE=(select MIN(BAKIYE) from musteri)") + " " + ist.istatistik("SELECT MUSOYAD FROM musteri WHERE BAKIYE=(select MIN(BAKIYE) from musteri)");
            txtEnDusukBakiye.Text = ist.istatistik("SELECT MIN(BAKIYE) FROM musteri");
            txtYatirilan.Text = ist.istatistik("select SUM(MIKTAR) from islemgecmisi where convert(date,ISLEM_TARIHI,103) = convert(date, getdate(), 103) AND ISLEM='Para Yatırma'");
            txtCekilen.Text = ist.istatistik("select SUM(MIKTAR) from islemgecmisi where convert(date,ISLEM_TARIHI,103) = convert(date, getdate(), 103) AND ISLEM='Para Çekme'");
            txtTransfer.Text = ist.istatistik("select SUM(MIKTAR) from islemgecmisi where convert(date,ISLEM_TARIHI,103) = convert(date, getdate(), 103) AND ISLEM='Para Transferi'");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            guncelle();
        }
    }
}
