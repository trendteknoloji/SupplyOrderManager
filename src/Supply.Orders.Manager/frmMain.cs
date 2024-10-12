using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Supply.Orders.Manager.Entity.Main;
using Supply.Orders.Manager.Entity.Models;
using Supply.Orders.Manager.Forms.Genel;
using Supply.Orders.Manager.Forms.Yonetici;
using Supply.Orders.Manager.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supply.Orders.Manager
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            Timer tmr = new Timer();
            tmr.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["Görev Kontrol Süresi"].ToString()) * 1000;
            tmr.Start();
            tmr.Tick += Tmr_Tick;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {

        }

        private void srbPalet_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(System.Windows.Forms.Application.ExecutablePath);
            config.AppSettings.Settings["Palet"].Value = e.Item.Caption;
            config.Save();
        }

        private void srbTema_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(System.Windows.Forms.Application.ExecutablePath);
            config.AppSettings.Settings["Tema"].Value = e.Item.Caption;
            config.Save();
        }

        private void btnKullaniciYonetim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKullanici form = new frmKullanici();
            form.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDepartmanYonetim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDepartman form = new frmDepartman();
            form.Show();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            using (SOMContext ctx = new SOMContext())
            {
                mdlDepartman departman = ctx.Departman.Where(x => x.kodu == AppInstance.User.bagli_departman).FirstOrDefault();
                if (!departman.yetki)
                {
                    rpYonetici.Visible = false;
                }
            }

        }

        private void acMain_AlertClick(object sender, DevExpress.XtraBars.Alerter.AlertClickEventArgs e)
        {
            e.AlertForm.Close();
        }

        private void acMain_ButtonClick(object sender, DevExpress.XtraBars.Alerter.AlertButtonClickEventArgs e)
        {
        }

        private void acMain_BeforeFormShow(object sender, DevExpress.XtraBars.Alerter.AlertFormEventArgs e)
        {
            e.AlertForm.Size = new Size(400, 200);
        }



        private void btnGizle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nvMain.Visible = true;
            this.Hide();
        }

        private void nvMain_DoubleClick(object sender, EventArgs e)
        {
            nvMain.Visible = false;
            this.Show();
        }

        private void btnCariYonetim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCariYonetim form = new frmCariYonetim();
            form.Show();
        }

        private void btnCinsYonetim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCinsYonetim form = new frmCinsYonetim();
            form.Show();
        }

        private void btnKaliteYonetim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKaliteYonetim form = new frmKaliteYonetim();
            form.Show();
        }

        private void btnStokYonetim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStokYonetim form = new frmStokYonetim();
            form.Show();
        }

        private void btnSiparisGiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSiparisGiris form = new frmSiparisGiris();
            form.Show();
        }

        private void btnDashboardHazirlama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDashboardHazirlama form = new frmDashboardHazirlama();
            form.Show();
        }

        private void btnRaporHazirlama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRaporHazirlama form = new frmRaporHazirlama();
            form.Show();
        }

        private void btnDashboardGoster_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Dashboard Dosyası |*.xml";
            ofd.InitialDirectory = string.Format("{0}\\Dashboard", Application.StartupPath);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName != "")
                {
                    frmDashboardGoster frm = new frmDashboardGoster(ofd.FileName);
                    frm.Show();
                }
            }
        }

        private void btnRaporCalistir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Rapor Dosyası |*.repx";
            ofd.InitialDirectory = string.Format("{0}\\Raporlar", Application.StartupPath);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName != "")
                {
                    XtraReport report = XtraReport.FromFile(ofd.FileName);
                    report.ShowRibbonPreview();
                }
            }
        }

        private void btnSiparisOdeme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOdeme form = new frmOdeme();
            form.Show();
        }

        private void btnCariSiparis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCariSiparisListesi form = new frmCariSiparisListesi();
            form.Show();
        }

        private void btnStokSiparis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStokSiparisListesi form = new frmStokSiparisListesi();
            form.Show();

        }

        private void btnEnvanterGiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEnvanterGiris form = new frmEnvanterGiris();
            form.Show();
        }

        private void btnEnvanterDurum_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEnvanterDurum form = new frmEnvanterDurum();
            form.Show();
        }
    }
}
