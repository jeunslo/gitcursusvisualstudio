using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Materiaal
{
    public delegate void Onderhoudsbeurt(Fotokopiemachine machine);
    public class Fotokopiemachine : IKost
    {
        public class KostPerBlzException : Exception
        {
            private decimal verkeerdeKostValue;

            public decimal VerkeerdeKost
            {
                get
                {
                    return verkeerdeKostValue;
                }
                set
                {
                    verkeerdeKostValue = value;
                }
            }

            public KostPerBlzException(string message, decimal verkeerdeKost) : base(message)
            {
                VerkeerdeKost = verkeerdeKost;
            }
        }

        public class AantalBlzException : Exception
        {
            private int verkeerdeAantalBlzValue;

            public int VerkeerdeAantalBlz
            {
                get
                {
                    return verkeerdeAantalBlzValue;
                }
                set
                {
                    verkeerdeAantalBlzValue = value;
                }
            }

            public AantalBlzException(string message, int verkeerdeAantalBlz) : base(message)
            {
                VerkeerdeAantalBlz = verkeerdeAantalBlz;
            }
        }

        private string serieNrValue;
        private int aantalGekopieerdeBlzValue;
        private decimal kostPerBlzValue;

        public string SerieNr
        {
            get
            {
                return serieNrValue;
            }
            set
            {
                serieNrValue = value;
            }
        }

        public int AantalGekopieerdeBlz
        {
            get
            {
                return aantalGekopieerdeBlzValue;
            }
            set
            {
                if (value < 0)
                    throw new AantalBlzException("Aantal blz. < 0!", value);
                aantalGekopieerdeBlzValue = value;
            }
        }

        public decimal KostPerBlz
        {
            get
            {
                return kostPerBlzValue;
            }
            set
            {
                if (value <= 0)
                    throw new KostPerBlzException("Kost per blz. <=0!", value);
                kostPerBlzValue = value;
            }
        }

        public Fotokopiemachine(string serieNr, int aantalGekopieerdeBlz, decimal kostPerBlz)
        {
            SerieNr = serieNr;
            AantalGekopieerdeBlz = aantalGekopieerdeBlz;
            KostPerBlz = kostPerBlz;
        }

        public decimal Bedrag
        {
            get
            {
                return AantalGekopieerdeBlz * KostPerBlz;
            }
        }

        public bool Menselijk
        {
            get
            {
                return false;
            }
        }

        public event Onderhoudsbeurt OnderhoudNodig;
        private const int AantalBlzTussenOnderhoudsBeurten = 10;

        public void Fotokopieer(int aantalBlz)
        {
            for (int blz = 1; blz <= aantalBlz; blz++)
            {
                Console.WriteLine($"FotokopieMachine {SerieNr} kopieert " + $"blz. {blz} van {aantalBlz}");
                if (++AantalGekopieerdeBlz % AantalBlzTussenOnderhoudsBeurten == 0)
                    if (OnderhoudNodig != null)
                        OnderhoudNodig(this);
            }
        }
    }
}
