using System;
using Firma;
using Firma.Materiaal;
using Firma.Personeel;
using MateriaalStatus = Firma.Materiaal.Status;
using PersoneelStatus = Firma.Personeel.Status;
using static System.Console;
using static System.Math;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpPFCursus
{
    class CSharpPFCursus
    {
        //delegate void WerknemersLijst(Werknemer[] werknemers);

        //delegate bool Filter(int getal);

        //static Filter MaakLambda()
        //{
        //    Console.Write("Geef een getal: ");
        //    var deelbaarDoor = int.Parse(Console.ReadLine());
        //    return getal => getal % deelbaarDoor == 0;
        //}

        //private static bool IsEvenGetal(int getal)
        //{
        //    return (getal % 2 == 0);
        //}

        //private static bool IsOnevenGetal(int getal)
        //{
        //    return getal % 2 == 1;
        //}

        //delegate int FunctieMetTweeParameters(int getal1, int getal2);
        //delegate int FunctieMetEenParameter(int getal);
        //delegate int FunctieZonderParameter();

        public static void Main(string[] args)
        {

            //Werknemer asterix = new Arbeider("Asterix", new DateTime(2016, 1, 1), Geslacht.Man, 24.79m, 3);
            //Arbeider obelix = new Arbeider("Obelisk", new DateTime(2016, 1, 1), Geslacht.Man, 24.79m, 3);
            //asterix.Afbeelden();
            //obelix.Afbeelden();

            //Arbeider asterix = new Arbeider("Asterix", new DateTime(2016, 1, 1), Geslacht.Man, 24.79m, 3);
            //asterix.Regime = new Werknemer.WerkRegime(Werknemer.WerkRegime.RegimeType.Voltijds);
            //Console.WriteLine(asterix.Regime);
            //Bediende Obelisk = new Bediende("Obelix", new DateTime(1995, 1, 1), Geslacht.Man, 2400.79m);
            //Manager idefix = new Manager("Idefix", new DateTime(1996, 1, 1), Geslacht.Man, 2400.79m, 7000m);

            //Afdeling afdeling1 = new Afdeling("Strijd", 0);
            //Afdeling afdeling2 = new Afdeling("Feest", 1);

            //Werknemer[] wij = new Werknemer[3];
            //wij[0] = new Arbeider("Asterix", new DateTime(2016, 1, 1), Geslacht.Man, 24.79m, 3);
            //wij[0].Afdeling = afdeling1;
            //wij[1] = new Bediende("Obelix", new DateTime(1995, 1, 1), Geslacht.Man, 2400.79m);
            //wij[1].Afdeling = afdeling1;
            //wij[2] = new Manager("Idefix", new DateTime(1996, 1, 1), Geslacht.Man, 2400.79m, 7000m);
            //wij[2].Afdeling = afdeling2;

            //foreach (Werknemer eenWerknemer in wij)
            //{
            //    eenWerknemer.Afbeelden();
            //    LijnenTrekker.TrekLijn();
            //}

            //IKost[] kosten = new IKost[4];
            //kosten[0] = new Arbeider("Asterix", new DateTime(2016, 1, 1), Geslacht.Man, 24.79m, 3);
            //kosten[1] = new Bediende("Obelix", new DateTime(1995, 1, 1), Geslacht.Man, 2400.79m);
            //kosten[2] = new Manager("Idefix", new DateTime(1996, 1, 1), Geslacht.Man, 2400.79m, 7000m);
            //kosten[3] = new Fotokopiemachine("123", 500, 0.025m);

            //decimal totaleKost = 0m;
            //foreach (IKost kost in kosten)
            //{
            //    Console.WriteLine(kost.Menselijk);
            //    Console.WriteLine(kost.Bedrag);
            //    totaleKost += kost.Bedrag;
            //    LijnenTrekker.TrekLijn();
            //}
            //LijnenTrekker.TrekLijn(79, '=');
            //Console.WriteLine(totaleKost);

            //Object[] dingen = new Object[3];
            //dingen[0] = new Arbeider("Asterix", new DateTime(2016, 1, 1), Geslacht.Man, 24.79m, 3);
            //dingen[1] = new Fotokopiemachine("Racekyo", 500, 0.025m);
            //dingen[2] = "C#";
            //foreach (Object ding in dingen)
            //    Console.WriteLine(ding is IKost);

            //double straal = 5.0;
            //WriteLine($"De omtrek van een cirkel met straal {straal} cm" + $" bedraagt {2 * PI * straal} cm.");

            //MateriaalStatus statusBoorMachine = MateriaalStatus.Werkend;
            //PersoneelStatus statusChef = PersoneelStatus.HogerKader;
            //WriteLine(statusBoorMachine);
            //WriteLine(statusChef);

            //WerknemersLijst lijst;

            //lijst = Werknemer.UitgebreideWerknemersLijst;
            //lijst(wij);
            //Console.WriteLine();

            //lijst = Werknemer.KorteWerknemersLijst;
            //lijst(wij);

            //lijst = new WerknemersLijst(Werknemer.UitgebreideWerknemersLijst);
            //lijst(wij);

            //Fotokopiemachine machine1 = new Fotokopiemachine("123", 0, 2.0m);
            //Fotokopiemachine machine2 = new Fotokopiemachine("456", 0, 2.5m);
            //Bediende eenBediende = new Bediende("Obelix", new DateTime(1995, 1, 1), Geslacht.Man, 2400.79m);
            //Manager eenManager = new Manager("Idefix", new DateTime(1996, 1, 1), Geslacht.Man, 2400.79m, 7000m);
            //machine1.OnderhoudNodig += eenBediende.DoeOnderhoud;
            //machine1.OnderhoudNodig += eenManager.OnderhoudNoteren;
            //machine2.OnderhoudNodig += eenBediende.DoeOnderhoud;
            //machine2.OnderhoudNodig += eenManager.OnderhoudNoteren;
            //machine1.Fotokopieer(49);
            //machine2.Fotokopieer(14);

            //WerknemersLijst rapport;

            //rapport = delegate (Werknemer[] werknemers)
            //{
            //    decimal totaal = 0m;
            //    foreach (Werknemer werknemer in werknemers)
            //        totaal += werknemer.Bedrag;
            //    Console.WriteLine("Totale kost is {0}", totaal);
            //};
            //rapport(wij);

            //Fotokopiemachine machine = new Fotokopiemachine("123", 0, 2.0m);
            //Bediende eenBediende = new Bediende("Obelix", new DateTime(1995, 1, 1), Geslacht.Man, 2400.79m);

            //machine.OnderhoudNodig += delegate (Fotokopiemachine apparaat)
            //{
            //    Console.WriteLine("Onderhoud is aangevraagd voor machine {0}.", apparaat.SerieNr);
            //};

            //machine.OnderhoudNodig += eenBediende.DoeOnderhoud;

            //machine.Fotokopieer(49);

            //decimal getal1, getal2;
            //try
            //{
            //    Console.Write("eerste getal:");
            //    getal1 = decimal.Parse(Console.ReadLine());
            //    try
            //    {
            //        Console.Write("tweede getal:");
            //        getal2 = decimal.Parse(Console.ReadLine());
            //        if (getal2 != 0m)
            //            Console.WriteLine($"deling: {getal1 / getal2:0.00}");
            //        else
            //            Console.WriteLine("Delen door nul is niet toegelaten");
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Je tikt geen getal als tweede getal");
            //    }

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Je tikt geen getal als eerste getal");
            //}


            //catch(FormatException)
            //{
            //    Console.WriteLine("Je tikt geen getal");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Delen door nul is niet toegelaten");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Een fout heeft zich voorgedaan");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Je tikt geen getal");
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("StackTrace");
            //    Console.WriteLine(ex.StackTrace);
            //}

            //try
            //{
            //    Fotokopiemachine machine = new Fotokopiemachine("123", -100, -5.4m);
            //    Console.WriteLine("Machine goed ingevuld");
            //}
            //catch (Fotokopiemachine.KostPerBlzException ex)
            //{
            //    Console.WriteLine("Fout: {0}: {1}", ex.Message, ex.VerkeerdeKost);
            //}
            //catch (Fotokopiemachine.AantalBlzException ex)
            //{
            //    Console.WriteLine("Fout: {0}: {1}", ex.Message, ex.VerkeerdeAantalBlz);
            //}
            //Console.WriteLine("Einde programma");

            //Console.WriteLine("Provincie:");
            //string provincie = Console.ReadLine();
            //try
            //{
            //    ProvincieInfo info = new ProvincieInfo();
            //    Console.WriteLine(info.ProvincieGrootte(provincie));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Arbeider asterix = new Arbeider("Asterix", new DateTime(2016, 1, 1), Geslacht.Man, 24.79m, 3);
            //string afdelingsnaam;
            //afdelingsnaam = asterix.Afdeling?.Afdelingsnaam??"onbekend";
            //Console.WriteLine($"{asterix.Naam} werkt op de afdeling {afdelingsnaam}");

            //Breuk breuk1 = new Breuk(1, 2);
            //Breuk breuk2 = new Breuk(1, 3);
            //Breuk breuk3 = new Breuk(2, 6);
            //Console.WriteLine(breuk1 == breuk2);
            //Console.WriteLine(breuk2 == breuk3);
            //Console.WriteLine(breuk1 * breuk3);
            //Console.WriteLine(breuk1 * 3);
            //breuk1 *= breuk2;
            //Console.WriteLine(breuk1);
            //Breuk breuk1 = new Breuk(1, 2);
            //Breuk breuk2 = breuk1++;
            //Console.WriteLine(breuk1);
            //Console.WriteLine(breuk2);
            //Breuk breuk1 = new Breuk(5, 2);
            //double dWaarde = breuk1;
            //int iWaarde = (int)breuk1;
            //Console.WriteLine(dWaarde);
            //Console.WriteLine(iWaarde);
            //Console.WriteLine(breuk1.ToString());
            //Console.WriteLine(breuk1 ? "Echte breuk" : "Onechte breuk");    

            //Overuren mijnOveruren = new Overuren();
            //mijnOveruren[0] = 4;
            //mijnOveruren["apr"] = 2;
            //Console.WriteLine(mijnOveruren["jan"]);
            //Console.WriteLine(mijnOveruren[3]);
            //Console.WriteLine(mijnOveruren.Totaal);

            //Arbeider asterix = new Arbeider("Asterix", new DateTime(2016, 1, 1), Geslacht.Man, 24.79m, 3);
            //Bediende obelix = new Bediende("Obelix", new DateTime(1995, 1, 1), Geslacht.Man, 2400.79m);
            //Manager idefix = new Manager("Idefix", new DateTime(1996, 1, 1), Geslacht.Man, 2400.79m, 7000m);

            //ArrayList personeel = new ArrayList();
            //personeel.Add(asterix);
            //personeel.Add(obelix);
            //personeel.Insert(1, idefix);

            //Console.WriteLine("{0} is de 1ste van {1} personeelsleden.", ((Werknemer)personeel[0]).Naam, personeel.Count);
            //Console.WriteLine();
            //foreach (Werknemer personeelslid in personeel)
            //    Console.WriteLine(personeelslid.Naam);
            //Console.WriteLine();

            //Afdeling eenAfdeling = new Afdeling("Verzending", 0);
            //personeel.Add(eenAfdeling);
            //foreach (Werknemer personeelslid in personeel)
            //    Console.WriteLine(personeelslid.Naam);

            //Arbeider asterix = new Arbeider("Asterix", new DateTime(2016, 1, 1), Geslacht.Man, 24.79m, 3);
            //Bediende obelix = new Bediende("Obelix", new DateTime(1995, 1, 1), Geslacht.Man, 2400.79m);
            //Manager idefix = new Manager("Idefix", new DateTime(1996, 1, 1), Geslacht.Man, 2400.79m, 7000m);

            //List<Werknemer> personeel = new List<Werknemer>();
            //personeel.Add(asterix);
            //personeel.Add(obelix);
            //personeel.Insert(1, idefix);

            //Console.WriteLine("{0} is de 1ste van {1} personeelsleden.", personeel[0].Naam, personeel.Count);
            //Console.WriteLine();
            //foreach (Werknemer personeelslid in personeel)
            //    Console.WriteLine(personeelslid.Naam);
            //Console.WriteLine();

            //Dictionary<int, string> opleidingen = new Dictionary<int, string>()
            //{
            //    { 1, "Word"},
            //    { 2, "Excel"},
            //    { 3, "Acces"}
            //};

            //Dictionary<string, string> extensies = new Dictionary<string, string>()
            //{
            //    { "txt", "Notepad"},
            //    { "docx", "Word"},
            //    { "xlsx", "Excel"}
            //};

            //List<Werknemer> werknemers = new List<Werknemer>
            //{
            //    new Arbeider("Asterix", new DateTime(2016, 1, 1), Geslacht.Man, 24.79m, 3),
            //    new Bediende("Obelix", new DateTime(1995, 1, 1), Geslacht.Man, 2400.79m)
            //};
            //Console.WriteLine($"Aantal werknemers: {werknemers.Count}");
            //werknemers = null;
            //Console.WriteLine(string.Format("Aantal werknemers: {0}", werknemers?.Count ?? 0));

            //byte? aantalKinderen = null;

            //if (aantalKinderen.HasValue)
            //    Console.WriteLine("{0}", aantalKinderen);
            //else
            //    Console.WriteLine("onbekeend");

            //bool? nullable = true;
            //bool realBool;
            //realBool = nullable ?? false;

            //Console.WriteLine(realBool);

            //var land = "belgië";
            //Console.WriteLine(land.ToUpperFirst());
            //Console.WriteLine(land.Right(3));


            //Klant eenKlant = new Klant("Asterix");
            //Klant tweeKlant = new Klant("Obelix");
            //Klant drieKlant = new Klant();

            //Console.WriteLine(eenKlant);
            //Console.WriteLine(tweeKlant);
            //Console.WriteLine(drieKlant);

            //var eersteMan = new Persoon { Naam = "Adam", AantalKinderen = 2 };
            //var eersteVrouw = new Persoon("Eva");
            //var eersteZoon = new Persoon { Naam = "Kaïn" };
            //eersteZoon.AantalKinderen = 0;
            //Console.WriteLine(eersteVrouw.Naam);

            //var persoon = new { Nr = 1, Naam = "Adam", AantalKinderen = 2 };
            //Console.WriteLine(persoon.GetType().ToString());
            //Console.WriteLine(persoon.Naam);

            //var klant = new Klant { NieuwNaam = "Jan" };
            //klant.NieuwNaam = "Piet";
            //Console.WriteLine(klant.NieuwNaam);


            //Filter evenGetal = IsEvenGetal;
            //Filter onevenGetal = IsOnevenGetal;
            //Console.WriteLine("Even getallen:");
            //ToonGetallen(evenGetal);
            //ToonGetallen(onevenGetal);

            //Filter getalDeelbaarDoorVijf = delegate (int getal)
            //{
            //    return (getal % 5 == 0);
            //};
            //ToonGetallen(getalDeelbaarDoorVijf);

            //FunctieMetTweeParameters som = (getal1, getal2) => getal1 + getal2;
            //Console.WriteLine(som(3, 7));
            //Console.WriteLine(som(10, 6));
            //Console.WriteLine(10 + 6);

            //FunctieMetTweeParameters aftrekking = delegate (int getal3, int getal4)
            //{
            //    return getal3 - getal4;
            //};
            //Console.WriteLine(aftrekking(10, 8));

            //FunctieMetEenParameter kwadraat = getal => getal * getal;
            //Console.WriteLine(kwadraat(5));

            //FunctieZonderParameter willekeurigGetal = () => new Random().Next(10);
            //Console.WriteLine(willekeurigGetal());

            //Filter evenGetal = getal => getal % 2 == 0;           
            //Console.WriteLine("Even getallen:");
            //ToonGetallen(evenGetal);
            //ToonGetallen(getal => getal % 2 == 1);

            //Filter getalDeelbaarDoorVijf = getal => getal % 5 == 0;

            //ToonGetallen(getalDeelbaarDoorVijf);

            //ToonGetallen(MaakLambda());

            //Action<int> kwadraat = getal => Console.WriteLine(getal * getal);
            //kwadraat(10);

            //Action<string, int> tekstDeel = (tekst, vanaf) => Console.WriteLine(tekst.Substring(vanaf));
            //tekstDeel("VDAB", 2);

            //Func<int, int, int> som = (getal1, getal2) => getal1 + getal2;
            //Console.WriteLine(som(10, 5));

            //Func<string, int, string> tekstDeel = (tekst, vanaf) => tekst.Substring(vanaf);
            //Console.WriteLine(tekstDeel("VDAB", 2));

            //Werknemer[] wij = new Werknemer[2];
            //wij[0] = new Arbeider("Asterix", new DateTime(2016, 1, 1), Geslacht.Man, 24.79m, 3);
            //wij[1] = new Bediende("Obelix", new DateTime(1995, 1, 1), Geslacht.Man, 2400.79m);
            //Action<Werknemer[]> toonWerknemers = UitgebreideWerknemersLijst;
            //toonWerknemers(wij);

            //var getallen = new[] { 0, 2, 1, 4, 3, 5, 7, 6, 8, 9 };

            //Console.WriteLine("Getallen groter dan 3:");
            //var getallenGroterDan3 = getallen.Where(getal => getal > 3);
            //foreach (var getal in getallenGroterDan3)
            //    Console.WriteLine(getal);

            //Console.WriteLine("Gesorteerde lijst:");
            //var gesorteerdeGetallen = getallen.OrderBy(getal => getal);
            //foreach (var getal in gesorteerdeGetallen)
            //    Console.WriteLine(getal);

            //Console.WriteLine("Aantal getallen groter dan 3:");
            //Console.WriteLine(getallen.Count(getal => getal > 3));

            //var namen = new List<string> { "Asterix", "Obelix", "Idefix", "Ambiorix" };
            //Console.WriteLine("Geef de beginletter(s) in: ");
            //var beginVanNaam = Console.ReadLine();
            //var gevondenNamen = namen.Where(naam => naam.StartsWith(beginVanNaam));
            //foreach (var naam in gevondenNamen)
            //    Console.WriteLine(naam);

            //var landen = new[]
            //{
            //    new { Naam = "Frankrijk", Oppervlakte = 643427 },
            //    new { Naam = "Nederland", Oppervlakte = 41528 }
            //};

            //var gesorteerdeLanden = landen.OrderBy(land => land.Oppervlakte);
            //foreach (var eenLand in gesorteerdeLanden)
            //    Console.WriteLine("{0} {1}", eenLand.Naam, eenLand.Oppervlakte);

            //Console.WriteLine("Totale oppervlakte van alle landen: {0}", landen.Sum(land => land.Oppervlakte));

            //var namen = new List<string> { "Asterix", "Obelix", "Idefix", "Ambiorix" };
            //var geselecteerdeNamenInHoofdletters = namen.Where(naam => naam.Length > 6).OrderBy(naam => naam).Select(naam => naam.ToUpper());
            //var geselecteerdeNamenInHoofdletters =
            //    from naam in namen
            //    where naam.Length > 6
            //    orderby naam
            //    select naam.ToUpper();
            //foreach (var naam in geselecteerdeNamenInHoofdletters)
            //    Console.WriteLine(naam);

            //var namen = new List<string> { "Asterix", "Obelix" };
            //var geselecteerdeNamen =
            //    from naam in namen
            //    where naam.StartsWith("A")
            //    select naam;
            //namen.Add("Assurancetourix");
            //foreach (var naam in geselecteerdeNamen)
            //    Console.WriteLine(naam);

            //var namen = new List<string> { "Asterix", "Obelix" };
            //var geselecteerdeNamen =
            //    (from naam in namen
            //     where naam.StartsWith("A")
            //     select naam).ToList();
            //namen.Add("Assurancetourix");
            //foreach (var naam in geselecteerdeNamen)
            //    Console.WriteLine(naam);

            //var namen = new List<string> { "Asterix", "Obelix", "Assurancetourix" };
            //Console.WriteLine("Beginletter? ");
            //var beginLetter = Console.ReadLine();
            //var eersteNaam =
            //    (from naam in namen
            //     where naam.StartsWith(beginLetter)
            //     select naam).FirstOrDefault();
            //Console.WriteLine(eersteNaam != null ? eersteNaam : "Geen elementen");

            //var brouwers = new Brouwers().GetBrouwers();
            //var alleBrouwers = from brouwer in brouwers select brouwer;
            //foreach (var brouwer in alleBrouwers)
            //    Console.WriteLine(brouwer.ToString());

            //var brouwers = new Brouwers().GetBrouwers();
            //var brouwersGesorteerdAsc = from brouwer in brouwers orderby brouwer.Brouwernaam select brouwer;
            //foreach (var brouwer in brouwersGesorteerdAsc)
            //    Console.WriteLine(brouwer.ToString());

            //Console.WriteLine();
            //var brouwersGesorteerdDesc = from brouwer in brouwers orderby brouwer.Brouwernaam descending select brouwer;
            //foreach (var brouwer in brouwersGesorteerdDesc)
            //    Console.WriteLine(brouwer.ToString());

            //var brouwers = new Brouwers().GetBrouwers();
            //var brouwerGegevens = from brouwer in brouwers select new { brouwer.Brouwernaam, brouwer.Bieren.Count };
            //foreach (var brouwer in brouwerGegevens)
            //    Console.WriteLine("{0}: {1} bier(en)", brouwer.Brouwernaam, brouwer.Count);

            //var brouwers = new Brouwers().GetBrouwers();
            //Console.WriteLine("Belgische brouwerijen:");
            //var belgischeBrouwerijen = from brouwer in brouwers where brouwer.Belgisch select brouwer;
            //foreach (var brouwer in belgischeBrouwerijen)
            //    Console.WriteLine(brouwer.ToString());

            //Console.WriteLine("Niet-Belgische brouwerijen:");
            //var nietBelgischeBrouwerijen = from brouwer in brouwers where !brouwer.Belgisch select brouwer;
            //foreach (var brouwer in nietBelgischeBrouwerijen)
            //    Console.WriteLine(brouwer.ToString());

            //Console.WriteLine("Brouwer met 2 bieren:");
            //var brouwersMet2Bieren = from brouwer in brouwers where brouwer.Bieren.Count == 2 select brouwer;
            //foreach (var brouwer in brouwersMet2Bieren)
            //    Console.WriteLine(brouwer.Brouwernaam);

            //Console.WriteLine("Brouwers met een ingegeven aantal bieren: ");
            //Console.Write("Geef een aantal: ");
            //var aantal = int.Parse(Console.ReadLine());
            //var brouwersMetXAantalBieren = from brouwer in brouwers where brouwer.Bieren.Count == aantal select brouwer;
            //if (brouwersMetXAantalBieren.Any())
            //{
            //    foreach (var brouwer in brouwersMetXAantalBieren)
            //        Console.WriteLine(brouwer.Brouwernaam);
            //}
            //else
            //    Console.WriteLine("Geen brouwers met {0} bieren", aantal == 0 ? "geen" : aantal.ToString());

            //Console.WriteLine("Brouwer met 3 bieren:");
            //var brouwersMet3Bieren = from brouwer in brouwers where brouwer.Bieren.Count == 3 select brouwer;
            //foreach (var brouwer in brouwersMet3Bieren)
            //    Console.WriteLine(brouwer.Brouwernaam);

            //var brouwers = new Brouwers().GetBrouwers();
            //var bieren = brouwers.SelectMany(brouwer => brouwer.Bieren);
            //var bieren = from brouwer in brouwers from bier in brouwer.Bieren select bier;
            //foreach (var bier in bieren)
            //    Console.WriteLine(bier.ToString());

            //var brouwers = new Brouwers().GetBrouwers();
            //var bieren = brouwers.SelectMany(brouwer => brouwer.Bieren).Where(bier => bier.Alcohol < 2.0F);
            //var bieren = from brouwer in brouwers from bier in brouwer.Bieren where bier.Alcohol < 2.0F select bier;
            //foreach (var bier in bieren)
            //    Console.WriteLine(bier.ToString());

            //var brouwers = new Brouwers().GetBrouwers();
            ////aantal Belgische brouwers
            //var belgischeBrouwers = from brouwer in brouwers where brouwer.Belgisch select brouwer;
            //Console.WriteLine("Aantal Belgische brouwers: {0}", belgischeBrouwers.Count());

            ////totaal aantal bieren
            //var alleBieren = brouwers.SelectMany(brouwer => brouwer.Bieren);
            //Console.WriteLine("Totaal aantal bieren: {0}", alleBieren.Count());

            ////totaal aantal bieren
            //Console.WriteLine("Totaal aantal bieren: {0}", brouwers.SelectMany(brouwer => brouwer.Bieren).Count());

            ////aantal Belgische Bieren
            //Console.WriteLine("Aantal Belgische bieren: {0}", brouwers.Where(brouwer => brouwer.Belgisch).SelectMany(brouwer => brouwer.Bieren).Count());

            ////gemiddelde alcoholgehalte van alle bieren
            //Console.WriteLine("Gemiddelde alcoholgehalte van de bieren: {0}", brouwers.SelectMany(brouwer => brouwer.Bieren).Average(bier => bier.Alcohol));
            //var bieren = from brouwer in brouwers from bier in brouwer.Bieren select bier;
            //var gemiddeldeAlcohol = bieren.Average(bier => bier.Alcohol);
            //Console.WriteLine("Gemiddelde alcoholgehalte van de bieren: {0}", gemiddeldeAlcohol);

            ////Gemiddelde van alle getallen van een array
            //int[] getallen = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var gemiddelde = getallen.Average();
            //Console.WriteLine("Het gemiddelde van deze getallen is: {0}", gemiddelde);

            //var brouwers = new Brouwers().GetBrouwers();
            //var opBelgisch = from brouwer in brouwers group brouwer by brouwer.Belgisch;
            //var opBelgisch = brouwers.GroupBy(brouwer => brouwer.Belgisch);
            //foreach (var welNietBelgisch in opBelgisch)
            //{
            //    Console.WriteLine(welNietBelgisch.Key ? "Belgisch" : "Niet-Belgisch");
            //    foreach (var brouwer in welNietBelgisch)
            //        Console.WriteLine(brouwer.Brouwernaam);
            //}

            //var brouwers = new Brouwers().GetBrouwers();
            //var opAantalBieren = from brouwer in brouwers group brouwer by brouwer.Bieren.Count;
            //foreach (var aantalBieren in opAantalBieren)
            //{
            //    Console.WriteLine(aantalBieren.Key);
            //    foreach (var brouwer in aantalBieren)
            //        Console.WriteLine(brouwer.Brouwernaam);
            //}

            //var brouwers = new Brouwers().GetBrouwers();
            //var opAantalBieren = from brouwer in brouwers group brouwer by brouwer.Bieren.Count into mijnGroep orderby mijnGroep.Key select mijnGroep;
            //foreach (var aantalBieren in opAantalBieren)
            //{
            //    Console.WriteLine(aantalBieren.Key);
            //    foreach (var brouwer in aantalBieren)
            //        Console.WriteLine(brouwer.Brouwernaam);
            //}

            //var brouwers = new Brouwers().GetBrouwers();
            //var opBelgisch = from brouwer in brouwers
            //                 from bier in brouwer.Bieren
            //                 group bier by brouwer.Belgisch;
            //into bieren
            //select new { Belgisch = bieren.Key, AantalBieren = bieren.Count() };
            //foreach (var groep in opBelgisch)
            //{
            //    Console.WriteLine((groep.Belgisch? "Belgische bieren: ": "Niet-Belgische bieren: ") + groep.AantalBieren);
            //}
            //foreach (var groep in opBelgisch)
            //    Console.WriteLine((groep.Key ? "belg" : "niet") + groep.Count());

            //var brouwers = new Brouwers().GetBrouwers();
            //var opBelgisch = from brouwer in brouwers
            //                 from bier in brouwer.Bieren
            //                 group bier by brouwer.Belgisch
            //                 into bieren
            //                 select new
            //                 {
            //                     Bieren = bieren,
            //                     Belgisch = bieren.Key,
            //                     AantalBieren = bieren.Count()                                 
            //                 };
            //foreach (var groep in opBelgisch)
            //{
            //    Console.WriteLine((groep.Belgisch ? "Belgische bieren: " : "Niet-Belgische bieren: ") + groep.AantalBieren);
            //    foreach (var bier in groep.Bieren)
            //        Console.WriteLine(bier.Biernaam);
            //}

            //var personen = new[]
            //{
            //        new{ Naam = "Jan", AantalKinderen = 1 },
            //        new{ Naam = "Mieke", AantalKinderen = 2 },
            //        new{ Naam = "Els", AantalKinderen = 1 }
            //    };
            //var toegangsprijzen = new[]
            //{
            //        new{ AantalKinderen = 1, Bedrag = 10 },
            //        new{ AantalKinderen = 2, Bedrag = 25 }
            //    };

            //var toegangsPrijzenPerPersoon = from persoon in personen
            //                                join toegangsprijs in toegangsprijzen
            //                                on persoon.AantalKinderen equals toegangsprijs.AantalKinderen
            //                                select new { persoon.Naam, persoon.AantalKinderen, toegangsprijs.Bedrag };
            //foreach (var persoon in toegangsPrijzenPerPersoon)
            //    //Console.WriteLine("{0}: {1} euro", persoon.Naam, persoon.Bedrag);
            //    Console.WriteLine(persoon.ToString());

            //var tekst = "Vlaamse Dienst Voor Arbeidsbemiddeling en Beroepsopleiding";
            //var zoekLetterA = from letter in tekst.ToUpper()
            //                  where letter == 'A'
            //                  select letter;
            //Console.WriteLine("De tekst {0} bevat {1} A's.", tekst, zoekLetterA.Count());

            //var zin = "The quick brown; fox; jumps; over the lazy dog";
            //var woorden = zin.Split(new[] { ' ', ';' });
            //var woordenVan3Tekens = from woord in woorden
            //                        where woord.Length == 3
            //                        select woord.ToLower();
            //foreach (var woord in woordenVan3Tekens.Distinct())
            //    Console.WriteLine(woord);

            //string directorynaam = @"C:\Data";
            //if (Directory.Exists(directorynaam))
            //{
            //    Console.WriteLine("De directory {0} bestaat.", directorynaam);
            //    if (Directory.GetDirectories(directorynaam).Count() != 0 || Directory.GetFiles(directorynaam).Count() != 0)
            //    {
            //        Console.WriteLine("De directory met inhoud wordt verwijderd");
            //        Directory.Delete(directorynaam, true);
            //    }
            //    else
            //    {
            //        Console.WriteLine("De directory wordt verwijderd");
            //        Directory.Delete(directorynaam);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("De directory {0} bestaat niet.", directorynaam);
            //    Console.WriteLine("De directory wordt gecreëerd");
            //    Directory.CreateDirectory(directorynaam);
            //}

            //string directorynaam = @"C:\Data";
            //string bestandsnaam = "Pizza.txt";
            //string bestand = directorynaam + @"\" + bestandsnaam;

            //Directory.CreateDirectory(directorynaam);

            //if (File.Exists(bestand))
            //{
            //    Console.WriteLine("Het bestand {0} bestaat.", bestand);
            //    string bestandsinformatie = "Datum creatie: " + File.GetCreationTime(bestand) + System.Environment.NewLine + "Datum laatst gebruikt: " + File.GetLastAccessTime(bestand);
            //    Console.WriteLine(bestandsinformatie);
            //    Console.WriteLine("De inhoud van het bestand:");
            //    string tekst = File.ReadAllText(bestand);
            //    Console.WriteLine(tekst);

            //    File.Delete(bestand);
            //}
            //else
            //{
            //    Console.WriteLine("Het bestand {0} bestaat niet.", bestand);
            //    Console.WriteLine("Het wordt gecreëerd");
            //    string tekst;
            //    tekst = "Pizza Margerita (tomatensaus - mozzarella): 8 EUR";
            //    File.WriteAllText(bestand, tekst);

            //    tekst = Environment.NewLine + "Pizza vegetariana (tomatensaus - mozzarella - groenten): 9.5 EUR";
            //    File.AppendAllText(bestand, tekst);
            //}

            //string locatie = @"C:\Data\";
            //try
            //{
            //    using (var schrijver = new StreamWriter(locatie + "Pizza.txt"))
            //    {
            //        string titel = "Prijslijst pizza's";
            //        schrijver.WriteLine(titel);
            //        for (var teller = 1; teller <= titel.Length; teller++)
            //            schrijver.Write('*');
            //        schrijver.WriteLine();
            //        schrijver.WriteLine("Pizza Margerita (tomatensaus - mozzarella): 8 EUR");
            //        schrijver.WriteLine("Pizza Napoli (tomatensaus - mozzarella - ansjovis - kappers - olijven): 9.5 EUR");
            //        schrijver.WriteLine("Pizza vegetariana (tomatensaus - mozzarella - assortiment van groenten): 9.5 EUR");
            //    }
            //    using (var schrijver = new StreamWriter(locatie + "Pizza.txt", true))
            //    {
            //        schrijver.WriteLine("Pizza Lardiera (tomatensaus - mozzarella - spek): 10.5 EUR");
            //    }
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Fout bij het schrijven naar het bestand!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //string locatie = @"C:\Data\";
            //try
            //{
            //    string regel;
            //    using (var lezer = new StreamReader(locatie + "Pizza.txt"))
            //    {
            //        while ((regel = lezer.ReadLine()) != null)
            //        {
            //            Console.WriteLine(regel);
            //        }
            //    }
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Fout bij het inlezen van het bestand!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //List<Pizza> pizzas = new List<Pizza>
            //{
            //    new Pizza { Naam = "Pizza Margherita", Onderdelen = new List<string> { "Tomatensaus", "Mozzarella" }, Prijs = 8m },
            //    new Pizza { Naam = "Pizza Vegetariana", Onderdelen = new List<string> { "Tomatensaus", "Mozzarella", "Groenten" }, Prijs = 9.5m },
            //    new Pizza { Naam = "Pizza Napoli", Onderdelen = new List<string> { "Tomatensaus", "Mozzarella", "Ansjovis", "Kappers", "Olijven" }, Prijs = 10m },
            //};

            //string locatie = @"C:\Data\";
            //StringBuilder pizzaRegel;
            //try
            //{
            //    using (var schrijver = new StreamWriter(locatie + "Pizza.txt"))
            //    {
            //        foreach (var pizza in pizzas)
            //        {
            //            pizzaRegel = new StringBuilder();
            //            pizzaRegel.Append(pizza.Naam + ':');
            //            pizzaRegel.Append(pizza.Onderdelen.Count.ToString() + ':');
            //            foreach (string onderdeel in pizza.Onderdelen)
            //                pizzaRegel.Append(onderdeel + ':');
            //            pizzaRegel.Append(pizza.Prijs);
            //            schrijver.WriteLine(pizzaRegel);
            //        }
            //    }
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Fout bij het schrijven naar het bestand!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //string locatie = @"C:\Data\";

            //List<Pizza> pizzas = new List<Pizza>();

            //string pizzaRegel;
            //string pizzaNaam;
            //int aantalOnderdelen;
            //List<string> pizzaOnderdelen;
            //decimal prijs;

            //try
            //{
            //    using (var lezer = new StreamReader(locatie + "Pizza.txt"))
            //    {
            //        while ((pizzaRegel = lezer.ReadLine()) != null)
            //        {
            //            string[] gegevens = pizzaRegel.Split(new Char[] { ':' });
            //            pizzaNaam = gegevens[0];
            //            aantalOnderdelen = int.Parse(gegevens[1]);
            //            pizzaOnderdelen = new List<string>();
            //            for (var teller = 0; teller < aantalOnderdelen; teller++)
            //                pizzaOnderdelen.Add(gegevens[teller + 2]);
            //            prijs = decimal.Parse(gegevens[gegevens.Length - 1]);
            //            pizzas.Add(new Pizza { Naam = pizzaNaam, Onderdelen = pizzaOnderdelen, Prijs = prijs });
            //        }

            //    }
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Fout bij het lezen van het bestand!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //foreach (Pizza pizza in pizzas)
            //{
            //    Console.WriteLine(pizza.ToString());
            //    foreach (string onderdeel in pizza.Onderdelen)
            //        Console.WriteLine(onderdeel);
            //    Console.WriteLine();
            //}

            //string tekst = "Lottogetallen";
            //int aantalGetallen = 45;
            //byte[] lottogetallen = { 1, 27, 32, 33, 44, 12, 5 };
            //decimal winst = 15m;
            //string datum = DateTime.Now.ToShortDateString();
            //using (BinaryWriter schrijver = new BinaryWriter(File.Open(@"C:\Data\Lottogetallen.bin", FileMode.Create)))
            //{
            //    schrijver.Write(aantalGetallen);
            //    schrijver.Write(tekst);
            //    schrijver.Write(lottogetallen);
            //    schrijver.Write(winst);
            //    schrijver.Write(datum);
            //}

            //string tekst;
            //int aantalGetallen;
            //byte[] lottogetallen;
            //decimal winst;
            //string datum;

            //using (BinaryReader lezer = new BinaryReader(File.Open(@"C:\Data\Lottogetallen.bin", FileMode.Open)))
            //{
            //    aantalGetallen = lezer.ReadInt32();
            //    tekst = lezer.ReadString();
            //    lottogetallen = lezer.ReadBytes(7);
            //    winst = lezer.ReadDecimal();
            //    datum = lezer.ReadString();
            //}

            //Console.WriteLine(aantalGetallen);
            //Console.WriteLine(tekst);
            //foreach (byte lottogetal in lottogetallen)
            //    Console.WriteLine("{0} ", lottogetal);
            //Console.WriteLine();
            //Console.WriteLine(winst);
            //Console.WriteLine(datum);

            //Pizza pizzaMargherita = new Pizza { Naam = "Pizza Margherita", Onderdelen = new List<string> { "Tomatensaus", "Mozzarella" }, Prijs = 8m };

            //List<Pizza> pizzas = new List<Pizza>
            //{
            //    new Pizza { Naam = "Pizza Margherita", Onderdelen = new List<string> { "Tomatensaus", "Mozzarella" }, Prijs = 8m },
            //    new Pizza { Naam = "Pizza Vegetariana", Onderdelen = new List<string> { "Tomatensaus", "Mozzarella", "Groenten" }, Prijs = 9.5m }
            //};

            //try
            //{
            //    using (var bestand = File.Open(@"C:\Data\Pizza.obj", FileMode.OpenOrCreate))
            //    {
            //        var schrijver = new BinaryFormatter();
            //        schrijver.Serialize(bestand, pizzas);
            //    }
            //    Console.WriteLine("Serialisatie geslaagd");
            //}
            //catch (SerializationException)
            //{ Console.WriteLine("Fout bij het serialiseren"); }
            //catch (Exception ex)
            //{ Console.WriteLine(ex.Message); }

            //    var pizzas = new List<Pizza> { };
            //    try
            //    {
            //        using (var bestand = File.Open(@"C:\Data\Pizza.obj", FileMode.Open, FileAccess.Read))
            //        {
            //            var lezer = new BinaryFormatter();
            //            //Pizza pizza;

            //            pizzas = (List<Pizza>)lezer.Deserialize(bestand);
            //            foreach (var pizza in pizzas)
            //            {
            //                Console.WriteLine(pizza.Naam);
            //                foreach (var onderdeel in pizza.Onderdelen)
            //                    Console.WriteLine(onderdeel);
            //                Console.WriteLine(pizza.Prijs);
            //            }
            //        }
            //    }
            //    catch (IOException)
            //    {
            //        throw new Exception("Fout bij het openen van het bestand!");
            //    }

            //    catch (SerializationException)
            //    {
            //        Console.WriteLine("Fout bij het deserialiseren");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //Console.WriteLine("method Main is gestart...");
            //Start();
            //Console.WriteLine("terug in method Main");
            //Console.WriteLine("druk een willekeurige toets ...");
            //Console.WriteLine();
            //Console.ReadLine();

            
        }

        //static void UitgebreideWerknemersLijst(Werknemer[] werknemers)
        //{
        //    foreach (Werknemer eenWerknemer in werknemers)
        //        eenWerknemer.Afbeelden();
        //}

        //private static void ToonGetallen(Filter filter)
        //{
        //    var getallen = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    foreach (var getal in getallen)
        //        if (filter(getal))
        //            Console.WriteLine(getal);
        //}

        static async void Start()
        {
            Console.WriteLine("method Start is gestart...");
            string tekst = await DoeIetsAsync();
            Console.WriteLine(tekst);
        }

        static async Task<string> DoeIetsAsync()
        {
            Console.WriteLine("Bezig met taak ...DoeIetsAsync");
            await Task.Delay(5000);
            return ("De taak is afgewerkt.");
        }
    }
}
