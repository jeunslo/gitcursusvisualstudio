using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefOpRekening
{
    class Program
    {
        delegate void RekeningsMiddel(Rekening middel);
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

            Klant ik = new Klant("Jeunsing", "Lo");

            //SpaarRekening spaarRekening = new SpaarRekening("BE40747524091936", 50m, DateTime.Today, ik);

            //spaarRekening.Afbeelden();



            //Zichtrekening zichtrekening = new Zichtrekening("BE40645100000163", 20m, DateTime.Today, ik, -1000m);

            //zichtrekening.Afbeelden();

            //BankBediende johan = new BankBediende("Johan", "DeBanker");
            //spaarRekening.RekeningUittreksel += johan.rekeningTonen;
            //zichtrekening.RekeningUittreksel += johan.rekeningTonen;
            //spaarRekening.SaldoInHetRood += johan.rekeningOntoereikend;
            //zichtrekening.SaldoInHetRood += johan.rekeningOntoereikend;
            //spaarRekening.Storten(1000m);
            //Console.WriteLine();
            //spaarRekening.Afhalen(500m);
            //Console.WriteLine();
            //spaarRekening.Afhalen(2000m);
            //Console.WriteLine();
            //zichtrekening.Storten(125m);
            //Console.WriteLine();
            //zichtrekening.Afhalen(25m);
            //Console.WriteLine();
            //zichtrekening.Afhalen(2000m);
            //Console.WriteLine();
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

            try
            {
                SpaarRekening.Intrest = 3m;
                ISpaarmiddel[] aSpaarmiddels = new ISpaarmiddel[8];
                aSpaarmiddels[0] = new Rekening("BE56001900200088", 1000m, DateTime.Today, ik);
                //aSpaarmiddels[1] = new Rekening("BE56001900200077", 1000m, new DateTime(1800, 1, 1), ik);
                aSpaarmiddels[1] = new Rekening("BE56001900200088", 1000m, DateTime.Today, ik);
                aSpaarmiddels[2] = new Zichtrekening("BE56001900200088", 1000m, DateTime.Today, ik, -3000m);
                aSpaarmiddels[3] = new Zichtrekening("BE56001900200088", 1000m, DateTime.Today, ik, -3000m);
                //aSpaarmiddels[3] = new Zichtrekening("BE56001900200077", 1000m, new DateTime(1800, 1, 1), ik, 3000m);
                aSpaarmiddels[4] = new SpaarRekening("BE73063154756360", 14.51m, DateTime.Today, ik);
                //SpaarRekening.Intrest = -5m;
                SpaarRekening.Intrest = 5m;
                aSpaarmiddels[5] = new SpaarRekening("BE73063154756360", 14.51m, DateTime.Today, ik);
                aSpaarmiddels[6] = new Kasbon(DateTime.Today, 500, 2, 2, ik);
                //aSpaarmiddels[7] = new Kasbon(DateTime.Today, 500, 2, 2, ik);
                aSpaarmiddels[7] = new Kasbon(new DateTime(1800, 1, 1), -500, -2, -2, ik);

                foreach (ISpaarmiddel middel in aSpaarmiddels)
                {
                    middel.Afbeelden();
                    Console.WriteLine();
                }
            }
            catch (OngeldigRekeningnummerException ex)
            {
                Console.WriteLine("Fout: {0} {1} {2}StackTrace:{3}", ex.Message, ex.OngeldigRekeningnummer, Environment.NewLine, ex.StackTrace);
            }
            catch (DateTimeException ex)
            {
                Console.WriteLine("Fout: {0} {1} {2}StackTrace:{3}", ex.Message, ex.OngeldigDateTime, Environment.NewLine, ex.StackTrace);
            }
            catch (OngeldigPositieveWaardeException ex)
            {
                Console.WriteLine("Fout: {0} {1} {2}StackTrace:{3}", ex.Message, ex.OngeldigPositieveWaarde, Environment.NewLine, ex.StackTrace);
            }
            catch (OngeldigNegatieveWaardeException ex)
            {
                Console.WriteLine("Fout: {0} {1} {2}StackTrace:{3}", ex.Message, ex.OngeldigNegatieveWaarde, Environment.NewLine, ex.StackTrace);
            }
        }
    }
}
