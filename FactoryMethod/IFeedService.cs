using System.Collections.Generic;
using System.ServiceModel.Syndication;

namespace FactoryMethod
{
    public interface IFeedService
    {
        SyndicationFeed GetFeed(List<Article> articles);
    }
}