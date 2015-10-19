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
            ArticleFeedGenerator feedGenerator = CreateFeedGenerator(feedSettings);
            feedGenerator.Run();
        }
        
        private static ArticleFeedGenerator CreateFeedGenerator(IFeedSettings feedSettings)
        {
            string feedFormat = feedSettings.FeedFormat;
            switch (feedFormat.ToLower())
            {
                case "atom": return new AtomFeedGenerator(new RareburgClient(), new RareburgArticleFeedService(), new S3PublishService(), feedSettings);
                case "rss": return new RssFeedGenerator(new RareburgClient(), new RareburgArticleFeedService(), new S3PublishService(), feedSettings);
                default: throw new ArgumentException("Unknown feed format");
            }
        }
    }
}
