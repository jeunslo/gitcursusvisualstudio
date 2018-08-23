using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorwerp.Boek
{
    public sealed class Leesboek : Boek, IVoorwerpen
    {
        private string onderwerpValue;

        public Leesboek(string titel, string auteur, Genre genre, decimal aankoopPrijs, string onderwerp) : base(titel, auteur, genre, aankoopPrijs)
        {
            Onderwerp = onderwerp;
        }

        public string Onderwerp
        {
            get
            {
                return onderwerpValue;
            }
            set
            {
                onderwerpValue = value;
            }
        }

        public override decimal Winst
        {
            get
            {
                return AankoopPrijs * 1.5m;
            }
        }

        public override void GegevensTonen()
        {
            base.GegevensTonen();
            Console.WriteLine("Onderwerp: {0}", Onderwerp);
        }
    }
}
