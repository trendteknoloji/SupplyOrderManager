using DevExpress.XtraGrid.Columns;
using DevExpress.XtraReports.UI;
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
    public partial class frmEnvanterDurum : frmBase
    {
        public frmEnvanterDurum()
        {
            InitializeComponent();
        }

        private void frmEnvanterDurum_Load(object sender, EventArgs e)
        {
            gcListe.DataSource = SQLHelper.ExecuteReader("Select * From STOK_ENVANTER_CHOOSE_1", CommandType.Text, null);
            GridDuzenle();
        }
        public void GridDuzenle()
        {
            int sayac = 0;
            foreach (GridColumn item in gvListe.Columns)
            {
                if (item.ColumnType.FullName == "System.Double")
                {
                    gvListe.Columns[sayac].DisplayFormat.FormatString = "n2";
                    gvListe.Columns[sayac].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                }
                if (item.ColumnType.FullName == "System.DateTime")
                {
                    gvListe.Columns[sayac].DisplayFormat.FormatString = "dd.MM.yyyy";
                    gvListe.Columns[sayac].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                }
                sayac++;
            }
            gvListe.RefreshData();
            gvListe.BestFitColumns();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Dosyası|*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                gvListe.ExportToXlsx(sfd.FileName);
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            gvListe.ShowRibbonPrintPreview();
        }

        private void btnRaporTasarla_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Rapor Dosyası |*.repx";
            ofd.InitialDirectory = string.Format("{0}\\Raporlar\\Envanter", Application.StartupPath);
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
                report.DataSource = SQLHelper.ExecuteReader("Select * From STOK_ENVANTER_CHOOSE_1", CommandType.Text, null); ;
                report.ShowDesigner();
            }
        }

        private void btnRaporYazdir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Rapor Dosyası |*.repx";
            ofd.InitialDirectory = string.Format("{0}\\Raporlar\\Envanter", Application.StartupPath);
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
