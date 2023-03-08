namespace Banka_Otomasyonu
{
    partial class frmMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteri));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.AllColumns allColumns1 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            this.cboxIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboxSehir = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.richTxtAdres = new System.Windows.Forms.RichTextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.dateDogumTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtEposta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridMusteri = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMUAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMUSOYAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMUTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMUDOGUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMUTEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMUEPOSTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMUIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMUILCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMUADRES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBAKIYE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.txtTELNo = new DevExpress.XtraEditors.TextEdit();
            this.txtTCNo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSehir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDogumTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDogumTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTELNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTCNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxIlce
            // 
            this.cboxIlce.Location = new System.Drawing.Point(156, 495);
            this.cboxIlce.Name = "cboxIlce";
            this.cboxIlce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxIlce.Properties.Appearance.Options.UseFont = true;
            this.cboxIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxIlce.Size = new System.Drawing.Size(172, 40);
            this.cboxIlce.TabIndex = 25;
            // 
            // cboxSehir
            // 
            this.cboxSehir.Location = new System.Drawing.Point(156, 441);
            this.cboxSehir.Name = "cboxSehir";
            this.cboxSehir.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxSehir.Properties.Appearance.Options.UseFont = true;
            this.cboxSehir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxSehir.Size = new System.Drawing.Size(172, 40);
            this.cboxSehir.TabIndex = 2;
            this.cboxSehir.SelectedIndexChanged += new System.EventHandler(this.cboxSehir_SelectedIndexChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.Options.UseBackColor = true;
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTemizle.ImageOptions.SvgImage")));
            this.btnTemizle.Location = new System.Drawing.Point(371, 427);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(172, 50);
            this.btnTemizle.TabIndex = 24;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.BackColor = System.Drawing.Color.Khaki;
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseBackColor = true;
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuncelle.ImageOptions.SvgImage")));
            this.btnGuncelle.Location = new System.Drawing.Point(371, 315);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(172, 50);
            this.btnGuncelle.TabIndex = 23;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSil.ImageOptions.SvgImage")));
            this.btnSil.Location = new System.Drawing.Point(371, 371);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(172, 50);
            this.btnSil.TabIndex = 22;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.GreenYellow;
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Appearance.Options.UseForeColor = true;
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(371, 259);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(172, 50);
            this.btnKaydet.TabIndex = 21;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // richTxtAdres
            // 
            this.richTxtAdres.Location = new System.Drawing.Point(156, 559);
            this.richTxtAdres.Name = "richTxtAdres";
            this.richTxtAdres.Size = new System.Drawing.Size(172, 202);
            this.richTxtAdres.TabIndex = 20;
            this.richTxtAdres.Text = "";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(79, 556);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 22);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Adres:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(95, 502);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(34, 22);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "İlçe:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(112, 448);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(17, 22);
            this.labelControl10.TabIndex = 15;
            this.labelControl10.Text = "İl:";
            // 
            // dateDogumTarihi
            // 
            this.dateDogumTarihi.EditValue = null;
            this.dateDogumTarihi.Location = new System.Drawing.Point(156, 387);
            this.dateDogumTarihi.Name = "dateDogumTarihi";
            this.dateDogumTarihi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateDogumTarihi.Properties.Appearance.Options.UseFont = true;
            this.dateDogumTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDogumTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDogumTarihi.Properties.MaskSettings.Set("mask", "d");
            this.dateDogumTarihi.Size = new System.Drawing.Size(172, 40);
            this.dateDogumTarihi.TabIndex = 15;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(156, 333);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEposta.Properties.Appearance.Options.UseFont = true;
            this.txtEposta.Size = new System.Drawing.Size(172, 40);
            this.txtEposta.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(16, 394);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(113, 22);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Doğum Tarihi:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(63, 340);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 22);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "E-posta:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(64, 286);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 22);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Telefon:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(156, 63);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Properties.Appearance.Options.UseBackColor = true;
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Size = new System.Drawing.Size(172, 40);
            this.txtId.TabIndex = 19;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(104, 70);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(25, 22);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "ID:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(156, 171);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Properties.Appearance.Options.UseFont = true;
            this.txtSoyad.Size = new System.Drawing.Size(172, 40);
            this.txtSoyad.TabIndex = 9;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(156, 117);
            this.txtAd.Name = "txtAd";
            this.txtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Properties.Appearance.Options.UseFont = true;
            this.txtAd.Size = new System.Drawing.Size(172, 40);
            this.txtAd.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(73, 232);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 22);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "TC No:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(75, 178);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 22);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Soyad:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(102, 124);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ad:";
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl3.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl3.CaptionImageOptions.SvgImage")));
            this.groupControl3.Controls.Add(this.gridMusteri);
            this.groupControl3.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl3.Location = new System.Drawing.Point(585, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1321, 802);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Müşteri Listesi";
            // 
            // gridMusteri
            // 
            this.gridMusteri.DataMember = "musteri";
            this.gridMusteri.DataSource = this.sqlDataSource1;
            this.gridMusteri.Location = new System.Drawing.Point(5, 48);
            this.gridMusteri.MainView = this.gridView1;
            this.gridMusteri.Name = "gridMusteri";
            this.gridMusteri.Size = new System.Drawing.Size(1311, 749);
            this.gridMusteri.TabIndex = 0;
            this.gridMusteri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "BankaOtomasyonu.mdf";
            this.sqlDataSource1.Name = "sqlDataSource1";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"285\" />";
            table1.Name = "musteri";
            allColumns1.Table = table1;
            selectQuery1.Columns.Add(allColumns1);
            selectQuery1.Name = "musteri";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Lime;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMUID,
            this.colMUAD,
            this.colMUSOYAD,
            this.colMUTC,
            this.colMUDOGUM,
            this.colMUTEL,
            this.colMUEPOSTA,
            this.colMUIL,
            this.colMUILCE,
            this.colMUADRES,
            this.colBAKIYE});
            this.gridView1.GridControl = this.gridMusteri;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // colMUID
            // 
            this.colMUID.Caption = "İd";
            this.colMUID.FieldName = "MUID";
            this.colMUID.MinWidth = 25;
            this.colMUID.Name = "colMUID";
            this.colMUID.Visible = true;
            this.colMUID.VisibleIndex = 0;
            this.colMUID.Width = 94;
            // 
            // colMUAD
            // 
            this.colMUAD.Caption = "Ad";
            this.colMUAD.FieldName = "MUAD";
            this.colMUAD.MinWidth = 25;
            this.colMUAD.Name = "colMUAD";
            this.colMUAD.Visible = true;
            this.colMUAD.VisibleIndex = 1;
            this.colMUAD.Width = 94;
            // 
            // colMUSOYAD
            // 
            this.colMUSOYAD.Caption = "Soyad";
            this.colMUSOYAD.FieldName = "MUSOYAD";
            this.colMUSOYAD.MinWidth = 25;
            this.colMUSOYAD.Name = "colMUSOYAD";
            this.colMUSOYAD.Visible = true;
            this.colMUSOYAD.VisibleIndex = 2;
            this.colMUSOYAD.Width = 94;
            // 
            // colMUTC
            // 
            this.colMUTC.Caption = "TC No";
            this.colMUTC.FieldName = "MUTC";
            this.colMUTC.MinWidth = 25;
            this.colMUTC.Name = "colMUTC";
            this.colMUTC.Visible = true;
            this.colMUTC.VisibleIndex = 3;
            this.colMUTC.Width = 94;
            // 
            // colMUDOGUM
            // 
            this.colMUDOGUM.Caption = "Doğum Tarihi";
            this.colMUDOGUM.FieldName = "MUDOGUM";
            this.colMUDOGUM.MinWidth = 25;
            this.colMUDOGUM.Name = "colMUDOGUM";
            this.colMUDOGUM.Visible = true;
            this.colMUDOGUM.VisibleIndex = 4;
            this.colMUDOGUM.Width = 94;
            // 
            // colMUTEL
            // 
            this.colMUTEL.Caption = "TEL No";
            this.colMUTEL.FieldName = "MUTEL";
            this.colMUTEL.MinWidth = 25;
            this.colMUTEL.Name = "colMUTEL";
            this.colMUTEL.Visible = true;
            this.colMUTEL.VisibleIndex = 5;
            this.colMUTEL.Width = 94;
            // 
            // colMUEPOSTA
            // 
            this.colMUEPOSTA.Caption = "E-posta";
            this.colMUEPOSTA.FieldName = "MUEPOSTA";
            this.colMUEPOSTA.MinWidth = 25;
            this.colMUEPOSTA.Name = "colMUEPOSTA";
            this.colMUEPOSTA.Visible = true;
            this.colMUEPOSTA.VisibleIndex = 6;
            this.colMUEPOSTA.Width = 94;
            // 
            // colMUIL
            // 
            this.colMUIL.Caption = "İl";
            this.colMUIL.FieldName = "MUIL";
            this.colMUIL.MinWidth = 25;
            this.colMUIL.Name = "colMUIL";
            this.colMUIL.Visible = true;
            this.colMUIL.VisibleIndex = 7;
            this.colMUIL.Width = 94;
            // 
            // colMUILCE
            // 
            this.colMUILCE.Caption = "İlçe";
            this.colMUILCE.FieldName = "MUILCE";
            this.colMUILCE.MinWidth = 25;
            this.colMUILCE.Name = "colMUILCE";
            this.colMUILCE.Visible = true;
            this.colMUILCE.VisibleIndex = 8;
            this.colMUILCE.Width = 94;
            // 
            // colMUADRES
            // 
            this.colMUADRES.Caption = "Adres";
            this.colMUADRES.FieldName = "MUADRES";
            this.colMUADRES.MinWidth = 25;
            this.colMUADRES.Name = "colMUADRES";
            this.colMUADRES.Visible = true;
            this.colMUADRES.VisibleIndex = 9;
            this.colMUADRES.Width = 94;
            // 
            // colBAKIYE
            // 
            this.colBAKIYE.Caption = "Bakiye";
            this.colBAKIYE.FieldName = "BAKIYE";
            this.colBAKIYE.MinWidth = 25;
            this.colBAKIYE.Name = "colBAKIYE";
            this.colBAKIYE.Visible = true;
            this.colBAKIYE.VisibleIndex = 10;
            this.colBAKIYE.Width = 94;
            // 
            // groupControl4
            // 
            this.groupControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl4.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.groupControl4.Appearance.Options.UseBackColor = true;
            this.groupControl4.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl4.AppearanceCaption.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupControl4.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl4.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl4.CaptionImageOptions.SvgImage")));
            this.groupControl4.Controls.Add(this.txtTELNo);
            this.groupControl4.Controls.Add(this.btnTemizle);
            this.groupControl4.Controls.Add(this.cboxIlce);
            this.groupControl4.Controls.Add(this.richTxtAdres);
            this.groupControl4.Controls.Add(this.btnSil);
            this.groupControl4.Controls.Add(this.btnGuncelle);
            this.groupControl4.Controls.Add(this.dateDogumTarihi);
            this.groupControl4.Controls.Add(this.cboxSehir);
            this.groupControl4.Controls.Add(this.btnKaydet);
            this.groupControl4.Controls.Add(this.labelControl6);
            this.groupControl4.Controls.Add(this.labelControl7);
            this.groupControl4.Controls.Add(this.txtEposta);
            this.groupControl4.Controls.Add(this.labelControl9);
            this.groupControl4.Controls.Add(this.txtTCNo);
            this.groupControl4.Controls.Add(this.txtId);
            this.groupControl4.Controls.Add(this.labelControl5);
            this.groupControl4.Controls.Add(this.labelControl10);
            this.groupControl4.Controls.Add(this.labelControl8);
            this.groupControl4.Controls.Add(this.labelControl1);
            this.groupControl4.Controls.Add(this.txtAd);
            this.groupControl4.Controls.Add(this.labelControl4);
            this.groupControl4.Controls.Add(this.txtSoyad);
            this.groupControl4.Controls.Add(this.labelControl2);
            this.groupControl4.Controls.Add(this.labelControl3);
            this.groupControl4.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl4.Location = new System.Drawing.Point(12, 12);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(567, 802);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "Müşteri İşlemleri";
            // 
            // txtTELNo
            // 
            this.txtTELNo.Location = new System.Drawing.Point(156, 279);
            this.txtTELNo.Name = "txtTELNo";
            this.txtTELNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTELNo.Properties.Appearance.Options.UseFont = true;
            this.txtTELNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtTELNo.Properties.MaskSettings.Set("mask", "(000) 000-0000");
            this.txtTELNo.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtTELNo.Properties.MaxLength = 15;
            this.txtTELNo.Size = new System.Drawing.Size(172, 40);
            this.txtTELNo.TabIndex = 26;
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(156, 225);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCNo.Properties.Appearance.Options.UseFont = true;
            this.txtTCNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTCNo.Properties.MaskSettings.Set("mask", "d");
            this.txtTCNo.Properties.MaxLength = 11;
            this.txtTCNo.Size = new System.Drawing.Size(172, 40);
            this.txtTCNo.TabIndex = 20;
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1942, 845);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.frmMusteri_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.cboxIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSehir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDogumTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDogumTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTELNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTCNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dateDogumTarihi;
        private DevExpress.XtraEditors.TextEdit txtEposta;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private System.Windows.Forms.RichTextBox richTxtAdres;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.ComboBoxEdit cboxIlce;
        public DevExpress.XtraEditors.ComboBoxEdit cboxSehir;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.TextEdit txtTCNo;
        private DevExpress.XtraGrid.GridControl gridMusteri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMUID;
        private DevExpress.XtraGrid.Columns.GridColumn colMUAD;
        private DevExpress.XtraGrid.Columns.GridColumn colMUSOYAD;
        private DevExpress.XtraGrid.Columns.GridColumn colMUTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMUDOGUM;
        private DevExpress.XtraGrid.Columns.GridColumn colMUTEL;
        private DevExpress.XtraGrid.Columns.GridColumn colMUEPOSTA;
        private DevExpress.XtraGrid.Columns.GridColumn colMUIL;
        private DevExpress.XtraGrid.Columns.GridColumn colMUILCE;
        private DevExpress.XtraGrid.Columns.GridColumn colMUADRES;
        private DevExpress.XtraGrid.Columns.GridColumn colBAKIYE;
        private DevExpress.XtraEditors.TextEdit txtTELNo;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}