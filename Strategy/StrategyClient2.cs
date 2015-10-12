using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class StrategyClient2
    {
        public void Execute()
        {
            string ipcheckerTypeName = ConfigurationManager.AppSettings["IPChecker"];

            IIpCheckStrategy ipchecker = Assembly.GetExecutingAssembly().CreateInstance(ipcheckerTypeName) as IIpCheckStrategy;

            Console.WriteLine(ipchecker.GetExternalIp());
        }
    }
}
