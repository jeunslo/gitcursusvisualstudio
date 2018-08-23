using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelNet.Activiteiten
{
    public class Cinema : IActiviteit
    {
        public Cinema()
        {
        }

        public Cinema(string naam, decimal inkom, decimal snoepgoed)
        {
            Naam = naam;
            Inkom = inkom;
            Snoepgoed = snoepgoed;
        }

        public string Naam { get; set; }
        public decimal Inkom { get; set; }
        public decimal Snoepgoed { get; set; }

        public decimal BerekenPrijs()
        {
            return Inkom + Snoepgoed;
        }
    }
}
