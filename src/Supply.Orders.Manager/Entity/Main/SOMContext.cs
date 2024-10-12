using Supply.Orders.Manager.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Supply.Orders.Manager.Entity.Main
{
    public class SOMContext : DbContext
    {
        public SOMContext()
            : base("SOMConnection")
        {
            System.Data.Entity.Database.SetInitializer<SOMContext>(new SOMInitializer<SOMContext, Supply.Orders.Manager.Entity.Configuration>());
        }

        void AddPrefixToColumnName<T>(EntityTypeConfiguration<T> table, string columnPrefix) where T : class
        {
            bool isMapped = true;
            Type type = typeof(T);
            PropertyInfo[] props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var pi in props)
            {
                foreach (var item in pi.CustomAttributes.ToList())
                    if (item.AttributeType.Name == "NotMappedAttribute")
                        isMapped = false;
                if (isMapped)
                {
                    var param = Expression.Parameter(typeof(T));
                    dynamic propertyExpression = Expression.Lambda(Expression.Property(param, pi.Name), param);
                    try
                    {
                        table.Property(propertyExpression).HasColumnName(columnPrefix + pi.Name);
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            AddPrefixToColumnName<mdlKullanici>(modelBuilder.Entity<mdlKullanici>().ToTable(Properties.Tablo.KULLANICILAR), "kul_");
            AddPrefixToColumnName<mdlEkranTasarim>(modelBuilder.Entity<mdlEkranTasarim>().ToTable(Properties.Tablo.EKRAN_TASARIMLARI), "ekt_");
            AddPrefixToColumnName<mdlDepartman>(modelBuilder.Entity<mdlDepartman>().ToTable(Properties.Tablo.DEPARTMANLAR), "dep_");
            AddPrefixToColumnName<mdlCariHesap>(modelBuilder.Entity<mdlCariHesap>().ToTable(Properties.Tablo.CARI_HESAPLAR), "cari_");
            AddPrefixToColumnName<mdlStok>(modelBuilder.Entity<mdlStok>().ToTable(Properties.Tablo.STOKLAR), "sto_");
            AddPrefixToColumnName<mdlStokCins>(modelBuilder.Entity<mdlStokCins>().ToTable(Properties.Tablo.STOK_CINSLERI), "cins_");
            AddPrefixToColumnName<mdlStokKalite>(modelBuilder.Entity<mdlStokKalite>().ToTable(Properties.Tablo.STOK_KALITELERI), "klt_");
            AddPrefixToColumnName<mdlSiparis>(modelBuilder.Entity<mdlSiparis>().ToTable(Properties.Tablo.SIPARISLER), "sip_");
            AddPrefixToColumnName<mdlOdeme>(modelBuilder.Entity<mdlOdeme>().ToTable(Properties.Tablo.ODEMELER), "odm_");
            AddPrefixToColumnName<mdlEnvanter>(modelBuilder.Entity<mdlEnvanter>().ToTable(Properties.Tablo.STOK_ENVANTER), "se_");
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<mdlKullanici> Kullanici { get; set; }
        public virtual DbSet<mdlEkranTasarim> EkranTasarim { get; set; }
        public virtual DbSet<mdlDepartman> Departman { get; set; }
        public virtual DbSet<mdlCariHesap> Cari { get; set; }
        public virtual DbSet<mdlStok> Stok { get; set; }
        public virtual DbSet<mdlStokCins> SCins { get; set; }
        public virtual DbSet<mdlStokKalite> SKalite { get; set; }
        public virtual DbSet<mdlSiparis> Siparis { get; set; }
        public virtual DbSet<mdlOdeme> Odeme { get; set; }
        public virtual DbSet<mdlEnvanter> Envanter { get; set; }
    }
}
