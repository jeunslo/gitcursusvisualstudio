using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OefeningOpPizza
{
    //public delegate string NaarString();
    public abstract class Gerecht : IBedrag
    {
        public Gerecht()
        {
        }

        public Gerecht(string naam, decimal prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }

        public string Naam { get; set; }

        public decimal Prijs { get; set; }

        public decimal BerekenBedrag()
        {
            return Prijs;
        }

        public override string ToString()
        {
            return string.Format("Gerecht: {0} <{1} euro>", Naam, Prijs);
        }

        //public event NaarString PizzaString;
        //public event NaarString PastaString;
        //public void GerechtWegSchrijven(List<Gerecht> gerechten)
        //{
        //    string locatie = @"C:\Data\";
        //    StringBuilder gerechtRegel;
        //    try
        //    {
        //        using (var schrijver = new StreamWriter(locatie + "gerechten.txt"))
        //        {
        //            foreach (var gerecht in gerechten)
        //            {
        //                gerechtRegel = new StringBuilder();
        //                if (gerecht is Pizza)
        //                {
        //                    gerechtRegel.Append(PizzaString);                            
        //                }
        //                if (gerecht is Pasta)
        //                {
        //                    gerechtRegel.Append(PastaString);
        //                }                         
        //                schrijver.WriteLine(gerechtRegel);
        //            }
        //        }
        //    }
        //    catch (IOException)
        //    {
        //        Console.WriteLine("Fout bij het schrijven van het bestand!");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        //public List<Gerecht> GerechtLezen()
        //{
        //    string locatie = @"C:\Data\";
        //    List<Gerecht> gerechten = new List<Gerecht>();
        //    string gerechtNaam;
        //    decimal gerechtPrijs;
        //    List<string> gerechtOnderdelen = new List<string>();
        //    string gerechtRegel;
        //    try
        //    {
        //        using (var lezer = new StreamReader(locatie + "gerechten.txt"))
        //        {
        //            while ((gerechtRegel = lezer.ReadLine()) != null)
        //            {
        //                string[] gegevens = gerechtRegel.Split(new char[] { '#' });
        //                gerechtNaam = gegevens[1];
        //                decimal.TryParse(gegevens[2], out gerechtPrijs);
        //                if (gegevens[0] == "pizza")
        //                {
        //                    for (var i = 2; i < gegevens.Length; i++)
        //                        gerechtOnderdelen.Add(gegevens[i]);
        //                    gerechten.Add(new Pizza(gerechtNaam, gerechtPrijs, gerechtOnderdelen));
        //                }
        //                if (gegevens[0] == "pasta")                       
        //                    gerechten.Add(new Pasta(gerechtNaam, gerechtPrijs, gegevens[3]));
        //            }
        //            return gerechten;
        //        }

        //    }
        //    catch (IOException)
        //    {
        //        throw new Exception("Fout bij het schrijven van het bestand!");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
    }
}
