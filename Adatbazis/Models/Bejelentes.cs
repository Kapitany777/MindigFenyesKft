﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adatbazis.Models
{
    public class Bejelentes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(4)]
        public string Iranyitoszam { get; set; } = string.Empty;

        [Required]
        [StringLength(40)]
        public string Varos { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Cim { get; set; } = string.Empty;

        [Required]
        [StringLength(80)]
        public string HibaLeiras { get; set; } = string.Empty;

        [Required]
        public DateTime BejelentesDatuma { get; set; }

        public DateTime? JavitasDatuma { get; set; }

        public int? DolgozoId { get; set; }

        public virtual Dolgozo? Dolgozo { get; set; }

        public int? JavitasTipusId { get; set; }

        public virtual JavitasTipus? JavitasTipus { get; set; }
    }
}
