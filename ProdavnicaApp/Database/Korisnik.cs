using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaApp.Database
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string KorisničkoIme { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRođenja { get; set; }

        public bool IsAdministrator { get; set; }
    }
}
