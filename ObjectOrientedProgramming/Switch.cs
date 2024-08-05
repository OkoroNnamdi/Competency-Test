using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Switch : NetworkDevice
    {
        // property to store the number of ports
        public int NumberOfPorts {  get; set; }
        // constructor to initialize the switch properites
        public Switch(string ipAddress, string macAddress, int numberOfPorts) 
            : base(ipAddress, macAddress)
        {
            // check the negative invalid numbers of ports
            if (numberOfPorts <= 0)
            {
                throw new ArgumentOutOfRangeException("Number of ports must be greater than zero", nameof(numberOfPorts));
            }
            NumberOfPorts = numberOfPorts;
        }

        // overiding the connected method to simulate connecting the switch to the network
        public override void connect()
        {
            Console.WriteLine($"switch  with IP: {IPAddress} and Mac: " +
                $"{MACAddress} is connecting with {NumberOfPorts} ports");
        }
    }
}
