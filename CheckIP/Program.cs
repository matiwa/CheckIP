using System;
using System.Net;

namespace CheckIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CheckIP";
            string hostname = Dns.GetHostName();
            IPHostEntry AdresyIP = Dns.GetHostEntry(hostname);
            Console.WriteLine("Computer name: {0}", hostname);
            int licznik = 0;
            foreach(IPAddress Adresip in AdresyIP.AddressList)
            {
                if (Adresip.ToString() == "127.0.0.1")
                    Console.WriteLine("The computer is not connected to the network. IP address: {0}", Adresip);
                else
                    Console.WriteLine("IP address #{0}: {1}", ++licznik, Adresip);
            }
            Console.ReadKey();
        }
    }
}
