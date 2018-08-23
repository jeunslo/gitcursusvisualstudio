using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelNet.Activiteiten;

namespace TravelNet.Vakanties
{
    public class AutoVakantie : Vakantie
    {
        public AutoVakantie()
        {
        }
        public AutoVakantie(Enums.Bestemming bestemming, List<IActiviteit> activiteiten, DateTime vertrekDatum, DateTime terugkeerDatum, List<Route> routes, Enums.WagenType wagenType, decimal huurPrijs) : base(bestemming, activiteiten, vertrekDatum, terugkeerDatum)
        {
            Routes = routes;
            WagenType = wagenType;
            HuurPrijs = huurPrijs;
        }

        public List<Route> Routes { get; set; }
        public Enums.WagenType WagenType { get; set; }

        private decimal huurPrijsValue;
        public decimal HuurPrijs
        {
            get
            {
                return huurPrijsValue;
            }
            set
            {
                if (WagenType == Enums.WagenType.EigenWagen && value != 0m)
                    throw new Exception("U kan geen huurprijs vastleggen op een eigen wagen");
                else
                    huurPrijsValue = value;
            }
        }

        public override decimal BerekenVakantiePrijs()
        {
            decimal totalePrijs = 0m;
            if (Routes != null)
            {
                foreach (var route in Routes)
                    totalePrijs += route.GekozenVerblijfsType.BerekenVerblijfsPrijs(1, route.GekozenFormule);
            }
            return totalePrijs += huurPrijsValue;
        }

        public override string ToString()
        {
            string overzicht = base.ToString();
            if (Routes != null)
            {
                foreach (var route in Routes)
                    overzicht += string.Format("{0}     - {1}       {2}         {3}{4}", route.VertrekPunt, route.EindPunt, route.GekozenFormule, route.GekozenVerblijfsType.BerekenVerblijfsPrijs(1, route.GekozenFormule), Environment.NewLine);
            }
            return overzicht += string.Format("Huurprijs: {0}", HuurPrijs);
        }
    }
}
