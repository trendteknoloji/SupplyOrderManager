namespace Supply.Orders.Manager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.XtraBars.Alerter.AlertButton alertButton1 = new DevExpress.XtraBars.Alerter.AlertButton();
            DevExpress.XtraBars.Alerter.AlertButton alertButton2 = new DevExpress.XtraBars.Alerter.AlertButton();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.srbTema = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.srbPalet = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.btnKullaniciYonetim = new DevExpress.XtraBars.BarButtonItem();
            this.btnDepartmanYonetim = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnGizle = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCariYonetim = new DevExpress.XtraBars.BarButtonItem();
            this.btnStokYonetim = new DevExpress.XtraBars.BarButtonItem();
            this.btnCinsYonetim = new DevExpress.XtraBars.BarButtonItem();
            this.btnKaliteYonetim = new DevExpress.XtraBars.BarButtonItem();
            this.btnSiparisGiris = new DevExpress.XtraBars.BarButtonItem();
            this.btnDashboardHazirlama = new DevExpress.XtraBars.BarButtonItem();
            this.btnRaporHazirlama = new DevExpress.XtraBars.BarButtonItem();
            this.btnCariSiparis = new DevExpress.XtraBars.BarButtonItem();
            this.btnStokSiparis = new DevExpress.XtraBars.BarButtonItem();
            this.btnDashboardGoster = new DevExpress.XtraBars.BarButtonItem();
            this.btnRaporCalistir = new DevExpress.XtraBars.BarButtonItem();
            this.btnSiparisOdeme = new DevExpress.XtraBars.BarButtonItem();
            this.btnEnvanterGiris = new DevExpress.XtraBars.BarButtonItem();
            this.btnEnvanterDurum = new DevExpress.XtraBars.BarButtonItem();
            this.rpGenel = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpYonetici = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpKullaniciIslemleri = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.acMain = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.bgMain = new System.ComponentModel.BackgroundWorker();
            this.icMain = new DevExpress.Utils.ImageCollection(this.components);
            this.nvMain = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.srbTema,
            this.srbPalet,
            this.btnKullaniciYonetim,
            this.btnDepartmanYonetim,
            this.barButtonItem1,
            this.btnGizle,
            this.barButtonItem2,
            this.btnCariYonetim,
            this.btnStokYonetim,
            this.btnCinsYonetim,
            this.btnKaliteYonetim,
            this.btnSiparisGiris,
            this.btnDashboardHazirlama,
            this.btnRaporHazirlama,
            this.btnCariSiparis,
            this.btnStokSiparis,
            this.btnDashboardGoster,
            this.btnRaporCalistir,
            this.btnSiparisOdeme,
            this.btnEnvanterGiris,
            this.btnEnvanterDurum});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 34;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpGenel,
            this.rpYonetici,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(1017, 158);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // srbTema
            // 
            this.srbTema.Caption = "skinRibbonGalleryBarItem1";
            this.srbTema.Id = 1;
            this.srbTema.Name = "srbTema";
            this.srbTema.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.srbTema_GalleryItemClick);
            // 
            // srbPalet
            // 
            this.srbPalet.Caption = "skinPaletteRibbonGalleryBarItem1";
            this.srbPalet.Id = 2;
            this.srbPalet.Name = "srbPalet";
            this.srbPalet.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.srbPalet_GalleryItemClick);
            // 
            // btnKullaniciYonetim
            // 
            this.btnKullaniciYonetim.Caption = "Kullanıcı Yönetim";
            this.btnKullaniciYonetim.Id = 4;
            this.btnKullaniciYonetim.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKullaniciYonetim.ImageOptions.SvgImage")));
            this.btnKullaniciYonetim.Name = "btnKullaniciYonetim";
            this.btnKullaniciYonetim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKullaniciYonetim_ItemClick);
            // 
            // btnDepartmanYonetim
            // 
            this.btnDepartmanYonetim.Caption = "Departman Yönetim";
            this.btnDepartmanYonetim.Id = 5;
            this.btnDepartmanYonetim.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDepartmanYonetim.ImageOptions.SvgImage")));
            this.btnDepartmanYonetim.Name = "btnDepartmanYonetim";
            this.btnDepartmanYonetim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDepartmanYonetim_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 18;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnGizle
            // 
            this.btnGizle.Caption = "Programı Gizle";
            this.btnGizle.Id = 11;
            this.btnGizle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGizle.ImageOptions.SvgImage")));
            this.btnGizle.Name = "btnGizle";
            this.btnGizle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGizle_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Firmalar";
            this.barButtonItem2.Id = 19;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnCariYonetim
            // 
            this.btnCariYonetim.Caption = "Cari Yönetim";
            this.btnCariYonetim.Id = 20;
            this.btnCariYonetim.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCariYonetim.ImageOptions.SvgImage")));
            this.btnCariYonetim.Name = "btnCariYonetim";
            this.btnCariYonetim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCariYonetim_ItemClick);
            // 
            // btnStokYonetim
            // 
            this.btnStokYonetim.Caption = "Stok Yönetim";
            this.btnStokYonetim.Id = 21;
            this.btnStokYonetim.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStokYonetim.ImageOptions.SvgImage")));
            this.btnStokYonetim.Name = "btnStokYonetim";
            this.btnStokYonetim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStokYonetim_ItemClick);
            // 
            // btnCinsYonetim
            // 
            this.btnCinsYonetim.Caption = "Cins Yönetim";
            this.btnCinsYonetim.Id = 22;
            this.btnCinsYonetim.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCinsYonetim.ImageOptions.SvgImage")));
            this.btnCinsYonetim.Name = "btnCinsYonetim";
            this.btnCinsYonetim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCinsYonetim_ItemClick);
            // 
            // btnKaliteYonetim
            // 
            this.btnKaliteYonetim.Caption = "Kalite Yönetim";
            this.btnKaliteYonetim.Id = 23;
            this.btnKaliteYonetim.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaliteYonetim.ImageOptions.SvgImage")));
            this.btnKaliteYonetim.Name = "btnKaliteYonetim";
            this.btnKaliteYonetim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKaliteYonetim_ItemClick);
            // 
            // btnSiparisGiris
            // 
            this.btnSiparisGiris.Caption = "Sipariş Girişi";
            this.btnSiparisGiris.Id = 24;
            this.btnSiparisGiris.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSiparisGiris.ImageOptions.SvgImage")));
            this.btnSiparisGiris.Name = "btnSiparisGiris";
            this.btnSiparisGiris.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSiparisGiris_ItemClick);
            // 
            // btnDashboardHazirlama
            // 
            this.btnDashboardHazirlama.Caption = "Dashboard Hazırlama";
            this.btnDashboardHazirlama.Id = 25;
            this.btnDashboardHazirlama.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDashboardHazirlama.ImageOptions.SvgImage")));
            this.btnDashboardHazirlama.Name = "btnDashboardHazirlama";
            this.btnDashboardHazirlama.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDashboardHazirlama_ItemClick);
            // 
            // btnRaporHazirlama
            // 
            this.btnRaporHazirlama.Caption = "Rapor Hazırlama";
            this.btnRaporHazirlama.Id = 26;
            this.btnRaporHazirlama.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRaporHazirlama.ImageOptions.SvgImage")));
            this.btnRaporHazirlama.Name = "btnRaporHazirlama";
            this.btnRaporHazirlama.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRaporHazirlama_ItemClick);
            // 
            // btnCariSiparis
            // 
            this.btnCariSiparis.Caption = "Cari Sipariş Listesi";
            this.btnCariSiparis.Id = 27;
            this.btnCariSiparis.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCariSiparis.ImageOptions.SvgImage")));
            this.btnCariSiparis.Name = "btnCariSiparis";
            this.btnCariSiparis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCariSiparis_ItemClick);
            // 
            // btnStokSiparis
            // 
            this.btnStokSiparis.Caption = "Stok Sipariş Listesi";
            this.btnStokSiparis.Id = 28;
            this.btnStokSiparis.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStokSiparis.ImageOptions.SvgImage")));
            this.btnStokSiparis.Name = "btnStokSiparis";
            this.btnStokSiparis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStokSiparis_ItemClick);
            // 
            // btnDashboardGoster
            // 
            this.btnDashboardGoster.Caption = "Dashboard Göster";
            this.btnDashboardGoster.Id = 29;
            this.btnDashboardGoster.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDashboardGoster.ImageOptions.SvgImage")));
            this.btnDashboardGoster.Name = "btnDashboardGoster";
            this.btnDashboardGoster.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDashboardGoster_ItemClick);
            // 
            // btnRaporCalistir
            // 
            this.btnRaporCalistir.Caption = "Rapor Çalıştır";
            this.btnRaporCalistir.Id = 30;
            this.btnRaporCalistir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRaporCalistir.ImageOptions.SvgImage")));
            this.btnRaporCalistir.Name = "btnRaporCalistir";
            this.btnRaporCalistir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRaporCalistir_ItemClick);
            // 
            // btnSiparisOdeme
            // 
            this.btnSiparisOdeme.Caption = "Sipariş Ödeme Girişi";
            this.btnSiparisOdeme.Id = 31;
            this.btnSiparisOdeme.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSiparisOdeme.ImageOptions.SvgImage")));
            this.btnSiparisOdeme.Name = "btnSiparisOdeme";
            this.btnSiparisOdeme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSiparisOdeme_ItemClick);
            // 
            // btnEnvanterGiris
            // 
            this.btnEnvanterGiris.Caption = "Stok Giriş";
            this.btnEnvanterGiris.Id = 32;
            this.btnEnvanterGiris.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEnvanterGiris.ImageOptions.SvgImage")));
            this.btnEnvanterGiris.Name = "btnEnvanterGiris";
            this.btnEnvanterGiris.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEnvanterGiris_ItemClick);
            // 
            // btnEnvanterDurum
            // 
            this.btnEnvanterDurum.Caption = "Stok Takip";
            this.btnEnvanterDurum.Id = 33;
            this.btnEnvanterDurum.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEnvanterDurum.ImageOptions.SvgImage")));
            this.btnEnvanterDurum.Name = "btnEnvanterDurum";
            this.btnEnvanterDurum.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEnvanterDurum_ItemClick);
            // 
            // rpGenel
            // 
            this.rpGenel.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup6,
            this.ribbonPageGroup5,
            this.ribbonPageGroup7});
            this.rpGenel.Name = "rpGenel";
            this.rpGenel.Text = "Genel";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSiparisGiris);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSiparisOdeme);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Sipariş Yönetim";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnEnvanterGiris);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnEnvanterDurum);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Stok Yönetim";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDashboardHazirlama);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDashboardGoster);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnRaporHazirlama);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnRaporCalistir);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnCariSiparis);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnStokSiparis);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Raporlama";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnGizle);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Program";
            // 
            // rpYonetici
            // 
            this.rpYonetici.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpKullaniciIslemleri,
            this.ribbonPageGroup1});
            this.rpYonetici.Name = "rpYonetici";
            this.rpYonetici.Text = "Yönetici";
            // 
            // rpKullaniciIslemleri
            // 
            this.rpKullaniciIslemleri.ItemLinks.Add(this.btnKullaniciYonetim);
            this.rpKullaniciIslemleri.ItemLinks.Add(this.btnDepartmanYonetim);
            this.rpKullaniciIslemleri.Name = "rpKullaniciIslemleri";
            this.rpKullaniciIslemleri.Text = "Kullanıcı İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCariYonetim);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCinsYonetim);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKaliteYonetim);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStokYonetim);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Genel Kartlar";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Ayarlar";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Program Ayarları";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.srbTema);
            this.ribbonPageGroup4.ItemLinks.Add(this.srbPalet);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Tema Ayarları";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 699);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1017, 24);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // acMain
            // 
            this.acMain.AllowHtmlText = true;
            this.acMain.AutoHeight = true;
            alertButton1.Hint = "Göreve Başla";
            alertButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            alertButton1.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            alertButton1.Name = "btnGorevBasla";
            alertButton2.Hint = "Görev Kapat";
            alertButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
            alertButton2.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            alertButton2.Name = "btnGorevKapat";
            this.acMain.Buttons.Add(alertButton1);
            this.acMain.Buttons.Add(alertButton2);
            this.acMain.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Slow;
            this.acMain.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.MoveVertical;
            this.acMain.AlertClick += new DevExpress.XtraBars.Alerter.AlertClickEventHandler(this.acMain_AlertClick);
            this.acMain.ButtonClick += new DevExpress.XtraBars.Alerter.AlertButtonClickEventHandler(this.acMain_ButtonClick);
            this.acMain.BeforeFormShow += new DevExpress.XtraBars.Alerter.AlertFormEventHandler(this.acMain_BeforeFormShow);
            // 
            // icMain
            // 
            this.icMain.ImageSize = new System.Drawing.Size(32, 32);
            this.icMain.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icMain.ImageStream")));
            this.icMain.Images.SetKeyName(0, "mailmerge_32x32.png");
            // 
            // nvMain
            // 
            this.nvMain.Icon = ((System.Drawing.Icon)(resources.GetObject("nvMain.Icon")));
            this.nvMain.Text = "Supply Task Manager";
            this.nvMain.Visible = true;
            this.nvMain.DoubleClick += new System.EventHandler(this.nvMain_DoubleClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 723);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmMain.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Supply Sipariş Yönetim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpGenel;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpYonetici;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpKullaniciIslemleri;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem srbTema;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem srbPalet;
        private DevExpress.XtraBars.BarButtonItem btnKullaniciYonetim;
        private DevExpress.XtraBars.BarButtonItem btnDepartmanYonetim;
        private DevExpress.XtraBars.Alerter.AlertControl acMain;
        private System.ComponentModel.BackgroundWorker bgMain;
        private DevExpress.Utils.ImageCollection icMain;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.NotifyIcon nvMain;
        private DevExpress.XtraBars.BarButtonItem btnGizle;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnCariYonetim;
        private DevExpress.XtraBars.BarButtonItem btnStokYonetim;
        private DevExpress.XtraBars.BarButtonItem btnCinsYonetim;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnKaliteYonetim;
        private DevExpress.XtraBars.BarButtonItem btnSiparisGiris;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnDashboardHazirlama;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnRaporHazirlama;
        private DevExpress.XtraBars.BarButtonItem btnCariSiparis;
        private DevExpress.XtraBars.BarButtonItem btnStokSiparis;
        private DevExpress.XtraBars.BarButtonItem btnDashboardGoster;
        private DevExpress.XtraBars.BarButtonItem btnRaporCalistir;
        private DevExpress.XtraBars.BarButtonItem btnSiparisOdeme;
        private DevExpress.XtraBars.BarButtonItem btnEnvanterGiris;
        private DevExpress.XtraBars.BarButtonItem btnEnvanterDurum;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}