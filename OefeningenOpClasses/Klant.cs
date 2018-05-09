using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenOpRekeningen
{
    public class Klant
    {
        private string voornaamValue;
        private string familienaamValue;

        public Klant(string voornaam, string familienaam)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
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

        public void Afbeelden()
        {
            Console.WriteLine("Voornaam: {0}", Voornaam);
            Console.WriteLine("Familienaam: {0}", Familienaam);
        }
    }
}
