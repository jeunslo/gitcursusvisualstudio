using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace OefeningenOpFilesStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Tweet tweetLijst = new Tweet();
            var tweetlist = new Twitter();
            //var meer = true;
            //var confirm = "y";
            //string naam, bericht;
            //while (meer == true)
            //{
            //    Tweet nieuwTweet = new Tweet();
            //    Console.WriteLine("Naam?");
            //    naam = Console.ReadLine();
            //    Console.WriteLine("Bericht:");
            //    bericht = Console.ReadLine();
            //    tweetLijst.Naam = naam;
            //    tweetLijst.Bericht = bericht;
            //    //var tweet = new Tweet() { Naam = naam, Bericht = bericht };
            //    //tweetlist.VoegTweetToe(tweet);
            //    tweetlist.VoegTweetToe(tweetLijst);
            //    Console.WriteLine("Meer tweets? y(yes) or n(no)");
            //    confirm = Console.ReadLine();
            //    if (confirm == "y" || confirm == "n")
            //        meer = (confirm == "y") ? true : false;
            //    else
            //        throw new Exception("Foute letter");
            //}

            Console.WriteLine("Toon alle tweets of van een specifieke gebruiker? all of \"gebruikersnaam\"");
            var keuze = Console.ReadLine();
            Console.WriteLine();

            if (keuze == "all")
            {
                Twitter.lijst += tweetlist.OrderTweets;
                Twitter.DelegateAfbeelden();
            }
            //Twitter.Afbeelden(tweetlist.OrderTweets());
            else
                Twitter.Afbeelden(tweetlist.TweetsUser(keuze));
        }
    }
}
