using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorwerp.Boek
{
    public class Genre
    {
        private string naamValue;
        private Doelgroep doelgroepValue;

        public Genre(string naam, Doelgroep doelgroep)
        {
            Naam = naam;
            Doelgroep = doelgroep;
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

        public Doelgroep Doelgroep
        {
            get
            {
                return doelgroepValue;
            }
            set
            {
                doelgroepValue = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Genre: {0}{1}{2}", Naam, Environment.NewLine, Doelgroep);
        }
    }
}
