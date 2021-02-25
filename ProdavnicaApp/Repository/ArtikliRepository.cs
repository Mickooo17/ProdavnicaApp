using ProdavnicaApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaApp.Repository
{
    public class ArtikliRepository
    {
        public List<Artikal> ArtikliSearch(string Naziv)
        {
            var Artikli = Connection.ProdavnicaApp.Artikli.AsQueryable();
            if (Naziv != "")
                Artikli = Artikli.Where(x => x.Naziv.ToLower()
                                     .Contains(Naziv.ToLower()));

            return Artikli.ToList();
        }


        public Artikal ArtikliGetById(int id)
        {
            return Connection.ProdavnicaApp.Artikli.Find(id);
        }

        public void ArtikliAdd(Artikal Artikal)
        {
            Connection.ProdavnicaApp.Artikli.Add(Artikal);
            Connection.ProdavnicaApp.SaveChanges();
        }

        public void ArtikliUpdate(int id, Artikal podaci)
        {
            var Artikal = Connection.ProdavnicaApp.Artikli.Find(id);
            if (Artikal != null)
            {
                Artikal.Naziv = podaci.Naziv;
                Artikal.Cijena = podaci.Cijena;
                Artikal.MjernaJedinica = podaci.MjernaJedinica;
                Artikal.KoličinaUSkladištu = podaci.KoličinaUSkladištu;

                Connection.ProdavnicaApp.SaveChanges();
            }
        }

        public void ArtikliDelete(int id)
        {
            var Artikal = Connection.ProdavnicaApp.Artikli.Find(id);
            if (Artikal != null)
            {
                Connection.ProdavnicaApp.Remove(Artikal);

                Connection.ProdavnicaApp.SaveChanges();
            }
        }
    }
}
