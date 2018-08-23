using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voorwerp.Boek;
using Voorwerp.Boekenrek;
using Voorwerp;

namespace TussentijdseOefeningBoeken
{
    class Program
    {
        static void Main(string[] args)
        {

            Boek.Eigenaar = "VDAB";
            IVoorwerpen[] voorwerp = new IVoorwerpen[4];
            //ik[0] = new Boek("Weerwolf", "Frankenstein", new Genre("Horror", new Doelgroep(15)) , 15);
            //ik[1] = new Boek("Hartjes", "J. K. Rowler", new Genre("Romantiek", new Doelgroep(20)), 11);
            voorwerp[0] = new Leesboek("Weerwolf", "Frankenstein", new Genre("Horror", new Doelgroep(15)), 15, "Het gaat over een half-man, half wolf.");
            voorwerp[1] = new Leesboek("Hartjes", "J. K. Rowler", new Genre("Romantiek", new Doelgroep(20)), 11, "Het gaat over een liefdesromantiek.");
            voorwerp[2] = new Woordenboek("Frans-Nederlands", "Pierre", new Genre("Woordenboek", new Doelgroep(20)), 20, "Frans-Nederlands");
            voorwerp[3] = new Boekenrek(1.5m, 3m, 25);


            decimal winst = 0m;

            foreach (IVoorwerpen boek in voorwerp)
            {
                if (boek == voorwerp[0])
                    Console.WriteLine("=========BOEKEN=========");
                if (boek == voorwerp[3])
                    Console.WriteLine("=========BOEKENREKKEN=========");
                boek.GegevensTonen();
                winst += boek.Winst;
                Console.WriteLine();
            }
            Console.WriteLine("totale winst: {0} euro", winst);
        }
    }
}
