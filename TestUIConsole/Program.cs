using ObjectOrientedProgramming;

namespace TestUIConsole
{
    public  class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Router router = new Router("192.168.0.1", "AA:BB:CC:DD:EE:FF", 4);
                Switch networkSwitch = new Switch("192.168.0.2", "FF:EE:DD:CC:BB:AA", 24);
                AccessPoint accessPoint = new AccessPoint("192.168.0.3", "11:22:33:44:55:66", "MySSID");

                router.connect();
                networkSwitch.connect();
                accessPoint.connect();
            }
            catch (ArgumentException   ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
