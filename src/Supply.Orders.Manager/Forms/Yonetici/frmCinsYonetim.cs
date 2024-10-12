﻿using DevExpress.XtraEditors;
using Supply.Orders.Manager.Entity.Main;
using Supply.Orders.Manager.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supply.Orders.Manager.Forms.Yonetici
{
    public partial class frmCinsYonetim : frmBase
    {
        SOMContext mainContext = new SOMContext();
        public frmCinsYonetim()
        {
            InitializeComponent();
            mainContext.SCins.Load();
            gcMain.DataSource = mainContext.SCins.Local.ToBindingList();
        }
        private void GvMain_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                mainContext.SaveChanges();
            }
            catch (Exception Ex)
            {
                ExceptionHelpers.ErrorRegister(Ex);
                XtraMessageBox.Show("Hatalı bir işlem yaptığınız için kayıt düzenleme başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCinsYonetim_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                mainContext.SaveChanges();
            }
            catch (Exception Ex)
            {
                ExceptionHelpers.ErrorRegister(Ex);
                XtraMessageBox.Show("Hatalı bir işlem yaptığınız için kayıt düzenleme başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
