using DevExpress.XtraEditors;
using Supply.Orders.Manager.Entity.Main;
using Supply.Orders.Manager.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supply.Orders.Manager.Forms.Genel
{
    public partial class frmOdeme : frmBase
    {
        SOMContext mainContext = new SOMContext();
        public frmOdeme()
        {
            InitializeComponent();
        }

        private void frmOdeme_Load(object sender, EventArgs e)
        {
            gluFirma.Properties.DataSource = mainContext.Cari.Select(x => new { x.kodu, x.unvan }).ToList();
            gluFirma.Properties.ValueMember = "kodu";
            gluFirma.Properties.DisplayMember = "unvan";
            deOdemeTarih.DateTime = DateTime.Now;
        }

        private void gluFirma_EditValueChanged(object sender, EventArgs e)
        {
            if (gluFirma.EditValue != "" && gluFirma.EditValue != null)
            {
                gluSiparis.Properties.DataSource = mainContext.Siparis.Where(y => y.bagli_cari == gluFirma.EditValue.ToString()).ToList();
                gluSiparis.Properties.ValueMember = "kodu";
            }
        }

        private void txtTutar_EditValueChanged(object sender, EventArgs e)
        {
            YekunHesapla();
        }

        private void txtKur_EditValueChanged(object sender, EventArgs e)
        {
            YekunHesapla();
        }
        public void YekunHesapla()
        {
            double tutar = Convert.ToDouble(txtTutar.EditValue);
            double kur = Convert.ToDouble(txtKur.EditValue);
            txtYekun.EditValue = (tutar * kur);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (gluSiparis.EditValue != null)
            {
                using (SOMContext ctx = new SOMContext())
                {
                    mdlSiparis siparis = ctx.Siparis.Where(x => x.kodu == gluSiparis.Text).FirstOrDefault();
                    ctx.Odeme.Add(new mdlOdeme { tarih = deOdemeTarih.DateTime, bagli_siparis = siparis.GuidNo, birim = txtBirim.Text, tutar = Convert.ToDouble(txtTutar.EditValue), kur_degeri = Convert.ToDouble(txtKur.EditValue), yekun = Convert.ToDouble(txtYekun.EditValue) });
                    ctx.SaveChanges();
                    SiparisOdemeDoldur();
                    XtraMessageBox.Show("Kayıt işlemi başarıyla yapıldı.", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void gluSiparis_EditValueChanged(object sender, EventArgs e)
        {
            SiparisOdemeDoldur();
        }
        public void SiparisOdemeDoldur()
        {
            if (gluSiparis.EditValue != null)
            {
                using (SOMContext ctx = new SOMContext())
                {
                    mdlSiparis siparis = ctx.Siparis.Where(x => x.kodu == gluSiparis.Text).FirstOrDefault();
                    gcOdeme.DataSource = ctx.Odeme.Where(x => x.bagli_siparis == siparis.GuidNo).ToList();
                    double siparis_toplam = ctx.Siparis.Where(x => x.GuidNo == siparis.GuidNo).Sum(y => y.yekun);
                    double odeme_toplam = ctx.Odeme.Where(x => x.bagli_siparis == siparis.GuidNo).Sum(y => y.yekun);
                    txtSiparisToplam.Text = siparis_toplam.ToString("N2");
                    txtOdemeToplam.Text = odeme_toplam.ToString("N2");
                    txtKalanOdeme.Text = (siparis_toplam - odeme_toplam).ToString("N2");
                }
            }
        }
    }
}
