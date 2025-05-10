using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcExample.Models
{
    public class Reservation
    {
        [Key]
        public int IdReservation { get; set; }

        [DisplayName("Date de debut"), Required]
        public DateTime? DateDeDebutReservation { get; set; }
        
        [DisplayName("Date de Fin"), Required]
        public DateTime? DateDeFinReservation { get; set; }

        [DisplayName("Status"), MaxLength(20, ErrorMessage = "La taille maximale est de 20")]
        public string Status { get; set; }

        [ForeignKey("IdBien")]
        public virtual Bien Bien { get; set; }

        public int IdBien { get; set; }

        [DisplayName("Montant"), Required]
        public float Montant { get; set; }

    }
}