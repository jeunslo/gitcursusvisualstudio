using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OefeningenOpLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var planten = new List<Plant>
            {
                new Plant { PlantId = 1, Plantnaam = "Tulp", Kleur = "rood", Prijs = 0.50m, Soort = "bol"},
                new Plant { PlantId = 2, Plantnaam = "Krokus", Kleur = "wit", Prijs = 0.20m, Soort = "bol"},
                new Plant { PlantId = 3, Plantnaam = "Narcis", Kleur = "geel", Prijs = 0.30m, Soort = "bol"},
                new Plant { PlantId = 4, Plantnaam = "Blauw druifje", Kleur = "blauw", Prijs = 0.20m, Soort = "bol"},
                new Plant { PlantId = 5, Plantnaam = "Azalea", Kleur = "rood", Prijs = 3.00m, Soort = "heester"},
                new Plant { PlantId = 6, Plantnaam = "Forsynthia", Kleur = "geel", Prijs = 2.00m, Soort = "heester"},
                new Plant { PlantId = 7, Plantnaam = "Magnolia", Kleur = "wit", Prijs = 4.00m, Soort = "heester"},
                new Plant { PlantId = 8, Plantnaam = "Waterlelie", Kleur = "wit", Prijs = 2.00m, Soort = "water"},
                new Plant { PlantId = 9, Plantnaam = "Lisdode", Kleur = "geel", Prijs = 3.00m, Soort = "water"},
                new Plant { PlantId = 10, Plantnaam = "Kalmoes", Kleur = "geel", Prijs = 2.50m, Soort = "water"},
                new Plant { PlantId = 11, Plantnaam = "Bieslook", Kleur = "paars", Prijs = 1.50m, Soort = "kruid"},
                new Plant { PlantId = 12, Plantnaam = "Rozemarijn", Kleur = "blauw", Prijs = 1.25m, Soort = "kruid"},
                new Plant { PlantId = 13, Plantnaam = "Munt", Kleur = "wit", Prijs = 1.10m, Soort = "kruid"},
                new Plant { PlantId = 14, Plantnaam = "Dragon", Kleur = "wit", Prijs = 1.30m, Soort = "kruid"},
                new Plant { PlantId = 15, Plantnaam = "Basilicum", Kleur = "wit", Prijs = 1.50m, Soort = "kruid"}
            };

            //var opPrijs = from plant in planten
            //              where plant.Kleur == "wit"
            //              orderby plant.Prijs
            //              select plant;
            //foreach (var plant in opPrijs)
            //    Console.WriteLine("{0} - {1} - {2}", plant.Plantnaam, plant.Kleur, plant.Prijs);

            //Console.WriteLine();
            //Console.WriteLine("Aantal witte planten: {0}", opPrijs.Count());

            //Console.WriteLine();
            //var opHeester = from plant in planten
            //                where plant.Soort == "heester"
            //                select plant;
            //Console.WriteLine("Gemiddelde prijs van heesters: {0}", opHeester.Average(gem => gem.Prijs));

            //Console.WriteLine();
            //var opKruid = from plant in planten
            //              where plant.Soort == "kruid"
            //              select plant;
            //Console.WriteLine("Gemiddelde prijs van kruiden: {0}", opKruid.Average(gem => gem.Prijs));
            //Console.WriteLine("Max prijs van kruiden: {0}", opKruid.Max(max => max.Prijs));

            //Console.WriteLine();
            //var opLetterB = from plant in planten
            //                where plant.Plantnaam.StartsWith("B")
            //                select plant;
            //foreach (var plant in opLetterB)
            //    Console.WriteLine(plant.Plantnaam);

            //Console.WriteLine();
            //var opKleur = from plant in planten
            //              group plant by plant.Kleur;
            //foreach (var plant in opKleur.Distinct())
            //{
            //    Console.WriteLine(plant.Key);
            //}

            //Console.WriteLine();
            //foreach (var plant in opKleur)
            //{
            //    Console.WriteLine("planten die {0} zijn:", plant.Key);
            //    foreach (var naam in plant)
            //        Console.WriteLine(naam.Plantnaam);
            //}

            //Console.WriteLine();
            //var opSoort = from plant in planten
            //              group plant by plant.Soort;
            //foreach (var plant in opSoort)
            //    Console.WriteLine("De Maximumprijs is {0} voor de plantsoort, {1}", plant.Max(max => max.Prijs), plant.Key);

            //Console.WriteLine();
            //var opAlfabet = from plant in planten
            //                group plant by plant.Soort
            //                into alfaPlant
            //                orderby alfaPlant.Key
            //                select alfaPlant;
            //foreach (var plantsoort in opAlfabet)
            //{
            //    Console.WriteLine("Plantsoort {0} telt {1} planten", plantsoort.Key, plantsoort.Count());
            //}

            //foreach (var plantsoort in opAlfabet.Distinct())
            //{
            //    Console.WriteLine("{0}: ", plantsoort.Key);
            //    foreach (var plant in plantsoort)
            //        Console.WriteLine(plant.Plantnaam);
            //}

            //Console.WriteLine();
            //var opSoortEnKleur = from plant in planten
            //                     group plant by plant.Soort
            //                     into opPlantSoort
            //                     select new
            //                     {
            //                         Soort = opPlantSoort.Key,
            //                         Groepkleur = from plant in opPlantSoort
            //                                      group plant by plant.Kleur
            //                     };
            //foreach (var plant in opSoortEnKleur)
            //{
            //    Console.WriteLine("===={0}==== ", plant.Soort.ToUpper());
            //    foreach (var kleur in plant.Groepkleur)
            //    {
            //        Console.WriteLine("{0}: ", kleur.Key);
            //        foreach (var naam in kleur)
            //        {
            //            Console.WriteLine("{0} ", naam.Plantnaam);
            //        }
            //    }
            //}

            //OEF1
            //var opPrijs = from plant in planten
            //              where plant.Kleur == "wit"
            //              orderby plant.Prijs
            //              select new { plant.Plantnaam, plant.Kleur, plant.Prijs };
            //foreach (var plant in opPrijs)
            //    Console.WriteLine("{0} - {1} - {2}", plant.Plantnaam, plant.Kleur, plant.Prijs);

            ////OEF2
            //Console.WriteLine();
            //Console.WriteLine("Aantal witte planten: {0}", opPrijs.Count());

            ////OEF3
            //Console.WriteLine();
            //var opHeester = from plant in planten
            //                where plant.Soort == "heester"
            //                select plant.Prijs;
            //Console.WriteLine("Gemiddelde prijs van heesters: {0}", opHeester.Average());

            ////OEF4
            //Console.WriteLine();
            //var opKruid = from plant in planten
            //              where plant.Soort == "kruid"
            //              select plant.Prijs;
            //Console.WriteLine("Gemiddelde prijs van kruiden: {0}", opKruid.Average());
            //Console.WriteLine("Max prijs van kruiden: {0}", opKruid.Max());

            ////OEF5
            //Console.WriteLine();
            //var opLetterB = from plant in planten
            //                where plant.Plantnaam.StartsWith("B")
            //                select plant.Plantnaam;
            //foreach (var plant in opLetterB)
            //    Console.WriteLine(plant);

            ////OEF6
            //Console.WriteLine();
            //var opKleur = from plant in planten
            //              group plant by plant.Kleur;
            //foreach (var plant in opKleur)
            //{
            //    Console.WriteLine(plant.Key);
            //}

            ////OEF7
            //Console.WriteLine();
            //foreach (var plant in opKleur)
            //{
            //    Console.WriteLine("planten die {0} zijn:", plant.Key);
            //    foreach (var naam in plant)
            //        Console.WriteLine(naam.Plantnaam);
            //}

            ////OEF8
            //Console.WriteLine();
            //var opSoort = from plant in planten
            //              group plant by plant.Soort into plantSoort
            //foreach (var plant in opSoort)
            //    Console.WriteLine("De Maximumprijs is {0} voor de plantsoort, {1}", plant.Max(max => max.Prijs), plant.Key);

            //OEF8
            Console.WriteLine();
            var opSoort = from plant in planten
                          group plant by plant.Soort into plantSoort
                          select new
                          {
                              Planten = from p in plantSoort where p.Prijs == plantSoort.Max(max => max.Prijs) select p.Plantnaam,
                              MaxPrijs = plantSoort.Max(max => max.Prijs),
                              Soort = plantSoort.Key
                          };
            foreach (var plant in opSoort)
            {
                Console.WriteLine("De Maximumprijs is {0} voor de plantsoort, {1}", plant.MaxPrijs, plant.Soort);
                foreach (var naam in plant.Planten)
                {
                    Console.WriteLine(naam);
                }
            }

            ////OEF9
            //Console.WriteLine();
            //var opAlfabet = from plant in planten
            //                group plant by plant.Soort
            //                into alfaPlant
            //                orderby alfaPlant.Key
            //                select alfaPlant;
            //foreach (var plantsoort in opAlfabet)
            //{
            //    Console.WriteLine("Plantsoort {0} telt {1} planten", plantsoort.Key, plantsoort.Count());
            //}

            //foreach (var plantsoort in opAlfabet)
            //{
            //    Console.WriteLine("{0}: ", plantsoort.Key);
            //    foreach (var plant in plantsoort)
            //        Console.WriteLine(plant.Plantnaam);
            //}

            ////OEF10
            //Console.WriteLine();
            //var opSoortEnKleur = from plant in planten
            //                     group plant by plant.Soort
            //                     into opPlantSoort
            //                     select new
            //                     {
            //                         Soort = opPlantSoort.Key,
            //                         Groepkleur = from plant in opPlantSoort
            //                                      group plant by plant.Kleur
            //                     };
            //foreach (var plant in opSoortEnKleur)
            //{
            //    Console.WriteLine("===={0}==== ", plant.Soort.ToUpper());
            //    foreach (var kleur in plant.Groepkleur)
            //    {
            //        Console.WriteLine("{0}: ", kleur.Key);
            //        foreach (var naam in kleur)
            //        {
            //            Console.WriteLine("{0} ", naam.Plantnaam);
            //        }
            //    }
            //}
        }


    }
}
