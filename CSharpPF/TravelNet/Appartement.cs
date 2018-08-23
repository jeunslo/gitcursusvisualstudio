using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelNet.Verblijven
{
    public class Appartement : Verblijf
    {
        public Appartement()
        {
        }
        public Appartement(string naamVerblijf, decimal basisPrijsPerDag, bool toeslagSingle, decimal schoonmaakPrijs, bool lift) : base(naamVerblijf, basisPrijsPerDag, toeslagSingle)
        {
            SchoonmaakPrijs = schoonmaakPrijs;
            Lift = lift;
        }
       
        public decimal SchoonmaakPrijs { get; set; }
        public bool Lift { get; set; }

        private List<Enums.Formule> beschikbareVerblijfsFormulesValue;
        public override List<Enums.Formule> BeschikbareVerblijfsFormules
        {
            get
            {
                return beschikbareVerblijfsFormulesValue = new List<Enums.Formule>{ Enums.Formule.Ontbijt, Enums.Formule.HalfPension };
            }
        }

        public override decimal BerekenVerblijfsPrijs(int aantalDagen, Enums.Formule gekozenFormule)
        {
            decimal prijs;
            BeschikbareVerblijfsFormuleControle("appartement", gekozenFormule);
            prijs = aantalDagen * BasisPrijsPerDag;
            prijs += aantalDagen * (int)gekozenFormule;
            prijs += SchoonmaakPrijs;    
            return prijs = ToeslagSingle ? prijs + (aantalDagen * 5) : prijs;  
        }
    }
}
