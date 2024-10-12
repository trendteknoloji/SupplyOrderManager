using DevExpress.XtraReports.UI;
using Supply.Orders.Manager.Entity.Main;
using Supply.Orders.Manager.Entity.Models;
using Supply.Orders.Manager.Entity.NotDbModels;
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
    public partial class frmStokSiparisListesi : frmBase
    {
        SOMContext mainContext = new SOMContext();
        public frmStokSiparisListesi()
        {
            InitializeComponent();
        }

        private void btnListeYazdir_Click(object sender, EventArgs e)
        {
            gvListe.OptionsPrint.PrintSelectedRowsOnly = false;
            gvListe.ShowRibbonPrintPreview();
        }

        private void btnSeciliSatirYazdir_Click(object sender, EventArgs e)
        {
            gvListe.OptionsPrint.PrintSelectedRowsOnly = true;
            gvListe.ShowRibbonPrintPreview();
        }

        private void btnRaporTasarla_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Rapor Dosyası |*.repx";
            ofd.InitialDirectory = string.Format("{0}\\Raporlar\\Stok Sipariş", Application.StartupPath);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName != "")
                {
                    XtraReport report = XtraReport.FromFile(ofd.FileName);
                    report.ShowDesigner();
                }
                else
                {
                    XtraReport report = new XtraReport();
                    report.DataSource = gcListe.DataSource;
                    report.ShowDesigner();
                }
            }
            else
            {
                XtraReport report = new XtraReport();
                report.DataSource = gcListe.DataSource;
                report.ShowDesigner();
            }
        }

        private void btnRaporYazdir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Rapor Dosyası |*.repx";
            ofd.InitialDirectory = string.Format("{0}\\Raporlar\\Stok Sipariş", Application.StartupPath);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName != "")
                {
                    XtraReport report = XtraReport.FromFile(ofd.FileName);
                    report.DataSource = gcListe.DataSource;
                    report.ShowRibbonPreview();
                }
                else
                {
                    gvListe.OptionsPrint.PrintSelectedRowsOnly = false;
                    gvListe.ShowRibbonPrintPreview();
                }
            }
        }

        private void frmStokSiparisListesi_Load(object sender, EventArgs e)
        {
            gluStok.Properties.DataSource = mainContext.Stok.Select(x => new { x.kodu, x.adi }).ToList();
            gluStok.Properties.ValueMember = "kodu";
        }

        private void gluStok_EditValueChanged(object sender, EventArgs e)
        {
            if (gluStok.EditValue != null)
            {
                using (SOMContext ctx = new SOMContext())
                {
                    List<mdlSiparis> SiparisListe = ctx.Siparis.Where(x => x.bagli_stok == gluStok.EditValue.ToString()).ToList();
                    List<mdlSiparisOdeme> SiparisOdemeListe = new List<mdlSiparisOdeme>();
                    foreach (var item in SiparisListe)
                    {
                        SiparisOdemeListe.Add(new mdlSiparisOdeme
                        {
                            GuidNo = item.GuidNo,
                            tarih = item.tarih,
                            bagli_cari = item.bagli_cari,
                            bagli_stok_cins = item.bagli_stok_cins,
                            bagli_stok_kalite = item.bagli_stok_kalite,
                            bagli_stok = item.bagli_stok,
                            kalinlik = item.kalinlik,
                            genislik = item.genislik,
                            boy = item.boy,
                            agirlik = item.agirlik,
                            fiyat = item.fiyat,
                            birim = item.birim,
                            kur_degeri = item.kur_degeri,
                            vade = item.vade,
                            tutar = item.tutar,
                            kdv = item.kdv,
                            tevkifat = item.tevkifat,
                            yekun = item.yekun,
                            OdemeListesi = ctx.Odeme.Where(x => x.bagli_siparis == item.GuidNo).ToList(),
                        });
                    }
                    gcListe.DataSource = SiparisOdemeListe;
                }
            }
        }
    }
}
