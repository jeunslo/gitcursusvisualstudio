using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefOpRekening
{
    public class Zichtrekening : Rekening
    {
        private decimal maxKredietValue;

        public Zichtrekening(string rekeningnummer, decimal saldo, DateTime creatieDatum, Klant eigenaar, decimal maxKrediet) : base(rekeningnummer, saldo, creatieDatum, eigenaar)
        {
            MaxKrediet = maxKrediet;
        }

        public decimal MaxKrediet
        {
            get
            {
                return maxKredietValue;
            }
            set
            {
                if (value < 0)
                    maxKredietValue = value;
                else
                    throw new OngeldigPositieveWaardeException("Ongeldige positieve waarde, max krediet: ", value);
            }
        }



        public override void Afbeelden()
        {
            Console.WriteLine("=====Zichtrekening=====");
            base.Afbeelden();
            Console.WriteLine("MaxKrediet: {0}", MaxKrediet);
        }
    }
}
