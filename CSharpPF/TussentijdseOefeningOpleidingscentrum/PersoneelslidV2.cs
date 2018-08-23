using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opleiding.Personeel
{
    public abstract partial class PersoneelslidV2 : Kosten
    {
        private int personeelsnummerValue;
        private string familienaamValue;
        private string voornaamValue;
        private decimal brutoValue;
        private static int idValue = 1;

        public PersoneelslidV2(string familienaam, string voornaam, decimal bruto)
        {
            Familienaam = familienaam;
            Voornaam = voornaam;
            Bruto = bruto;
            personeelsnummerValue = idValue;
            idValue++;
        }

        private static VerlofPeriodeV2[] verlofPeriodeValue;
        public static VerlofPeriodeV2[] VerlofPeriodePersoneel
        {
            get
            {
                return verlofPeriodeValue;
            }
            set
            {
                verlofPeriodeValue = value;
            }
        }

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
            Console.WriteLine("Personeelsnummer: {0}", Personeelsnummer);
            Console.WriteLine("Familienaam: {0}", Familienaam);
            Console.WriteLine("Voornaam: {0}", Voornaam);
            Console.WriteLine("Bruto maandloon: {0:0.00} euro", Bruto);
            Console.WriteLine("Maandkost personeel: {0:0.00} euro", Maandkost);
            if (VerlofPeriodePersoneel != null)
            {
                foreach (VerlofPeriodeV2 verlof in VerlofPeriodePersoneel)
                {
                    Console.WriteLine(verlof);
                }
            }
        }
    }
}
