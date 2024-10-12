namespace Supply.Orders.Manager.Forms.Yonetici
{
    partial class frmKullanici
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
            this.gcMain = new DevExpress.XtraGrid.GridControl();
            this.gvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colkodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsifre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collisans_anahtari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbagli_departman = new DevExpress.XtraGrid.Columns.GridColumn();
            this.leDepartman = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colRECno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGuidNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTempID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreate_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreate_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collastup_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collastup_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.dlcMain)).BeginInit();
            this.dlcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlcMainRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leDepartman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dlcMain
            // 
            this.dlcMain.Controls.Add(this.gcMain);
            this.dlcMain.DataSource = typeof(Supply.Orders.Manager.Entity.Models.mdlKullanici);
            this.dlcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(852, 198, 650, 400);
            this.dlcMain.OptionsCustomizationForm.ShowPropertyGrid = true;
            this.dlcMain.OptionsCustomizationForm.SnapMode = ((DevExpress.Utils.Controls.SnapMode)((((DevExpress.Utils.Controls.SnapMode.OwnerControl | DevExpress.Utils.Controls.SnapMode.OwnerForm) 
            | DevExpress.Utils.Controls.SnapMode.Screens) 
            | DevExpress.Utils.Controls.SnapMode.SnapForms)));
            // 
            // dlcMainRoot
            // 
            this.dlcMainRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem1});
            // 
            // gcMain
            // 
            this.gcMain.Location = new System.Drawing.Point(7, 7);
            this.gcMain.MainView = this.gvMain;
            this.gcMain.Name = "gcMain";
            this.gcMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.leDepartman});
            this.gcMain.Size = new System.Drawing.Size(786, 404);
            this.gcMain.TabIndex = 5;
            this.gcMain.UseEmbeddedNavigator = true;
            this.gcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMain});
            // 
            // gvMain
            // 
            this.gvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colkodu,
            this.coladi,
            this.colsoyadi,
            this.colsifre,
            this.collisans_anahtari,
            this.colbagli_departman,
            this.colRECno,
            this.colGuidNo,
            this.colTempID,
            this.colcreate_date,
            this.colcreate_user,
            this.collastup_date,
            this.collastup_user});
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
            this.gvMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvMain.OptionsView.ShowAutoFilterRow = true;
            this.gvMain.OptionsView.ShowChildrenInGroupPanel = true;
            this.gvMain.OptionsView.ShowFooter = true;
            this.gvMain.OptionsView.ShowGroupPanel = false;
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
            // colsoyadi
            // 
            this.colsoyadi.FieldName = "soyadi";
            this.colsoyadi.Name = "colsoyadi";
            this.colsoyadi.Visible = true;
            this.colsoyadi.VisibleIndex = 2;
            // 
            // colsifre
            // 
            this.colsifre.FieldName = "sifre";
            this.colsifre.Name = "colsifre";
            this.colsifre.Visible = true;
            this.colsifre.VisibleIndex = 3;
            // 
            // collisans_anahtari
            // 
            this.collisans_anahtari.FieldName = "lisans_anahtari";
            this.collisans_anahtari.Name = "collisans_anahtari";
            this.collisans_anahtari.Visible = true;
            this.collisans_anahtari.VisibleIndex = 4;
            // 
            // colbagli_departman
            // 
            this.colbagli_departman.ColumnEdit = this.leDepartman;
            this.colbagli_departman.FieldName = "bagli_departman";
            this.colbagli_departman.Name = "colbagli_departman";
            this.colbagli_departman.Visible = true;
            this.colbagli_departman.VisibleIndex = 5;
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
            // colRECno
            // 
            this.colRECno.FieldName = "RECno";
            this.colRECno.Name = "colRECno";
            // 
            // colGuidNo
            // 
            this.colGuidNo.FieldName = "GuidNo";
            this.colGuidNo.Name = "colGuidNo";
            // 
            // colTempID
            // 
            this.colTempID.FieldName = "TempID";
            this.colTempID.Name = "colTempID";
            // 
            // colcreate_date
            // 
            this.colcreate_date.FieldName = "create_date";
            this.colcreate_date.Name = "colcreate_date";
            // 
            // colcreate_user
            // 
            this.colcreate_user.FieldName = "create_user";
            this.colcreate_user.Name = "colcreate_user";
            // 
            // collastup_date
            // 
            this.collastup_date.FieldName = "lastup_date";
            this.collastup_date.Name = "collastup_date";
            // 
            // collastup_user
            // 
            this.collastup_user.FieldName = "lastup_user";
            this.collastup_user.Name = "collastup_user";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcMain;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(790, 408);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 408);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(790, 32);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmKullanici";
            this.Text = "Kullanıcı İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKullanici_FormClosed);
            this.Load += new System.EventHandler(this.frmKullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dlcMain)).EndInit();
            this.dlcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dlcMainRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leDepartman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMain;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colkodu;
        private DevExpress.XtraGrid.Columns.GridColumn coladi;
        private DevExpress.XtraGrid.Columns.GridColumn colsoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colsifre;
        private DevExpress.XtraGrid.Columns.GridColumn collisans_anahtari;
        private DevExpress.XtraGrid.Columns.GridColumn colbagli_departman;
        private DevExpress.XtraGrid.Columns.GridColumn colRECno;
        private DevExpress.XtraGrid.Columns.GridColumn colGuidNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTempID;
        private DevExpress.XtraGrid.Columns.GridColumn colcreate_date;
        private DevExpress.XtraGrid.Columns.GridColumn colcreate_user;
        private DevExpress.XtraGrid.Columns.GridColumn collastup_date;
        private DevExpress.XtraGrid.Columns.GridColumn collastup_user;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit leDepartman;
    }
}