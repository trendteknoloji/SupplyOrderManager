namespace Supply.Orders.Manager.Forms.Yonetici
{
    partial class frmCinsYonetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCinsYonetim));
            this.gcMain = new DevExpress.XtraGrid.GridControl();
            this.mdlStokCinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colkodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstok_kod_artikel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.leDepartman = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dlcMain)).BeginInit();
            this.dlcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlcMainRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdlStokCinsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leDepartman)).BeginInit();
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
            this.gcMain.DataSource = this.mdlStokCinsBindingSource;
            this.gcMain.Location = new System.Drawing.Point(7, 7);
            this.gcMain.MainView = this.gvMain;
            this.gcMain.Name = "gcMain";
            this.gcMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.leDepartman});
            this.gcMain.Size = new System.Drawing.Size(786, 436);
            this.gcMain.TabIndex = 8;
            this.gcMain.UseEmbeddedNavigator = true;
            this.gcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMain});
            // 
            // mdlStokCinsBindingSource
            // 
            this.mdlStokCinsBindingSource.DataSource = typeof(Supply.Orders.Manager.Entity.Models.mdlStokCins);
            // 
            // gvMain
            // 
            this.gvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colkodu,
            this.coladi,
            this.colstok_kod_artikel});
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
            // colstok_kod_artikel
            // 
            this.colstok_kod_artikel.FieldName = "stok_kod_artikel";
            this.colstok_kod_artikel.Name = "colstok_kod_artikel";
            this.colstok_kod_artikel.Visible = true;
            this.colstok_kod_artikel.VisibleIndex = 2;
            // 
            // leDepartman
            // 
            this.leDepartman.AutoHeight = false;
            this.leDepartman.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leDepartman.CaseSensitiveSearch = true;
            this.leDepartman.DisplayMember = "kodu";
            this.leDepartman.Name = "leDepartman";
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
            // frmCinsYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmCinsYonetim.IconOptions.Icon")));
            this.Name = "frmCinsYonetim";
            this.Text = "Stok Cins Yönetim";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCinsYonetim_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dlcMain)).EndInit();
            this.dlcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dlcMainRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdlStokCinsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leDepartman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMain;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit leDepartman;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource mdlStokCinsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colkodu;
        private DevExpress.XtraGrid.Columns.GridColumn coladi;
        private DevExpress.XtraGrid.Columns.GridColumn colstok_kod_artikel;
    }
}