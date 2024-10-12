namespace Supply.Orders.Manager.Forms.UygulamaForm
{
    partial class frmGirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGirisEkrani));
            this.peLogo = new DevExpress.XtraEditors.PictureEdit();
            this.lcLogo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcKullaniciKod = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueKod = new DevExpress.XtraEditors.LookUpEdit();
            this.teSifre = new DevExpress.XtraEditors.TextEdit();
            this.lcKullaniciSifre = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbHatirla = new DevExpress.XtraEditors.CheckButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dlcMain)).BeginInit();
            this.dlcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlcMainRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcKullaniciKod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcKullaniciSifre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // dlcMain
            // 
            this.dlcMain.Controls.Add(this.cbHatirla);
            this.dlcMain.Controls.Add(this.btnVazgec);
            this.dlcMain.Controls.Add(this.btnGiris);
            this.dlcMain.Controls.Add(this.teSifre);
            this.dlcMain.Controls.Add(this.peLogo);
            this.dlcMain.Controls.Add(this.lueKod);
            this.dlcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(852, 198, 650, 400);
            this.dlcMain.OptionsCustomizationForm.ShowPropertyGrid = true;
            this.dlcMain.OptionsCustomizationForm.SnapMode = ((DevExpress.Utils.Controls.SnapMode)((((DevExpress.Utils.Controls.SnapMode.OwnerControl | DevExpress.Utils.Controls.SnapMode.OwnerForm) 
            | DevExpress.Utils.Controls.SnapMode.Screens) 
            | DevExpress.Utils.Controls.SnapMode.SnapForms)));
            this.dlcMain.Size = new System.Drawing.Size(250, 239);
            // 
            // dlcMainRoot
            // 
            this.dlcMainRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcLogo,
            this.lcKullaniciKod,
            this.lcKullaniciSifre,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.dlcMainRoot.Size = new System.Drawing.Size(250, 239);
            // 
            // peLogo
            // 
            this.peLogo.EditValue = global::Supply.Orders.Manager.Properties.Resources.SUPPLY_YENİ_LOGO;
            this.peLogo.Location = new System.Drawing.Point(7, 7);
            this.peLogo.Name = "peLogo";
            this.peLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peLogo.Size = new System.Drawing.Size(236, 97);
            this.peLogo.StyleController = this.dlcMain;
            this.peLogo.TabIndex = 4;
            // 
            // lcLogo
            // 
            this.lcLogo.Control = this.peLogo;
            this.lcLogo.Location = new System.Drawing.Point(0, 0);
            this.lcLogo.Name = "lcLogo";
            this.lcLogo.Size = new System.Drawing.Size(240, 101);
            this.lcLogo.Text = "Logo";
            this.lcLogo.TextSize = new System.Drawing.Size(0, 0);
            this.lcLogo.TextVisible = false;
            // 
            // lcKullaniciKod
            // 
            this.lcKullaniciKod.Control = this.lueKod;
            this.lcKullaniciKod.Location = new System.Drawing.Point(0, 101);
            this.lcKullaniciKod.Name = "lcKullaniciKod";
            this.lcKullaniciKod.Size = new System.Drawing.Size(240, 24);
            this.lcKullaniciKod.Text = "Kullanıcı Kodu";
            this.lcKullaniciKod.TextSize = new System.Drawing.Size(64, 13);
            // 
            // lueKod
            // 
            this.lueKod.Location = new System.Drawing.Point(83, 108);
            this.lueKod.Name = "lueKod";
            this.lueKod.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lueKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueKod.Properties.NullText = "";
            this.lueKod.Properties.PopupSizeable = false;
            this.lueKod.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueKod.Size = new System.Drawing.Size(160, 20);
            this.lueKod.StyleController = this.dlcMain;
            this.lueKod.TabIndex = 5;
            // 
            // teSifre
            // 
            this.teSifre.Location = new System.Drawing.Point(83, 132);
            this.teSifre.Name = "teSifre";
            this.teSifre.Properties.PasswordChar = '*';
            this.teSifre.Size = new System.Drawing.Size(160, 20);
            this.teSifre.StyleController = this.dlcMain;
            this.teSifre.TabIndex = 6;
            // 
            // lcKullaniciSifre
            // 
            this.lcKullaniciSifre.Control = this.teSifre;
            this.lcKullaniciSifre.Location = new System.Drawing.Point(0, 125);
            this.lcKullaniciSifre.Name = "lcKullaniciSifre";
            this.lcKullaniciSifre.Size = new System.Drawing.Size(240, 24);
            this.lcKullaniciSifre.Text = "Kullanıcı Şifre";
            this.lcKullaniciSifre.TextSize = new System.Drawing.Size(64, 13);
            // 
            // btnGiris
            // 
            this.btnGiris.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGiris.ImageOptions.SvgImage")));
            this.btnGiris.Location = new System.Drawing.Point(127, 156);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(116, 36);
            this.btnGiris.StyleController = this.dlcMain;
            this.btnGiris.TabIndex = 7;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnGiris;
            this.layoutControlItem1.Location = new System.Drawing.Point(120, 149);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(120, 40);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btnVazgec
            // 
            this.btnVazgec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVazgec.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnVazgec.ImageOptions.SvgImage")));
            this.btnVazgec.Location = new System.Drawing.Point(7, 156);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(116, 36);
            this.btnVazgec.StyleController = this.dlcMain;
            this.btnVazgec.TabIndex = 8;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnVazgec;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 149);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(120, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // cbHatirla
            // 
            this.cbHatirla.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cbHatirla.ImageOptions.SvgImage")));
            this.cbHatirla.Location = new System.Drawing.Point(7, 196);
            this.cbHatirla.Name = "cbHatirla";
            this.cbHatirla.Size = new System.Drawing.Size(236, 36);
            this.cbHatirla.StyleController = this.dlcMain;
            this.cbHatirla.TabIndex = 9;
            this.cbHatirla.Text = "Beni Hatırla";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbHatirla;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 189);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(240, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // frmGirisEkrani
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVazgec;
            this.ClientSize = new System.Drawing.Size(250, 239);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmGirisEkrani.IconOptions.Icon")));
            this.Name = "frmGirisEkrani";
            this.Text = "Supply Sipariş Yönetim - Giriş";
            this.Load += new System.EventHandler(this.frmGirisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dlcMain)).EndInit();
            this.dlcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dlcMainRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcKullaniciKod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcKullaniciSifre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit peLogo;
        private DevExpress.XtraLayout.LayoutControlItem lcLogo;
        private DevExpress.XtraLayout.LayoutControlItem lcKullaniciKod;
        private DevExpress.XtraEditors.TextEdit teSifre;
        private DevExpress.XtraLayout.LayoutControlItem lcKullaniciSifre;
        private DevExpress.XtraEditors.CheckButton cbHatirla;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LookUpEdit lueKod;
    }
}