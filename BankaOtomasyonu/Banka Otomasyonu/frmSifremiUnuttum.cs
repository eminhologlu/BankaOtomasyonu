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
    public partial class frmSifremiUnuttum : Form
    {
        public frmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            int pno = Convert.ToInt32(txtPno.Text);
            string email = txtEposta.Text;
            if (email != "" && txtPno.Text != "")
            {
                SifremiUnuttum sfr = new SifremiUnuttum();
                sfr.sifreGonder(pno, email);
            }
            else
                MessageBox.Show("Bilgileri doldurunuz.");
            
        }
    }
}
