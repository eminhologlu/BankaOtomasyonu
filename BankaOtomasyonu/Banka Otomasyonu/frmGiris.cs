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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {  
            if (txtPersonelNo.Text == "" || txtSifre.Text == "")
                MessageBox.Show("Bilgileri doldurunuz.");
            else
            {
                MetotSQL met = new MetotSQL();
                int pno = Int32.Parse(txtPersonelNo.Text);
                string sifre = txtSifre.Text;
                if (met.giris(pno,sifre))
                {
                    this.Hide();
                    frmPanel frm = new frmPanel();
                    frm.Show();
                }
            }   
        }
        frmSifremiUnuttum frm;
        private void linkLblSifremiUnuttum_Click(object sender, EventArgs e)
        {
            
            if (frm == null || frm.IsDisposed)
            {
                frm = new frmSifremiUnuttum();
                frm.Show();
            }
        }
    }
}
