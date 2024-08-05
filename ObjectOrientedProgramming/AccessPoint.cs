using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class AccessPoint : NetworkDevice
    {
        // property to store the SSID
        public string SSID { get; set; }
        public AccessPoint(string ipAddress, string macAddress, string sSID) : base(ipAddress, macAddress)
        {
            if (string.IsNullOrWhiteSpace(sSID))
                throw new ArgumentNullException("SSID cannot be null or empty", nameof(sSID));
            SSID = sSID;
        }
        // Overide the connect method to simulate connecting the access point to the network
        public override void connect()
        {
            Console.WriteLine($"Access point with IP {IPAddress }, MAC{MACAddress}, and SSID{SSID} is connecting");
        }
    }
}
