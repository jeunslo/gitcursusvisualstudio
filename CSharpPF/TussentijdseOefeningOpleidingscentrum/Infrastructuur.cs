using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opleiding.Infrastructuur
{
    public class Infrastructuur : Kosten
    {
        private string naamValue;
        private decimal maandhuurPrijsValue;

        public Infrastructuur(string naam, decimal maandhuurPrijs)
        {
            Naam = naam;
            MaandhuurPrijs = maandhuurPrijs;
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

        public decimal MaandhuurPrijs
        {
            get
            {
                return maandhuurPrijsValue;
            }
            set
            {
                maandhuurPrijsValue = value;
            }
        }

        public decimal Maandkost
        {
            get
            {
                return MaandhuurPrijs;
            }
        }

        public void GegevensTonen()
        {
            Console.WriteLine("Naam gebouw: {0}", Naam);
            Console.WriteLine("Maandelijkse huurprijs: {0} euro", MaandhuurPrijs);
            Console.WriteLine("Maandkost gebouw: {0} euro", Maandkost);
        }

        //public override string ToString()
        //{
        //    return String.Format("Naam gebouw: {0} {1}Maandelijkse huurprijs: {2} euro{3}Maandkost gebouw: {4} euro", Naam, Environment.NewLine, MaandhuurPrijs, Environment.NewLine, Maandkost);
        //}
    }
}
