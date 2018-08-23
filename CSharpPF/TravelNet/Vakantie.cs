using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelNet.Activiteiten;

namespace TravelNet.Vakanties
{
    public abstract class Vakantie
    {
        public Vakantie()
        {
        }
        public Vakantie(Enums.Bestemming bestemming, List<IActiviteit> activiteiten, DateTime vertrekDatum, DateTime terugkeerDatum)
        {
            Bestemming = bestemming;
            Activiteiten = activiteiten;
            VertrekDatum = vertrekDatum;
            TerugkeerDatum = terugkeerDatum;
            BoekingsNr = boekNrValue;
            boekNrValue++;
        }

        private static int boekNrValue = 1;
        public int BoekingsNr { get; }
        public Enums.Bestemming Bestemming { get; set; }
        public List<IActiviteit> Activiteiten { get; set; }

        public DateTime VertrekDatum { get; set; }

        private DateTime terugkeerDatumValue;
        public DateTime TerugkeerDatum
        {
            get
            {
                return terugkeerDatumValue;
            }
            set
            {
                if (value > VertrekDatum)
                    terugkeerDatumValue = value;
                else
                    throw new Exception(string.Format("Reis met boekingsnummer {0}: terugkeerdatum({1:dd-MM-yyyy}) moet later zijn dan vetrekdatum ({2:dd-MM-yyyy})!", boekNrValue, value, VertrekDatum));
            }
        }

        public abstract decimal BerekenVakantiePrijs();
        public void AfdrukActiviteiten()
        {
            Console.WriteLine("Activiteit(en):");
            decimal totaalPrijs = 0m;
            if (Activiteiten != null)
            {
                foreach (var activiteit in Activiteiten)
                {
                    Console.WriteLine("{0} kost: {1}", activiteit.Naam, activiteit.BerekenPrijs());
                    totaalPrijs += activiteit.BerekenPrijs();
                }
            }
            Console.WriteLine("Totale activiteitsprijs: {0}", totaalPrijs);
        }

        public override string ToString()
        {
            string overzicht;
            overzicht = string.Format("Boekingsnr: {0} Bestemming: {1}{2}", BoekingsNr, Bestemming, Environment.NewLine);
            overzicht += string.Format("vertrekdatum: {0:dd/MM/yyyy} einddatum: {1:dd/MM/yyyy}{2}", VertrekDatum, TerugkeerDatum, Environment.NewLine);
            return overzicht;
        }
    }
}
