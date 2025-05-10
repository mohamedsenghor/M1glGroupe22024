using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcExample.Models
{
    public class Gestionnaire:Utilisateur
    {

        [Display(Name = "Ninea"), MaxLength(20, ErrorMessage = "la taille maximale est de 20")]
        public string Ninea { get; set; }

        [Display(Name = "Rccm"), MaxLength(20, ErrorMessage = "la taille maximale est de 20")]
        public string Rccm { get; set; }
    }
}