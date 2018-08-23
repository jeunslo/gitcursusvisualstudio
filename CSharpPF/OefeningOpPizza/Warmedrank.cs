using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOpPizza
{
    public class Warmedrank : Drank
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
                if ((int)value > 0)
                    naamValue = value;
                else
                    throw new Exception("Dit is geen warme drank!");
            }
        }
        public override decimal Prijs { get => 2.5m; }
    }
}
