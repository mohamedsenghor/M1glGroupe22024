using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcExample.Models
{
    public class Media
    {
        [Key]
        public int IdMedia { get; set; }

        [Display(Name ="Type"), Required(ErrorMessage ="*"), MaxLength(10, ErrorMessage ="La taille maximale est de 10")]
        public string TypeMedia { get; set; }

        [MaxLength(10, ErrorMessage = "La taille maximale est de 10")]
        public string ExtensionMedia { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "URL"), Required(ErrorMessage = "*"), MaxLength(150, ErrorMessage = "La taille maximale est de 150")]
        public string URLMedia { get; set; }

        [MaxLength(10, ErrorMessage = "La taille maximale est de 10")]
        public string StatutMedia { get; set; }

        [Display(Name ="Bien"), Required(ErrorMessage ="Choisir un bien")]
        public int IdBien { get; set; }
        [ForeignKey("IdBien")]
        public virtual Bien Bien { get; set; }
    }
}