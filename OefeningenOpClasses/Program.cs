using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenOpRekeningen
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Rekening ik = new Rekening();
            //ik.Rekeningnummer = "BE40747524091936";//"BE56001900200088";//Console.ReadLine();
            ////int.TryParse(ik.Rekeningnummer.Substring(14, 2), out int laatsteTwee);
            ////ulong.TryParse(ik.Rekeningnummer.Substring(4, 10), out ulong volgendeTien);
            ////////ik.CreatieDatum = DateTime.Today;
            ////////Console.WriteLine("Voer een bedrag in om te storten");
            ////////ik.Storten(decimal.Parse(Console.ReadLine()));
            ////Console.WriteLine(laatsteTwee);
            ////Console.WriteLine(volgendeTien);
            ////Console.WriteLine((int) (volgendeTien % 97));
            //ik.Afbeelden();

            //Klant ik = new Klant("Jeunsing", "Lo");

            //SpaarRekening spaarRekening = new SpaarRekening("BE40747524091936", 0m, DateTime.Today, ik);
            //spaarRekening.Storten(1000m);
            //spaarRekening.Afbeelden();

            //Zichtrekening zichtrekening = new Zichtrekening("BE40645100000163", 0m, DateTime.Today, ik, - 1000m);
            //zichtrekening.Storten(125m);
            //zichtrekening.Afbeelden();

            //SpaarRekening.Intrest = 3m;
            //Rekening[] aRekeningen = new Rekening[2];
            //aRekeningen[0] = new SpaarRekening("BE56001900200088", 1000m, DateTime.Today, ik);
            //aRekeningen[1] = new Rekening("BE73063154756360", 14.51m, DateTime.Today, ik);
            //Zichtrekening test = new Zichtrekening("BE73063154756360", 14.51m, DateTime.Today, ik, -500m);

            ////test = (Zichtrekening)aRekeningen[1];
            //Console.WriteLine(aRekeningen[1]);
            //Console.WriteLine(test.Equals(aRekeningen[1]));

            //test.Afbeelden();
            //Console.WriteLine();

            //aRekeningen[1].Afbeelden();
            //Console.WriteLine();

            //foreach (Rekening rekeningType in aRekeningen)
            //{
            //    rekeningType.Afbeelden();
            //    Console.WriteLine();
            //}
            
            //SpaarRekening.Intrest = 3m;
            //ISpaarmiddel[] aSpaarmiddels = new ISpaarmiddel[3];
            //aSpaarmiddels[0] = new Zichtrekening("BE56001900200088", 1000m, DateTime.Today, ik, -3000m);
            //aSpaarmiddels[1] = new SpaarRekening("BE73063154756360", 14.51m, DateTime.Today, ik);
            //aSpaarmiddels[2] = new Kasbon(DateTime.Today, 500, 2, 2, ik);

            //foreach (ISpaarmiddel spaarmiddel in aSpaarmiddels)
            //{
            //    spaarmiddel.Afbeelden();
            //    Console.WriteLine();
            //}

        }
    }
}
