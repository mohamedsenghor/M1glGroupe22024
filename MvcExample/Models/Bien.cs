using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcExample.Models
{
    public class Bien
    {
        [Key]
        public int IdBien { get; set; }

        [Display(Name = "Designation"), Required(ErrorMessage ="*"), MaxLength(100, ErrorMessage ="La taille maximale est de 100")]
        public  string LibelleBien { get; set; }

        [Display(Name = "Description"), Required(ErrorMessage = "*"), MaxLength(2000, ErrorMessage = "La taille maximale est de 2000")]
        public string DescriptionBien { get; set; }

        [Display(Name = "Prix journalier"), Required(ErrorMessage = "*")]
        public float? PrixJourBien { get; set;}

        [Display(Name = "Region"), Required(ErrorMessage = "*"), MaxLength(50, ErrorMessage = "La taille maximale est de 50")]
        public string RegionBien { get; set;}

        [Display(Name = "Pays"), Required(ErrorMessage = "*"), MaxLength(50, ErrorMessage = "La taille maximale est de 50")]
        public string PaysBien { get;set;}

        [Display(Name = "Longitude"), Required(ErrorMessage = "*")]
        public float?  LongitudeBien { get; set; }

        [Display(Name = "Latitude"), Required(ErrorMessage = "*")]
        public float? LatitudeBien { get; set; }

        [Display(Name = "Nombre de chambre"), Required(ErrorMessage = "*")]
        public int? NbreChambre { get; set; }

        [Display(Name = "Nombre de lit"), Required(ErrorMessage = "*")]
        public int? NbreLit {  get; set; }

        [Display(Name = "Nombre de salle d'eau"), Required(ErrorMessage = "*")]
        public int? NbreSalleEau { get; set; } = 0;

        [Display(Name = "Type"), Required(ErrorMessage = "*"), MaxLength(20, ErrorMessage = "La taille maximale est de 20")]
        public string TypeBien { get; set; } = "Maison";
        
        public virtual ICollection<Media> Medias { get; set; }

        public virtual ICollection<Annonce> Annonces { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }  
    }
}