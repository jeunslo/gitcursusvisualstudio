using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    class ConversieCelsiusFahrenheit
    {
        const float GemLichTempCelsius = 37.00F;
        static readonly float CelsiusNaarFahrenheit = 9.00F / 5.00F;
        static void Main(string[] args)
        {
            Console.WriteLine(CelsiusNaarFahrenheit);
            Console.WriteLine(GemLichTempCelsius * CelsiusNaarFahrenheit+32.00F);
        }
    }
}
