using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opleiding.Personeel
{
    public class VerlofPeriodeV2
    {
        private string verlofPeriodeNaamValue;
        private DateTime beginDatumValue;
        private DateTime eindDatumValue;

        public VerlofPeriodeV2(string naam, DateTime beginDatum, DateTime eindDatum)
        {
            VerlofPeriodeNaam = naam;
            BeginDatum = beginDatum;
            EindDatum = eindDatum;
        }

        public string VerlofPeriodeNaam
        {
            get
            {
                return verlofPeriodeNaamValue;
            }
            set
            {
                verlofPeriodeNaamValue = value;
            }
        }

        public DateTime BeginDatum
        {
            get
            {
                return beginDatumValue;
            }
            set
            {
                beginDatumValue = value;
            }
        }

        public DateTime EindDatum
        {
            get
            {
                return eindDatumValue;
            }
            set
            {
                eindDatumValue = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}: begin {1:dd/MM/yyyy} - eind {2:dd/MM/yyyy}", VerlofPeriodeNaam, BeginDatum, EindDatum);
        }
    }
}
