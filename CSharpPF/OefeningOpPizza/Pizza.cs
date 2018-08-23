using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OefeningOpPizza
{
    public class Pizza : Gerecht
    {
        public Pizza()
        {
        }

        public Pizza(string naam, decimal prijs, List<string> onderdelen) : base(naam, prijs)
        {
            Onderdelen = onderdelen;
        }

        public List<string> Onderdelen { get; set; }

        public override string ToString()
        {
            string onderdeelTekst = string.Join(" - ", Onderdelen);
            return base.ToString() + string.Format(" {0} ", onderdeelTekst);
        }

        public string PizzaStringToBestand(Pizza pizza)
        {
            string onderdeelTekst = string.Join("#", pizza.Onderdelen);
            return string.Format("pizza#{0}#{1}#{2}", pizza.Naam, pizza.Prijs, onderdeelTekst);
        }

        public void PizzaWegSchrijven(Pizza pizza)
        {
            string locatie = @"C:\Data\";
            StringBuilder gerechtRegel;
            try
            {
                using (var schrijver = new StreamWriter(locatie + "gerechten.txt", true))
                {
                        gerechtRegel = new StringBuilder();
                        gerechtRegel.Append(PizzaStringToBestand(pizza));
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
