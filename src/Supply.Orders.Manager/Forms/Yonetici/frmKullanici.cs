using Supply.Orders.Manager.Entity.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Supply.Orders.Manager.Entity.Models;
using Supply.Orders.Manager.Helpers;

namespace Supply.Orders.Manager.Forms.Yonetici
{
    public partial class frmKullanici : frmBase
    {
        SOMContext mainContext = new SOMContext();
        mdlKullanici newRow;
        public frmKullanici()
        { 
            InitializeComponent();

            mainContext.Kullanici.Load();
            gcMain.DataSource = mainContext.Kullanici.Local.ToBindingList();
            gvMain.InitNewRow += GvMain_InitNewRow;
            gvMain.RowUpdated += GvMain_RowUpdated;
            gvMain.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            leDepartman.DataSource = mainContext.Departman.Select(x => new { x.kodu, x.adi }).ToList();
            leDepartman.ValueMember = "kodu";
            leDepartman.BestFit();
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

        private void GvMain_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var gridView = (GridView)sender;
            newRow = (mdlKullanici)gridView.GetRow(e.RowHandle);
        }

        private void frmKullanici_Load(object sender, EventArgs e)
        {
            using (SOMContext ctx = new SOMContext())
            {

            }
        }
        public void KayitEkleGuncelle(mdlKullanici kayit)
        {
            try
            {
                using (SOMContext ctx = new SOMContext())
                {
                    mdlKullanici tempUser = ctx.Kullanici.Where(x => x.kodu == kayit.kodu).FirstOrDefault();
                    if (tempUser != null)
                        ctx.Entry(tempUser).CurrentValues.SetValues(kayit);
                    else
                        ctx.Kullanici.Add(kayit);
                    ctx.SaveChanges();
                }
            }
            catch (Exception Ex)
            {
                ExceptionHelpers.ErrorRegister(Ex);
                XtraMessageBox.Show("Hatalı bir işlem yaptığınız için kayıt ekleme/güncelleme başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmKullanici_FormClosed(object sender, FormClosedEventArgs e)
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
