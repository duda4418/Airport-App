
using Airport_App;
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
            Flight z1 = new Flight("London", 12.30, 13, "Delayed", "Departure");
            Flight z2 = new Flight("Madrid", 18.47, 2, "On Time", "Arrival");

            Console.WriteLine("FLIGHTS: ");
            Console.WriteLine(z1.DisplayFlight());
            Console.WriteLine(z2.DisplayFlight());

            Console.WriteLine();

        }
    }
}
