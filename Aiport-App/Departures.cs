using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aiport_App
{
    class Departures
    {
        string destinationCity = "", status = "";
        double departureTime = 00.00;
        int gate = 0;

        public Departures(string _destinationCity, double _departureTime, int _gate, string _status)
        {
            destinationCity = _destinationCity;
            departureTime = _departureTime;
            gate = _gate;
            status = _status;
        }

        public string DisplayArrival()
        {
            return $"Destination: {destinationCity}, Time: {departureTime}, Gate: {gate}, Status:{status}";
        }
    }
}
