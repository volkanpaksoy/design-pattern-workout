using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CustomIpChecker : IIpCheckStrategy
    {
        public string GetExternalIp()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://check-ip.herokuapp.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("").Result;
                string json = response.Content.ReadAsStringAsync().Result;
                dynamic ip = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                string result = ip.ipAddress;
                return result;
            }
        }
    }
}
