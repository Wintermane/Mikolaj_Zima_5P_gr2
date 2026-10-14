using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    public class Produkt
    {
        public string nazwa;
        public double cena;

        public Produkt()
        {
            nazwa = "kamien";
            cena = 5.99;
        }
        public Produkt(string n, double c)
        {
            nazwa = n;
            cena = c;
        }
    }
}
