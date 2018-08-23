using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFCursus
{
    public partial class Klant
    {
        private static int nummerPlusEen = 1;
        public Klant() { }
        public Klant(string naam)
        {
            Naam = naam;
            Klantnummer = nummerPlusEen;
            nummerPlusEen++;
        }

        public int Klantnummer { get; }
        public string Naam { get; set; } = "Onbekend";


        partial void NaamChanged(string naam)
        {
            Console.WriteLine("Naam gewijzigd naar {0}.", naam);
        }

        public override string ToString()
        {
            return string.Format("klantnummer = {0}, klantnaam = {1}", Klantnummer, Naam);
        }
    }
}
