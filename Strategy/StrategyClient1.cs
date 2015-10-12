using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Strategy
{
    class StrategyClient1
    {
        public void Execute()
        {
            IIpCheckStrategy ipChecker;

            ipChecker = new DynDns();
            Console.WriteLine(ipChecker.GetExternalIp());

            ipChecker = new AwsIPCheckStrategy();
            Console.WriteLine(ipChecker.GetExternalIp());

            ipChecker = new CustomIpChecker();
            Console.WriteLine(ipChecker.GetExternalIp());

            Console.ReadKey();
        }
    }
}
