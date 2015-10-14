using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class AppConfigOfflineClientSettings : IOfflineClientSettings
    {
        public string LocalFilePath
        {
            get { return ConfigurationManager.AppSettings["Rareburg.LocalFilePath"]; }
        }
    }
}
