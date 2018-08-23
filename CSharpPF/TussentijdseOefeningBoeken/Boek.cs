using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorwerp.Boek
{
    public abstract class Boek : IVoorwerpen
    {
        private decimal aankoopPrijsValue;
        private string auteurValue;
        private static string eigenaarValue;
        private Genre genreValue;
        private string titelValue;

        public Boek(string titel, string auteur, Genre genre, decimal aankoopPrijs)
        {
            Titel = titel;
            Auteur = auteur;
            Genre = genre;
            AankoopPrijs = aankoopPrijs;
        }

        public string Titel
        {
            get
            {
                return titelValue;
            }
            set
            {
                titelValue = value;
            }
        }

        public string Auteur
        {
            get
            {
                return auteurValue;
            }
            set
            {
                auteurValue = value;
            }
        }

        public static string Eigenaar
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

        public decimal AankoopPrijs
        {
            get
            {
                return aankoopPrijsValue;
            }
            set
            {
                aankoopPrijsValue = value;
            }
        }

        public Genre Genre
        {
            get
            {
                return genreValue;
            }
            set
            {
                genreValue = value;
            }
        }

        public abstract decimal Winst
        {
            get;
        }

        public virtual void GegevensTonen()
        {
            Console.WriteLine("Titel: {0}", Titel);
            Console.WriteLine("Auteur: {0}", Auteur);
            Console.WriteLine("Eigenaar: {0}", Eigenaar);
            Console.WriteLine("{0}", Genre);
            Console.WriteLine("Aankoopprijs: {0:0.00} euro", AankoopPrijs);
        }
    }
}
