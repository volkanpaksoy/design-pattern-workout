using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class AwsIPCheckStrategy : IIpCheckStrategy
    {
        public string GetExternalIp()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://checkip.amazonaws.com/");
                string result = client.GetStringAsync("").Result;
                return result.TrimEnd('\n');
            }
        }
    }
}
