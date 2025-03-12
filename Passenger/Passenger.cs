using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_App
{
    class Passenger
    {
        public string name { get; set; }
        public string passportNumber { get; set; }
        public string flightNumber { get; set; }
        public string seatNumber { get; set; }

        public Passenger()
        {

        }

        public Passenger(string _name, string _passportNumber, string _flightNumber, string _seatNumber)
        {
            name = _name;
            passportNumber = _passportNumber;
            flightNumber = _flightNumber;
            seatNumber = _seatNumber;
        }

        public string DisplayPassenger()
        {
            return $"Name: {name}, Passport: {passportNumber}, Flight: {flightNumber}, Seat: {seatNumber}";
        }
    }
}
