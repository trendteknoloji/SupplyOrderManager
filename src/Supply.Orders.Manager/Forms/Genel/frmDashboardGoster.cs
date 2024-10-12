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
    public partial class frmDashboardGoster : frmBase
    {
        public frmDashboardGoster()
        {
            InitializeComponent();
        }
        public frmDashboardGoster(string fileName)
        {
            InitializeComponent();
            dashboardViewer1.LoadDashboard(fileName);
        }

        private void frmDashboardGoster_Load(object sender, EventArgs e)
        {

        }
    }
}
