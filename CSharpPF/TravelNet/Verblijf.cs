using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelNet
{
    public abstract class Verblijf
    {
        public Verblijf()
        {
        }
        public Verblijf(string naamVerblijf, decimal basisPrijsPerDag, bool toeslagSingle)
        {
            NaamVerblijf = naamVerblijf;
            BasisPrijsPerDag = basisPrijsPerDag;
            ToeslagSingle = toeslagSingle;
        }

        public string NaamVerblijf { get; set; }
        public abstract List<Enums.Formule> BeschikbareVerblijfsFormules { get; }
        public decimal  BasisPrijsPerDag { get; set; }
        public bool ToeslagSingle { get; set; }

        public abstract decimal BerekenVerblijfsPrijs(int aantalDagen, Enums.Formule gekozenFormule);

        public void BeschikbareVerblijfsFormuleControle(string verblijf, Enums.Formule gekozenFormule)
        {
            if (BeschikbareVerblijfsFormules != null)
            {
                int aantalFouten = 0;
                foreach (var beschikbareVerblijfsFormule in BeschikbareVerblijfsFormules)
                {
                    if (gekozenFormule != beschikbareVerblijfsFormule)
                    {
                        aantalFouten++;
                        if (aantalFouten == BeschikbareVerblijfsFormules.Count)
                            throw new Exception(string.Format("De verblijfsformule {0} is foutief voor een {1}, geef één van de beschikbare formules op!", gekozenFormule, verblijf));
                    }
                }
            }
        }
    }
}
