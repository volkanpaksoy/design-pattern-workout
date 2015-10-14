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
            var feed = new SyndicationFeed();
            var feedFormatterFactory = FeedFormatterFactory.CreateFactory(feed, feedSettings);
            var feedFormatter = feedFormatterFactory.CreateFeedFormatter();
        }
    }
}
