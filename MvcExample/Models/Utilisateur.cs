using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcExample.Models
{
    public class Utilisateur
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "*"), Display(Name = "Nom prenom"), MaxLength(160, ErrorMessage = "la taille maximale est de 160")]
        public string NomPrenom { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "*"), Display(Name = "Téléphone"), MaxLength(20, ErrorMessage = "la taille maximale est de 20")]
        public string Telephone { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "*"), Display(Name = "Nom prenom"), MaxLength(80, ErrorMessage = "la taille maximale est de 80")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*"), Display(Name = "Adresse"), MaxLength(160, ErrorMessage = "la taille maximale est de 160")]
        public string Adresse { get; set; }

       
    }
}