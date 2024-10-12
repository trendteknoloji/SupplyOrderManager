using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supply.Orders.Manager.Helpers
{
    public class ExceptionHelpers
    {
        public static void ErrorRegister(Exception ex)
        {
            if (ex.GetType() == typeof(DbEntityValidationException))
            {
                EntityErrorRegister((DbEntityValidationException)ex);
                return;
            }
            string mesaj = string.Format("Mesaj\t: {0}\nKaynak\t: {1}\nHedef\t: {2}\nYığın\t: {3}\n{4}", ex.Message, ex.Source, ex.TargetSite, ex.StackTrace, ex.ToString());
            System.Windows.MessageBox.Show(mesaj);
            // ErrorSave(mesaj);
        }

        private static void EntityErrorRegister(DbEntityValidationException ex)
        {
            string mesaj = "";
            DbEntityValidationException e = (DbEntityValidationException)ex;
            foreach (var eve in e.EntityValidationErrors)
            {
                mesaj += String.Format("Entity Tipi \"{0}\" Konum \"{1}\" Hata Mesajı:", eve.Entry.Entity.GetType().Name, eve.Entry.State);
                foreach (var ve in eve.ValidationErrors)
                {
                    mesaj += String.Format("\n- Property: \"{0}\", Error: \"{1}\"",
                        ve.PropertyName, ve.ErrorMessage);
                }
            }
            //ErrorSave(mesaj);
            System.Windows.MessageBox.Show(mesaj);

        }

        private static void ErrorSave(string mesaj)
        {
            string olayAdi = "Supply Orders Manager";
            if (!EventLog.SourceExists(olayAdi))
            {
                EventLog.CreateEventSource(olayAdi, olayAdi);
            }
            using (EventLog olay = new EventLog())
            {
                olay.Source = olayAdi;
                olay.WriteEntry(mesaj, EventLogEntryType.Error, 1121);
            }
            DBErrorSave(mesaj);
        }

        private static void DBErrorSave(string mesaj)
        {
            //using (ModoLogContext log = new ModoLogContext())
            //{
            //    if (AppSettings.Kullanici != null && AppSettings.Veritabani != null)
            //    {
            //        log.KullaniciHatalari.Add(new mdlKullaniciHatalari { create_user = AppSettings.Kullanici.kodu, lastup_user = AppSettings.Kullanici.kodu, mesaj = mesaj, veritabani = AppSettings.Veritabani.kod });
            //    }
            //    else
            //    {
            //        log.KullaniciHatalari.Add(new mdlKullaniciHatalari { create_user = "001", lastup_user = "001", mesaj = mesaj, veritabani = "Genel Kayıt" });
            //    }
            //    log.SaveChanges();
            //}
        }
    }
}
