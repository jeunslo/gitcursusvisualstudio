using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenOpRekeningen
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
            }
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine("Intrest: {0}", Intrest);
        }
    }
}
