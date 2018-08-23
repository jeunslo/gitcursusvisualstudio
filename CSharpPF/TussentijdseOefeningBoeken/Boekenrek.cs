using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorwerp.Boekenrek
{
    public class Boekenrek : IVoorwerpen
    {
        private decimal hoogteValue;
        private decimal breedteValue;
        private decimal aankoopPrijsValue;

        public Boekenrek(decimal hoogte, decimal breedte, decimal aankoopPrijs)
        {
            Hoogte = hoogte;
            Breedte = breedte;
            AankoopPrijs = aankoopPrijs;
        }

        public decimal Hoogte
        {
            get
            {
                return hoogteValue;
            }
            set
            {
                hoogteValue = value;
            }
        }

        public decimal Breedte
        {
            get
            {
                return breedteValue;
            }
            set
            {
                breedteValue = value;
            }
        }

        public decimal AankoopPrijs
        {
            get
            {
                return aankoopPrijsValue;
            }
            set
            {
                aankoopPrijsValue = value;
            }
        }

        public decimal Winst
        {
            get
            {
                return AankoopPrijs * 2;
            }
        }

        public void GegevensTonen()
        {
            Console.WriteLine("Hoogte: {0:0.00} m", Hoogte);
            Console.WriteLine("Breedte: {0:0.00} m", Breedte);
            Console.WriteLine("Aankoopprijs: {0:0.00} euro", AankoopPrijs);
        }
    }
}
