namespace HaliSaha.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Saatler")]
    public partial class Saatler
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string saat { get; set; }
    }
}
