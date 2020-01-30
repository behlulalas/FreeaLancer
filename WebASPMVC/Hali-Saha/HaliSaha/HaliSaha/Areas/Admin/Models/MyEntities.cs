namespace HaliSaha.Areas.Admin.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyEntities : DbContext
    {
        public MyEntities()
            : base("name=MyEntities")
        {
        }

        public virtual DbSet<Rezervasyon> Rezervasyon { get; set; }

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

            modelBuilder.Entity<Rezervasyon>()
                .Property(e => e.userid)
                .IsUnicode(false);
        }
    }
}
