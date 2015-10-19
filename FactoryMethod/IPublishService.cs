using System.ServiceModel.Syndication;

namespace FactoryMethod
{
    public interface IPublishService
    {
        void Publish(SyndicationFeedFormatter feedFormatter);
    }
}