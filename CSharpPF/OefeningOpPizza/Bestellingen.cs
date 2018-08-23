using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OefeningOpPizza
{
    public class Bestellingen : IBedrag
    {
        public Bestellingen()
        {
            Aantal = 1;
        }

        public Bestellingen(Klant klant, BesteldGerecht besteldGerecht, Drank drank, Dessert dessert, int aantal)
        {
            Klant = klant;
            BesteldGerecht = besteldGerecht;
            Drank = drank;
            Dessert = dessert;
            Aantal = aantal;
        }

        public Klant Klant { get; set; }

        public BesteldGerecht BesteldGerecht { get; set; }

        public Drank Drank { get; set; }

        public Dessert Dessert { get; set; }

        public int Aantal { get; set; }

        public override string ToString()
        {
            StringBuilder tekst = new StringBuilder();
            tekst.Append(string.Format("{2}.Klant: {0}{1}", Klant.Naam, Environment.NewLine, Klant.KlantID));
            if(BesteldGerecht != null)
                tekst.Append(string.Format("{0}{1}", BesteldGerecht, Environment.NewLine));
            if (Drank != null)
                tekst.Append(string.Format("{0}{1}", Drank, Environment.NewLine));
            if (Dessert != null)
                tekst.Append(string.Format("{0}{1}", Dessert, Environment.NewLine));
            tekst.Append(string.Format("Aantal: {0}{1}", Aantal, Environment.NewLine));
            tekst.Append(string.Format("Bedrag van deze bestelling: {0} euro", BerekenBedrag()));
            return tekst.ToString();
        }

        public decimal BerekenBedrag()
        {
            decimal prijs = 0;
            if (BesteldGerecht != null)
                prijs += BesteldGerecht.BerekenBedrag();
            if (Drank != null)
                prijs += Drank.BerekenBedrag();
            if (Dessert != null)
                prijs += Dessert.BerekenBedrag();
            prijs *= Aantal;
            if (BesteldGerecht != null && Drank != null && Dessert != null)
                prijs -= prijs * 0.1m;
            return prijs;
        }

        public void BestellingWegSchrijven(Bestellingen bestelling)
        {
            string locatie = @"C:\Data\";          
            StringBuilder bestellingRegel;
            List<string> extraArray = new List<string>();
            string extraString;
            try
            {
                using (var schrijver = new StreamWriter(locatie + "bestellingen.txt", true))
                {
                    bestellingRegel = new StringBuilder();
                    bestellingRegel.Append(bestelling.Klant.KlantID + "#");
                    if (bestelling.BesteldGerecht != null)
                    {
                        bestellingRegel.Append(bestelling.BesteldGerecht.Gerecht.Naam + "-");
                        bestellingRegel.Append(bestelling.BesteldGerecht.Size + "-");
                        if (bestelling.BesteldGerecht.Extraatje != null)
                        {
                            bestellingRegel.Append(bestelling.BesteldGerecht.Extraatje.Count + "-");
                            extraString = string.Join("-", bestelling.BesteldGerecht.Extraatje);
                            bestellingRegel.Append(extraString);
                        }
                    }
                    bestellingRegel.Append("#");
                    if (bestelling.Drank is Frisdrank && bestelling.Drank != null)
                        bestellingRegel.Append("F-"+ bestelling.Drank.Naam);
                    if (bestelling.Drank is Warmedrank && bestelling.Drank != null)
                        bestellingRegel.Append("W-" + bestelling.Drank.Naam);
                    bestellingRegel.Append("#");
                    if(bestelling.Dessert != null)
                        bestellingRegel.Append(bestelling.Dessert.Naam);
                    bestellingRegel.Append("#");
                    bestellingRegel.Append(bestelling.Aantal);
                    schrijver.WriteLine(bestellingRegel);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Fout bij het schrijven van het bestand!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("exeption bij BestellingWegSchrijven: {0}", ex.Message);
            }
        }

        public void BestellingBestandLezen()
        {
            string locatie = @"C:\Data\";
            string bestellingenRegel;
            try
            {
                using (var lezer = new StreamReader(locatie + "bestellingen.txt"))
                {
                    while ((bestellingenRegel = lezer.ReadLine()) != null)
                    {
                        ToonBestellingBestandGegevens(bestellingenRegel);
                    }
                }
            }
            catch (IOException)
            {
                throw new Exception("Fout bij het schrijven van het bestand!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("exeption bij BestellingBestandLezen: {0}", ex.Message);
            }
        }

        private static void ToonBestellingBestandGegevens(string bestellingenRegel)
        {
            string[] gegevens = bestellingenRegel.Split(new char[] { '#' });
            Console.WriteLine("KlantId: {0}", gegevens[0]);
            if (gegevens[1] != "")
            {
                string[] besteldGerechtGegevens = gegevens[1].Split(new char[] { '-' });
                Console.WriteLine("Gerecht: {0} <{1}>", besteldGerechtGegevens[0], besteldGerechtGegevens[1]);
                int.TryParse(besteldGerechtGegevens[2], out var maxExtrasGegevens);
                if (maxExtrasGegevens != 0)
                {
                    Console.Write("Extra's: ");
                    for (var i = 3; i < 3 + maxExtrasGegevens; i++)
                    {
                        Console.Write("{0} ", besteldGerechtGegevens[i]);
                    }
                    Console.WriteLine();
                }

            }
            if (gegevens[2] != "")
            {
                string[] drankGegevens = gegevens[2].Split(new char[] { '-' });
                if (drankGegevens[0] == "F")
                    Console.WriteLine("Frisdrank: {0}", drankGegevens[1]);
                if (drankGegevens[0] == "W")
                    Console.WriteLine("Warme drank: {0}", drankGegevens[1]);
            }
            if (gegevens[3] != "")
                Console.WriteLine("Dessert: {0}", gegevens[3]);
            Console.WriteLine("Aantal: {0}", gegevens[4]);
            Console.WriteLine();
        }
    }
}
