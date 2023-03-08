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
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            int pno = Convert.ToInt32(txtPersonelNo.Text);
            string eski = txtEskiSifre.Text;
            string yeni = txtYeniSifre.Text;
            string yenitekrar = txtYeniSifreTekrar.Text;
            SifreDegistir sif = new SifreDegistir();
            if (yeni == "" || yenitekrar == "")
                MessageBox.Show("Bilgileri doldurunuz.");
            else if (yeni != yenitekrar)
                MessageBox.Show("Yeni şifre ve tekrarı eşleşmiyor.");
            else
                sif.sifreDegis(pno, eski, yeni);
        }
    }
}
