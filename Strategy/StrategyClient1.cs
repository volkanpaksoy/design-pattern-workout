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

            ipChecker = new DynDnsIPCheckStrategy();
            Console.WriteLine(ipChecker.GetExternalIp());

            ipChecker = new AwsIPCheckStrategy();
            Console.WriteLine(ipChecker.GetExternalIp());

            ipChecker = new CustomIpCheckStrategy();
            Console.WriteLine(ipChecker.GetExternalIp());

            Console.ReadKey();
        }
    }
}
