using DevExpress.DashboardCommon;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supply.Orders.Manager.Forms.Genel
{
    public partial class frmDashboardHazirlama : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmDashboardHazirlama()
        {
            InitializeComponent();
            try
            {
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                args.Caption = "Rapor İsmi";
                args.Prompt = "Lütfen raporunuz için bir isim giriniz.";
                var result = XtraInputBox.Show(args).ToString();
                if (result != "")
                {
                    SqlConnectionStringBuilder con = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["SOMConnection"].ConnectionString);
                    DataConnectionParametersBase connParameters = new MsSqlConnectionParameters()
                    {
                        ServerName = con.DataSource,
                        DatabaseName = con.InitialCatalog,
                        AuthorizationType = MsSqlAuthorizationType.SqlServer,
                        UserName = con.UserID,
                        Password = con.Password
                    };
                    DashboardSqlDataSource sqlDataSource = new DashboardSqlDataSource("SQL Bağlantısı", connParameters);
                    dashboardDesigner1.Dashboard.Title.Text = result;
                    dashboardDesigner1.Dashboard.DataSources.Add(sqlDataSource);
                }
                else
                {
                    XtraMessageBox.Show("Rapor ismi girmeniz gerekmektedir.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                XtraMessageBox.Show("Rapor ismi girmeniz gerekmektedir.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
