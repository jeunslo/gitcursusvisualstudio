using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFCursus
{
    public static class LijnenTrekker
    {
        public static void TrekLijn(int lengte = 79, char teken = '-')
        {
            for (int teller = 0; teller < lengte; teller++)
                Console.Write(teken);
            Console.WriteLine();
        }
    }
}
