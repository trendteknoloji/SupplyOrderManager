using Supply.Orders.Manager.Entity.Main;
using Supply.Orders.Manager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Supply.Orders.Manager.Entity.Models
{
    public class mdlBase
    {
        [Key, Column(Order = 1), Display(Name = "Database Kayıt Numarası", Description = "Database Kayıt Numarası"), SOM("v1.0a")]
        [DataMember]
        public int RECno { get; set; }

        [Column(Order = 2), Display(Name = "Database Guid Numara", Description = "Database Guid Numara"), SOM("v1.0a")]
        [Index("NDX_MAIN_00", 1, IsUnique = true)]
        [DataMember]
        public Guid GuidNo { get; set; }

        [Column(Order = 3), Display(Name = "Database Temp Numara", Description = "Database Temp Numara"), SOM("v1.0a")]
        [DataMember]
        public int TempID { get; set; }

        [Column(Order = 4), Display(Name = "Database Kayıt Tarihi", Description = "Database Kayıt Tarihi"), SOM("v1.0a")]
        [DataMember]
        public DateTime create_date { get; set; }
        [Column(Order = 5), Display(Name = "Kayıt Yapan Kullanıcı", Description = "Kayıt Yapan Kullanıcı"), SOM("v1.0a")]
        [DataMember]
        public int create_user { get; set; }
        [Column(Order = 6), Display(Name = "Son Güncelleme Tarihi", Description = "Son Güncelleme Tarihi"), SOM("v1.0a")]
        [DataMember]
        public DateTime lastup_date { get; set; }
        [Column(Order = 7), Display(Name = "Son Güncelleyen Kullanıcı", Description = "Son Güncelleyen Kullanıcı"), SOM("v1.0a")]
        [DataMember]
        public int lastup_user { get; set; }


        public mdlBase()
        {
            GuidNo = Guid.NewGuid();
            create_date = DateTime.Now;
            lastup_date = DateTime.Now;
            create_user = 1;
            lastup_user = 1;
        }
    }
}
