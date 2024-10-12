using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using Supply.Orders.Manager.Entity.Main;
using Supply.Orders.Manager.Forms;
using Supply.Orders.Manager.Forms.UygulamaForm;
using Supply.Orders.Manager.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supply.Orders.Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            if (ConfigurationManager.AppSettings["Tema"].ToString() == "WXI Compact")
            {
                UserLookAndFeel.Default.SetSkinStyle("WXI", ConfigurationManager.AppSettings["Palet"].ToString());
                UserLookAndFeel.ForceCompactUIMode(true, false);
            }
            else
            {
                UserLookAndFeel.Default.SetSkinStyle(ConfigurationManager.AppSettings["Tema"].ToString(), ConfigurationManager.AppSettings["Palet"].ToString());
            }
            

            //using (STContext ctx = new STContext())
            //{
            //    foreach (var item in ctx.Kullanici.ToList())
            //    {
            //        item.lisans_anahtari = item.kodu.Encrypt(AppInstance.Password);
            //    }
            //    ctx.SaveChanges();
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmGirisEkrani());
        }
    }
}
