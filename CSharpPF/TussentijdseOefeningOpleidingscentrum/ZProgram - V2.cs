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
    class ProgramV2
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("============Verplicht vakanties=============");
            //Console.WriteLine(PersoneelslidV2.VerlofPeriodeV3.VerlofPeriodes.Zomervakantie);
            //Console.WriteLine();

            //PersoneelslidV2.VerlofPeriodeV3[] aVerlofPeriodes = new PersoneelslidV2.VerlofPeriodeV3[2];
            //aVerlofPeriodes[0] = new PersoneelslidV2.VerlofPeriodeV3(PersoneelslidV2.VerlofPeriodeV3.VerlofPeriodes.Kerstvakantie);
            //aVerlofPeriodes[1] = new PersoneelslidV2.VerlofPeriodeV3(PersoneelslidV2.VerlofPeriodeV3.VerlofPeriodes.Zomervakantie);

            //PersoneelslidV2.VerlofPeriodePersoneel = aVerlofPeriodes;

            VerlofPeriodeV2[] aVakanties = new VerlofPeriodeV2[2]; 
            aVakanties[0] = new VerlofPeriodeV2("Kerstvakantie", new DateTime(DateTime.Today.Year, 12, 24), new DateTime(DateTime.Today.AddYears(1).Year, 1, 1));
            aVakanties[1] = new VerlofPeriodeV2("Zomervakantie", new DateTime(DateTime.Today.Year, 7, 1), new DateTime(DateTime.Today.Year, 7, 31));

            //Console.WriteLine("=====Verplichte VerlofPeriodes======");
            //foreach (PersoneelslidV2.VerlofPeriodeV3 periode in aVerlofPeriodes)
            //{
            //    Console.WriteLine(periode);
            //}
            //Console.WriteLine();

            Kosten[] aGegevens = new Kosten[5];
            //ik[0] = new Personeelslid("Lo", "Jeunsing", 1000);
            //ik[1] = new Personeelslid("Lol", "Jeuns", 3000);
            //ik[2] = new Personeelslid("Lola", "Jeunsman", 500);
            aGegevens[2] = new Instructeur("LopaInstr", "Teur", 5000, Vakgebieden.netwerken, "polo@hotmail.com");
            aGegevens[3] = new Instructeur("VerkeerdeInstr", "Teuror", 5000, Vakgebieden.ontwikkeling, "para.com");
            aGegevens[4] = new Medewerker("MedeLo", "werkerJeuns", 1000, 10);
            aGegevens[0] = new Infrastructuur("goedkoopGebouw", 1500);
            aGegevens[1] = new Infrastructuur("duurGebouw", 2500);

            decimal totaleMaandkost = 0m;
 
            foreach (Kosten kost in aGegevens)
            {
                if(kost == aGegevens[0])
                    Console.WriteLine("============GEBOUWEN=============");
                if (kost == aGegevens[2])
                    Console.WriteLine("============PERSONEEL=============");
                kost.GegevensTonen();
                totaleMaandkost += kost.Maandkost;
                Console.WriteLine();                
            }
            Console.WriteLine("Totale maandkost: {0:0.00} euro", totaleMaandkost);    
        }
    }
}
