using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aiport_App.Properties
{
    class Arrivals
    {
        string departureCity="", status = "";
        double arrivalTime = 00.00;
        int gate = 0;

        public Arrivals(string _departureCity, double _arrvialTime, int _gate, string _status)
        {
            departureCity = _departureCity;
            arrivalTime = _arrvialTime;
            gate = _gate;
            status = _status;
        }
        
        public string DisplayArrival()
        {
            return $"From: {departureCity}, Time: {arrivalTime}, Gate: {gate}, Status:{status}";
        }
    }
}
