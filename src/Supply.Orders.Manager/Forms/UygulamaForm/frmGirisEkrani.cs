using DevExpress.XtraEditors;
using Supply.Orders.Manager.Entity.Main;
using Supply.Orders.Manager.Entity.Models;
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

namespace Supply.Orders.Manager.Forms.UygulamaForm
{
    public partial class frmGirisEkrani : frmBase
    {
        public frmGirisEkrani()
        {
            InitializeComponent();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (lueKod.Text != "" && teSifre.Text != "")
            {
                AppInstance.UserSet(lueKod.Text, teSifre.Text);
                if (AppInstance.UserLogin())
                {
                    if (cbHatirla.Checked)
                    {
                        Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                        string kad = config.AppSettings.Settings["Kullanıcı Kodu"].Value;
                        string kpw = config.AppSettings.Settings["Kullanıcı Şifre"].Value;
                        if (kad != "" && kpw != "")
                        {
                            config.AppSettings.Settings["Kullanıcı Kodu"].Value = lueKod.Text;
                            config.AppSettings.Settings["Kullanıcı Şifre"].Value = teSifre.Text.Encrypt(AppInstance.Password);
                        }
                        else
                        {
                            config.AppSettings.Settings.Add("Kullanıcı Kodu", lueKod.Text);
                            config.AppSettings.Settings.Add("Kullanıcı Şifre", teSifre.Text.Encrypt(AppInstance.Password));
                        }
                        config.Save();
                    }
                    frmMain main = new frmMain();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    XtraMessageBox.Show("Kullanıcı için girilen şifre hatalı!\nEğer şifrenizi unuttuysanız yöneticilerinizden yeni şifre talep ediniz.", "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı Kodu ve Şifre bilginizi girmek zorundasınız!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGirisEkrani_Load(object sender, EventArgs e)
        {
            using (SOMContext ctx = new SOMContext())
            {
                if (ctx.Kullanici.Count() == 0)
                {
                    DbCreator();
                }
                else
                {
                    KullaniciDoldur();
                }
            }
        }
        public void DbCreator()
        {
            using (SOMContext ctx = new SOMContext())
            {
                ctx.Departman.Add(new mdlDepartman { kodu = "001", adi = "Favorim Bilişim", yetki = true });
                ctx.Departman.Add(new mdlDepartman { kodu = "002", adi = "Yönetim", yetki = true });
                ctx.Departman.Add(new mdlDepartman { kodu = "003", adi = "Muhasebe", });
                ctx.Departman.Add(new mdlDepartman { kodu = "004", adi = "Finans", });
                ctx.Departman.Add(new mdlDepartman { kodu = "005", adi = "Satınalma", });
                ctx.Departman.Add(new mdlDepartman { kodu = "006", adi = "Satış", });
                ctx.Departman.Add(new mdlDepartman { kodu = "007", adi = "Bilgi İşlem", });
                ctx.Departman.Add(new mdlDepartman { kodu = "008", adi = "Depo", });
                ctx.Departman.Add(new mdlDepartman { kodu = "009", adi = "Pazarlama", });
                ctx.Departman.Add(new mdlDepartman { kodu = "010", adi = "Üretim", });
                ctx.Departman.Add(new mdlDepartman { kodu = "011", adi = "İnsan Kaynakları", });
                ctx.Departman.Add(new mdlDepartman { kodu = "012", adi = "Genel", });
                ctx.Kullanici.Add(new mdlKullanici { kodu = "001", adi = "Metin Oktay", soyadi = "POLAT", sifre = "1121", lisans_anahtari = "001".Encrypt(AppInstance.Password), bagli_departman = "001" });
                ctx.Kullanici.Add(new mdlKullanici { kodu = "002", adi = "Oktay", soyadi = "ÜNLÜVER", sifre = "1121", lisans_anahtari = "002".Encrypt(AppInstance.Password), bagli_departman = "001" });
                ctx.Kullanici.Add(new mdlKullanici { kodu = "003", adi = "Onur", soyadi = "PEKKAN", sifre = "1121", lisans_anahtari = "003".Encrypt(AppInstance.Password), bagli_departman = "001" });
                ctx.Kullanici.Add(new mdlKullanici { kodu = "004", adi = "Gökhan", soyadi = "AYKAN", sifre = "1121", lisans_anahtari = "004".Encrypt(AppInstance.Password), bagli_departman = "001" });
                ctx.SaveChanges();
                KullaniciDoldur();
            }
        }
        public void KullaniciDoldur()
        {
            using (SOMContext ctx = new SOMContext())
            {
                lueKod.Properties.DataSource = ctx.Kullanici.Select(x => new { x.kodu, x.adi, x.soyadi }).ToList();
                lueKod.Properties.DisplayMember = "kodu";
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                string kad = config.AppSettings.Settings["Kullanıcı Kodu"].Value;
                string kpw = config.AppSettings.Settings["Kullanıcı Şifre"].Value;
                if (kad != "" && kpw != "")
                {
                    lueKod.Text = kad;
                    teSifre.Text = kpw.Decrypt(AppInstance.Password);
                }
            }
        }
    }
}
