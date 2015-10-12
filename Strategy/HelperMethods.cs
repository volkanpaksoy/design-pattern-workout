using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strategy
{
    public class HelperMethods
    {
        public static string ExtractIPAddress(string fullText)
        {
            string regExPattern = @"\b(?:[0-9]{1,3}\.){3}[0-9]{1,3}\b";
            
            Regex regex = new Regex(regExPattern);
            Match match = regex.Match(fullText);
            if (match != null && match.Success)
	        {
                return match.Value;
	        }

            throw new ArgumentException("Provided text does not contain an IP address");
        }
    }
}
