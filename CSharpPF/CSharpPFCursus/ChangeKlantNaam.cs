using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFCursus
{
    public partial class Klant
    {
        private string nieuwNaam;

        public string NieuwNaam
        {
            get { return nieuwNaam; }
            set { nieuwNaam = value; NaamChanged(nieuwNaam); }
        }

        partial void NaamChanged(string naam);
        
    }
}
