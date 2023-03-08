namespace Banka_Otomasyonu
{
    partial class frmPiyasa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPiyasa));
            this.gboxKurlar = new System.Windows.Forms.GroupBox();
            this.lboxSFiyat = new System.Windows.Forms.ListBox();
            this.lboxAFiyat = new System.Windows.Forms.ListBox();
            this.lboxCins = new System.Windows.Forms.ListBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gboxDonustur = new System.Windows.Forms.GroupBox();
            this.cboxNeye = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtSonuc = new DevExpress.XtraEditors.TextEdit();
            this.btnDonustur = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.cboxNeyden = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lboxKripto = new System.Windows.Forms.ListBox();
            this.lboxKriptoCins = new System.Windows.Forms.ListBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.gboxKurlar.SuspendLayout();
            this.gboxDonustur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxNeye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSonuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxNeyden.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxKurlar
            // 
            this.gboxKurlar.BackColor = System.Drawing.Color.Teal;
            this.gboxKurlar.Controls.Add(this.lboxSFiyat);
            this.gboxKurlar.Controls.Add(this.lboxAFiyat);
            this.gboxKurlar.Controls.Add(this.lboxCins);
            this.gboxKurlar.Controls.Add(this.labelControl3);
            this.gboxKurlar.Controls.Add(this.labelControl2);
            this.gboxKurlar.Controls.Add(this.labelControl1);
            this.gboxKurlar.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboxKurlar.ForeColor = System.Drawing.Color.Cornsilk;
            this.gboxKurlar.Location = new System.Drawing.Point(12, 12);
            this.gboxKurlar.Name = "gboxKurlar";
            this.gboxKurlar.Size = new System.Drawing.Size(644, 723);
            this.gboxKurlar.TabIndex = 0;
            this.gboxKurlar.TabStop = false;
            this.gboxKurlar.Text = "Döviz Kurları";
            // 
            // lboxSFiyat
            // 
            this.lboxSFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lboxSFiyat.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lboxSFiyat.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lboxSFiyat.FormattingEnabled = true;
            this.lboxSFiyat.ItemHeight = 35;
            this.lboxSFiyat.Items.AddRange(new object[] {
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " "});
            this.lboxSFiyat.Location = new System.Drawing.Point(498, 107);
            this.lboxSFiyat.Name = "lboxSFiyat";
            this.lboxSFiyat.Size = new System.Drawing.Size(133, 599);
            this.lboxSFiyat.TabIndex = 9;
            // 
            // lboxAFiyat
            // 
            this.lboxAFiyat.BackColor = System.Drawing.Color.Aquamarine;
            this.lboxAFiyat.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lboxAFiyat.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lboxAFiyat.FormattingEnabled = true;
            this.lboxAFiyat.ItemHeight = 35;
            this.lboxAFiyat.Items.AddRange(new object[] {
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " "});
            this.lboxAFiyat.Location = new System.Drawing.Point(359, 107);
            this.lboxAFiyat.Name = "lboxAFiyat";
            this.lboxAFiyat.Size = new System.Drawing.Size(133, 599);
            this.lboxAFiyat.TabIndex = 8;
            // 
            // lboxCins
            // 
            this.lboxCins.BackColor = System.Drawing.Color.FloralWhite;
            this.lboxCins.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lboxCins.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lboxCins.FormattingEnabled = true;
            this.lboxCins.ItemHeight = 35;
            this.lboxCins.Items.AddRange(new object[] {
            "Amerikan Doları (USD)",
            "Euro (EUR)",
            "İngiliz Sterlini (GBP)",
            "Rus Rublesi (RUB)",
            "İsviçre Frangı (CHF)",
            "Kanada Doları (CAD)",
            "Çin Yuanı (CNY)",
            "Katar Riyali (QAR)",
            "Azerbaycan Manatı (AZN)",
            "Güney Kore Wonu (KRW)",
            "İsveç Kronu (SEK)",
            "Kuveyt Dinarı (KWD)",
            "Bulgar Levası (BGN)",
            "Rumen Leyi (RON)",
            "Pakistan Rupisi (PKR)",
            "Arabistan Riyali (SAR)",
            "Japon Yeni (JPY) x100"});
            this.lboxCins.Location = new System.Drawing.Point(16, 107);
            this.lboxCins.Name = "lboxCins";
            this.lboxCins.Size = new System.Drawing.Size(337, 599);
            this.lboxCins.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(498, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(128, 28);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Döviz Satış";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(359, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(112, 28);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Döviz Alış";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 73);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 28);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Döviz Cinsi";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gboxDonustur
            // 
            this.gboxDonustur.BackColor = System.Drawing.Color.Teal;
            this.gboxDonustur.Controls.Add(this.cboxNeye);
            this.gboxDonustur.Controls.Add(this.txtSonuc);
            this.gboxDonustur.Controls.Add(this.btnDonustur);
            this.gboxDonustur.Controls.Add(this.labelControl5);
            this.gboxDonustur.Controls.Add(this.labelControl4);
            this.gboxDonustur.Controls.Add(this.txtTutar);
            this.gboxDonustur.Controls.Add(this.cboxNeyden);
            this.gboxDonustur.Controls.Add(this.labelControl6);
            this.gboxDonustur.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboxDonustur.ForeColor = System.Drawing.Color.Cornsilk;
            this.gboxDonustur.Location = new System.Drawing.Point(662, 12);
            this.gboxDonustur.Name = "gboxDonustur";
            this.gboxDonustur.Size = new System.Drawing.Size(263, 723);
            this.gboxDonustur.TabIndex = 1;
            this.gboxDonustur.TabStop = false;
            this.gboxDonustur.Text = "Döviz Dönüştür";
            // 
            // cboxNeye
            // 
            this.cboxNeye.Location = new System.Drawing.Point(41, 307);
            this.cboxNeye.Name = "cboxNeye";
            this.cboxNeye.Properties.Appearance.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cboxNeye.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxNeye.Properties.Appearance.Options.UseBackColor = true;
            this.cboxNeye.Properties.Appearance.Options.UseFont = true;
            this.cboxNeye.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxNeye.Properties.Items.AddRange(new object[] {
            "TRY",
            "USD",
            "EUR",
            "GBP",
            "RUB",
            "CHF",
            "CAD",
            "CNY",
            "QAR",
            "AZN",
            "KRW",
            "SEK",
            "KWD",
            "BGN",
            "RON",
            "PKR",
            "SAR",
            "JPY"});
            this.cboxNeye.Size = new System.Drawing.Size(181, 46);
            this.cboxNeye.TabIndex = 12;
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(41, 465);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSonuc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonuc.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtSonuc.Properties.Appearance.Options.UseBackColor = true;
            this.txtSonuc.Properties.Appearance.Options.UseFont = true;
            this.txtSonuc.Properties.Appearance.Options.UseForeColor = true;
            this.txtSonuc.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSonuc.Properties.MaskSettings.Set("mask", "n");
            this.txtSonuc.Properties.MaxLength = 9;
            this.txtSonuc.Properties.ReadOnly = true;
            this.txtSonuc.Properties.UseMaskAsDisplayFormat = true;
            this.txtSonuc.Size = new System.Drawing.Size(181, 46);
            this.txtSonuc.TabIndex = 10;
            // 
            // btnDonustur
            // 
            this.btnDonustur.Appearance.BackColor = System.Drawing.Color.White;
            this.btnDonustur.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnDonustur.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDonustur.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDonustur.Appearance.Options.UseBackColor = true;
            this.btnDonustur.Appearance.Options.UseFont = true;
            this.btnDonustur.Appearance.Options.UseForeColor = true;
            this.btnDonustur.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDonustur.ImageOptions.SvgImage")));
            this.btnDonustur.Location = new System.Drawing.Point(41, 381);
            this.btnDonustur.Name = "btnDonustur";
            this.btnDonustur.Size = new System.Drawing.Size(181, 46);
            this.btnDonustur.TabIndex = 9;
            this.btnDonustur.Text = "Dönüştür";
            this.btnDonustur.Click += new System.EventHandler(this.btnDonustur_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(41, 273);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 28);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Neye";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(41, 73);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 28);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Tutar";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(41, 107);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtTutar.Properties.Appearance.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Properties.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtTutar.Properties.Appearance.Options.UseBackColor = true;
            this.txtTutar.Properties.Appearance.Options.UseFont = true;
            this.txtTutar.Properties.Appearance.Options.UseForeColor = true;
            this.txtTutar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTutar.Properties.MaskSettings.Set("mask", "n");
            this.txtTutar.Properties.MaxLength = 9;
            this.txtTutar.Properties.UseMaskAsDisplayFormat = true;
            this.txtTutar.Size = new System.Drawing.Size(181, 46);
            this.txtTutar.TabIndex = 5;
            // 
            // cboxNeyden
            // 
            this.cboxNeyden.Location = new System.Drawing.Point(41, 207);
            this.cboxNeyden.Name = "cboxNeyden";
            this.cboxNeyden.Properties.Appearance.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cboxNeyden.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxNeyden.Properties.Appearance.Options.UseBackColor = true;
            this.cboxNeyden.Properties.Appearance.Options.UseFont = true;
            this.cboxNeyden.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxNeyden.Properties.Items.AddRange(new object[] {
            "TRY",
            "USD",
            "EUR",
            "GBP",
            "RUB",
            "CHF",
            "CAD",
            "CNY",
            "QAR",
            "AZN",
            "KRW",
            "SEK",
            "KWD",
            "BGN",
            "RON",
            "PKR",
            "SAR",
            "JPY"});
            this.cboxNeyden.Size = new System.Drawing.Size(181, 46);
            this.cboxNeyden.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(41, 173);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(88, 28);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Neyden";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.lboxKripto);
            this.groupBox1.Controls.Add(this.lboxKriptoCins);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Location = new System.Drawing.Point(931, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 723);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kripto Paralar";
            // 
            // lboxKripto
            // 
            this.lboxKripto.BackColor = System.Drawing.Color.Aquamarine;
            this.lboxKripto.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lboxKripto.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lboxKripto.FormattingEnabled = true;
            this.lboxKripto.ItemHeight = 35;
            this.lboxKripto.Items.AddRange(new object[] {
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " "});
            this.lboxKripto.Location = new System.Drawing.Point(303, 107);
            this.lboxKripto.Name = "lboxKripto";
            this.lboxKripto.Size = new System.Drawing.Size(133, 599);
            this.lboxKripto.TabIndex = 8;
            // 
            // lboxKriptoCins
            // 
            this.lboxKriptoCins.BackColor = System.Drawing.Color.FloralWhite;
            this.lboxKriptoCins.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lboxKriptoCins.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lboxKriptoCins.FormattingEnabled = true;
            this.lboxKriptoCins.ItemHeight = 35;
            this.lboxKriptoCins.Items.AddRange(new object[] {
            "Bitcoin (BTC)",
            "Ethereum (ETH)",
            "Litecoin (LTC)",
            "Ripple (XRP)",
            "Polygon (MATIC)",
            "Cardano (ADA)",
            "Chainlink (LINK)",
            "Chiliz (CHZ)",
            "Avalanche (AVAX)",
            "Solana (SOL)",
            "Polkadot (DOT)",
            "Near Protocol (NEAR)",
            "Enjin (ENJ)",
            "Algorand (ALGO)"});
            this.lboxKriptoCins.Location = new System.Drawing.Point(16, 107);
            this.lboxKriptoCins.Name = "lboxKriptoCins";
            this.lboxKriptoCins.Size = new System.Drawing.Size(278, 599);
            this.lboxKriptoCins.TabIndex = 6;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(303, 73);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(57, 28);
            this.labelControl8.TabIndex = 3;
            this.labelControl8.Text = "Fiyat";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(16, 73);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(134, 28);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "Kripto Cinsi";
            // 
            // frmPiyasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::Banka_Otomasyonu.Properties.Resources.bgpiyasa;
            this.ClientSize = new System.Drawing.Size(1942, 839);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxDonustur);
            this.Controls.Add(this.gboxKurlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPiyasa";
            this.Text = "Piyasalar";
            this.Load += new System.EventHandler(this.frmPiyasa_Load);
            this.gboxKurlar.ResumeLayout(false);
            this.gboxKurlar.PerformLayout();
            this.gboxDonustur.ResumeLayout(false);
            this.gboxDonustur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxNeye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSonuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxNeyden.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxKurlar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lboxCins;
        private System.Windows.Forms.ListBox lboxAFiyat;
        private System.Windows.Forms.ListBox lboxSFiyat;
        private System.Windows.Forms.GroupBox gboxDonustur;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cboxNeyden;
        private DevExpress.XtraEditors.TextEdit txtSonuc;
        private DevExpress.XtraEditors.SimpleButton btnDonustur;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.ComboBoxEdit cboxNeye;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lboxKripto;
        private System.Windows.Forms.ListBox lboxKriptoCins;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}