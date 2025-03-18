
using AdministrareMemorie;
using Airport_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_App
{
    class Program
    {
        static int nrFlights = 0;

        static void Main(string[] args)
        {

            AdministrareMemorieFlight adminFlights = new AdministrareMemorieFlight();
            Flight newFlight = new Flight();

            string optiune;
            do
            {
                Console.WriteLine("C. Citire informatii zboruri de la tastatura");
                Console.WriteLine("I. Afisare ultimul zbor");
                Console.WriteLine("A. Afisare zboruri");
                Console.WriteLine("S. Salvare zbor in vector de obiecte");
                Console.WriteLine("P. Gasire zboruri dupa tip");
                Console.WriteLine("D. Gasire zboruri dupa ora");
                Console.WriteLine("X. Inchidere program");

                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "C":
                        newFlight = CitireZbor();

                        break;
                    case "I":
                        AfisareZbor(newFlight);

                        break;

                    case "A":
                        Flight[] flights = adminFlights.GetFlights(out nrFlights);
                        AfisareZboruri(flights, nrFlights);

                        break;
                    case "S":
                        int flightId = nrFlights + 1;
                        newFlight.flightId = flightId;
                        adminFlights.AddFlight(newFlight);

                        break;
                    case "X":
                        return;

                    case "P":
                        Console.WriteLine("Introduceti tipul zborului: (Departure / Arrival)");
                        string type = Console.ReadLine();

                        Flight[] flightList = adminFlights.GetFlightType(type, out nrFlights);
                        AfisareZboruri(flightList, nrFlights);
                        return;


                    case "D":
                        Console.WriteLine("Introduceti ora");
                        double time = double.Parse(Console.ReadLine());

                        newFlight = adminFlights.GetFlightDestination(time);
                        AfisareZbor(newFlight);
                        return;


                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();

            AdministrareMemoriePassenger adminPassenger = new AdministrareMemoriePassenger();

            Console.WriteLine("Vector scara: ");
            adminPassenger.ProcessWords("test.txt");
        }

        public static Flight CitireZbor()
        {
            Console.WriteLine("Introduceti tipul zborului");
            string type = Console.ReadLine();

            Console.WriteLine("Introduceti orasul");
            string city = Console.ReadLine();

            Console.WriteLine("Introduceti ora");
            double time = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti gate-ul");
            int gate = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti statusul");
            string status = Console.ReadLine();

            Flight flight = new Flight(city, time, gate, status, type, nrFlights);

            return flight;
        }

        public static void AfisareZbor(Flight flight)
        {
            string flightInfo = string.Format("Datele zborului {0}: {1} {2} {3} {4} {5}",
                    flight.flightId,
                    flight.flightType ?? " NECUNOSCUT ",
                    flight.city ?? " NECUNOSCUT ",
                    flight.time,
                    flight.gate,
                    flight.status ?? "NECUNOSCUT");

            Console.WriteLine(flightInfo);
        }

        public static void AfisareZboruri(Flight[] flights, int nrFlights)
        {
            Console.WriteLine("Zboruri:");
            for (int contor = 0; contor < nrFlights; contor++)
            {
                string flightInfo = flights[contor].DisplayFlight();
                Console.WriteLine(flightInfo);
            }
        }
    }

}


