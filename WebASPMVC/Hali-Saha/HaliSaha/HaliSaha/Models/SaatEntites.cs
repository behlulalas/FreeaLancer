namespace HaliSaha.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SaatEntites : DbContext
    {
        public SaatEntites()
            : base("name=SaatEntites")
        {
        }

        public virtual DbSet<Saatler> Saatler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Saatler>()
                .Property(e => e.saat)
                .IsUnicode(false);
        }
    }
}
