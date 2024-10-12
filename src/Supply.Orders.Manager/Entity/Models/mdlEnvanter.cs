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
    [Serializable, Table("STOK_ENVANTER"), SOM(Version = "v1.0a", Tag = "se_")]
    public class mdlEnvanter : mdlBase
    {

        [Display(Name = "Envanter Tarih", Description = "Envanter Tarih"), SOM("v1.0a"), DataMember]
        public DateTime tarih { get; set; }
        [Display(Name = "Kodu", Description = "Cari Kodu"), SOM("v1.0a"), StringLength(25), DataMember]
        public string bagli_cari { get; set; }
        [Display(Name = "Stok Cinsi", Description = "Stok Cinsi"), SOM("v1.0a"), StringLength(25), DataMember]
        public string bagli_stok_cins { get; set; }
        [Display(Name = "Stok Kalite", Description = "Stok Kalite"), SOM("v1.0a"), StringLength(25), DataMember]
        public string bagli_stok_kalite { get; set; }
        [Display(Name = "Stok", Description = "Stok"), SOM("v1.0a"), StringLength(25), DataMember]
        public string bagli_stok { get; set; }
        [Display(Name = "Kalınlık", Description = "Kalınlık"), SOM("v1.0a"), DisplayFormat(DataFormatString = "N2"), DataMember]
        public double kalinlik { get; set; }
        [Display(Name = "Genişlik", Description = "Genişlik"), SOM("v1.0a"), DisplayFormat(DataFormatString = "N2"), DataMember]
        public double genislik { get; set; }
        [Display(Name = "Boy", Description = "Boy"), SOM("v1.0a"), DisplayFormat(DataFormatString = "N2"), DataMember]
        public double boy { get; set; }
        [Display(Name = "Ağırlık", Description = "Ağırlık"), SOM("v1.0a"), DisplayFormat(DataFormatString = "N2"), DataMember]
        public double agirlik { get; set; }
        [Display(Name = "Fiyat", Description = "Fiyat"), SOM("v1.0a"), DisplayFormat(DataFormatString = "N2"), DataMember]
        public double fiyat { get; set; }
        [Display(Name = "Birim", Description = "Birim"), SOM("v1.0a"), StringLength(10), DataMember]
        public string birim { get; set; }
        [Display(Name = "Kur Değeri", Description = "Kur Değeri"), SOM("v1.0a"), DisplayFormat(DataFormatString = "N4"), DataMember]
        public double kur_degeri { get; set; }
        [Display(Name = "Vade", Description = "Vade"), SOM("v1.0a"), DataMember]
        public int vade { get; set; }
        [Display(Name = "Tutar", Description = "Tutar"), SOM("v1.0a"), DisplayFormat(DataFormatString = "N2"), DataMember]
        public double tutar { get; set; }
        [Display(Name = "KDV", Description = "KDV"), SOM("v1.0a"), DisplayFormat(DataFormatString = "N2"), DataMember]
        public double kdv { get; set; }
        [Display(Name = "Tevkifat", Description = "Tevkifat"), SOM("v1.0a"), DisplayFormat(DataFormatString = "N2"), DataMember]
        public double tevkifat { get; set; }
        [Display(Name = "Yekün", Description = "Yekün"), SOM("v1.0a"), DisplayFormat(DataFormatString = "N2"), DataMember]
        public double yekun { get; set; }

    }
}
