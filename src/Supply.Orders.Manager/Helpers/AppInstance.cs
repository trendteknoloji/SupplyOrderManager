using Supply.Orders.Manager.Entity.Main;
using Supply.Orders.Manager.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Supply.Orders.Manager.Helpers
{
    public static class AppInstance
    {
        public static string Password = "*Fv3871320*Fv";

        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }
        public enum CariTip
        {
            [Description("Müşteri")]
            Musteri = 0,
            [Description("Satıcı")]
            Satici = 1
        }


        private static mdlKullanici user;

        public static mdlKullanici User
        {
            get { return user; }
            set { user = value; }
        }

        public static void UserSet(string User_Code, string User_Pass)
        {
            try
            {
                using (SOMContext ctx = new SOMContext())
                {
                    mdlKullanici tempUser = ctx.Kullanici.Where(x => x.kodu == User_Code && x.sifre == User_Pass).FirstOrDefault();
                    if (tempUser.kodu == tempUser.lisans_anahtari.Decrypt(AppInstance.Password))
                    {
                        User = tempUser;
                    }
                }
            }
            catch (Exception Ex)
            {
                ExceptionHelpers.ErrorRegister(Ex);
            }
        }
        public static bool UserLogin()
        {
            if (User != null)
                return true;
            else
                return false;
        }
    }
}
