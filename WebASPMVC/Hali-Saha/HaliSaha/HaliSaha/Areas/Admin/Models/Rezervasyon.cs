namespace HaliSaha.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rezervasyon")]
    public partial class Rezervasyon
    {
        public int RezervasyonID { get; set; }

        [Required]
        [StringLength(50)]
        public string adsoyad { get; set; }

        [Required]
        [StringLength(50)]
        public string telefon { get; set; }

        [Column(TypeName = "date")]
        public DateTime tarih { get; set; }

        [Required]
        [StringLength(50)]
        public string saat { get; set; }

        [Required]
        [StringLength(128)]
        public string userid { get; set; }

        public bool Durum { get; set; }
    }
}
