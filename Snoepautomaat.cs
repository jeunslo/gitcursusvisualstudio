using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    class Snoepautomaat
    {
        static void Main(string[] args)
        {
            decimal snoepKost = 1.94m;
            int eenEuro, fiftyCent, twentyCent, tenCent;
            int fiveCent, twoCent, oneCent;

            decimal rest = 2.00m - snoepKost;
            Console.WriteLine(rest);
            int restCenten = (int)(rest * 100);
            Console.WriteLine(restCenten);

            eenEuro = restCenten / 100;
            restCenten %= 100;

            fiftyCent = restCenten / 50;
            restCenten %= 50;

            twentyCent = restCenten / 20;
            restCenten %= 20;

            tenCent = restCenten / 10;
            restCenten %= 10;

            fiveCent = restCenten / 5;
            restCenten %= 5;

            twoCent = restCenten / 2;

            oneCent = restCenten % 2;

            Console.WriteLine("1 euro: "+eenEuro + " / 50 Cent: " + fiftyCent + " / 20 Cent: " + twentyCent + " / 10 Cent: " + tenCent + " / 5 Cent: " + fiveCent + " / 2 Cent: " + twoCent + " / 1 Cent: " + oneCent);
        }
    }
}
