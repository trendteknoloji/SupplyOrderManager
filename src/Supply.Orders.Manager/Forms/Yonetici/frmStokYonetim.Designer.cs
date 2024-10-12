namespace Supply.Orders.Manager.Forms.Yonetici
{
    partial class frmStokYonetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokYonetim));
            this.gcMain = new DevExpress.XtraGrid.GridControl();
            this.mdlStokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colkodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcins = new DevExpress.XtraGrid.Columns.GridColumn();
            this.leCins = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colkalite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.leKalite = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colkdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltevkifat = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dlcMain)).BeginInit();
            this.dlcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlcMainRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdlStokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leCins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leKalite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dlcMain
            // 
            this.dlcMain.Controls.Add(this.gcMain);
            this.dlcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(852, 198, 650, 400);
            this.dlcMain.OptionsCustomizationForm.ShowPropertyGrid = true;
            this.dlcMain.OptionsCustomizationForm.SnapMode = ((DevExpress.Utils.Controls.SnapMode)((((DevExpress.Utils.Controls.SnapMode.OwnerControl | DevExpress.Utils.Controls.SnapMode.OwnerForm) 
            | DevExpress.Utils.Controls.SnapMode.Screens) 
            | DevExpress.Utils.Controls.SnapMode.SnapForms)));
            // 
            // dlcMainRoot
            // 
            this.dlcMainRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            // 
            // gcMain
            // 
            this.gcMain.DataSource = this.mdlStokBindingSource;
            this.gcMain.Location = new System.Drawing.Point(7, 7);
            this.gcMain.MainView = this.gvMain;
            this.gcMain.Name = "gcMain";
            this.gcMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.leCins,
            this.leKalite});
            this.gcMain.Size = new System.Drawing.Size(786, 436);
            this.gcMain.TabIndex = 10;
            this.gcMain.UseEmbeddedNavigator = true;
            this.gcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMain});
            // 
            // mdlStokBindingSource
            // 
            this.mdlStokBindingSource.DataSource = typeof(Supply.Orders.Manager.Entity.Models.mdlStok);
            // 
            // gvMain
            // 
            this.gvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colkodu,
            this.coladi,
            this.colcins,
            this.colkalite,
            this.colkdv,
            this.coltevkifat});
            this.gvMain.GridControl = this.gcMain;
            this.gvMain.Name = "gvMain";
            this.gvMain.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gvMain.OptionsCustomization.AllowRowSizing = true;
            this.gvMain.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.gvMain.OptionsCustomization.CustomizationFormSnapMode = ((DevExpress.Utils.Controls.SnapMode)((((DevExpress.Utils.Controls.SnapMode.OwnerControl | DevExpress.Utils.Controls.SnapMode.OwnerForm) 
            | DevExpress.Utils.Controls.SnapMode.Screens) 
            | DevExpress.Utils.Controls.SnapMode.SnapForms)));
            this.gvMain.OptionsEditForm.BindingMode = DevExpress.XtraGrid.Views.Grid.EditFormBindingMode.Direct;
            this.gvMain.OptionsEditForm.FormCaptionFormat = "Kullanıcı Formu";
            this.gvMain.OptionsNavigation.AutoFocusNewRow = true;
            this.gvMain.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvMain.OptionsView.ShowAutoFilterRow = true;
            this.gvMain.OptionsView.ShowChildrenInGroupPanel = true;
            this.gvMain.OptionsView.ShowFooter = true;
            this.gvMain.OptionsView.ShowGroupPanel = false;
            this.gvMain.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.GvMain_RowUpdated);
            // 
            // colkodu
            // 
            this.colkodu.FieldName = "kodu";
            this.colkodu.Name = "colkodu";
            this.colkodu.Visible = true;
            this.colkodu.VisibleIndex = 0;
            // 
            // coladi
            // 
            this.coladi.FieldName = "adi";
            this.coladi.Name = "coladi";
            this.coladi.Visible = true;
            this.coladi.VisibleIndex = 1;
            // 
            // colcins
            // 
            this.colcins.ColumnEdit = this.leCins;
            this.colcins.FieldName = "cins";
            this.colcins.Name = "colcins";
            this.colcins.Visible = true;
            this.colcins.VisibleIndex = 2;
            // 
            // leCins
            // 
            this.leCins.AutoHeight = false;
            this.leCins.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leCins.CaseSensitiveSearch = true;
            this.leCins.DisplayMember = "kodu";
            this.leCins.Name = "leCins";
            // 
            // colkalite
            // 
            this.colkalite.ColumnEdit = this.leKalite;
            this.colkalite.FieldName = "kalite";
            this.colkalite.Name = "colkalite";
            this.colkalite.Visible = true;
            this.colkalite.VisibleIndex = 3;
            // 
            // leKalite
            // 
            this.leKalite.AutoHeight = false;
            this.leKalite.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leKalite.Name = "leKalite";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcMain;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(790, 440);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // colkdv
            // 
            this.colkdv.FieldName = "kdv";
            this.colkdv.Name = "colkdv";
            this.colkdv.Visible = true;
            this.colkdv.VisibleIndex = 4;
            // 
            // coltevkifat
            // 
            this.coltevkifat.FieldName = "tevkifat";
            this.coltevkifat.Name = "coltevkifat";
            this.coltevkifat.Visible = true;
            this.coltevkifat.VisibleIndex = 5;
            // 
            // frmStokYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmStokYonetim.IconOptions.Icon")));
            this.Name = "frmStokYonetim";
            this.Text = "Stok Yönetim";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKaliteYonetim_FormClosed);
            this.Load += new System.EventHandler(this.frmStokYonetim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dlcMain)).EndInit();
            this.dlcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dlcMainRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdlStokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leCins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leKalite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMain;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit leCins;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource mdlStokBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colkodu;
        private DevExpress.XtraGrid.Columns.GridColumn coladi;
        private DevExpress.XtraGrid.Columns.GridColumn colcins;
        private DevExpress.XtraGrid.Columns.GridColumn colkalite;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit leKalite;
        private DevExpress.XtraGrid.Columns.GridColumn colkdv;
        private DevExpress.XtraGrid.Columns.GridColumn coltevkifat;
    }
}