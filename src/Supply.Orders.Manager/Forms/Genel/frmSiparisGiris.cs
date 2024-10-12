using DevExpress.XtraEditors;
using Supply.Orders.Manager.Entity.Main;
using Supply.Orders.Manager.Entity.Models;
using Supply.Orders.Manager.Helpers;
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
    public partial class frmSiparisGiris : frmBase
    {
        SOMContext mainContext = new SOMContext();
        public frmSiparisGiris()
        {
            InitializeComponent();
        }

        private void frmSiparis_Load(object sender, EventArgs e)
        {
            gluSCins.Properties.DataSource = mainContext.SCins.Select(x => new { x.kodu, x.adi }).ToList();
            gluSCins.Properties.ValueMember = "kodu";
            gluSCins.Properties.DisplayMember = "adi";
            gluSKalite.Properties.DataSource = mainContext.SKalite.Select(x => new { x.kodu, x.adi }).ToList();
            gluSKalite.Properties.ValueMember = "kodu";
            gluSKalite.Properties.DisplayMember = "adi";
            gluFirma.Properties.DataSource = mainContext.Cari.Select(x => new { x.kodu, x.unvan }).ToList();
            gluFirma.Properties.ValueMember = "kodu";
            gluFirma.Properties.DisplayMember = "unvan";
            deSiparisTarih.DateTime = DateTime.Now;

        }

        private void gluSCins_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (gluSCins.EditValue != null && gluSKalite.EditValue != null)
                {
                    //string stok_sira = (mainContext.Stok.Count() + 1).ToString().PadLeft(7, '0');
                    //string cinsArtikel = mainContext.SCins.Where(x => x.kodu == gluSCins.EditValue.ToString()).FirstOrDefault().stok_kod_artikel;
                    //string kaliteArtikel = mainContext.SKalite.Where(x => x.kodu == gluSKalite.EditValue.ToString()).FirstOrDefault().stok_kod_artikel;
                    //gluSKalite.Enabled = true;

                    string cinsArtikel = mainContext.SCins.Where(x => x.kodu == gluSCins.EditValue.ToString()).FirstOrDefault().stok_kod_artikel;
                    string kaliteArtikel = mainContext.SKalite.Where(x => x.kodu == gluSKalite.EditValue.ToString()).FirstOrDefault().stok_kod_artikel;
                    txtStokIsmi.Text = string.Format("{0} {1}", cinsArtikel, kaliteArtikel);
                    gluSKalite.Enabled = true;
                }
            }
            catch (Exception Ex)
            {
                ExceptionHelpers.ErrorRegister(Ex);
            }
        }
        private void gluSKalite_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (gluSCins.EditValue != null && gluSKalite.EditValue != null)
                {
                    //string stok_sira = (mainContext.Stok.Count() + 1).ToString().PadLeft(7, '0');
                    string cinsArtikel = mainContext.SCins.Where(x => x.kodu == gluSCins.EditValue.ToString()).FirstOrDefault().stok_kod_artikel;
                    string kaliteArtikel = mainContext.SKalite.Where(x => x.kodu == gluSKalite.EditValue.ToString()).FirstOrDefault().stok_kod_artikel;
                    txtStokIsmi.Text = string.Format("{0} {1}", cinsArtikel, kaliteArtikel);
                    gluSKalite.Enabled = true;
                }
            }
            catch (Exception Ex)
            {
                ExceptionHelpers.ErrorRegister(Ex);
            }
        }
        private void txtAgirlik_EditValueChanged(object sender, EventArgs e)
        {
            if (txtFiyat.Text != "" && txtAgirlik.Text != "" && txtKur.Text != "")
            {
                TutarHesapla();
            }
        }

        private void txtFiyat_EditValueChanged(object sender, EventArgs e)
        {
            if (txtFiyat.Text != "" && txtAgirlik.Text != "" && txtKur.Text != "")
            {
                TutarHesapla();
            }
        }
        private void txtKur_EditValueChanged(object sender, EventArgs e)
        {
            if (txtFiyat.Text != "" && txtAgirlik.Text != "" && txtKur.Text != "")
            {
                TutarHesapla();
            }
        }
        private void txtTutar_EditValueChanged(object sender, EventArgs e)
        {
            if (txtFiyat.Text != "" && txtAgirlik.Text != "" && txtKur.Text != "" && txtTutar.Text != "" && txtKdv.Text != "" && txtKdvOran.Text != "" && txtTevkifat.Text != "" && txtTevkifatOran.Text != "")
            {
                YekunHesapla();
            }
        }
        private void txtKdvOran_EditValueChanged(object sender, EventArgs e)
        {
            if (txtFiyat.Text != "" && txtAgirlik.Text != "" && txtKur.Text != "" && txtTutar.Text != "" && txtKdv.Text != "" && txtKdvOran.Text != "" && txtTevkifat.Text != "" && txtTevkifatOran.Text != "")
            {
                KdvHesapla();
                YekunHesapla();
            }
        }
        private void txtTevkifatOran_EditValueChanged(object sender, EventArgs e)
        {
            if (txtFiyat.Text != "" && txtAgirlik.Text != "" && txtKur.Text != "" && txtTutar.Text != "" && txtKdv.Text != "" && txtKdvOran.Text != "" && txtTevkifat.Text != "" && txtTevkifatOran.Text != "")
            {
                TevkifatHesapla();
                YekunHesapla();
            }
        }
        private void txtKdv_EditValueChanged(object sender, EventArgs e)
        {
            if (txtFiyat.Text != "" && txtAgirlik.Text != "" && txtKur.Text != "" && txtTutar.Text != "" && txtKdv.Text != "" && txtKdvOran.Text != "" && txtTevkifat.Text != "" && txtTevkifatOran.Text != "")
            {
                YekunHesapla();
            }
        }

        private void txtTevkifat_EditValueChanged(object sender, EventArgs e)
        {
            if (txtFiyat.Text != "" && txtAgirlik.Text != "" && txtKur.Text != "" && txtTutar.Text != "" && txtKdv.Text != "" && txtKdvOran.Text != "" && txtTevkifat.Text != "" && txtTevkifatOran.Text != "")
            {
                YekunHesapla();
            }
        }
        private void btnKdvEkle_Click(object sender, EventArgs e)
        {
            KdvHesapla();
        }

        private void btnTevkifatEkle_Click(object sender, EventArgs e)
        {
            TevkifatHesapla();
        }
        public void TutarHesapla()
        {
            try
            {
                double agirlik = Convert.ToDouble(txtAgirlik.EditValue);
                double fiyat = Convert.ToDouble(txtFiyat.EditValue);
                double kur = Convert.ToDouble(txtKur.EditValue);
                txtTutar.EditValue = ((agirlik * fiyat) / 1000) * kur;
                YekunHesapla();
            }
            catch { }
        }
        public void KdvHesapla()
        {
            try
            {
                double tutar = Convert.ToDouble(txtTutar.EditValue);
                double kdv = Convert.ToDouble(txtKdvOran.EditValue);
                txtKdv.EditValue = (tutar * kdv);
                YekunHesapla();
            }
            catch { }
        }
        public void TevkifatHesapla()
        {
            try
            {
                double tutar = Convert.ToDouble(txtTutar.EditValue);
                double tevkifat = Convert.ToDouble(txtTevkifatOran.EditValue);
                txtTevkifat.EditValue = (tutar * tevkifat);
                YekunHesapla();
            }
            catch { }
        }
        public void YekunHesapla()
        {
            try
            {
                double tutar = Convert.ToDouble(txtTutar.EditValue);
                double tevkifat = Convert.ToDouble(txtTevkifat.EditValue);
                double kdv = Convert.ToDouble(txtKdv.EditValue);
                txtYekun.EditValue = (tutar + kdv + tevkifat);
            }
            catch { }
        }

        private void btnSatirEkle_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtKalinlik.Text != "" && txtGenislik.Text != "" && txtBoyu.Text != "" && txtAgirlik.Text != "" && txtFiyat.Text != "" && txtKur.Text != "" && txtVade.Text != "" && txtTutar.Text != "" && txtKdv.Text != "" && txtTevkifat.Text != "" && txtYekun.Text != "")
                {
                    List<mdlSiparis> SiparisListe = new List<mdlSiparis>();
                    if (gcSiparis.DataSource != null)
                    {
                        try
                        {
                            SiparisListe = (List<mdlSiparis>)gcSiparis.DataSource;
                        }
                        catch (Exception Ex)
                        {
                            ExceptionHelpers.ErrorRegister(Ex);
                        }
                    }

                    #region Stok Ekle
                    try
                    {
                        using (SOMContext ctx = new SOMContext())
                        {
                            ctx.Stok.Add(new mdlStok
                            {
                                kodu = txtStokKodu.Text,
                                adi = txtStokIsmi.Text,
                                cins = gluSCins.EditValue.ToString(),
                                kalite = gluSKalite.EditValue.ToString(),
                                kdv = Convert.ToDouble(txtKdvOran.EditValue),
                                tevkifat = Convert.ToDouble(txtTevkifatOran.EditValue)
                            });
                            ctx.SaveChanges();
                        }
                    }
                    catch (Exception Ex)
                    {
                        ExceptionHelpers.ErrorRegister(Ex);
                        DialogResult dr = XtraMessageBox.Show("Bu sipariş kodu daha önce eklendiği için tekrar eklenemez lütfen yeni sipariş kodu giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    #endregion

                    SiparisListe.Add(new mdlSiparis
                    {
                        tarih = deSiparisTarih.DateTime,
                        kodu = txtStokKodu.Text,
                        bagli_cari = gluFirma.EditValue.ToString(),
                        bagli_stok_cins = gluSCins.EditValue.ToString(),
                        bagli_stok_kalite = gluSKalite.EditValue.ToString(),
                        bagli_stok = txtStokKodu.Text,
                        kalinlik = Convert.ToDouble(txtKalinlik.EditValue),
                        genislik = Convert.ToDouble(txtGenislik.EditValue),
                        boy = Convert.ToDouble(txtBoyu.EditValue),
                        agirlik = Convert.ToDouble(txtAgirlik.EditValue),
                        fiyat = Convert.ToDouble(txtFiyat.EditValue),
                        birim = txtBirim.Text,
                        kur_degeri = Convert.ToDouble(txtKur.EditValue),
                        vade = Convert.ToInt32(txtVade.EditValue),
                        tutar = Convert.ToDouble(txtTutar.EditValue),
                        kdv = Convert.ToDouble(txtKdv.EditValue),
                        tevkifat = Convert.ToDouble(txtTevkifat.EditValue),
                        yekun = Convert.ToDouble(txtYekun.EditValue),
                    });
                    gcSiparis.DataSource = SiparisListe;
                    gvSiparis.RefreshData();
                    gvSiparis.BestFitColumns();
                }
                else
                {
                    XtraMessageBox.Show("Gerekli tüm alanları doldurmanız gereklidir.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEvrakKaydet_Click(object sender, EventArgs e)
        {
            if (gcSiparis.DataSource != null)
            {
                List<mdlSiparis> SiparisListe = (List<mdlSiparis>)gcSiparis.DataSource;
                mainContext.Siparis.AddRange(SiparisListe);
                mainContext.SaveChanges();
                XtraMessageBox.Show("Kayıt işlemi başarıyla yapıldı.", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gluFirma_EditValueChanged(object sender, EventArgs e)
        {
            string kaliteArtikel = mainContext.Cari.Where(x => x.kodu == gluFirma.EditValue.ToString()).FirstOrDefault().kodu;
            txtStokKodu.Text = string.Format("{0}-", kaliteArtikel);
        }
    }
}
