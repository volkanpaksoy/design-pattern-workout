using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // var configFactory = new AppConfigConfigurationFactory();
            var configFactory = new DynamoDBConfigurationFactory();

            IApiSettings apiSettings = configFactory.GetApiSettings();
            IFeedSettings feedSettings = configFactory.GetFeedSettings();
        }
    }
}
