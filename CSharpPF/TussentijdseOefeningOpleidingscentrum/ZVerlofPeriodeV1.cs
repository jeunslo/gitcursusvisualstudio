using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TussentijdseOefeningOpleidingscentrum
{
    public abstract class ZVerlofPeriodeV1
    {
        public abstract string VerlofPeriodeNaam
        {
            get;
        }

        public abstract DateTime BeginDatum
        {
            get;
        }

        public abstract DateTime EindDatum
        {
            get;
        }

        public override string ToString()
        {
            return String.Format("{0}: begin {1:dd/MM/yyyy} - eind {2:dd/MM/yyyy}", VerlofPeriodeNaam, BeginDatum, EindDatum);
        }
    }   
}
