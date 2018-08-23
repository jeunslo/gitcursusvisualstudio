using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oplossing
{
    [Serializable]
    public class Tweet
    {
        public Tweet()
        {
            
        }

        public string Naam { get; set; }
        public DateTime Tijdstip { get; private set; }

        private string berichtValue;
        public string Bericht 
        {
            get
            {
                return berichtValue;
            }
            set
            {
                berichtValue = value.Length <= 140 ? value : value.Substring(0, 140);
            }
        }

        public override string ToString()
        {
            var tekst = string.Format("Naam: {0}{1}Bericht:{2}{3}{4}", Naam, Environment.NewLine, Environment.NewLine, Bericht, Environment.NewLine);
            var geleden = DateTime.Now - Tijdstip;

            if (geleden.Days > 0)
                return tekst += string.Format("{0}", Tijdstip);
            else if (geleden.Hours > 0)
                return tekst += string.Format("{0} uur geleden", geleden.Hours);
            else if (geleden.Minutes > 0)
                return tekst += string.Format("{0} {1} geleden", geleden.Minutes, geleden.Minutes == 1 ? "minuut" : "minuten");
            else
                return tekst += string.Format("{0}", DateTime.Now.ToShortTimeString());
        }
    }
}
