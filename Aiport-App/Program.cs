using Aiport_App.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aiport_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrivals z1 = new Arrivals("London", 12.30, 13, "Delayed");
            Arrivals z2 = new Arrivals("Madrid", 18.47, 2, "On Time");

            Console.WriteLine("ARRIVALS: ");
            Console.WriteLine(z1.DisplayArrival());
            Console.WriteLine(z2.DisplayArrival());

            Departures z3 = new Departures("New York", 8.23, 6, "On Time");
            Departures z4 = new Departures("New York", 8.23, 5, "On Time");

            Console.WriteLine();

            Console.WriteLine("Departures: ");
            Console.WriteLine(z3.DisplayArrival());
            Console.WriteLine(z4.DisplayArrival());
        }
    }
}
