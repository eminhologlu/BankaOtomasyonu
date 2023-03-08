namespace Banka_Otomasyonu
{
    partial class frmAyarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyarlar));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.txtYeniSifreTekrar = new DevExpress.XtraEditors.TextEdit();
            this.txtYeniSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtEskiSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtPersonelNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniSifreTekrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEskiSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.btnDegistir);
            this.groupControl1.Controls.Add(this.txtYeniSifreTekrar);
            this.groupControl1.Controls.Add(this.txtYeniSifre);
            this.groupControl1.Controls.Add(this.txtEskiSifre);
            this.groupControl1.Controls.Add(this.txtPersonelNo);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl1.Location = new System.Drawing.Point(13, 13);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(341, 565);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Şifre Değiştir";
            // 
            // btnDegistir
            // 
            this.btnDegistir.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDegistir.Appearance.Options.UseFont = true;
            this.btnDegistir.Appearance.Options.UseForeColor = true;
            this.btnDegistir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDegistir.ImageOptions.SvgImage")));
            this.btnDegistir.Location = new System.Drawing.Point(82, 458);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(202, 52);
            this.btnDegistir.TabIndex = 8;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(82, 392);
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSifreTekrar.Properties.Appearance.Options.UseFont = true;
            this.txtYeniSifreTekrar.Properties.MaxLength = 20;
            this.txtYeniSifreTekrar.Properties.PasswordChar = '*';
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(202, 42);
            this.txtYeniSifreTekrar.TabIndex = 7;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(82, 298);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSifre.Properties.Appearance.Options.UseFont = true;
            this.txtYeniSifre.Properties.MaxLength = 20;
            this.txtYeniSifre.Properties.PasswordChar = '*';
            this.txtYeniSifre.Size = new System.Drawing.Size(202, 42);
            this.txtYeniSifre.TabIndex = 6;
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.Location = new System.Drawing.Point(82, 204);
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEskiSifre.Properties.Appearance.Options.UseFont = true;
            this.txtEskiSifre.Properties.MaxLength = 20;
            this.txtEskiSifre.Properties.PasswordChar = '*';
            this.txtEskiSifre.Size = new System.Drawing.Size(202, 42);
            this.txtEskiSifre.TabIndex = 5;
            // 
            // txtPersonelNo
            // 
            this.txtPersonelNo.Location = new System.Drawing.Point(82, 108);
            this.txtPersonelNo.Name = "txtPersonelNo";
            this.txtPersonelNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelNo.Properties.Appearance.Options.UseFont = true;
            this.txtPersonelNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPersonelNo.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtPersonelNo.Properties.MaskSettings.Set("mask", "000000000");
            this.txtPersonelNo.Properties.MaxLength = 9;
            this.txtPersonelNo.Size = new System.Drawing.Size(202, 42);
            this.txtPersonelNo.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(82, 362);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(149, 24);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Yeni Şifre Tekrar";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(82, 268);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 24);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Yeni Şifre";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(82, 174);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 24);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Eski Şifre";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(82, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Personel No";
            // 
            // frmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(911, 740);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAyarlar";
            this.Text = "Ayarlar";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniSifreTekrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEskiSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnDegistir;
        private DevExpress.XtraEditors.TextEdit txtYeniSifreTekrar;
        private DevExpress.XtraEditors.TextEdit txtYeniSifre;
        private DevExpress.XtraEditors.TextEdit txtEskiSifre;
        private DevExpress.XtraEditors.TextEdit txtPersonelNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}