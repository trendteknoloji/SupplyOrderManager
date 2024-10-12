using Supply.Orders.Manager.Entity.Main;
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
    [Serializable, Table("ODEMELER"), SOM(Version = "v1.0a", Tag = "odm_")]
    public class mdlOdeme : mdlBase
    {
        [Display(Name = "Bağlı Sipariş Guid", Description = "Bağlı Sipariş Guid"), SOM("v1.0a"), DataMember]
        public Guid bagli_siparis { get; set; }
        [Display(Name = "Ödeme Tarih", Description = "Ödeme Tarih"), SOM("v1.0a"), DataMember]
        public DateTime tarih { get; set; }
        [Display(Name = "Tutar", Description = "Tutar"), SOM("v1.0a"), DataMember]
        public double tutar { get; set; }
        [Display(Name = "Birim", Description = "Birim"), SOM("v1.0a"), StringLength(10), DataMember]
        public string birim { get; set; }
        [Display(Name = "Kur Değeri", Description = "Kur Değeri"), SOM("v1.0a"), DataMember]
        public double kur_degeri { get; set; }

        [Display(Name = "Yekün", Description = "Yekün"), SOM("v1.0a"), DataMember]
        public double yekun { get; set; }
    }
}
