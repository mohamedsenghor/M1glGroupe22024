using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcExample.Models
{
    public class Admin:Utilisateur
    {
        [Required, MaxLength(10), Display(Name ="Matricule")]
        public string Matricule { get; set; }
    }
}