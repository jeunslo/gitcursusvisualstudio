using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelNet.Activiteiten;

namespace TravelNet.Vakanties
{
    public class Cruise : Vakantie
    {
        public Cruise()
        {
        }
        public Cruise(Enums.Bestemming bestemming, List<IActiviteit> activiteiten, DateTime vertrekDatum, DateTime terugkeerDatum, Route route, List<string> aanlegPlaatsen, decimal allInPrijs) : base(bestemming, activiteiten, vertrekDatum, terugkeerDatum)
        {
            Route = route;
            AanlegPlaatsen = aanlegPlaatsen;
            AllInPrijs = allInPrijs;
        }

        public Route Route { get; set; }
        public List<string> AanlegPlaatsen { get; set; }
        public decimal AllInPrijs { get; set; }

        public override decimal BerekenVakantiePrijs()
        {
            return AllInPrijs;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("{0}     - {1}       {2}", Route.VertrekPunt, Route.EindPunt, Route.GekozenFormule);
        }
    }
}
