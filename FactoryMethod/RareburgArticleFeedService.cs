using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;

namespace FactoryMethod
{
    internal class RareburgArticleFeedService : IFeedService
    {
        public SyndicationFeed GetFeed(List<Article> articles)
        {
            return new SyndicationFeed();
        }
    }
}