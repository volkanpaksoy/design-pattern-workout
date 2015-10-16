using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfigurationFactory configFactory = new AppConfigConfigurationFactory();
            // IConfigurationFactory configFactory = new DynamoDBConfigurationFactory();

            IApiSettings apiSettings = configFactory.GetApiSettings();
            IFeedSettings feedSettings = configFactory.GetFeedSettings();
            IFeedServiceSettings feedServiceSettings = configFactory.GetFeedServiceSettings();
            IS3PublisherSettings s3PublishSettings = configFactory.GetS3PublisherSettings();
            IOfflineClientSettings offlineClientSettings = configFactory.GetOfflineClientSettings();
        }
    }
}
