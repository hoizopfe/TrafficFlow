using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TrafficFlow.DnsModel
{
    internal class DnsResolverModel
    {
        public static async Task<IPAddress> GetAddressOfHostnameAsync(string hostname)
        {
            IPHostEntry ipHostInfo = await Dns.GetHostEntryAsync(hostname).ConfigureAwait(false);
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            return ipAddress;
        }
    }
}
