
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

            Passenger p1 = new Passenger("David", "12345", "112", "14C");
            Passenger p2 = new Passenger("Rebeca", "54321", "112", "14D");

            Console.WriteLine("PASSANGERS: ");
            Console.WriteLine(p1.DisplayPassenger());
            Console.WriteLine(p2.DisplayPassenger());

            Console.WriteLine();

        }
    }
}
