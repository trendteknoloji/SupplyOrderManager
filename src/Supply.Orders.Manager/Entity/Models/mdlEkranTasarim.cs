using Supply.Orders.Manager.Entity.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Supply.Orders.Manager.Entity.Models
{
    [Serializable, Table("EKRAN_TASARIMLARI"), SOM(Version = "v1.0a", Tag = "ekt_")]
    public class mdlEkranTasarim : mdlBase
    {
        [Display(Name = "Kullanıcı Kodu", Description = "Kullanıcı Kodu"), SOM("v1.0a"), StringLength(25), DataMember]
        public string kullanici_kodu { get; set; }
        [Display(Name = "Form Kodu", Description = "Form Kodu"), SOM("v1.0a"), StringLength(25), DataMember]
        public string form_kodu { get; set; }
        [Display(Name = "Tasarım İçerik", Description = "Tasarım İçerik"), SOM("v1.0a"), DataMember]
        public byte[] tasarim_icerik { get; set; }
    }
}
