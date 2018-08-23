using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OefeningOpPizza
{
    public class Klant
    {
        private static int IDValue = 1;


        public Klant()
        {
            Naam = "Onbekende klant";
            KlantID = 0;
        }

        public Klant(string naam)
        {
            Naam = naam;
            KlantID = IDValue;
            IDValue++;
        }
        public int KlantID { get; }

        public string Naam { get; set; }

        public override string ToString()
        {
            return string.Format("{0}#{1}", KlantID, Naam);
        }

        public void KlantWegSchrijven(Klant klant)
        {
            string locatie = @"C:\Data\";
            string klantRegel;
            try
            {
                using (var schrijver = new StreamWriter(locatie + "klanten.txt", true))
                {
                        klantRegel = klant.ToString();
                        schrijver.WriteLine(klantRegel);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Fout bij het schrijven van het bestand!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Klant> KlantLezen()
        {
            string locatie = @"C:\Data\";
            List<Klant> klanten = new List<Klant>();
            string klantNaam;
            string klantRegel;
            try
            {
                using (var lezer = new StreamReader(locatie + "klanten.txt"))
                {
                    while ((klantRegel = lezer.ReadLine()) != null)
                    {
                        string[] gegevens = klantRegel.Split(new char[] { '#' });
                        klantNaam = gegevens[1];
                        klanten.Add(new Klant(Naam = klantNaam));
                    }
                    return klanten;
                }
               
            }
            catch (IOException)
            {
                throw new Exception("Fout bij het lezen van het bestand!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
