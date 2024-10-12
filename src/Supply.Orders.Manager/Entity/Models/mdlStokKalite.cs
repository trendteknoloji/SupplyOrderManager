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
    [Serializable, Table("STOK_KALITELERI"), SOM(Version = "v1.0a", Tag = "klt_")]
    public class mdlStokKalite : mdlBase
    {
        [Display(Name = "Kodu", Description = "Kalite Kodu"), SOM("v1.0a"), StringLength(25), DataMember, Index("NDX_STOK_KALITELERI_00", 1, IsUnique = true)]
        public string kodu { get; set; }
        [Display(Name = "Adı", Description = "Kalite Adı"), SOM("v1.0a"), StringLength(50), DataMember]
        public string adi { get; set; }
        [Display(Name = "Stok Kod Artikeli", Description = "Stok Kod Artikeli"), SOM("v1.0a"), StringLength(10), DataMember]
        public string stok_kod_artikel { get; set; }
    }
}
