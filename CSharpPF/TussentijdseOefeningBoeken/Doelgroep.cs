using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorwerp.Boek
{
    public class Doelgroep
    {
        private int leeftijdValue;

        public Doelgroep(int leeftijd)
        {
            Leeftijd = leeftijd;
        }

        public int Leeftijd
        {
            get
            {
                return leeftijdValue;
            }
            set
            {
                leeftijdValue = value; 
            }
        }

        public string Categorie
        {
            get
            {
                return Leeftijd < 18 ? "Jeugd" : "Volwassen";
            }
        }

        public override string ToString()
        {
            return String.Format("Doelgroep: {0}", Categorie);
        }
    }
}
