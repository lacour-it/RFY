using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFY.Models
{
    public class NetworkInterface
    {
        public string ID { get; set; }
        public string InterfaceName { get; set; }
        public string IPAddress { get; set; }
        public string IPAddressV6 { get; set; }
        public string Description { get; set; }
        public string InterfaceType { get; set; }
        public string OperationalStatus { get; set; }
        public string Speed { get; set; }
        public string AnyCastAddress { get; set; }
        public string DNSServerAddresses { get; set; }
        public string DHCPServerAddresses { get; set; }
        public string DNSSuffix { get; set; }
        public string GatewayAddresses { get; set; }
        public bool IsDNSEnabled { get; set; }
        public bool IsDHCPEnabled { get; set; }
        public string MulticastAddresses { get; set; }
        public string UniCastAddresses { get; set; }
        public string WinServerAddresses { get; set; }
    }
}
