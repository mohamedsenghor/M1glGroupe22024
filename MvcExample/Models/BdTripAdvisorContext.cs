using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcExample.Models
{
    public class BdTripAdvisorContext:DbContext
    {
        public BdTripAdvisorContext():base("connTripAdvisor")
        { }

        public DbSet<Client> clients { get; set; }
        public DbSet<Utilisateur> utilisateurs { get; set; }
        public DbSet<Bien> biens { get; set; }
        public DbSet<Media> medias { get; set; }
        public DbSet<Annonce> annonces { get; set; }
        public DbSet<Reservation> reservations { get; set; }
        public DbSet<Gestionnaire> gestionnaires { get; set; }
        public DbSet<Admin> admin { get; set; }
    }
}