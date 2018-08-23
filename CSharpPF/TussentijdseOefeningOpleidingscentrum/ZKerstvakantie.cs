using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TussentijdseOefeningOpleidingscentrum
{
    public sealed class KerstVakantie : ZVerlofPeriodeV1
    {
        private string verlofPeriodeNaamValue = "Kerstvakantie";
        private DateTime beginDatumValue = new DateTime(DateTime.Today.Year, 7, 1);
        private DateTime eindDatumValue = new DateTime(DateTime.Today.Year, 7, 31);

        public override string VerlofPeriodeNaam
        {
            get
            {
                return verlofPeriodeNaamValue;
            }
        }

        public override DateTime BeginDatum
        {
            get
            {
                return beginDatumValue;
            }
        }

        public override DateTime EindDatum
        {
            get
            {
                return eindDatumValue;
            }
        }
    }
}
