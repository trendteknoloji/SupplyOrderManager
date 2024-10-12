using DevExpress.XtraBars.Customization;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Customization;
using Supply.Orders.Manager.Entity.Main;
using Supply.Orders.Manager.Entity.Models;
using Supply.Orders.Manager.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supply.Orders.Manager
{
    public partial class frmBase : XtraForm
    {
        public frmBase()
        {
            InitializeComponent();
            dlcMain.HideCustomization += DlcMain_HideCustomization;
        }

        private void DlcMain_HideCustomization(object sender, EventArgs e)
        {
            MemoryStream st = new System.IO.MemoryStream();
            dlcMain.SaveLayoutToStream(st);
            using (SOMContext ctx = new SOMContext())
            {
                if (AppInstance.User != null)
                {
                    ctx.EkranTasarim.RemoveRange(ctx.EkranTasarim.Where(x => x.form_kodu == this.Text && x.kullanici_kodu == AppInstance.User.kodu));
                    ctx.EkranTasarim.Add(new Entity.Models.mdlEkranTasarim { kullanici_kodu = AppInstance.User.kodu, form_kodu = this.Text, tasarim_icerik = st.ToArray() });
                    ctx.SaveChanges();
                }
            }
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            using (SOMContext ctx = new SOMContext())
            {
                if (AppInstance.User != null)
                {
                    mdlEkranTasarim tasarim = ctx.EkranTasarim.Where(x => x.form_kodu == this.Text && x.kullanici_kodu == AppInstance.User.kodu).FirstOrDefault();
                    if (tasarim != null)
                    {
                        var ms = new MemoryStream(tasarim.tasarim_icerik);
                        dlcMain.RestoreLayoutFromStream(ms);
                    }
                }
            }
        }
    }
}
