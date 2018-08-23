using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefOpRekening
{
    public class SpaarRekening : Rekening
    {
        private static decimal intrestValue;

        public SpaarRekening(string rekeningnummer, decimal saldo, DateTime creatieDatum, Klant eigenaar) : base(rekeningnummer, saldo, creatieDatum, eigenaar)
        {
        }

        public static decimal Intrest
        {
            get
            {
                return intrestValue;
            }
            set
            {
                if (value > 0)
                    intrestValue = value;
                else
                    throw new OngeldigNegatieveWaardeException("Ongeldige negatieve waarde, intrest: ", value);
            }
        }

        public override void Afbeelden()
        {
            Console.WriteLine("=====Spaarrekening=====");
            base.Afbeelden();
            Console.WriteLine("Intrest: {0}", Intrest);
        }
    }
}
