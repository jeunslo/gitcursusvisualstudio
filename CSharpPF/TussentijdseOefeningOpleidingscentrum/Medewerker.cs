using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opleiding.Personeel
{
    public sealed class Medewerker : PersoneelslidV2
    {
        private int aantalCursistenValue;

        public Medewerker(string familienaam, string voornaam, decimal bruto, /*VerlofPeriodeV2 verlofperiode1, VerlofPeriodeV2 verlofperiode2, */int aantalCursisten) : base(familienaam, voornaam, bruto/*, verlofperiode1, verlofperiode2*/)
        {
            AantalCursisten = aantalCursisten;
        }

        public int AantalCursisten
        {
            get
            {
                return aantalCursistenValue;
            }
            set
            {
                aantalCursistenValue = value;
            }
        }

        public override void GegevensTonen()
        {
            base.GegevensTonen();
            Console.WriteLine("Aantal cursisten: {0}", AantalCursisten);
        }
    }
}
