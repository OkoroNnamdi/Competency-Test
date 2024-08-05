using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public abstract class NetworkDevice
    {
        // properties to store the IP and MAC address
        public string IPAddress { get;set; }
        public string MACAddress { get;set; }
        // abstract method to be implemented by the derived classes
        public abstract void connect();

        // constructor to initialize the IP and MAC address
        public NetworkDevice(string ipAddress, string macAddress)
        {
            if (string.IsNullOrWhiteSpace(ipAddress))
            {
                throw new ArgumentNullException("The IP address cannot be null or empty",nameof (ipAddress));
            }
            if (string.IsNullOrWhiteSpace(macAddress))
            {
                throw new ArgumentNullException("MAc address cannot be null or empty", nameof(macAddress));
            }
            IPAddress = ipAddress;
            MACAddress = macAddress;
        }
    }
}
