using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelNet.Verblijven;
using TravelNet.Vakanties;
using TravelNet.Activiteiten;

namespace TravelNet
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //**********************************************************
                // Hotels
                //**********************************************************
                Hotel albergoNero = new Hotel
                {
                    NaamVerblijf = "Albergo Nero",
                    BasisPrijsPerDag = 80m,
                    ToeslagSingle = true,
                    Internet = true,
                    WellnessPrijs = 0m
                };

                Hotel capella = new Hotel
                {
                    NaamVerblijf = "Capella",
                    BasisPrijsPerDag = 125m,
                    ToeslagSingle = false,
                    Internet = false,
                    WellnessPrijs = null
                };

                Hotel hotelletFrokost = new Hotel
                {
                    NaamVerblijf = "Hotellet Frokost",
                    BasisPrijsPerDag = 120m,
                    ToeslagSingle = true,
                    Internet = true,
                    WellnessPrijs = 100m
                };

                Hotel meniBeach = new Hotel
                {
                    NaamVerblijf = "MeniBeach",
                    BasisPrijsPerDag = 100m,
                    ToeslagSingle = true,
                    Internet = true,
                    WellnessPrijs = 250m
                };

                //**********************************************************
                // Appartementen
                //**********************************************************
                Appartement casaBlanca = new Appartement
                {
                    NaamVerblijf = "Casa Blanca",
                    BasisPrijsPerDag = 80m,
                    ToeslagSingle = false,
                    SchoonmaakPrijs = 100m,
                    Lift = true
                };

                Appartement parcoVista = new Appartement
                {
                    NaamVerblijf = "Parco Vista",
                    BasisPrijsPerDag = 45m,
                    ToeslagSingle = false,
                    SchoonmaakPrijs = 80m,
                    Lift = true
                };

                Appartement hviteHus = new Appartement
                {
                    NaamVerblijf = "Hvite Hus",
                    BasisPrijsPerDag = 85m,
                    ToeslagSingle = false,
                    SchoonmaakPrijs = 75m,
                    Lift = false
                };

                Appartement husetSvart = new Appartement
                {
                    NaamVerblijf = "Huset Svart",
                    BasisPrijsPerDag = 135m,
                    ToeslagSingle = true,
                    SchoonmaakPrijs = 100m,
                    Lift = false
                };

                //**********************************************************
                //Vakantiehuizen
                //**********************************************************

                Vakantiehuis fioriTorre = new Vakantiehuis
                {
                    NaamVerblijf = "Fiori Torre",
                    BasisPrijsPerDag = 100m,
                    ToeslagSingle = false,
                    SchoonmaakPrijs = 50m,
                    LinnengoedPrijs = 60m
                };

                Vakantiehuis gronnpark = new Vakantiehuis
                {
                    NaamVerblijf = "Gronnpark",
                    BasisPrijsPerDag = 66m,
                    ToeslagSingle = false,
                    SchoonmaakPrijs = 75m,
                    LinnengoedPrijs = 45m
                };

                Vakantiehuis blomsterTarnet = new Vakantiehuis
                {
                    NaamVerblijf = "Blomster Tarnet",
                    BasisPrijsPerDag = 90m,
                    ToeslagSingle = false,
                    SchoonmaakPrijs = 50m,
                    LinnengoedPrijs = 55m
                };

                Vakantiehuis visning = new Vakantiehuis
                {
                    NaamVerblijf = "Visning",
                    BasisPrijsPerDag = 120,
                    ToeslagSingle = false,
                    SchoonmaakPrijs = 100m,
                    LinnengoedPrijs = 100
                };

                //**********************************************************
                //Routes
                //**********************************************************
                Route routeLucca = new Route
                {
                    VertrekPunt = "Lucca",
                    EindPunt = "Prato",
                    GekozenVerblijfsType = casaBlanca,
                    GekozenFormule = Enums.Formule.Ontbijt
                };

                Route routePrato = new Route
                {
                    VertrekPunt = "Prato",
                    EindPunt = "Bologna",
                    GekozenVerblijfsType = albergoNero,
                    GekozenFormule = Enums.Formule.Ontbijt
                };

                Route routeBologna = new Route
                {
                    VertrekPunt = "Bologna",
                    EindPunt = "Arezzo",
                    GekozenVerblijfsType = parcoVista,
                    GekozenFormule = Enums.Formule.HalfPension
                };

                Route routeArezzo = new Route
                {
                    VertrekPunt = "Arezzo",
                    EindPunt = "Livorno",
                    GekozenVerblijfsType = fioriTorre,
                    GekozenFormule = Enums.Formule.Ontbijt
                };

                Route routeLivorno = new Route
                {
                    VertrekPunt = "Livorno",
                    EindPunt = "Firenze",
                    GekozenVerblijfsType = capella,
                    GekozenFormule = Enums.Formule.Ontbijt
                };

                Route routeStavanger = new Route
                {
                    VertrekPunt = "Stavanger",
                    EindPunt = "EgerSund",
                    GekozenVerblijfsType = hviteHus,
                    GekozenFormule = Enums.Formule.Ontbijt
                };

                Route routeEgerSund = new Route
                {
                    VertrekPunt = "EgerSund",
                    EindPunt = "Kragera",
                    GekozenVerblijfsType = husetSvart,
                    GekozenFormule = Enums.Formule.Ontbijt
                };

                Route routeKragera = new Route
                {
                    VertrekPunt = "Kragera",
                    EindPunt = "Porsgrunn",
                    GekozenVerblijfsType = gronnpark,
                    GekozenFormule = Enums.Formule.Ontbijt
                };

                Route routePorsgrunn = new Route
                {
                    VertrekPunt = "Porsgrunn",
                    EindPunt = "Drammen",
                    GekozenVerblijfsType = blomsterTarnet,
                    GekozenFormule = Enums.Formule.Ontbijt
                };

                Route routeDrammen = new Route
                {
                    VertrekPunt = "Drammen",
                    EindPunt = "Oslo",
                    GekozenVerblijfsType = visning,
                    GekozenFormule = Enums.Formule.Ontbijt
                };

                Route routeOslo = new Route
                {
                    VertrekPunt = "Oslo",
                    EindPunt = "Moss",
                    GekozenVerblijfsType = hotelletFrokost,
                    GekozenFormule = Enums.Formule.Ontbijt
                };

                Route routeAthene = new Route
                {
                    VertrekPunt = "Athene",
                    EindPunt = "Koz",
                    GekozenVerblijfsType = meniBeach,
                    GekozenFormule = Enums.Formule.VolPension
                };

                Route routeHelsinki = new Route
                {
                    VertrekPunt = "Helsinki",
                    EindPunt = "Helsinki",
                    GekozenVerblijfsType = null,
                    GekozenFormule = Enums.Formule.VolPension
                };



                //**********************************************************
                //Activiteiten
                //**********************************************************
                MTB VolwassenFiets = new MTB
                {
                    Naam = "Volwassen fiets",
                    PrijsUitrusting = 20m,
                    HuurFietsPerUur = 10m,
                    AantalUur = 4
                };

                MTB KinderFiets = new MTB
                {
                    Naam = "Kinderfiets",
                    PrijsUitrusting = 15m,
                    HuurFietsPerUur = 7.5m,
                    AantalUur = 3
                };

                Cinema VolwassenCinema = new Cinema
                {
                    Naam = "Volwassen cinema",
                    Inkom = 7.5m,
                    Snoepgoed = 5m
                };

                Cinema KinderCinema = new Cinema
                {
                    Naam = "Kindercinema",
                    Inkom = 5m,
                    Snoepgoed = 5.25m
                };

                Stadsbezoek Athene = new Stadsbezoek
                {
                    Naam = "Athene",
                    PrijsGidsPer10 = 150m,
                    AantalPersonen = 15
                };

                Stadsbezoek Rome = new Stadsbezoek
                {
                    Naam = "Rome",
                    PrijsGidsPer10 = 125m,
                    AantalPersonen = 12
                };

                Stadsbezoek Oslo = new Stadsbezoek
                {
                    Naam = "Oslo",
                    PrijsGidsPer10 = 175m,
                    AantalPersonen = 7
                };

                //********************Alle activiteiten Listen*****************************
                var autoVakantieActiviteiten1 = new List<IActiviteit> { Rome, VolwassenCinema, VolwassenCinema, KinderCinema };
                var autoVakantieActiviteiten2 = new List<IActiviteit> { Oslo, VolwassenFiets, KinderFiets, KinderFiets };
                var vliegVakantieActiviteiten1 = new List<IActiviteit> { Athene, VolwassenFiets, VolwassenFiets, KinderFiets, KinderFiets };
                var cruiseActiviteiten1 = new List<IActiviteit>();

                //********************Alle Routes Listen*****************************
                var autoVakantieRoutes1 = new List<Route> { routeLucca, routePrato, routeBologna, routeArezzo, routeLivorno };
                var autoVakantieRoutes2 = new List<Route> { routeStavanger, routeEgerSund, routeKragera, routePorsgrunn, routeDrammen, routeOslo };
                var vliegVakantieRoute1 = routeAthene;
                var cruiseRoute1 = routeHelsinki;

                //********************Alle aanlegPlaatsen Listen*****************************
                var cruiseAanlegPlaatsen1 = new List<string> { "Turku", "Rauma", "Vaasa", "Oulu" };

                //********************Vakantie List*****************************
                List<Vakantie> vakanties = new List<Vakantie>()
            {
                new Cruise(Enums.Bestemming.Finland, cruiseActiviteiten1, new DateTime(2017,8,12), new DateTime(2017,8,20), cruiseRoute1, cruiseAanlegPlaatsen1, 6800m),
                new AutoVakantie(Enums.Bestemming.Italië, autoVakantieActiviteiten1, new DateTime(2017,5,14), new DateTime(2017,5,19), autoVakantieRoutes1, Enums.WagenType.Camper, 1000m),
                new AutoVakantie(Enums.Bestemming.Noorwegen, autoVakantieActiviteiten2, new DateTime(2017,8,8), new DateTime(2017,8,14), autoVakantieRoutes2, Enums.WagenType.Camper, 1500m),
                new VliegVakantie(Enums.Bestemming.Griekenland, vliegVakantieActiviteiten1, new DateTime(2017,9,1), new DateTime(2017,9,15), vliegVakantieRoute1, 800m)
            };


                //******************************Overzicht**************************************************
                ToonGroep("Autovakanties", vakanties);
                ToonGroep("Vliegvakanties", vakanties);
                ToonGroep("Cruises", vakanties);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //************************METHODS*******************************
        public static void ToonGroep(string vakantieType, List<Vakantie> vakanties)
        {
            Console.WriteLine(vakantieType);
            Console.WriteLine("================================================================");
            
            switch (vakantieType)
            {
                case "Autovakanties":
                    foreach (var vakantie in vakanties.Where(vakantie => vakantie is AutoVakantie))
                        ToonListItem(vakantie);
                    break;
                case "Vliegvakanties":
                    foreach (var vakantie in vakanties.Where(vakantie => vakantie is VliegVakantie))
                        ToonListItem(vakantie);
                    break;
                case "Cruises":
                    foreach (var vakantie in vakanties.Where(vakantie => vakantie is Cruise))
                        ToonListItem(vakantie);
                    break;
            }
            Console.WriteLine();
        }

        public static void ToonListItem(Vakantie vakantie)
        {
            decimal totalePrijs = 0m;
            Console.WriteLine(vakantie);
            vakantie.AfdrukActiviteiten();
            foreach (var activiteit in vakantie.Activiteiten)
            {
                totalePrijs += activiteit.BerekenPrijs();
            }
            totalePrijs += vakantie.BerekenVakantiePrijs();
            Console.WriteLine("Totale prijs: {0}", totalePrijs);
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
