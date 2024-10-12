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
    [Serializable, Table("STOKLAR"), SOM(Version = "v1.0a", Tag = "sto_")]
    public class mdlStok : mdlBase
    {
        [Display(Name = "Kodu", Description = "Stok Kodu"), SOM("v1.0a"), StringLength(25), DataMember, Index("NDX_STOKLAR_00", 1, IsUnique = true)]
        public string kodu { get; set; }
        [Display(Name = "Adı", Description = "Stok Adı"), SOM("v1.0a"), StringLength(200), DataMember]
        public string adi { get; set; }
        [Display(Name = "Cins", Description = "Stok Cins"), SOM("v1.0a"), StringLength(25), DataMember]
        public string cins { get; set; }
        [Display(Name = "Kalite", Description = "Stok Kalite"), SOM("v1.0a"), StringLength(25), DataMember]
        public string kalite { get; set; }
        [Display(Name = "Kdv", Description = "Stok Kdv"), SOM("v1.0a"),  DataMember]
        public double kdv { get; set; }
        [Display(Name = "Tevkifat", Description = "Stok Tevkifat"), SOM("v1.0a"), DataMember]
        public double tevkifat { get; set; }
    }
}
