using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressieOefeningen
{
    class Program
    {
        delegate ConsoleColor Kleur(int getal);
        static void Main(string[] args)
        {
            //var arrayGetallen = new[] { 0, -1, 2, 3, 4, -5, 6, 7, 8, -9, 10};

            //Func<int, bool> evenGetal = getal => getal % 2 == 0;
            //Func<int, bool> onevenGetal = getal => getal % 2 == 1;

            //foreach (var getal in arrayGetallen)
            //{
            //    if (evenGetal(getal))
            //        Console.ForegroundColor = ConsoleColor.Green;
            //    else
            //        Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine(getal);
            //}

            //Console.WriteLine();

            Func<int, ConsoleColor> posGetal = getal => getal >= 0 ? ConsoleColor.White : ConsoleColor.Yellow;
            ToonFuncGetallen(posGetal);
            //Func<int, bool> negGetal = getal => getal < 0;

            //foreach (var getal in arrayGetallen)
            //{
            //    if (posGetal(getal))
            //        Console.ForegroundColor = ConsoleColor.White;
            //    else
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine(getal);
            //}

            Kleur evenOfOnevenGetal = getal => getal % 2 == 0 ? ConsoleColor.Green : ConsoleColor.Red;
            Kleur posOfNegGetal = getal => getal >= 0 ? ConsoleColor.White : ConsoleColor.Yellow;

            ToonGetallen(evenOfOnevenGetal);
            ToonGetallen(posOfNegGetal);
        }

        private static void ToonGetallen(Kleur kleur)
        {
            var arrayGetallen = new List<int> { 0, -1, 2, 3, 4, -5, 6, 7, 8, -9, 10 };

            arrayGetallen.Insert(0, 5);

            Console.WriteLine("Average?: {0}", arrayGetallen.Average());
            foreach (var getal in arrayGetallen)
            { 
                Console.ForegroundColor = kleur(getal);
                Console.WriteLine(getal);
            }
            Console.WriteLine();
        }

        private static void ToonFuncGetallen(Func<int, ConsoleColor> kleur)
        {
            var arrayGetallen = new[] { 0, -1, 2, 3, 4, -5, 6, 7, 8, -9, 10 };
            foreach (var getal in arrayGetallen)
            {
                Console.ForegroundColor = kleur(getal);
                Console.WriteLine(getal);
            }
            Console.WriteLine();
        }
    }
}
