using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenOpRekeningen
{
    public class Kasbon : ISpaarmiddel
    {
        private DateTime aankoopDatumValue;
        private decimal bedragValue;
        private int looptijdValue;
        private decimal intrestValue;
        private Klant eigenaarValue;

        public Kasbon(DateTime aankoopDatum, decimal bedrag, int looptijd, decimal intrest, Klant eigenaar)
        {
            AankoopDatum = aankoopDatum;
            Bedrag = bedrag;
            Looptijd = looptijd;
            Intrest = intrest;
            Eigenaar = eigenaar;
        }

        public DateTime AankoopDatum
        {
            get
            {
                return aankoopDatumValue;
            }
            set
            {
                if (value.Year >= 1900)
                    aankoopDatumValue = value;
            }
        }

        public decimal Bedrag
        {
            get
            {
                return bedragValue;
            }
            set
            {
                if (value >= 0)
                    bedragValue = value;
            }
        }

        public int Looptijd
        {
            get
            {
                return looptijdValue;
            }
            set
            {
                if (value >= 0)
                    looptijdValue = value;
            }
        }

        public decimal Intrest
        {
            get
            {
                return intrestValue;
            }
            set
            {
                if (value >= 0)
                    intrestValue = value;
            }
        }

        public Klant Eigenaar
        {
            get
            {
                return eigenaarValue;
            }
            set
            {
                if (value is Klant)
                    eigenaarValue = value;
            }
        }

        public void Afbeelden()
        {
            if (Eigenaar != null)
            {
                Eigenaar.Afbeelden();
            }
            Console.WriteLine("Aankoop datum: {0}", AankoopDatum);
            Console.WriteLine("Bedrag: {0}", Bedrag);
            Console.WriteLine("Looptijd: {0}", Looptijd);
            Console.WriteLine("Intrest: {0}", Intrest);
        }
    }
}
