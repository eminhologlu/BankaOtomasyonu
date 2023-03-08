namespace Banka_Otomasyonu
{
    partial class frmParaTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParaTransfer));
            DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters msSqlConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.AllColumns allColumns1 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnYatir = new DevExpress.XtraEditors.SimpleButton();
            this.txtYatirMiktar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboxYatirHesap = new DevExpress.XtraEditors.ComboBoxEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnCek = new DevExpress.XtraEditors.SimpleButton();
            this.txtCekMiktar = new DevExpress.XtraEditors.TextEdit();
            this.cboxCekHesap = new DevExpress.XtraEditors.ComboBoxEdit();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cboxTransferAliciHesap = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnTransfer = new DevExpress.XtraEditors.SimpleButton();
            this.txtTransferMiktar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cboxTransferGonderenHesap = new DevExpress.XtraEditors.ComboBoxEdit();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.btnSorgula = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cboxSorgulaHesap = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridGecmis = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISLEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGONDEREN_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALICI_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMIKTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISLEM_TARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYatirMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxYatirHesap.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxCekHesap.Properties)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxTransferAliciHesap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransferMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxTransferGonderenHesap.Properties)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSorgulaHesap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGecmis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.Transparent;
            this.xtraTabControl1.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.White;
            this.xtraTabControl1.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.xtraTabControl1.AppearancePage.HeaderActive.Options.UseForeColor = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(823, 545);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xtraTabPage1.Appearance.Header.ForeColor = System.Drawing.Color.Teal;
            this.xtraTabPage1.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage1.Appearance.Header.Options.UseForeColor = true;
            this.xtraTabPage1.Appearance.HeaderActive.BackColor = System.Drawing.Color.Transparent;
            this.xtraTabPage1.Appearance.HeaderActive.BackColor2 = System.Drawing.Color.Transparent;
            this.xtraTabPage1.Appearance.HeaderActive.Options.UseBackColor = true;
            this.xtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.xtraTabPage1.Appearance.PageClient.BackColor2 = System.Drawing.Color.White;
            this.xtraTabPage1.Appearance.PageClient.BorderColor = System.Drawing.Color.White;
            this.xtraTabPage1.Appearance.PageClient.ForeColor = System.Drawing.Color.Teal;
            this.xtraTabPage1.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage1.Appearance.PageClient.Options.UseBorderColor = true;
            this.xtraTabPage1.Appearance.PageClient.Options.UseForeColor = true;
            this.xtraTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.xtraTabPage1.Controls.Add(this.btnYatir);
            this.xtraTabPage1.Controls.Add(this.txtYatirMiktar);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.cboxYatirHesap);
            this.xtraTabPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage1.ImageOptions.SvgImage")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(821, 491);
            this.xtraTabPage1.Text = "Para Yatır";
            // 
            // btnYatir
            // 
            this.btnYatir.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYatir.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btnYatir.Appearance.Options.UseFont = true;
            this.btnYatir.Appearance.Options.UseForeColor = true;
            this.btnYatir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYatir.ImageOptions.SvgImage")));
            this.btnYatir.Location = new System.Drawing.Point(306, 340);
            this.btnYatir.Name = "btnYatir";
            this.btnYatir.Size = new System.Drawing.Size(207, 52);
            this.btnYatir.TabIndex = 4;
            this.btnYatir.Text = "YATIR";
            this.btnYatir.Click += new System.EventHandler(this.btnYatir_Click);
            // 
            // txtYatirMiktar
            // 
            this.txtYatirMiktar.Location = new System.Drawing.Point(306, 260);
            this.txtYatirMiktar.Name = "txtYatirMiktar";
            this.txtYatirMiktar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYatirMiktar.Properties.Appearance.Options.UseFont = true;
            this.txtYatirMiktar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtYatirMiktar.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtYatirMiktar.Properties.MaskSettings.Set("mask", "c");
            this.txtYatirMiktar.Properties.MaxLength = 8;
            this.txtYatirMiktar.Size = new System.Drawing.Size(207, 46);
            this.txtYatirMiktar.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(306, 214);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 40);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Miktar";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(306, 87);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 40);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Hesap";
            // 
            // cboxYatirHesap
            // 
            this.cboxYatirHesap.Location = new System.Drawing.Point(306, 133);
            this.cboxYatirHesap.Name = "cboxYatirHesap";
            this.cboxYatirHesap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxYatirHesap.Properties.Appearance.Options.UseFont = true;
            this.cboxYatirHesap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxYatirHesap.Size = new System.Drawing.Size(207, 46);
            this.cboxYatirHesap.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xtraTabPage2.Appearance.Header.ForeColor = System.Drawing.Color.Red;
            this.xtraTabPage2.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage2.Appearance.Header.Options.UseForeColor = true;
            this.xtraTabPage2.Appearance.HeaderActive.ForeColor = System.Drawing.Color.Red;
            this.xtraTabPage2.Appearance.HeaderActive.Options.UseForeColor = true;
            this.xtraTabPage2.Appearance.PageClient.ForeColor = System.Drawing.Color.Red;
            this.xtraTabPage2.Appearance.PageClient.Options.UseForeColor = true;
            this.xtraTabPage2.Controls.Add(this.labelControl3);
            this.xtraTabPage2.Controls.Add(this.labelControl9);
            this.xtraTabPage2.Controls.Add(this.btnCek);
            this.xtraTabPage2.Controls.Add(this.txtCekMiktar);
            this.xtraTabPage2.Controls.Add(this.cboxCekHesap);
            this.xtraTabPage2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage2.ImageOptions.SvgImage")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(821, 491);
            this.xtraTabPage2.Text = "Para Çek";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(306, 214);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(107, 40);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Miktar";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(306, 87);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(103, 40);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "Hesap";
            // 
            // btnCek
            // 
            this.btnCek.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCek.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnCek.Appearance.Options.UseFont = true;
            this.btnCek.Appearance.Options.UseForeColor = true;
            this.btnCek.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCek.ImageOptions.SvgImage")));
            this.btnCek.Location = new System.Drawing.Point(306, 340);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(207, 53);
            this.btnCek.TabIndex = 9;
            this.btnCek.Text = "ÇEK";
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // txtCekMiktar
            // 
            this.txtCekMiktar.Location = new System.Drawing.Point(306, 260);
            this.txtCekMiktar.Name = "txtCekMiktar";
            this.txtCekMiktar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCekMiktar.Properties.Appearance.Options.UseFont = true;
            this.txtCekMiktar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCekMiktar.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtCekMiktar.Properties.MaskSettings.Set("mask", "c");
            this.txtCekMiktar.Properties.MaxLength = 8;
            this.txtCekMiktar.Size = new System.Drawing.Size(207, 46);
            this.txtCekMiktar.TabIndex = 8;
            // 
            // cboxCekHesap
            // 
            this.cboxCekHesap.Location = new System.Drawing.Point(306, 133);
            this.cboxCekHesap.Name = "cboxCekHesap";
            this.cboxCekHesap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxCekHesap.Properties.Appearance.Options.UseFont = true;
            this.cboxCekHesap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxCekHesap.Size = new System.Drawing.Size(207, 46);
            this.cboxCekHesap.TabIndex = 5;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xtraTabPage3.Appearance.Header.ForeColor = System.Drawing.Color.RoyalBlue;
            this.xtraTabPage3.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage3.Appearance.Header.Options.UseForeColor = true;
            this.xtraTabPage3.Appearance.PageClient.ForeColor = System.Drawing.Color.RoyalBlue;
            this.xtraTabPage3.Appearance.PageClient.Options.UseForeColor = true;
            this.xtraTabPage3.Controls.Add(this.labelControl7);
            this.xtraTabPage3.Controls.Add(this.cboxTransferAliciHesap);
            this.xtraTabPage3.Controls.Add(this.btnTransfer);
            this.xtraTabPage3.Controls.Add(this.txtTransferMiktar);
            this.xtraTabPage3.Controls.Add(this.labelControl5);
            this.xtraTabPage3.Controls.Add(this.labelControl6);
            this.xtraTabPage3.Controls.Add(this.cboxTransferGonderenHesap);
            this.xtraTabPage3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage3.ImageOptions.SvgImage")));
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(821, 491);
            this.xtraTabPage3.Text = "Para Transferi";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(278, 167);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(183, 40);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Alıcı Hesap";
            // 
            // cboxTransferAliciHesap
            // 
            this.cboxTransferAliciHesap.Location = new System.Drawing.Point(278, 213);
            this.cboxTransferAliciHesap.Name = "cboxTransferAliciHesap";
            this.cboxTransferAliciHesap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxTransferAliciHesap.Properties.Appearance.Options.UseFont = true;
            this.cboxTransferAliciHesap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxTransferAliciHesap.Size = new System.Drawing.Size(275, 46);
            this.cboxTransferAliciHesap.TabIndex = 10;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTransfer.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnTransfer.Appearance.Options.UseFont = true;
            this.btnTransfer.Appearance.Options.UseForeColor = true;
            this.btnTransfer.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTransfer.ImageOptions.SvgImage")));
            this.btnTransfer.Location = new System.Drawing.Point(278, 394);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(275, 47);
            this.btnTransfer.TabIndex = 9;
            this.btnTransfer.Text = "TRANSFER";
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtTransferMiktar
            // 
            this.txtTransferMiktar.Location = new System.Drawing.Point(278, 327);
            this.txtTransferMiktar.Name = "txtTransferMiktar";
            this.txtTransferMiktar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTransferMiktar.Properties.Appearance.Options.UseFont = true;
            this.txtTransferMiktar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTransferMiktar.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtTransferMiktar.Properties.MaskSettings.Set("mask", "c");
            this.txtTransferMiktar.Properties.MaxLength = 8;
            this.txtTransferMiktar.Size = new System.Drawing.Size(275, 46);
            this.txtTransferMiktar.TabIndex = 8;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(278, 281);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(107, 40);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Miktar";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(278, 51);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(275, 40);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Gönderen Hesap";
            // 
            // cboxTransferGonderenHesap
            // 
            this.cboxTransferGonderenHesap.Location = new System.Drawing.Point(278, 97);
            this.cboxTransferGonderenHesap.Name = "cboxTransferGonderenHesap";
            this.cboxTransferGonderenHesap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxTransferGonderenHesap.Properties.Appearance.Options.UseFont = true;
            this.cboxTransferGonderenHesap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxTransferGonderenHesap.Size = new System.Drawing.Size(275, 46);
            this.cboxTransferGonderenHesap.TabIndex = 5;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xtraTabPage4.Appearance.Header.ForeColor = System.Drawing.Color.Gray;
            this.xtraTabPage4.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage4.Appearance.Header.Options.UseForeColor = true;
            this.xtraTabPage4.Appearance.PageClient.ForeColor = System.Drawing.Color.Gray;
            this.xtraTabPage4.Appearance.PageClient.Options.UseForeColor = true;
            this.xtraTabPage4.Controls.Add(this.btnSorgula);
            this.xtraTabPage4.Controls.Add(this.labelControl8);
            this.xtraTabPage4.Controls.Add(this.cboxSorgulaHesap);
            this.xtraTabPage4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage4.ImageOptions.SvgImage")));
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(821, 491);
            this.xtraTabPage4.Text = "Bakiye Sorgula";
            // 
            // btnSorgula
            // 
            this.btnSorgula.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSorgula.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btnSorgula.Appearance.Options.UseFont = true;
            this.btnSorgula.Appearance.Options.UseForeColor = true;
            this.btnSorgula.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSorgula.ImageOptions.SvgImage")));
            this.btnSorgula.Location = new System.Drawing.Point(306, 215);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(207, 47);
            this.btnSorgula.TabIndex = 10;
            this.btnSorgula.Text = "SORGULA";
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(306, 87);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(103, 40);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Hesap";
            // 
            // cboxSorgulaHesap
            // 
            this.cboxSorgulaHesap.Location = new System.Drawing.Point(306, 133);
            this.cboxSorgulaHesap.Name = "cboxSorgulaHesap";
            this.cboxSorgulaHesap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxSorgulaHesap.Properties.Appearance.Options.UseFont = true;
            this.cboxSorgulaHesap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxSorgulaHesap.Size = new System.Drawing.Size(207, 46);
            this.cboxSorgulaHesap.TabIndex = 7;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.gridGecmis);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Location = new System.Drawing.Point(865, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1034, 544);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "İşlem Geçmişi";
            // 
            // gridGecmis
            // 
            this.gridGecmis.DataMember = "islemgecmisi";
            this.gridGecmis.DataSource = this.sqlDataSource1;
            this.gridGecmis.Location = new System.Drawing.Point(6, 49);
            this.gridGecmis.MainView = this.gridView1;
            this.gridGecmis.Name = "gridGecmis";
            this.gridGecmis.Size = new System.Drawing.Size(1023, 490);
            this.gridGecmis.TabIndex = 2;
            this.gridGecmis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "hologlu.BankaOtomasyonu.dbo";
            msSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows;
            msSqlConnectionParameters1.DatabaseName = "BankaOtomasyonu";
            msSqlConnectionParameters1.ServerName = "HOLOGLU";
            this.sqlDataSource1.ConnectionParameters = msSqlConnectionParameters1;
            this.sqlDataSource1.Name = "sqlDataSource1";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"185\" />";
            table1.Name = "islemgecmisi";
            allColumns1.Table = table1;
            selectQuery1.Columns.Add(allColumns1);
            selectQuery1.Name = "islemgecmisi";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.SystemColors.Info;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.SystemColors.Info;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colISLEM,
            this.colGONDEREN_ID,
            this.colALICI_ID,
            this.colMIKTAR,
            this.colISLEM_TARIHI});
            this.gridView1.GridControl = this.gridGecmis;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.Caption = "İşlem İd";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // colISLEM
            // 
            this.colISLEM.Caption = "İşlem Türü";
            this.colISLEM.FieldName = "ISLEM";
            this.colISLEM.MinWidth = 25;
            this.colISLEM.Name = "colISLEM";
            this.colISLEM.Visible = true;
            this.colISLEM.VisibleIndex = 1;
            this.colISLEM.Width = 94;
            // 
            // colGONDEREN_ID
            // 
            this.colGONDEREN_ID.Caption = "Gönderen İd";
            this.colGONDEREN_ID.FieldName = "GONDEREN_ID";
            this.colGONDEREN_ID.MinWidth = 25;
            this.colGONDEREN_ID.Name = "colGONDEREN_ID";
            this.colGONDEREN_ID.Visible = true;
            this.colGONDEREN_ID.VisibleIndex = 2;
            this.colGONDEREN_ID.Width = 94;
            // 
            // colALICI_ID
            // 
            this.colALICI_ID.Caption = "Alıcı İd";
            this.colALICI_ID.FieldName = "ALICI_ID";
            this.colALICI_ID.MinWidth = 25;
            this.colALICI_ID.Name = "colALICI_ID";
            this.colALICI_ID.Visible = true;
            this.colALICI_ID.VisibleIndex = 3;
            this.colALICI_ID.Width = 94;
            // 
            // colMIKTAR
            // 
            this.colMIKTAR.Caption = "Miktar";
            this.colMIKTAR.FieldName = "MIKTAR";
            this.colMIKTAR.MinWidth = 25;
            this.colMIKTAR.Name = "colMIKTAR";
            this.colMIKTAR.Visible = true;
            this.colMIKTAR.VisibleIndex = 4;
            this.colMIKTAR.Width = 94;
            // 
            // colISLEM_TARIHI
            // 
            this.colISLEM_TARIHI.Caption = "İşlem Tarihi";
            this.colISLEM_TARIHI.FieldName = "ISLEM_TARIHI";
            this.colISLEM_TARIHI.MinWidth = 25;
            this.colISLEM_TARIHI.Name = "colISLEM_TARIHI";
            this.colISLEM_TARIHI.Visible = true;
            this.colISLEM_TARIHI.VisibleIndex = 5;
            this.colISLEM_TARIHI.Width = 94;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuncelle.ImageOptions.SvgImage")));
            this.btnGuncelle.Location = new System.Drawing.Point(907, 0);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(122, 43);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // frmParaTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1942, 717);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmParaTransfer";
            this.Text = "Para Transfer İşlemleri";
            this.Load += new System.EventHandler(this.ParaTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYatirMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxYatirHesap.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxCekHesap.Properties)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxTransferAliciHesap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransferMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxTransferGonderenHesap.Properties)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSorgulaHesap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGecmis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraEditors.SimpleButton btnYatir;
        private DevExpress.XtraEditors.TextEdit txtYatirMiktar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboxYatirHesap;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit cboxTransferAliciHesap;
        private DevExpress.XtraEditors.SimpleButton btnTransfer;
        private DevExpress.XtraEditors.TextEdit txtTransferMiktar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cboxTransferGonderenHesap;
        private DevExpress.XtraEditors.SimpleButton btnSorgula;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cboxSorgulaHesap;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnCek;
        private DevExpress.XtraEditors.TextEdit txtCekMiktar;
        private DevExpress.XtraEditors.ComboBoxEdit cboxCekHesap;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.GridControl gridGecmis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colISLEM;
        private DevExpress.XtraGrid.Columns.GridColumn colGONDEREN_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colALICI_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMIKTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colISLEM_TARIHI;
    }
}