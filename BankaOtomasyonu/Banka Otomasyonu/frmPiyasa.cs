using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoinMarketCap;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Banka_Otomasyonu
{
    public partial class frmPiyasa : Form
    {
        public frmPiyasa()
        {
            InitializeComponent();
        }
        private void frmPiyasa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        KriptoCek kripto = new KriptoCek();
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 180000;
            dovizGoster();
            kriptoGoster();
        }
        public void kriptoGoster()
        {
            lboxKripto.Items[0] = "$" + kripto.getBitcoinInUSD().ToString();
            lboxKripto.Items[1] = "$" + kripto.getEthInUSD().ToString();
            lboxKripto.Items[2] = "$" + kripto.getLtcInUSD().ToString();
            lboxKripto.Items[3] = "$" + kripto.getXrpInUSD().ToString();
            lboxKripto.Items[4] = "$" + kripto.getMaticInUSD().ToString();
            lboxKripto.Items[5] = "$" + kripto.getAdaInUSD().ToString();
            lboxKripto.Items[6] = "$" + kripto.getLinkInUSD().ToString();
            lboxKripto.Items[7] = "$" + kripto.getChzInUSD().ToString();
            lboxKripto.Items[8] = "$" + kripto.getAvaxInUSD().ToString();
            lboxKripto.Items[9] = "$" + kripto.getSolInUSD().ToString();
            lboxKripto.Items[10] = "$" + kripto.getDotInUSD().ToString();
            lboxKripto.Items[11] = "$" + kripto.getNearInUSD().ToString();
            lboxKripto.Items[12] = "$" + kripto.getEnjInUSD().ToString();
            lboxKripto.Items[13] = "$" + kripto.getAlgoInUSD().ToString();
        }
        DovizCek doviz = new DovizCek();
        string[] parabirimleri = { "USD", "EUR", "GBP", "RUB", "CHF", "CAD", "CNY", "QAR", "AZN", "KRW", "SEK", "KWD", "BGN", "RON", "PKR", "SAR", "JPY","TRY" };
        public void dovizGoster()
        {
            for (int i = 0; i < 17; i++)
            {
                lboxAFiyat.Items[i] = doviz.GetRate(parabirimleri[i].ToString());
                lboxSFiyat.Items[i] = doviz.GetSRate(parabirimleri[i].ToString());
            }
        }
        bool varMi(string neyden,string neye)
        {
            if (parabirimleri.Contains(neyden) == false || (parabirimleri.Contains(neye)) == false)
                return true;
            else
                return false;
        }
        private void btnDonustur_Click(object sender, EventArgs e)
        {
            if (cboxNeyden.SelectedText == cboxNeye.SelectedText || varMi(cboxNeyden.SelectedText,cboxNeye.SelectedText))
                MessageBox.Show("İki farklı geçerli parabirimi girmelisiniz.");
            else if(txtTutar.Text=="")
                MessageBox.Show("Tutar kısmı boş kalamaz.");
            else
            {
                if (cboxNeyden.SelectedIndex != 0 && cboxNeye.SelectedIndex != 0)
                {
                    decimal oran = doviz.GetSRate(cboxNeyden.SelectedText) / doviz.GetSRate(cboxNeye.SelectedText);
                    txtSonuc.Text = (Convert.ToDecimal(txtTutar.Text) * oran).ToString();
                }
                else if (cboxNeyden.SelectedIndex == 0) 
                    txtSonuc.Text = (Convert.ToDecimal(txtTutar.Text) / doviz.GetSRate(cboxNeye.SelectedText)).ToString();
                else
                    txtSonuc.Text = (Convert.ToDecimal(txtTutar.Text) * doviz.GetSRate(cboxNeyden.SelectedText)).ToString();
            }    
        }
    }
}
