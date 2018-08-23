using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opleiding;
using Opleiding.Infrastructuur;
using Opleiding.Personeel;

namespace TussentijdseOefeningOpleidingscentrum
{
    class Program
    {
        static void Main(string[] args)
        {
            VerlofPeriodeV2[] aVakanties = new VerlofPeriodeV2[2];
            aVakanties[0] = new VerlofPeriodeV2("Kerstvakantie", new DateTime(DateTime.Today.Year, 12, 24), new DateTime(DateTime.Today.AddYears(1).Year, 1, 1));
            aVakanties[1] = new VerlofPeriodeV2("Zomervakantie", new DateTime(DateTime.Today.Year, 7, 1), new DateTime(DateTime.Today.Year, 7, 31));
            PersoneelslidV2.VerlofPeriodePersoneel = aVakanties;

            try
            {
                Kosten[] aGegevens = new Kosten[5];
                aGegevens[2] = new Instructeur("LopaInstr", "Teur", 5000, Vakgebieden.netwerken, "polo@hotmail.com");
                aGegevens[3] = new Instructeur("VerkeerdeInstr", "Teuror", 5000, Vakgebieden.ontwikkeling, "para.com");
                aGegevens[4] = new Medewerker("MedeLo", "werkerJeuns", 1000, 10);
                aGegevens[0] = new Infrastructuur("goedkoopGebouw", 1500);
                aGegevens[1] = new Infrastructuur("duurGebouw", 2500);

                decimal totaleMaandkost = 0m;

                foreach (Kosten kost in aGegevens)
                {
                    if (kost == aGegevens[0])
                        Console.WriteLine("============GEBOUWEN=============");
                    if (kost == aGegevens[2])
                        Console.WriteLine("============PERSONEEL=============");
                    kost.GegevensTonen();
                    totaleMaandkost += kost.Maandkost;
                    Console.WriteLine();
                }
                Console.WriteLine("Totale maandkost: {0:0.00} euro", totaleMaandkost);
            }
            catch (Instructeur.OngeldigEmailadressException ex)
            {
                Console.WriteLine("Fout: {0}: {1}", ex.Message, ex.OngeldigEmail);
            }           
        }
    }
}
