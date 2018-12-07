using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;

namespace Programming_Fundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            bool netconnection = NetworkInterface.GetIsNetworkAvailable();

            if (netconnection == true)
            {
                Console.WriteLine("You have net.");
            }

            else
            {
                Console.WriteLine("You don't have net.");
            }
            Console.ReadKey(true);
        }
    }
}