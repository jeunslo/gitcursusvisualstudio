using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TussentijdseOefeningOpleidingscentrum
{
    public sealed class ZomerVakantie : ZVerlofPeriodeV1
    {
        private string verlofPeriodeNaamValue = "Zomervakantie";
        private DateTime beginDatumValue = new DateTime(DateTime.Today.Year, 12, 24);
        private DateTime eindDatumValue = new DateTime(DateTime.Today.AddYears(1).Year, 1, 1);

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
