using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OefeningOpPizza
{
    public abstract class Gerecht : IBedrag
    {
        public Gerecht()
        {
        }

        public Gerecht(string naam, decimal prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }

        public string Naam { get; set; }

        public decimal Prijs { get; set; }

        public decimal BerekenBedrag()
        {
            return Prijs;
        }

        public override string ToString()
        {
            return string.Format("Gerecht: {0} <{1} euro>", Naam, Prijs);
        }
    }
}
