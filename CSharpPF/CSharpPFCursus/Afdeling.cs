using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Personeel
{
    public class Afdeling
    {
        public const int Verdiepingen = 10;
        private string afdelingsnaamValue;
        private int verdiepingValue;

        public Afdeling(string naam, int verdieping)
        {
            Afdelingsnaam = naam;
            Verdieping = verdieping;
        }

        public string Afdelingsnaam
        {
            get
            {
                return afdelingsnaamValue;
            }
            set
            {
                afdelingsnaamValue = value;
            }
        }

        public int Verdieping
        {
            get
            {
                return verdiepingValue;
            }
            set
            {
                if (value >= 0 && value <= Verdiepingen)
                    verdiepingValue = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Afdeling: {0} op verdieping {1} ", Afdelingsnaam, Verdieping);
        }
    }
}
