using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oplossing
{
    class Program
    {
        static void Main(string[] args)
        {
            Twitter twitter = new Twitter();
            //string naam, bericht;
            //var meer = true;
            //var confirm = "y";
            //while (meer == true)
            //{
            //    Console.WriteLine("Naam?");
            //    naam = Console.ReadLine();
            //    Console.WriteLine("Bericht:");
            //    bericht = Console.ReadLine();
            //    Tweet tweet = new Tweet()
            //    {
            //        Naam = naam,
            //        Bericht = bericht
            //    };
            //    twitter.SchrijfTweet(tweet);
            //    Console.WriteLine("Meer tweets? y(yes) or n(no)");
            //    confirm = Console.ReadLine();
            //    if (confirm == "y" || confirm == "n")
            //        meer = (confirm == "y") ? true : false;
            //    else
            //        throw new Exception("Foute letter");
            //}

            var tweets = twitter.AlleTweets();
            foreach (var eenTweet in tweets)
                Console.WriteLine(eenTweet);
        }
    }
}
