using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opleiding.Personeel
{
    public abstract class Personeelslid : Kosten
    {
        private int personeelsnummerValue;
        private string familienaamValue;
        private string voornaamValue;
        private decimal brutoValue;
        private static int idValue = 1;
        private static VerlofPeriodeV2 verlofPeriodeValue1;
        private static VerlofPeriodeV2 verlofPeriodeValue2;
        //private Infrastructuur infrastructuurValue;

        public Personeelslid(string familienaam, string voornaam, decimal bruto/*, VerlofPeriodeV2 verlofperiode1, VerlofPeriodeV2 verlofperiode2*/)
        {
            Familienaam = familienaam;
            Voornaam = voornaam;
            Bruto = bruto;
            personeelsnummerValue = idValue;
            idValue++;
            //VerlofPeriode1 = verlofperiode1;
            //VerlofPeriode2 = verlofperiode2;
        }

        public static VerlofPeriodeV2 VerlofPeriode1
        {
            get
            {
                return verlofPeriodeValue1;
            }
            set
            {
                verlofPeriodeValue1 = value;
            }
        }

        public static VerlofPeriodeV2 VerlofPeriode2
        {
            get
            {
                return verlofPeriodeValue2;
            }
            set
            {
                verlofPeriodeValue2 = value;
            }
        }

        //public Infrastructuur Infrastructuur
        //{
        //    get
        //    {
        //        return infrastructuurValue;
        //    }
        //    set
        //    {
        //        infrastructuurValue = value;
        //    }
        //}

        public decimal Bruto
        {
            get
            {
                return brutoValue;
            }
            set
            {
                brutoValue = value;
            }
        }

        public string Familienaam
        {
            get
            {
                return familienaamValue;
            }
            set
            {
                familienaamValue = value;
            }
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

        public int Personeelsnummer
        {
            get
            {
                return personeelsnummerValue;
            }
        }

        public decimal Maandkost
        {
            get
            {
                return Bruto * 0.6m;
            }
        }

        public virtual void GegevensTonen()
        {
            //if (Infrastructuur != null)
            //    Console.WriteLine(Infrastructuur);
            Console.WriteLine("Personeelsnummer: {0}", Personeelsnummer);
            Console.WriteLine("Familienaam: {0}", Familienaam);
            Console.WriteLine("Voornaam: {0}", Voornaam);
            Console.WriteLine("Bruto maandloon: {0:0.00} euro", Bruto);
            Console.WriteLine("Maandkost personeel: {0:0.00} euro", Maandkost);
            Console.WriteLine(VerlofPeriode1);
            Console.WriteLine(VerlofPeriode2);
        }
    }
}
