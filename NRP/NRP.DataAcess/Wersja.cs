namespace NRP.DataAcess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ojk.Wersja")]
    public partial class Wersja
    {
        public int Id { get; set; }

        public int KlientId { get; set; }

        public int StatusId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DataModyfikacji { get; set; }

        [Required]
        [StringLength(30)]
        public string PracownikId { get; set; }

        public virtual Klient Klient { get; set; }

        public virtual Status Status { get; set; }
    }
}
