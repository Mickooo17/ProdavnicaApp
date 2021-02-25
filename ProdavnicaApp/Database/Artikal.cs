using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaApp.Database
{
    public class Artikal
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public decimal KoličinaUSkladištu { get; set; }
        public string MjernaJedinica { get; set; }
        public decimal Cijena { get; set; }


        public string KoličinaUSkladištuTxt
        {
            get
            {
                if (Math.Truncate(KoličinaUSkladištu) == KoličinaUSkladištu)
                    return KoličinaUSkladištu.ToString("0");

                return KoličinaUSkladištu.ToString("0.00");
            }
        }

        public string CijenaTxt => Cijena.ToString("0.00");
    }
}
