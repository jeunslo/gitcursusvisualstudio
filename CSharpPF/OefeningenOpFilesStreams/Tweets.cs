using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.ObjectModel;


namespace OefeningenOpFilesStreams
{
    [Serializable]
    public class Tweets
    {
        public List<Tweet> TweetList { get; set; }

        //private List<Tweet> tweetListValue;

        //public ReadOnlyCollection<Tweet> TweetList()
        //{
        //    return new ReadOnlyCollection<Tweet>(tweetListValue);
        //}

        public void AddTweet(Tweet tweet)
        {
            //if (tweetListValue == null)
            //    tweetListValue = new List<Tweet>();
            //tweetListValue.Add(tweet);
            if (TweetList == null)
                TweetList = new List<Tweet>();
            TweetList.Add(tweet);
        }
    }
}
