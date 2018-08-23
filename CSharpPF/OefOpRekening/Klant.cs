using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefOpRekening
{
    public class Klant
    {
        public Klant() { }
        public Klant(string voornaam, string familienaam)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
        }

        public int Klantnummer { get; } = 10;
        public string Voornaam { get; set; } = "Onbekend";

        public string Familienaam { get; set; } = "Onbekend";


        public void Afbeelden()
        {
            Console.WriteLine("Voornaam: {0}", Voornaam);
            Console.WriteLine("Familienaam: {0}", Familienaam);
        }

        public override string ToString()
        {
            return string.Format("klantnummer = {0}, klantnaam = {1} {2}", Klantnummer, Voornaam, Familienaam);
        }
    }
}
