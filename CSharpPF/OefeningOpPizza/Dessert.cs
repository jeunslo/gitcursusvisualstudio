using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOpPizza
{
    public class Dessert : IBedrag
    {
        public enum Dessertverzameling
        {
            Tiramisu, Ijs, Cake
        }

        public Dessertverzameling Naam { get; set; }
        public decimal Prijs
        {
            get
            {
                switch (Naam)
                {
                    case Dessertverzameling.Tiramisu:
                        return 3m;
                    case Dessertverzameling.Ijs:
                        return 3m;
                    case Dessertverzameling.Cake:
                        return 2m;
                    default:
                        return 0;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Dessert: {0} <{1:0.0} euro>", Naam, Prijs);
        }

        public decimal BerekenBedrag()
        {
            return Prijs;
        }
    }
}
