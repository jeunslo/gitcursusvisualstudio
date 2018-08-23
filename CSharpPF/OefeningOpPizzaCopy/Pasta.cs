using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OefeningOpPizza
{
    public class Pasta : Gerecht
    {
        public Pasta()
        {
        }

        public Pasta(string naam, decimal prijs, string omschrijving) : base(naam, prijs)
        {
            Omschrijving = omschrijving;
        }

        public string Omschrijving { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format(" {0} ", Omschrijving);
        }

        public string PastaStringToBestand(Pasta pasta)
        {
            return string.Format("pasta#{0}#{1}#{2}", pasta.Naam, pasta.Prijs, pasta.Omschrijving);
        }

        public void PastaWegSchrijven(Pasta pasta)
        {
            string locatie = @"C:\Data\";
            StringBuilder gerechtRegel;
            try
            {
                using (var schrijver = new StreamWriter(locatie + "gerechten.txt", true))
                {
                    gerechtRegel = new StringBuilder();
                    gerechtRegel.Append(PastaStringToBestand(pasta));
                    schrijver.WriteLine(gerechtRegel);
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
    }
}
