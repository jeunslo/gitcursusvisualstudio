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
    public delegate List<Tweet> Lijst();
    public class Twitter
    {

        //Wegschrijven van tweets
        private void AddToBestand(Tweets tweets)
        {
            try
            {
                using (var bestand = File.Open(@"C:\Data\twitter.obj", FileMode.OpenOrCreate))
                {
                    var schrijver = new BinaryFormatter();
                    schrijver.Serialize(bestand, tweets);
                }
                Console.WriteLine("Serialisatie geslaagd");
            }
            catch (IOException)
            {
                throw new Exception("Fout bij het openen van het bestand!");
            }
            catch (SerializationException)
            {
                Console.WriteLine("Fout bij het Serialiseren");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //lezen van het bestand
        private Tweets LeesBestand()
        {
            try
            {
                using (var bestand = File.Open(@"C:\Data\twitter.obj", FileMode.Open, FileAccess.Read))
                {
                    var lezer = new BinaryFormatter();
                    return ((Tweets)lezer.Deserialize(bestand));
                }
            }
            catch (IOException)
            {
                throw new Exception("Fout bij het openen van het bestand!");
            }
            catch (SerializationException)
            {
                throw new Exception("Fout bij het deserialiseren");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Console.WriteLine("Deserialisatie geslaagd");
            }
        }

        //tweets ordenen
        public List<Tweet> OrderTweets()
        {
            if (File.Exists(@"C:\Data\twitter.obj"))
            {
                Tweets tweets = LeesBestand();
                return (from tweet in tweets.TweetList orderby tweet.Tijdstip descending select tweet).ToList();
                //return tweets.TweetList.OrderByDescending(t => t.Tijdstip).ToList();
            }
            else
                throw new Exception("het bestand is niet gevonden");
        }


        //tweet van gebruiker
        public List<Tweet> TweetsUser(string naam)
        {
            var tweets = OrderTweets();
            return (from tweet in tweets where tweet.Naam == naam select tweet).ToList();
        }

        //Toon alle tweets
        public static void Afbeelden(List<Tweet> tweetLijst)
        {
            foreach (var tweet in tweetLijst)
            {
                Console.WriteLine(tweet);
                Console.WriteLine();
            }
        }

        public static event Lijst lijst;
        public static void DelegateAfbeelden()
        {
            if (lijst != null)
            {
                foreach (var tweet in lijst())
                {
                    Console.WriteLine(tweet);
                    Console.WriteLine();
                }
            }
        }

        //Tweets toevoegen aan bestaand bestand
        public void VoegTweetToe(Tweet tweet)
        {
            Tweets bestand;
            if (File.Exists(@"C:\Data\twitter.obj"))
                bestand = LeesBestand();
            else
                bestand = new Tweets();
            bestand.AddTweet(tweet);
            AddToBestand(bestand);

        }
    }
}
