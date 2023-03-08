using System;
using System.Data.SqlClient;
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
    public partial class frmParaTransfer : Form
    {
        public frmParaTransfer()
        {
            InitializeComponent();
            sqlDataSource1.FillAsync();
        }
        MetotSQL metot = new MetotSQL();
        Hesap hesap = new Hesap();
        IslemGecmisi islem = new IslemGecmisi();
        private void ParaTransfer_Load(object sender, EventArgs e)
        {
            cbox();
            DataTable dt = islem.goster();
            gridGecmis.DataSource = dt;
        }
        public void cbox()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM musteri", metot.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboxYatirHesap.Properties.Items.Add(dr["MUID"]);
                cboxCekHesap.Properties.Items.Add(dr["MUID"]);
                cboxTransferGonderenHesap.Properties.Items.Add(dr["MUID"]);
                cboxTransferAliciHesap.Properties.Items.Add(dr["MUID"]);
                cboxSorgulaHesap.Properties.Items.Add(dr["MUID"]);
            }
        }
        private void btnYatir_Click(object sender, EventArgs e)
        {
            if(txtYatirMiktar.Text == "" || cboxYatirHesap.SelectedText == "")
                MessageBox.Show("Lütfen bütün bilgileri doğru giriniz.", "Tekrar deneyin.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                decimal miktar = Decimal.Parse(txtYatirMiktar.Text);
                string muid = cboxYatirHesap.SelectedText;
                hesap.paraYatir(miktar, muid);
            }
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            if(txtCekMiktar.Text == "" || cboxCekHesap.SelectedText == "")
                MessageBox.Show("Lütfen bütün bilgileri doğru giriniz.", "Tekrar deneyin.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                decimal miktar = Decimal.Parse(txtCekMiktar.Text);
                string muid = cboxCekHesap.SelectedText;
                hesap.paraCek(miktar, muid);
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (txtTransferMiktar.Text == "" || cboxTransferAliciHesap.SelectedText == "" || cboxTransferGonderenHesap.SelectedText == "")
                MessageBox.Show("Lütfen bütün bilgileri doğru giriniz.", "Tekrar deneyin.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                decimal miktar = Decimal.Parse(txtTransferMiktar.Text);
                string gonderenMuid = cboxTransferGonderenHesap.SelectedText;
                string aliciMuid = cboxTransferAliciHesap.SelectedText;
                hesap.paraTransferi(miktar, gonderenMuid, aliciMuid);
            }
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            if(cboxSorgulaHesap.SelectedText == "")
                MessageBox.Show("Lütfen bütün bilgileri doğru giriniz.", "Tekrar deneyin.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string muid = cboxSorgulaHesap.SelectedText;
                hesap.bakiyeSorgula(muid);
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataTable dt = islem.goster();
            gridGecmis.DataSource = dt;
        }
    }
}
