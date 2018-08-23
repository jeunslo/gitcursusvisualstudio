using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOpPizza
{
    public class BesteldGerecht : IBedrag
    {
        public enum Grootte
        {
            Klein, Groot
        }

        public enum Extra
        {
            Brood, Kaas, Look
        }

        public BesteldGerecht()
        {
        }

        public BesteldGerecht(Gerecht gerecht, Grootte grootte, List<Extra> extra)
        {
            Gerecht = gerecht;
            Size = grootte;
            Extraatje = extra;
        }

        public Gerecht Gerecht { get; set; }
        public  Grootte Size { get; set; }
        public List<Extra> Extraatje { get; set; }

        public override string ToString()
        {
            string extraLijst = "";
            if (Extraatje.Count() != 0)
            {
                extraLijst = "extra: ";
                foreach (var extra in Extraatje)
                    extraLijst += string.Format("{0} ", extra);
            }
            return string.Format("{0} <{1}> {2} <bedrag: {3} euro>", Gerecht, Size, extraLijst, BerekenBedrag());
        }

        public decimal BerekenBedrag()
        {
            decimal prijs = 0;
            if (Gerecht != null)
                prijs = Gerecht.BerekenBedrag();
            if (Size == Grootte.Groot)
                prijs += 3m;
            if (Extraatje != null)
                prijs += Extraatje.Count();
            return prijs;
        }
    }
}
