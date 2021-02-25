using ProdavnicaApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaApp.Repository
{
    public class KorisniciRepository
    {
        public List<Korisnik> KorisniciSearch(string ImePrezime)
        {
            var Korisnici = Connection.ProdavnicaApp.Korisnici.AsQueryable();
            if (ImePrezime != "")
                Korisnici = Korisnici.Where(k => (k.Ime + " " + k.Prezime).ToLower()
                                     .Contains(ImePrezime.ToLower()));

            return Korisnici.ToList();
        }

        public Korisnik KorisniciSearchByUsernameAndPassword(string korisnickoIme, string lozinka)
        {
            return Connection.ProdavnicaApp.Korisnici.Where(k => k.KorisničkoIme == korisnickoIme && k.Lozinka == lozinka).FirstOrDefault();
        }

        public Korisnik KorisniciGetById(int id)
        {
            return Connection.ProdavnicaApp.Korisnici.Find(id);
        }

        public void KorisniciAdd(Korisnik korisnik)
        {
            Connection.ProdavnicaApp.Korisnici.Add(korisnik);
            Connection.ProdavnicaApp.SaveChanges();
        }

        public void KorisniciUpdate(int id, Korisnik podaci)
        {
            var korisnik = Connection.ProdavnicaApp.Korisnici.Find(id);
            if(korisnik != null)
            {
                korisnik.Ime = podaci.Ime;
                korisnik.Prezime = podaci.Prezime;
                korisnik.KorisničkoIme = podaci.KorisničkoIme;
                korisnik.DatumRođenja = podaci.DatumRođenja;
                if (podaci.Lozinka != "")
                    korisnik.Lozinka = podaci.Lozinka;
                korisnik.IsAdministrator = podaci.IsAdministrator;

                Connection.ProdavnicaApp.SaveChanges();
            }
        }

        public void KorisniciDelete(int id)
        {
            var korisnik = Connection.ProdavnicaApp.Korisnici.Find(id);
            if(korisnik != null)
            {
                Connection.ProdavnicaApp.Remove(korisnik);

                Connection.ProdavnicaApp.SaveChanges();
            }
        }
    }
}
