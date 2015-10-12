using Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class DynDns : IIpCheckStrategy
    {
        public string GetExternalIp()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://checkip.dyndns.org/");
                HttpResponseMessage response = client.GetAsync("").Result;
                return HelperMethods.ExtractIPAddress(response.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
