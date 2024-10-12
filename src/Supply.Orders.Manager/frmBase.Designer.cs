namespace Supply.Orders.Manager
{
    partial class frmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
            this.dlcMain = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.dlcMainRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dlcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlcMainRoot)).BeginInit();
            this.SuspendLayout();
            // 
            // dlcMain
            // 
            this.dlcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dlcMain.Location = new System.Drawing.Point(0, 0);
            this.dlcMain.Name = "dlcMain";
            this.dlcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(852, 198, 650, 400);
            this.dlcMain.OptionsCustomizationForm.ShowPropertyGrid = true;
            this.dlcMain.OptionsCustomizationForm.SnapMode = ((DevExpress.Utils.Controls.SnapMode)((((DevExpress.Utils.Controls.SnapMode.OwnerControl | DevExpress.Utils.Controls.SnapMode.OwnerForm) 
            | DevExpress.Utils.Controls.SnapMode.Screens) 
            | DevExpress.Utils.Controls.SnapMode.SnapForms)));
            this.dlcMain.Root = this.dlcMainRoot;
            this.dlcMain.Size = new System.Drawing.Size(800, 450);
            this.dlcMain.TabIndex = 0;
            this.dlcMain.Text = "MainLayout";
            // 
            // dlcMainRoot
            // 
            this.dlcMainRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.dlcMainRoot.GroupBordersVisible = false;
            this.dlcMainRoot.Name = "Root";
            this.dlcMainRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.dlcMainRoot.Size = new System.Drawing.Size(800, 450);
            this.dlcMainRoot.Text = "Main Layout Root";
            this.dlcMainRoot.TextVisible = false;
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dlcMain);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmBase.IconOptions.Icon")));
            this.Name = "frmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBase";
            this.Load += new System.EventHandler(this.frmBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dlcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlcMainRoot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraDataLayout.DataLayoutControl dlcMain;
        public DevExpress.XtraLayout.LayoutControlGroup dlcMainRoot;
    }
}