using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelNet.Verblijven
{
    public class Vakantiehuis : Verblijf
    {
        public Vakantiehuis()
        {
        }
        public Vakantiehuis(string naamVerblijf, decimal basisPrijsPerDag, bool toeslagSingle, decimal schoonmaakPrijs, decimal linnengoedPrijs) : base(naamVerblijf, basisPrijsPerDag, toeslagSingle)
        {
            SchoonmaakPrijs = schoonmaakPrijs;
            LinnengoedPrijs = linnengoedPrijs;
        }

        public decimal SchoonmaakPrijs { get; set; }
        public decimal LinnengoedPrijs { get; set; }

        private List<Enums.Formule> beschikbareVerblijfsFormulesValue;
        public override List<Enums.Formule> BeschikbareVerblijfsFormules
        {
            get
            {
                return beschikbareVerblijfsFormulesValue = new List<Enums.Formule> { Enums.Formule.Ontbijt };
            }
        }

        public override decimal BerekenVerblijfsPrijs(int aantalDagen, Enums.Formule gekozenFormule)
        {
            decimal prijs;
            prijs = aantalDagen * BasisPrijsPerDag;
            BeschikbareVerblijfsFormuleControle("vakantiehuis", gekozenFormule);
            prijs += aantalDagen * (int)gekozenFormule;
            prijs += SchoonmaakPrijs;
            prijs += LinnengoedPrijs;
            return prijs = ToeslagSingle ? (prijs + (aantalDagen * 5)) : prijs;
        }
    }
}
