namespace Supply.Orders.Manager.Forms.Yonetici
{
    partial class frmDepartman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartman));
            this.gcMain = new DevExpress.XtraGrid.GridControl();
            this.gvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colkodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyetki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRECno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGuidNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTempID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreate_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreate_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collastup_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collastup_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.leDepartman = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dlcMain)).BeginInit();
            this.dlcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlcMainRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).BeginInit();
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
            this.gcMain.Location = new System.Drawing.Point(7, 7);
            this.gcMain.MainView = this.gvMain;
            this.gcMain.Name = "gcMain";
            this.gcMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.leDepartman});
            this.gcMain.Size = new System.Drawing.Size(786, 436);
            this.gcMain.TabIndex = 6;
            this.gcMain.UseEmbeddedNavigator = true;
            this.gcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMain});
            // 
            // gvMain
            // 
            this.gvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colkodu,
            this.coladi,
            this.colyetki,
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
            this.colkodu.Width = 183;
            // 
            // coladi
            // 
            this.coladi.FieldName = "adi";
            this.coladi.Name = "coladi";
            this.coladi.Visible = true;
            this.coladi.VisibleIndex = 1;
            this.coladi.Width = 585;
            // 
            // colyetki
            // 
            this.colyetki.FieldName = "yetki";
            this.colyetki.Name = "colyetki";
            this.colyetki.Visible = true;
            this.colyetki.VisibleIndex = 2;
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
            // frmDepartman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmDepartman.IconOptions.Icon")));
            this.Name = "frmDepartman";
            this.Text = "Departman İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDepartman_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dlcMain)).EndInit();
            this.dlcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dlcMainRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colkodu;
        private DevExpress.XtraGrid.Columns.GridColumn coladi;
        private DevExpress.XtraGrid.Columns.GridColumn colRECno;
        private DevExpress.XtraGrid.Columns.GridColumn colGuidNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTempID;
        private DevExpress.XtraGrid.Columns.GridColumn colcreate_date;
        private DevExpress.XtraGrid.Columns.GridColumn colcreate_user;
        private DevExpress.XtraGrid.Columns.GridColumn collastup_date;
        private DevExpress.XtraGrid.Columns.GridColumn collastup_user;
        private DevExpress.XtraGrid.Columns.GridColumn colyetki;
    }
}