using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenOpClasses
{
    public class BankBediende
    {
        private string voornaamValue;
        private string naamValue;

        public string Voornaam
        {
            get
            {
                return voornaamValue;
            }
            set
            {
                voornaamValue = value;
            }
        }

        public string Naam
        {
            get
            {
                return naamValue;
            }
            set
            {
                naamValue = value;
            }
        }

        public void rekeningTonen(OefeningenOpRekeningen.Rekening middel)
        {
            middel.Afbeelden();
            Console.WriteLine($"Bedrag van storting/afhaling: {Math.Abs(middel.Saldo-middel.VorigSaldo)}");
            Console.WriteLine("Vorige saldo: {0}", middel.VorigSaldo);
        }

        public void rekeningOntoereikend(OefeningenOpRekeningen.Rekening middel)
        {
            Console.WriteLine("Rekening ontoereikend! Maximum af te halen bedrag is {0} euro", middel.Saldo);
        }

    }
}
