using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    class OmrekeningSeconden
    {
        
        static void Main(string[] args)
        {
            float huidigeSeconden = 3736F;
            int aantalUren = (int)huidigeSeconden / 3600;
            int restSeconden = (int)huidigeSeconden % 3600;
            Console.WriteLine(restSeconden);
            int aantalMinuten = restSeconden / 60;
            int aantalSeconden = restSeconden % 60;
            Console.WriteLine("U:" + aantalUren + " M:" + aantalMinuten + " S:" + aantalSeconden);
        }
    }
}
