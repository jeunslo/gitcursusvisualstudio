using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opleiding.Personeel
{
    public abstract partial class PersoneelslidV2
    {
        public class VerlofPeriodeV3
        {
            public enum VerlofPeriodes
            {
                Kerstvakantie, Zomervakantie
            }

            private VerlofPeriodes verlofPeriodeValue;


            public VerlofPeriodeV3(VerlofPeriodes verlofPeriode)
            {
                VerlofPeriode = verlofPeriode;
            }
               

            public VerlofPeriodes VerlofPeriode
            {
                get
                {
                    return verlofPeriodeValue;
                }
                set
                {
                    verlofPeriodeValue = value;
                }
            }

            public DateTime BeginDatum
            {
                get
                {
                    switch (VerlofPeriode)
                    {
                        case VerlofPeriodes.Kerstvakantie:
                            return new DateTime(DateTime.Today.Year, 7, 1);
                        case VerlofPeriodes.Zomervakantie:
                            return new DateTime(DateTime.Today.Year, 12, 24);
                        default:
                            return new DateTime(DateTime.Today.Year, 01, 01);
                    }
                }
            }

            public DateTime EindDatum
            {
                get
                {
                    switch (VerlofPeriode)
                    {
                        case VerlofPeriodes.Kerstvakantie:
                            return new DateTime(DateTime.Today.Year, 7, 31);
                        case VerlofPeriodes.Zomervakantie:
                            return new DateTime(DateTime.Today.AddYears(1).Year, 1, 1);
                        default:
                            return new DateTime(DateTime.Today.Year, 01, 01);
                    }
                }
            }

            public override string ToString()
            {
                return String.Format("{0}: begin {1:dd/MM/yyyy} - eind {2:dd/MM/yyyy}", VerlofPeriode, BeginDatum, EindDatum);
            }

        }
    }
}
