using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenOpRekeningen
{
    public /*abstract*/ class Rekening : ISpaarmiddel
    {
        private readonly DateTime EersteCreatie = new DateTime(1900, 1, 1);
        private string rekeningnummerValue;
        private decimal saldoValue;
        private DateTime creatieDatumValue;
        private Klant eigenaarValue;

        public Klant Eigenaar
        {
            get
            {
                return eigenaarValue;
            }
            set
            {
                eigenaarValue = value;
            }
        }

        public string Rekeningnummer
        {
            get
            {
                return rekeningnummerValue;
            }
            set
            {
                if (RekeningnummerCheck(value))
                {
                    rekeningnummerValue = value;
                }
            }
        }

        public DateTime CreatieDatum
        {
            get
            {
                return creatieDatumValue;
            }
            set
            {
                if (value > EersteCreatie)
                    creatieDatumValue = value;
            }
        }

        public decimal Saldo
        {
            get
            {
                return saldoValue;
            }
            set
            {
                saldoValue = value;
            }
        }

        //public Rekening() : this("Geen geldig rekeningnummer", 0, DateTime.Today)
        //{
        //}

        public Rekening(string rekeningnummer, decimal saldo, DateTime creatieDatum, Klant eigenaar)
        {
            Rekeningnummer = rekeningnummer;
            Saldo = saldo;
            CreatieDatum = creatieDatum;
            Eigenaar = eigenaar;
        }

        private bool RekeningnummerCheck(string rekeningNr)
        {
            if (!string.IsNullOrWhiteSpace(rekeningNr) &&
            rekeningNr.Length == 16 &&
            rekeningNr.Substring(0, 2) == "BE" &&                
            int.TryParse(rekeningNr.Substring(2, 2), out int derdeVierdeGetal) &&               
            ulong.TryParse(rekeningNr.Substring(4, 10), out ulong volgendeTien) &&                
            int.TryParse(rekeningNr.Substring(14, 2), out int laatsteTwee) &&
            (int) (volgendeTien % 97) == laatsteTwee)
                return true;
            else
                return false;
        }

        public virtual void Afbeelden()
        {
            if(Eigenaar != null)
                Eigenaar.Afbeelden();
            Console.WriteLine("Rekeningnummer: {0}", Rekeningnummer);
            Console.WriteLine("CreatieDatum: {0}", CreatieDatum);
            Console.WriteLine("Saldo: {0}", Saldo);
        }

        public void Storten(decimal bedrag)
        {
            Saldo += bedrag;
        }
    }
}
