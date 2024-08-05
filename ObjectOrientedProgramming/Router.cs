using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Router : NetworkDevice
    {
        // property to store the number of poorts
        public int NumberOfPorts { get; set; }

        // constructor to initialize the router properties
        public Router(string ipAddress, string macAddress, int numberOfPorts)
            : base(ipAddress, macAddress)
        {
            // check the negative invalid numbers of ports
            if (numberOfPorts <= 0) 
            {
                throw new ArgumentOutOfRangeException("Number of ports must be greater than zero", nameof (numberOfPorts));
            }
            NumberOfPorts = numberOfPorts;
        }
        // overiding the connected method to simulate connecting the router to the network
        public override void connect()
        {
            Console.WriteLine($"Router with {IPAddress } and Mac " +
                $"{MACAddress } is connecting with {NumberOfPorts } ports");
        }
    }
}
