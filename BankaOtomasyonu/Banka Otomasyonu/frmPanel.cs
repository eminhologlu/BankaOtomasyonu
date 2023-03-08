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
    public partial class frmPanel : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmPanel()
        {
            InitializeComponent();
        }
        private void frmPanel_Load(object sender, EventArgs e)
        {
            timer1.Start();  
        }
        
        frmMusteri frm1;
        frmPiyasa frm2;
        frmParaTransfer frm3;
        frmIstatistikler frm4;
        frmAyarlar frm5;
        private void btnMusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm1==null || frm1.IsDisposed)
            {
                frm1 = new frmMusteri();
                frm1.MdiParent = this;
                frm1.Show();
            }   
        }
        private void btnDoviz_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {               
                frm2 = new frmPiyasa();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }
        private void btnHesapMak_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.Exe");
        }
        private void btnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGiris frm = new frmGiris();
            frm.Show();
            this.Hide();
        }
        private void btnParaTransfer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new frmParaTransfer();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeTarih.Time = DateTime.Now;
        }

        private void btnIstatistikler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new frmIstatistikler();
                frm4.MdiParent = this;
                frm4.Show();
            }
        }

        private void btnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
            {
                frm5 = new frmAyarlar();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }
    }
}
