using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelNet.Verblijven
{
    public class Hotel : Verblijf
    {
        public Hotel()
        {
        }
        public Hotel(string naamVerblijf, decimal basisPrijsPerDag, bool toeslagSingle, bool internet, decimal wellnessPrijs) : base(naamVerblijf, basisPrijsPerDag, toeslagSingle)
        {
            Internet = internet;
            WellnessPrijs = wellnessPrijs;
        }
        public bool Internet { get; set; }
        public decimal? WellnessPrijs { get; set; }

        private List<Enums.Formule> beschikbareVerblijfsFormulesValue;
        public override List<Enums.Formule> BeschikbareVerblijfsFormules
        {
            get
            {
                return beschikbareVerblijfsFormulesValue = new List<Enums.Formule> { Enums.Formule.Ontbijt, Enums.Formule.HalfPension, Enums.Formule.VolPension };
            }
        }

        public override decimal BerekenVerblijfsPrijs(int aantalDagen, Enums.Formule gekozenFormule)
        {
            decimal prijs;
            prijs = aantalDagen * BasisPrijsPerDag;
            BeschikbareVerblijfsFormuleControle("hotel", gekozenFormule);
            prijs += aantalDagen * (int)gekozenFormule;
            if(WellnessPrijs != null)
                prijs += (decimal) WellnessPrijs;
            return prijs = ToeslagSingle ? prijs + (aantalDagen * 5) : prijs;
        }
    }
}
