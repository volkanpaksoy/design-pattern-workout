using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var feedSettings = new AppConfigFeedSettings();
            // This instance is created by the abstract factory in the Rareburg.ArticleFeedGenerator project

            var feed = new SyndicationFeed();
            // Just a blank feed for demonstration

            var feedFormatterFactory = FeedFormatterFactory.CreateFactory(feed, feedSettings);
            // This static method is an example of what GoF defines as "Parameterized factory methods":
            // "The factory method takes a parameter that identifies the kind of object to create"

            var feedFormatter = feedFormatterFactory.CreateFeedFormatter();


        }
    }
}
