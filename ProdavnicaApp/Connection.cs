using ProdavnicaApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaApp
{
    public class Connection
    {
        public static ProdavnicaAppContext ProdavnicaApp = new ProdavnicaAppContext();
    }
}
