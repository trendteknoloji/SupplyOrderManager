namespace Supply.Orders.Manager.Forms.Genel
{
    partial class frmCariSiparisListesi
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariSiparisListesi));
            this.gvOdemeListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltarih1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltutar1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirim1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkur_degeri1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyekun1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcListe = new DevExpress.XtraGrid.GridControl();
            this.mdlSiparisOdemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbagli_stok_cins = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbagli_stok_kalite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbagli_stok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkalinlik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgenislik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colboy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagirlik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkur_degeri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltevkifat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyekun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gluFirma = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gluvFirma = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lcgFirma = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnRaporYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnListeYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnRaporTasarla = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSeciliSatirYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dlcMain)).BeginInit();
            this.dlcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlcMainRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOdemeListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdlSiparisOdemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluFirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluvFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // dlcMain
            // 
            this.dlcMain.Controls.Add(this.btnSeciliSatirYazdir);
            this.dlcMain.Controls.Add(this.btnRaporTasarla);
            this.dlcMain.Controls.Add(this.btnListeYazdir);
            this.dlcMain.Controls.Add(this.btnRaporYazdir);
            this.dlcMain.Controls.Add(this.gcListe);
            this.dlcMain.Controls.Add(this.gluFirma);
            this.dlcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(852, 198, 650, 400);
            this.dlcMain.OptionsCustomizationForm.ShowPropertyGrid = true;
            this.dlcMain.OptionsCustomizationForm.SnapMode = ((DevExpress.Utils.Controls.SnapMode)((((DevExpress.Utils.Controls.SnapMode.OwnerControl | DevExpress.Utils.Controls.SnapMode.OwnerForm) 
            | DevExpress.Utils.Controls.SnapMode.Screens) 
            | DevExpress.Utils.Controls.SnapMode.SnapForms)));
            // 
            // dlcMainRoot
            // 
            this.dlcMainRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgFirma,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            // 
            // gvOdemeListe
            // 
            this.gvOdemeListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltarih1,
            this.coltutar1,
            this.colbirim1,
            this.colkur_degeri1,
            this.colyekun1});
            this.gvOdemeListe.GridControl = this.gcListe;
            this.gvOdemeListe.Name = "gvOdemeListe";
            // 
            // coltarih1
            // 
            this.coltarih1.FieldName = "tarih";
            this.coltarih1.Name = "coltarih1";
            this.coltarih1.Visible = true;
            this.coltarih1.VisibleIndex = 0;
            // 
            // coltutar1
            // 
            this.coltutar1.DisplayFormat.FormatString = "n2";
            this.coltutar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltutar1.FieldName = "tutar";
            this.coltutar1.Name = "coltutar1";
            this.coltutar1.Visible = true;
            this.coltutar1.VisibleIndex = 1;
            // 
            // colbirim1
            // 
            this.colbirim1.FieldName = "birim";
            this.colbirim1.Name = "colbirim1";
            this.colbirim1.Visible = true;
            this.colbirim1.VisibleIndex = 2;
            // 
            // colkur_degeri1
            // 
            this.colkur_degeri1.DisplayFormat.FormatString = "n2";
            this.colkur_degeri1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colkur_degeri1.FieldName = "kur_degeri";
            this.colkur_degeri1.Name = "colkur_degeri1";
            this.colkur_degeri1.Visible = true;
            this.colkur_degeri1.VisibleIndex = 3;
            // 
            // colyekun1
            // 
            this.colyekun1.DisplayFormat.FormatString = "n2";
            this.colyekun1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colyekun1.FieldName = "yekun";
            this.colyekun1.Name = "colyekun1";
            this.colyekun1.Visible = true;
            this.colyekun1.VisibleIndex = 4;
            // 
            // gcListe
            // 
            this.gcListe.DataSource = this.mdlSiparisOdemeBindingSource;
            gridLevelNode1.LevelTemplate = this.gvOdemeListe;
            gridLevelNode1.RelationName = "OdemeListesi";
            this.gcListe.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcListe.Location = new System.Drawing.Point(7, 71);
            this.gcListe.MainView = this.gvListe;
            this.gcListe.Name = "gcListe";
            this.gcListe.Size = new System.Drawing.Size(786, 372);
            this.gcListe.TabIndex = 16;
            this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListe,
            this.gvOdemeListe});
            // 
            // mdlSiparisOdemeBindingSource
            // 
            this.mdlSiparisOdemeBindingSource.DataSource = typeof(Supply.Orders.Manager.Entity.NotDbModels.mdlSiparisOdeme);
            // 
            // gvListe
            // 
            this.gvListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltarih,
            this.colbagli_stok_cins,
            this.colbagli_stok_kalite,
            this.colbagli_stok,
            this.colkalinlik,
            this.colgenislik,
            this.colboy,
            this.colagirlik,
            this.colfiyat,
            this.colbirim,
            this.colkur_degeri,
            this.colvade,
            this.coltutar,
            this.colkdv,
            this.coltevkifat,
            this.colyekun});
            this.gvListe.GridControl = this.gcListe;
            this.gvListe.Name = "gvListe";
            this.gvListe.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gvListe.OptionsPrint.EnableAppearanceOddRow = true;
            this.gvListe.OptionsPrint.ExpandAllDetails = true;
            this.gvListe.OptionsPrint.PrintDetails = true;
            this.gvListe.OptionsPrint.PrintFilterInfo = true;
            this.gvListe.OptionsPrint.PrintFixedColumnsOnEveryPage = true;
            this.gvListe.OptionsPrint.PrintPreview = true;
            this.gvListe.OptionsView.ShowAutoFilterRow = true;
            this.gvListe.OptionsView.ShowFooter = true;
            this.gvListe.OptionsView.ShowGroupPanel = false;
            // 
            // coltarih
            // 
            this.coltarih.FieldName = "tarih";
            this.coltarih.Name = "coltarih";
            this.coltarih.Visible = true;
            this.coltarih.VisibleIndex = 0;
            // 
            // colbagli_stok_cins
            // 
            this.colbagli_stok_cins.FieldName = "bagli_stok_cins";
            this.colbagli_stok_cins.Name = "colbagli_stok_cins";
            this.colbagli_stok_cins.Visible = true;
            this.colbagli_stok_cins.VisibleIndex = 1;
            // 
            // colbagli_stok_kalite
            // 
            this.colbagli_stok_kalite.FieldName = "bagli_stok_kalite";
            this.colbagli_stok_kalite.Name = "colbagli_stok_kalite";
            this.colbagli_stok_kalite.Visible = true;
            this.colbagli_stok_kalite.VisibleIndex = 2;
            // 
            // colbagli_stok
            // 
            this.colbagli_stok.FieldName = "bagli_stok";
            this.colbagli_stok.Name = "colbagli_stok";
            this.colbagli_stok.Visible = true;
            this.colbagli_stok.VisibleIndex = 3;
            // 
            // colkalinlik
            // 
            this.colkalinlik.FieldName = "kalinlik";
            this.colkalinlik.Name = "colkalinlik";
            this.colkalinlik.Visible = true;
            this.colkalinlik.VisibleIndex = 4;
            // 
            // colgenislik
            // 
            this.colgenislik.FieldName = "genislik";
            this.colgenislik.Name = "colgenislik";
            this.colgenislik.Visible = true;
            this.colgenislik.VisibleIndex = 5;
            // 
            // colboy
            // 
            this.colboy.FieldName = "boy";
            this.colboy.Name = "colboy";
            this.colboy.Visible = true;
            this.colboy.VisibleIndex = 6;
            // 
            // colagirlik
            // 
            this.colagirlik.FieldName = "agirlik";
            this.colagirlik.Name = "colagirlik";
            this.colagirlik.Visible = true;
            this.colagirlik.VisibleIndex = 7;
            // 
            // colfiyat
            // 
            this.colfiyat.FieldName = "fiyat";
            this.colfiyat.Name = "colfiyat";
            this.colfiyat.Visible = true;
            this.colfiyat.VisibleIndex = 8;
            // 
            // colbirim
            // 
            this.colbirim.FieldName = "birim";
            this.colbirim.Name = "colbirim";
            this.colbirim.Visible = true;
            this.colbirim.VisibleIndex = 9;
            // 
            // colkur_degeri
            // 
            this.colkur_degeri.FieldName = "kur_degeri";
            this.colkur_degeri.Name = "colkur_degeri";
            this.colkur_degeri.Visible = true;
            this.colkur_degeri.VisibleIndex = 10;
            // 
            // colvade
            // 
            this.colvade.FieldName = "vade";
            this.colvade.Name = "colvade";
            this.colvade.Visible = true;
            this.colvade.VisibleIndex = 11;
            // 
            // coltutar
            // 
            this.coltutar.FieldName = "tutar";
            this.coltutar.Name = "coltutar";
            this.coltutar.Visible = true;
            this.coltutar.VisibleIndex = 12;
            // 
            // colkdv
            // 
            this.colkdv.FieldName = "kdv";
            this.colkdv.Name = "colkdv";
            this.colkdv.Visible = true;
            this.colkdv.VisibleIndex = 13;
            // 
            // coltevkifat
            // 
            this.coltevkifat.FieldName = "tevkifat";
            this.coltevkifat.Name = "coltevkifat";
            this.coltevkifat.Visible = true;
            this.coltevkifat.VisibleIndex = 14;
            // 
            // colyekun
            // 
            this.colyekun.FieldName = "yekun";
            this.colyekun.Name = "colyekun";
            this.colyekun.Visible = true;
            this.colyekun.VisibleIndex = 15;
            // 
            // gluFirma
            // 
            this.gluFirma.Location = new System.Drawing.Point(45, 7);
            this.gluFirma.Name = "gluFirma";
            this.gluFirma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gluFirma.Properties.PopupView = this.gluvFirma;
            this.gluFirma.Size = new System.Drawing.Size(748, 20);
            this.gluFirma.StyleController = this.dlcMain;
            this.gluFirma.TabIndex = 15;
            this.gluFirma.EditValueChanged += new System.EventHandler(this.gluFirma_EditValueChanged);
            // 
            // gluvFirma
            // 
            this.gluvFirma.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gluvFirma.Name = "gluvFirma";
            this.gluvFirma.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gluvFirma.OptionsView.ShowGroupPanel = false;
            // 
            // lcgFirma
            // 
            this.lcgFirma.Control = this.gluFirma;
            this.lcgFirma.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lcgFirma.CustomizationFormText = "Firma";
            this.lcgFirma.Location = new System.Drawing.Point(0, 0);
            this.lcgFirma.Name = "lcgFirma";
            this.lcgFirma.Size = new System.Drawing.Size(790, 24);
            this.lcgFirma.Text = "Firma";
            this.lcgFirma.TextSize = new System.Drawing.Size(26, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcListe;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 64);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(790, 376);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btnRaporYazdir
            // 
            this.btnRaporYazdir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRaporYazdir.ImageOptions.SvgImage")));
            this.btnRaporYazdir.Location = new System.Drawing.Point(599, 31);
            this.btnRaporYazdir.Name = "btnRaporYazdir";
            this.btnRaporYazdir.Size = new System.Drawing.Size(194, 36);
            this.btnRaporYazdir.StyleController = this.dlcMain;
            this.btnRaporYazdir.TabIndex = 17;
            this.btnRaporYazdir.Text = "Rapor Yazdır";
            this.btnRaporYazdir.Click += new System.EventHandler(this.btnRaporYazdir_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnRaporYazdir;
            this.layoutControlItem2.Location = new System.Drawing.Point(592, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(198, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // btnListeYazdir
            // 
            this.btnListeYazdir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnListeYazdir.ImageOptions.SvgImage")));
            this.btnListeYazdir.Location = new System.Drawing.Point(7, 31);
            this.btnListeYazdir.Name = "btnListeYazdir";
            this.btnListeYazdir.Size = new System.Drawing.Size(193, 36);
            this.btnListeYazdir.StyleController = this.dlcMain;
            this.btnListeYazdir.TabIndex = 18;
            this.btnListeYazdir.Text = "Listeyi Yazdır";
            this.btnListeYazdir.Click += new System.EventHandler(this.btnListeYazdir_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnListeYazdir;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(197, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // btnRaporTasarla
            // 
            this.btnRaporTasarla.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRaporTasarla.ImageOptions.SvgImage")));
            this.btnRaporTasarla.Location = new System.Drawing.Point(402, 31);
            this.btnRaporTasarla.Name = "btnRaporTasarla";
            this.btnRaporTasarla.Size = new System.Drawing.Size(193, 36);
            this.btnRaporTasarla.StyleController = this.dlcMain;
            this.btnRaporTasarla.TabIndex = 19;
            this.btnRaporTasarla.Text = "Rapor Tasarla";
            this.btnRaporTasarla.Click += new System.EventHandler(this.btnRaporTasarla_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnRaporTasarla;
            this.layoutControlItem4.Location = new System.Drawing.Point(395, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(197, 40);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // btnSeciliSatirYazdir
            // 
            this.btnSeciliSatirYazdir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSeciliSatirYazdir.ImageOptions.SvgImage")));
            this.btnSeciliSatirYazdir.Location = new System.Drawing.Point(204, 31);
            this.btnSeciliSatirYazdir.Name = "btnSeciliSatirYazdir";
            this.btnSeciliSatirYazdir.Size = new System.Drawing.Size(194, 36);
            this.btnSeciliSatirYazdir.StyleController = this.dlcMain;
            this.btnSeciliSatirYazdir.TabIndex = 20;
            this.btnSeciliSatirYazdir.Text = "Seçili Siparişi Yazdır";
            this.btnSeciliSatirYazdir.Click += new System.EventHandler(this.btnSeciliSatirYazdir_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnSeciliSatirYazdir;
            this.layoutControlItem5.Location = new System.Drawing.Point(197, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(198, 40);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // frmCariSiparisListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmCariSiparisListesi.IconOptions.Icon")));
            this.Name = "frmCariSiparisListesi";
            this.Text = "Cari Sipariş ve Ödeme Listesi";
            this.Load += new System.EventHandler(this.frmCariSiparisListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dlcMain)).EndInit();
            this.dlcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dlcMainRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOdemeListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdlSiparisOdemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluFirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluvFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit gluFirma;
        private DevExpress.XtraGrid.Views.Grid.GridView gluvFirma;
        private DevExpress.XtraLayout.LayoutControlItem lcgFirma;
        private DevExpress.XtraGrid.GridControl gcListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListe;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource mdlSiparisOdemeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coltarih;
        private DevExpress.XtraGrid.Columns.GridColumn colbagli_stok_cins;
        private DevExpress.XtraGrid.Columns.GridColumn colbagli_stok_kalite;
        private DevExpress.XtraGrid.Columns.GridColumn colbagli_stok;
        private DevExpress.XtraGrid.Columns.GridColumn colkalinlik;
        private DevExpress.XtraGrid.Columns.GridColumn colgenislik;
        private DevExpress.XtraGrid.Columns.GridColumn colboy;
        private DevExpress.XtraGrid.Columns.GridColumn colagirlik;
        private DevExpress.XtraGrid.Columns.GridColumn colfiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colbirim;
        private DevExpress.XtraGrid.Columns.GridColumn colkur_degeri;
        private DevExpress.XtraGrid.Columns.GridColumn colvade;
        private DevExpress.XtraGrid.Columns.GridColumn coltutar;
        private DevExpress.XtraGrid.Columns.GridColumn colkdv;
        private DevExpress.XtraGrid.Columns.GridColumn coltevkifat;
        private DevExpress.XtraGrid.Columns.GridColumn colyekun;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOdemeListe;
        private DevExpress.XtraGrid.Columns.GridColumn coltarih1;
        private DevExpress.XtraGrid.Columns.GridColumn coltutar1;
        private DevExpress.XtraGrid.Columns.GridColumn colbirim1;
        private DevExpress.XtraGrid.Columns.GridColumn colkur_degeri1;
        private DevExpress.XtraGrid.Columns.GridColumn colyekun1;
        private DevExpress.XtraEditors.SimpleButton btnSeciliSatirYazdir;
        private DevExpress.XtraEditors.SimpleButton btnRaporTasarla;
        private DevExpress.XtraEditors.SimpleButton btnListeYazdir;
        private DevExpress.XtraEditors.SimpleButton btnRaporYazdir;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}