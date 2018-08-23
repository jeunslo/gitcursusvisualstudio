using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OefeningOpPizza;
using System.IO;

namespace OefeningOpPizza
{
    class Program
    {
        public static List<Gerecht> gerechten = new List<Gerecht>
            {
                new Pizza("Pizza Margharita", 8m, new List<string>() { "Tomatensaus", "Mozzarella" }),
                new Pizza("Pizza Napoli", 10m, new List<string>() { "Tomatensaus", "Mozzarella", "Ansjovis", "Kappers", "Olijven" }),
                new Pizza("Pizza Lardiera", 9.5m, new List<string>() { "Tomatensaus", "Mozzarella", "Spek" }),
                new Pizza("Pizza Vegetariana", 9.5m, new List<string>() { "Tomatensaus", "Mozzarella", "Groenten" }),
                new Pasta("Spaghetti Bolognese", 12m, "met gehaktsaus"),
                new Pasta("Spaghetti Carbonara", 13m, "spek, roomsaus en parmezaanse kaas"),
                new Pasta("Penne Arrabbiata", 14m, "met pittige tomatensaus"),
                new Pasta("Lasagna", 15m, "")

            };

        public static List<Drank> dranken = new List<Drank>
                {
                new Frisdrank { Naam = Drank.Drankverzameling.Cocacola },
                new Frisdrank { Naam = Drank.Drankverzameling.Limonade },
                new Frisdrank { Naam = Drank.Drankverzameling.Water },
                new Warmedrank { Naam = Drank.Drankverzameling.Koffie },
                new Warmedrank { Naam = Drank.Drankverzameling.Thee }
                };

        public static List<Dessert> desserts = new List<Dessert>
            {
                new Dessert { Naam = Dessert.Dessertverzameling.Cake },
                new Dessert { Naam = Dessert.Dessertverzameling.Ijs },
                new Dessert { Naam = Dessert.Dessertverzameling.Tiramisu }
            };

        public static List<BesteldGerecht.Extra> extraatjes = new List<BesteldGerecht.Extra>
            {
                BesteldGerecht.Extra.Brood, BesteldGerecht.Extra.Kaas, BesteldGerecht.Extra.Look
            };


        static void Main(string[] args)
        {
            //**********Console app***************

            try
            {
                string keuze = "1";
                int aantalBestellingen = 0;
                List<Bestellingen> bestellinglijst = new List<Bestellingen>();
                //alle klanten uit bestand halen zodat klantID's kloppen
                Klant klantbestand = new Klant();
                List<Klant> klanten;
                if (File.Exists(@"C:\Data\klanten.txt"))
                {
                     klanten = klantbestand.KlantLezen();
                }
                else
                {
                    klanten = new List<Klant>();
                }
                while (keuze != "STOP")
                {
                    Bestellingen bestelling = new Bestellingen();
                    //Klantgegevens opvragen
                    Console.WriteLine("Geregristreerde klant? y(yes) or n(no) ['stop' om te stoppen]");
                    keuze = Console.ReadLine();
                    KeuzeControle(ref keuze);
                    Klant klant = new Klant();
                    if (keuze == "stop")
                        break;
                    if (keuze == "y")
                    {
                        Console.WriteLine("Voer uw naam in:");
                        string bestaandKlant = Console.ReadLine();
                        while (CheckKlantInList(klanten, bestaandKlant) == false)
                        {
                            Console.WriteLine("Naam bestaat niet, voer nieuw naam in:");
                            bestaandKlant = Console.ReadLine();
                            if (bestaandKlant == "stop")
                                break;
                        }
                        foreach (var klantNaam in klanten)
                        {
                            if (klantNaam.Naam == bestaandKlant)
                            {
                                klant = klantNaam;
                            }
                        }
                    }
                    if (keuze == "n")
                    {
                        Console.WriteLine("Wilt u registreren? y(yes) or n(no)");
                        keuze = Console.ReadLine();
                        KeuzeControle(ref keuze);
                        if (keuze == "y")
                        {
                            Console.WriteLine("Voer een klantNaam in:");
                            string nieuwKlant = Console.ReadLine();
                            while (CheckKlantInList(klanten, nieuwKlant) == true)
                            {
                                Console.WriteLine("Naam bestaat al, voer nieuw naam in:");
                                nieuwKlant = Console.ReadLine();
                            }
                            klant = new Klant(nieuwKlant);
                            klanten.Add(klant);
                            klantbestand.KlantWegSchrijven(klant);
                        }
                    }
                    bestelling.Klant = klant;


                    //gerecht bestellen
                    MaakKeuze("gerecht", bestelling);
                    MaakKeuze("drank", bestelling);
                    MaakKeuze("dessert", bestelling);
                    Console.WriteLine("Hoeveel keer wilt u uw bestelling bestellen?");
                    int aantal;
                    int.TryParse(Console.ReadLine(), out aantal);
                    while (aantal <= 0)
                    {
                        Console.WriteLine("Kies een werkelijk aantal");
                        int.TryParse(Console.ReadLine(), out aantal);
                    }
                    bestelling.Aantal = aantal;
                    Console.WriteLine();
                    Console.WriteLine("==================Overzicht=========================");
                    Console.WriteLine("bestelling {0}:", ++aantalBestellingen);
                    Console.WriteLine(bestelling);
                    TekenSterretjes();
                    bestellinglijst.Add(bestelling);
                    bestelling.BestellingWegSchrijven(bestelling);
                }
                //Toon alle bestellingen wanneer er "STOP" wordt ingevoerd
                Console.WriteLine("=========================Lijst van BESTELLINGEN============================");
                aantalBestellingen = 0;
                foreach (var eenBestelling in bestellinglijst)
                {
                    Console.WriteLine("bestelling {0}:", ++aantalBestellingen);
                    Console.WriteLine(eenBestelling);
                    TekenSterretjes();
                }

                //*********Sortering op naam***************
                Console.WriteLine("=========================Sortering op NAAM============================");
                Console.WriteLine("Toon bestellingen van klant: ");
                string toonKlantnaam = Console.ReadLine();
                foreach (var bestelOpNaam in SorteerOpNaam(toonKlantnaam, bestellinglijst))
                {
                    Console.WriteLine(bestelOpNaam);
                    Console.WriteLine();
                }
                TekenSterretjes();

                //********Sortering per Groep********************
                Console.WriteLine("=========================Sortering op GROEP============================");
                pauze();
                var opGroep = from bestelling in bestellinglijst where bestelling.Klant.Naam != "Onbekende klant" group bestelling by bestelling.Klant.Naam;
                foreach (var klant in opGroep)
                {
                    decimal totaleBedrag = 0m;
                    Console.WriteLine("Bestellingen van klant {0}: ", klant.Key);
                    Console.WriteLine();
                    foreach (var gegevens in klant)
                    {
                        Console.WriteLine(gegevens);
                        totaleBedrag += gegevens.BerekenBedrag();
                        Console.WriteLine();
                    }
                    Console.WriteLine("Het totaal bedrag van alle bestellingen van klant {0}: {1} euro", klant.Key, totaleBedrag);
                    TekenSterretjes();
                }
                //*********Sortering op Onbekende klant***************
                Console.WriteLine("Onbekende klanten: ");
                foreach (var bestelOpNaam in SorteerOpNaam("Onbekende klant", bestellinglijst))
                {
                    Console.WriteLine(bestelOpNaam);
                    Console.WriteLine();
                }
                TekenSterretjes();

                //*****************DEEL 2: Gerechten Wegschrijven*************
                pauze();
                List<Gerecht> gerechtenLijst = new List<Gerecht>() {
                                                                        new Pizza("Pizza Margharita", 8m, new List<string>() { "Tomatensaus", "Mozzarella" }),
                                                                        new Pizza("Pizza Napoli", 10m, new List<string>() { "Tomatensaus", "Mozzarella", "Ansjovis", "Kappers", "Olijven" }),
                                                                        new Pizza("Pizza Lardiera", 9.5m, new List<string>() { "Tomatensaus", "Mozzarella", "Spek" }),
                                                                        new Pizza("Pizza Vegetariana", 9.5m, new List<string>() { "Tomatensaus", "Mozzarella", "Groenten" }),
                                                                        new Pasta("Spaghetti Bolognese", 12m, "met gehaktsaus"),
                                                                        new Pasta("Spaghetti Carbonara", 13m, "spek, roomsaus en parmezaanse kaas"),
                                                                        new Pasta("Penne Arrabbiata", 14m, "met pittige tomatensaus"),
                                                                        new Pasta("Lasagna", 15m, "")
                                                                    };
                Pizza pizzaBestand = new Pizza();
                Pasta pastaBestand = new Pasta();

                foreach (var gerecht in gerechtenLijst)
                {
                    if (gerecht is Pasta)
                        pastaBestand.PastaWegSchrijven((Pasta)gerecht);
                    if (gerecht is Pizza)
                        pizzaBestand.PizzaWegSchrijven((Pizza)gerecht);
                }
                Console.WriteLine("Deel 2: gerechten.txt aangemaakt");

                //***************BestellingBestand uitlezen********************
                Console.WriteLine("=========================BestellingenBestand lezen============================");
                pauze();
                Bestellingen bestellingBestand = new Bestellingen();
                bestellingBestand.BestellingBestandLezen();
                TekenSterretjes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }//einde STATIC VOID MAIN


        //********************************ALLE METHODS*********************************************

        private static bool CheckKlantInList(List<Klant> klanten, string naam)
        {
            foreach (var klantNaam in klanten)
            {
                if (klantNaam.Naam == naam)
                {
                    return true;
                }
            }
            return false;
        }

        private static string KeuzeControle(ref string keuze)
        {
            while (keuze != "y" && keuze != "n" && keuze != "stop")
            {
                Console.WriteLine("Type 'y' of 'n'");
                keuze = Console.ReadLine();
            };
            return keuze;
        }

        //method om te bepalen welke array er gebruikt moet worden en de keuzes tonen
        private static void MaakKeuze(string voedsel, Bestellingen bestelling)
        {
            Console.WriteLine("Wilt u een {0} bestellen? y(yes) or n(no)", voedsel);
            var keuze = Console.ReadLine();
            KeuzeControle(ref keuze);
            if (keuze == "y")
            {
                //keuzeLijst gerechten
                Console.WriteLine("Maak een keuze tussen:");              
                int itemKeuze = 0;
                switch (voedsel)
                {
                    case "gerecht":
                        //Lijst van gerechten tonen en getal kiezen
                        ToonLijst(gerechten);
                        itemKeuze = KiesGetalUitList(gerechten);
                        //referenties leggen naar objects
                        Gerecht besteldGerecht = gerechten[itemKeuze - 1];
                        //Extra's lijsten en referenties naar objecten
                        BesteldGerecht.Grootte grootte = ExtraGrootte(besteldGerecht);
                        List<BesteldGerecht.Extra> extraLijst = ExtraExtras();
                        BesteldGerecht besteldeGerecht = new BesteldGerecht(besteldGerecht, grootte, extraLijst);
                        bestelling.BesteldGerecht = besteldeGerecht;
                        break;
                    case "drank":
                        //Lijst van dranken tonen en getal kiezen
                        ToonLijst(dranken);
                        itemKeuze = KiesGetalUitList(dranken);
                        //referenties leggen naar objects
                        Drank besteldDrank = dranken[itemKeuze - 1];
                        bestelling.Drank = besteldDrank;
                        break;
                    case "dessert":
                        //Lijst van desserts tonen en getal kiezen
                        ToonLijst(desserts);
                        itemKeuze = KiesGetalUitList(desserts);
                        //referenties leggen naar objects
                        Dessert besteldDessert = desserts[itemKeuze - 1];
                        bestelling.Dessert = besteldDessert;
                        break;
                }
            }
        }

        //array weergeven in de applicatie
        private static void ToonLijst(IEnumerable<dynamic> list)
        {
            int i = 0;
            foreach (dynamic item in list)
            {
                Console.WriteLine("{0}.({1}) / prijs: {2} euro", ++i, item.Naam, item.Prijs);
            }
        }

        //je keuze uit de array controleren en teruggeven
        private static int KiesGetalUitList(IEnumerable<dynamic> list)
        {
            int max = list.Count();
            //de input controleren
            int gerechtKeuze = ControleKeuzeGetal(max);
            return gerechtKeuze;
        }


        //referentie leggen in Bestellingen om grootte te plaatsen
        private static BesteldGerecht.Grootte ExtraGrootte(Gerecht gerecht)
        {
            //grootte opvragen
            Console.WriteLine("Wilt u een groot of klein {0}?", gerecht.Naam);
            var grootteKeuze = Console.ReadLine();
            while (grootteKeuze != "groot" && grootteKeuze != "klein")
            {
                Console.WriteLine("Type 'groot' of 'klein'");
                grootteKeuze = Console.ReadLine();
            };
            BesteldGerecht.Grootte grootte = BesteldGerecht.Grootte.Klein;
            if (grootteKeuze == "groot")
                grootte = BesteldGerecht.Grootte.Groot;
            return grootte;
        }

        //referentie leggen in Bestellingen om extras te plaatsen
        private static List<BesteldGerecht.Extra> ExtraExtras()
        {
            //extras opvragen
            Console.WriteLine("Wilt u extra's bestellen (1 euro/extra)? y(yes) or n(no)");
            var keuze = Console.ReadLine();
            KeuzeControle(ref keuze);
            var extraGekozenLijst = new List<BesteldGerecht.Extra>();
            if (keuze == "y")
            {
                Console.WriteLine("Maak een keuze tussen:");
                var i = 0;
                //Alle extras uit een array weergeven in applicatie
                foreach (var extra in extraatjes)
                    Console.WriteLine("{0}.({1})", ++i, extra);
                int max = extraatjes.Count();
                Console.WriteLine("{0}.(stoppen)", max + 1);
                int extrakeuze = 0;
                int aantalExtras = 0;
                List<int> gekozenGetallen = new List<int>();
                while (extrakeuze != 4)
                {
                    extrakeuze = ControleKeuzeGetal(max + 1);
                    if (gekozenGetallen.Count() != 0)
                    {
                        //uw keuze checken
                        bool check = true;
                        while (check == true)
                        {
                            foreach (var getal in gekozenGetallen)
                            {
                                if (getal == extrakeuze)
                                {
                                    Console.WriteLine("U heeft keuze {0} al reeds gekozen, maak een nieuwe keuze:", extrakeuze);
                                    extrakeuze = ControleKeuzeGetal(max + 1);
                                    check = true;
                                    break;
                                }
                                else
                                    check = false;
                            }

                        }
                    }
                    gekozenGetallen.Add(extrakeuze);
                    switch (extrakeuze)
                    {
                        case 1:
                            extraGekozenLijst.Add(BesteldGerecht.Extra.Brood);
                            break;
                        case 2:
                            extraGekozenLijst.Add(BesteldGerecht.Extra.Kaas);
                            break;
                        case 3:
                            extraGekozenLijst.Add(BesteldGerecht.Extra.Look);
                            break;
                        default:
                            break;
                    }
                    if (++aantalExtras == 3 || extrakeuze == 4)
                        break;
                    Console.WriteLine("Nog een extra?");
                }
                
            }
            return extraGekozenLijst;
        }
        
        //Method om te zien of je keuze ligt tussen  en max
        private static int ControleKeuzeGetal(int max)
        {
            int keuze;
            int.TryParse(Console.ReadLine(), out keuze);
            while (keuze <= 0 || keuze > max)
            {
                Console.WriteLine("Maak een keuze tussen 1 en {0}", max);
                int.TryParse(Console.ReadLine(), out keuze);
            }
            return keuze;
        }

        private static void TekenSterretjes()
        {
            Console.WriteLine();
            for (var i = 0; i < 70; i++)
                Console.Write("*");
            Console.WriteLine();
        }

        //sorteeropnaam methode
        private static List<Bestellingen> SorteerOpNaam(string naam, List<Bestellingen> bestellinglijst)
        {
            return (from bestelling in bestellinglijst where bestelling.Klant.Naam == naam select bestelling).ToList(); 
        }

        private static void pauze()
        {
            Console.WriteLine("type een toets om verder te gaan");
            Console.ReadLine();
        }
    }
}
