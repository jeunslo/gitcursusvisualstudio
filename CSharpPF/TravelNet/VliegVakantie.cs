using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelNet.Activiteiten;

namespace TravelNet.Vakanties
{
    public class VliegVakantie : Vakantie
    {
        public VliegVakantie()
        {
        }
        public VliegVakantie(Enums.Bestemming bestemming, List<IActiviteit> activiteiten, DateTime vertrekDatum, DateTime terugkeerDatum, Route route, decimal vliegTicketPrijs) : base(bestemming, activiteiten, vertrekDatum, terugkeerDatum)
        {
            Route = route;
            VliegTicketPrijs = vliegTicketPrijs;
        }

        public Route Route { get; set; }
        public decimal VliegTicketPrijs { get; set; }

        public override decimal BerekenVakantiePrijs()
        {
            decimal totalePrijs = 0m;
            int aantalDagen = (TerugkeerDatum - VertrekDatum).Days;
            totalePrijs += Route.GekozenVerblijfsType.BerekenVerblijfsPrijs(aantalDagen, Route.GekozenFormule);
            totalePrijs += VliegTicketPrijs;
            return totalePrijs;
        }

        public override string ToString()
        {
            string overzicht = base.ToString();
            overzicht += string.Format("{0}     - {1}  {2}      {3}{4}", Route.VertrekPunt, Route.EindPunt, Route.GekozenFormule, Route.GekozenVerblijfsType.BerekenVerblijfsPrijs((TerugkeerDatum - VertrekDatum).Days, Route.GekozenFormule), Environment.NewLine);
            overzicht += string.Format("Vliegtuigticket: {0}", VliegTicketPrijs);
            return overzicht;
        }
    }
}
