using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AppConfigApiSettings : IApiSettings
    {
        public string ApiKey
        {
            get { return ConfigurationManager.AppSettings["Rareburg.ApiKey"]; }
        }

        public string ApiEndPoint
        {
            get { return ConfigurationManager.AppSettings["Rareburg.ApiEndPoint"]; }
        }
    }
}
