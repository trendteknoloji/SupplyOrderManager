using Supply.Orders.Manager.Entity.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static Supply.Orders.Manager.Helpers.AppInstance;

namespace Supply.Orders.Manager.Entity.Models
{
    [Serializable, Table("CARI_HESAPLAR"), SOM(Version = "v1.0a", Tag = "cari_")]
    public class mdlCariHesap : mdlBase
    {
        [Display(Name = "Kodu", Description = "Cari Kodu"), SOM("v1.0a"), StringLength(25), DataMember, Index("NDX_CARI_HESAPLAR_00", 1, IsUnique = true)]
        public string kodu { get; set; }
        [Display(Name = "Ünvan", Description = "Cari Ünvan"), SOM("v1.0a"), StringLength(200), DataMember]
        public string unvan { get; set; }

        [Display(Name = "Tip", Description = "Tip"), SOM("v1.0a"), DataMember]
        public CariTip tip { get; set; }
    }
}
