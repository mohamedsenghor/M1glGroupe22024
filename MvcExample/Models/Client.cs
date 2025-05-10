using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcExample.Models
{
    public class Client:Utilisateur
    {
        [Display(Name = "CNI"), MaxLength(20, ErrorMessage = "la taille maximale est de 20")]
        public string CNI { get; set; }

        [Display(Name = "Passport"), MaxLength(20, ErrorMessage = "la taille maximale est de 20")]
        public string Passport { get; set; }
    }
}