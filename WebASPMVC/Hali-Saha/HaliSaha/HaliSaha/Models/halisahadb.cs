namespace HaliSaha.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class halisahadb : DbContext
    {
        public halisahadb()
            : base("name=halisahadb")
        {
        }

        public virtual DbSet<Rezervasyon> Rezervasyon { get; set; }
        public virtual DbSet<Saatler> Saatler { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rezervasyon>()
                .Property(e => e.adsoyad)
                .IsUnicode(false);

            modelBuilder.Entity<Rezervasyon>()
                .Property(e => e.telefon)
                .IsUnicode(false);

            modelBuilder.Entity<Rezervasyon>()
                .Property(e => e.saat)
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<HaliSaha.Areas.Admin.Models.Users> Users { get; set; }
    }
}
