using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefOpRekening
{
    public class BankBediende
    {
        private string voornaamValue;
        private string naamValue;

        public BankBediende(string voornaam, string naam)
        {
            Voornaam = voornaam;
            Naam = naam;
        }

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

        public override string ToString()
        {
            return String.Format("Bankbediende {0} {1}", Voornaam, Naam);
        }

        public void rekeningTonen(OefOpRekening.Rekening middel)
        {
            middel.Afbeelden();
            if(middel.Saldo > middel.VorigSaldo)
                Console.WriteLine($"Bedrag van storting: {Math.Abs(middel.Saldo-middel.VorigSaldo):0.00} euro");
            else
                Console.WriteLine($"Bedrag van afhaling: {Math.Abs(middel.Saldo - middel.VorigSaldo):0.00} euro");
            Console.WriteLine("Vorige saldo: {0:0.00}", middel.VorigSaldo);
        }

        public void rekeningOntoereikend(OefOpRekening.Rekening middel)
        {
            Console.WriteLine("Rekening ontoereikend! Maximum afhaalbaar bedrag is {0:0.00} euro", middel.Saldo);
        }

    }
}
