using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelNet.Vakanties
{
    public class Route
    {
        public Route()
        {
        }
        public Route(string vertrekPunt, string eindPunt, Verblijf gekozenVerblijfsType, Enums.Formule gekozenFormule)
        {
            VertrekPunt = vertrekPunt;
            EindPunt = eindPunt;
            GekozenFormule = gekozenFormule;
            GekozenVerblijfsType = gekozenVerblijfsType;
        }

        public string VertrekPunt { get; set; }
        public string EindPunt { get; set; }
        public Verblijf GekozenVerblijfsType { get; set; }
        public Enums.Formule GekozenFormule { get; set; }
    }
}
