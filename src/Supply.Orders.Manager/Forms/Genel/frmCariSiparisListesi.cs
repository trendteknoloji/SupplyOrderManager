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
    public partial class frmCariSiparisListesi : frmBase
    {
        SOMContext mainContext = new SOMContext();
        public frmCariSiparisListesi()
        {
            InitializeComponent();
        }

        private void gluFirma_EditValueChanged(object sender, EventArgs e)
        {
            if (gluFirma.EditValue != null)
            {
                using (SOMContext ctx = new SOMContext())
                {
                    List<mdlSiparis> SiparisListe = ctx.Siparis.Where(x => x.bagli_cari == gluFirma.EditValue.ToString()).ToList();
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

        private void frmCariSiparisListesi_Load(object sender, EventArgs e)
        {
            gluFirma.Properties.DataSource = mainContext.Cari.Select(x => new { x.kodu, x.unvan }).ToList();
            gluFirma.Properties.ValueMember = "kodu";
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
            ofd.InitialDirectory = string.Format("{0}\\Raporlar\\Cari Sipariş", Application.StartupPath);
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
            ofd.InitialDirectory = string.Format("{0}\\Raporlar\\Cari Sipariş", Application.StartupPath);
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
    }
}
