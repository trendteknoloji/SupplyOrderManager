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
    [Serializable, Table("DEPARTMANLAR"), SOM(Version = "v1.0a", Tag = "dep_")]
    public class mdlDepartman : mdlBase
    {
        [Display(Name = "Kodu", Description = "Departman Kodu"), SOM("v1.0a"), StringLength(25), DataMember, Index("NDX_DEPARTMANLAR_00", 1, IsUnique = true)]
        public string kodu { get; set; }
        [Display(Name = "Adı", Description = "Departman Adı"), SOM("v1.0a"), StringLength(50), DataMember]
        public string adi { get; set; }

        [Display(Name = "Yetkili mi?", Description = "Yetkili mi?"), SOM("v1.0a"), DataMember]
        public bool yetki { get; set; }
    }
}
