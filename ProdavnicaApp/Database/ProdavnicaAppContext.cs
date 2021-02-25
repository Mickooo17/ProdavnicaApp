using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaApp.Database
{
    public class ProdavnicaAppContext : DbContext
    {
        public ProdavnicaAppContext(): base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=.;initial catalog=ProdavnicaApp;integrated security=True;MultipleActiveResultSets=True");
        }

        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Artikal> Artikli { get; set; }
    }
}
