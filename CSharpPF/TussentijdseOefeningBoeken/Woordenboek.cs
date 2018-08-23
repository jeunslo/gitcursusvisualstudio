using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorwerp.Boek
{
    public sealed class Woordenboek : Boek, IVoorwerpen
    {
        private string taalValue;

        public Woordenboek(string titel, string auteur, Genre genre, decimal aankoopPrijs, string taal) : base(titel, auteur, genre, aankoopPrijs)
        {
            Taal = taal;
        }

        public string Taal
        {
            get
            {
                return taalValue;
            }
            set
            {
                taalValue = value;
            }
        }

        public override decimal Winst
        {
            get
            {
                return AankoopPrijs * 1.75m;
            }
        }

        public override void GegevensTonen()
        {
            base.GegevensTonen();
            Console.WriteLine("Taal: {0}", Taal);
        }
    }
}