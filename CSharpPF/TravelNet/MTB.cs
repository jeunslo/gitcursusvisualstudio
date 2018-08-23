using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelNet.Activiteiten
{
    public class MTB : IActiviteit
    {
        public MTB()
        {
        }
        public MTB(string naam, decimal prijsUitrusting, decimal huurFietsPerUur, int aantalUur)
        {
            Naam = naam;
            PrijsUitrusting = prijsUitrusting;
            HuurFietsPerUur = huurFietsPerUur;
            AantalUur = aantalUur;
        }

        public string Naam { get; set; }
        public decimal PrijsUitrusting { get; set; }
        public decimal HuurFietsPerUur { get; set; }
        public int AantalUur { get; set; }

        public decimal BerekenPrijs()
        {
            return PrijsUitrusting + (AantalUur * HuurFietsPerUur);
        }
    }
}
