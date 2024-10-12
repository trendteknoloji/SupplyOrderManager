namespace Supply.Orders.Manager.Forms.Genel
{
    partial class frmEnvanterDurum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnvanterDurum));
            this.gcListe = new DevExpress.XtraGrid.GridControl();
            this.gvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnRaporTasarla = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnRaporYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dlcMain)).BeginInit();
            this.dlcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlcMainRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // dlcMain
            // 
            this.dlcMain.Controls.Add(this.btnYazdir);
            this.dlcMain.Controls.Add(this.btnRaporYazdir);
            this.dlcMain.Controls.Add(this.btnExcel);
            this.dlcMain.Controls.Add(this.btnRaporTasarla);
            this.dlcMain.Controls.Add(this.gcListe);
            this.dlcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(852, 198, 650, 400);
            this.dlcMain.OptionsCustomizationForm.ShowPropertyGrid = true;
            this.dlcMain.OptionsCustomizationForm.SnapMode = ((DevExpress.Utils.Controls.SnapMode)((((DevExpress.Utils.Controls.SnapMode.OwnerControl | DevExpress.Utils.Controls.SnapMode.OwnerForm) 
            | DevExpress.Utils.Controls.SnapMode.Screens) 
            | DevExpress.Utils.Controls.SnapMode.SnapForms)));
            this.dlcMain.Size = new System.Drawing.Size(1258, 578);
            // 
            // dlcMainRoot
            // 
            this.dlcMainRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.dlcMainRoot.Size = new System.Drawing.Size(1258, 578);
            // 
            // gcListe
            // 
            this.gcListe.Location = new System.Drawing.Point(7, 47);
            this.gcListe.MainView = this.gvListe;
            this.gcListe.Name = "gcListe";
            this.gcListe.Size = new System.Drawing.Size(1244, 524);
            this.gcListe.TabIndex = 4;
            this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListe});
            // 
            // gvListe
            // 
            this.gvListe.GridControl = this.gcListe;
            this.gvListe.Name = "gvListe";
            this.gvListe.OptionsBehavior.Editable = false;
            this.gvListe.OptionsBehavior.ReadOnly = true;
            this.gvListe.OptionsMenu.EnableGroupRowMenu = true;
            this.gvListe.OptionsMenu.ShowConditionalFormattingItem = true;
            this.gvListe.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gvListe.OptionsView.ShowAutoFilterRow = true;
            this.gvListe.OptionsView.ShowFooter = true;
            this.gvListe.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcListe;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1248, 528);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btnRaporTasarla
            // 
            this.btnRaporTasarla.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRaporTasarla.ImageOptions.SvgImage")));
            this.btnRaporTasarla.Location = new System.Drawing.Point(943, 7);
            this.btnRaporTasarla.Name = "btnRaporTasarla";
            this.btnRaporTasarla.Size = new System.Drawing.Size(308, 36);
            this.btnRaporTasarla.StyleController = this.dlcMain;
            this.btnRaporTasarla.TabIndex = 5;
            this.btnRaporTasarla.Text = "Rapor Tasarla";
            this.btnRaporTasarla.Click += new System.EventHandler(this.btnRaporTasarla_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnRaporTasarla;
            this.layoutControlItem2.Location = new System.Drawing.Point(936, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(312, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // btnExcel
            // 
            this.btnExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExcel.ImageOptions.SvgImage")));
            this.btnExcel.Location = new System.Drawing.Point(7, 7);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(308, 36);
            this.btnExcel.StyleController = this.dlcMain;
            this.btnExcel.TabIndex = 6;
            this.btnExcel.Text = "Excel Aktar";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnExcel;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(312, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // btnRaporYazdir
            // 
            this.btnRaporYazdir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRaporYazdir.ImageOptions.SvgImage")));
            this.btnRaporYazdir.Location = new System.Drawing.Point(631, 7);
            this.btnRaporYazdir.Name = "btnRaporYazdir";
            this.btnRaporYazdir.Size = new System.Drawing.Size(308, 36);
            this.btnRaporYazdir.StyleController = this.dlcMain;
            this.btnRaporYazdir.TabIndex = 7;
            this.btnRaporYazdir.Text = "Rapor Yazdır";
            this.btnRaporYazdir.Click += new System.EventHandler(this.btnRaporYazdir_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnRaporYazdir;
            this.layoutControlItem4.Location = new System.Drawing.Point(624, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(312, 40);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // btnYazdir
            // 
            this.btnYazdir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYazdir.ImageOptions.SvgImage")));
            this.btnYazdir.Location = new System.Drawing.Point(319, 7);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(308, 36);
            this.btnYazdir.StyleController = this.dlcMain;
            this.btnYazdir.TabIndex = 8;
            this.btnYazdir.Text = "Tablo Yazdır";
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnYazdir;
            this.layoutControlItem5.Location = new System.Drawing.Point(312, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(312, 40);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // frmEnvanterDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 578);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmEnvanterDurum.IconOptions.Icon")));
            this.Name = "frmEnvanterDurum";
            this.Text = "Stok Takip";
            this.Load += new System.EventHandler(this.frmEnvanterDurum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dlcMain)).EndInit();
            this.dlcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dlcMainRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListe;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnYazdir;
        private DevExpress.XtraEditors.SimpleButton btnRaporYazdir;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.SimpleButton btnRaporTasarla;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}