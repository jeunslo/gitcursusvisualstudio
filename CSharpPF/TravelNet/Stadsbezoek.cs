using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelNet.Activiteiten
{
    public class Stadsbezoek : IActiviteit
    {
        public Stadsbezoek()
        {
        }
        public Stadsbezoek(string naam, decimal prijsGidsPer10, int aantalPersonen)
        {
            Naam = naam;
            PrijsGidsPer10 = prijsGidsPer10;
            AantalPersonen = aantalPersonen;
        }
        public string Naam { get; set; }
        public decimal PrijsGidsPer10 { get; set; }
        public int AantalPersonen { get; set; }

        public decimal BerekenPrijs()
        {
            int aantalGids = 0;
            if (AantalPersonen % 10 != 0)
                aantalGids += 1;
            aantalGids += Math.Abs(AantalPersonen/10);
            return PrijsGidsPer10 * aantalGids;
        }
    }
}
