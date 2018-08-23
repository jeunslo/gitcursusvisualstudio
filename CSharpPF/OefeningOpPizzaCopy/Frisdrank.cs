using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOpPizza
{
    public class Frisdrank : Drank
    {
        private Drankverzameling naamValue;
        public override Drankverzameling Naam
        {
            get
            {
                return naamValue;
            }
            set
            {
                if ((int)value < 0)
                    naamValue = value;
                else
                    throw new Exception("Dit is geen frisdrank!");
            }
        }
        public override decimal Prijs { get => 2m; }
    }
}
