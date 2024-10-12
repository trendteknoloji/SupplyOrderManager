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
    /*DataType(DataType.Currency), Range(200, 5000)*/
    [Serializable, Table("KULLANICILAR"), SOM(Version = "v1.0a", Tag = "kul_")]
    public class mdlKullanici : mdlBase
    {
        [Display(Name = "Kodu", Description = "Kullanıcı Kodu"), SOM("v1.0a"), StringLength(25), DataMember, Index("NDX_KULLANICILAR_00", 1, IsUnique = true)]
        public string kodu { get; set; }
        [Display(Name = "Adı", Description = "Kullanıcı Adı"), SOM("v1.0a"), StringLength(50), DataMember]
        public string adi { get; set; }
        [Display(Name = "Soyadı", Description = "Kullanıcı Soyadı"), SOM("v1.0a"), StringLength(50), DataMember]
        public string soyadi { get; set; }
        [Display(Name = "Şifre", Description = "Kullanıcı Şifre"), SOM("v1.0a"), StringLength(50), DataMember]
        public string sifre { get; set; }
        [Display(Name = "Lisans Anahtarı", Description = "Kullanıcı Lisans Anahtarı"), SOM("v1.0a"), DataMember]
        public string lisans_anahtari { get; set; }
        [Display(Name = "Bağlı Olduğu Departman", Description = "Bağlı Olduğu Departman"), SOM("v1.0a"), StringLength(25), DataMember]
        public string bagli_departman { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1}", adi, soyadi);
        }
    }
}
