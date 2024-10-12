using DevExpress.XtraReports.UI;
using Supply.Orders.Manager.Entity.Main;
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
    public partial class frmRaporHazirlama : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmRaporHazirlama()
        {
            InitializeComponent();
        }

        private void frmRaporHazirlama_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Select * From SIPARISLER \n");
            sb.Append("Left Join CARI_HESAPLAR On cari_kodu = sip_bagli_cari \n");
            sb.Append("Left Join STOK_CINSLERI On cins_kodu = sip_bagli_stok_cins \n");
            sb.Append("Left Join STOK_KALITELERI On klt_kodu = sip_bagli_stok_kalite \n");
            sb.Append("Left Join STOKLAR On sto_kodu = sip_bagli_stok \n");
            sb.Append("Left Join ODEMELER On odm_bagli_siparis = sip_GuidNo \n");
            XtraReport rapor = new XtraReport();
            using (SOMContext ctx = new SOMContext())
            {
                rapor.DataSource = SQLHelper.ExecuteReader(sb.ToString(), CommandType.Text, null);
            }
            reportDesigner1.OpenReport(rapor);
        }
    }
}
