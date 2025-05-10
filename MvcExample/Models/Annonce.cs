using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcExample.Models
{
    public class Annonce
    {
        [Key]
        public int IdAnnonce { get; set; }

        [DisplayName("Date de debut"), Required]
        public DateTime? DateDeDebutAnnonce { get; set; }

        [DisplayName("Date de Fin"), Required]
        public DateTime? DateDeFinAnnonce { get; set; }

        [DisplayName("Status"), MaxLength(20, ErrorMessage = "La taille maximale est de 20")]
        public string Status { get; set; }

        [ForeignKey("IdBien")]
        public virtual Bien bien { get; set; }

        public int IdBien { get; set; }

    }
}