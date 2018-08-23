using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOpPizza
{
    public abstract class Drank : IBedrag
    {
        public enum Drankverzameling
        {
            Water = -1, Limonade = -2, Cocacola = -3, Koffie = 1, Thee = 2
        }

        public abstract Drankverzameling Naam { get; set; }
        public abstract decimal Prijs { get; }

        public override string ToString()
        {
            return string.Format("Drank: {0} <{1:0.0} euro>", Naam, Prijs);
        }

        public decimal BerekenBedrag()
        {
            return Prijs;
        }
    }
}
