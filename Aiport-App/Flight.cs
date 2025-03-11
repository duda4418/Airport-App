 ﻿using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

namespace Airport_App
{

    class Flight
    {
        string city = "", status = "";
        double time = 00.00;
        int gate = 0;
        string flightType = "";

        public Flight(string _city, double _time, int _gate, string _status, string _flightType)
        {
            city = _city;
            time = _time;
            gate = _gate;
            status = _status;
            flightType = _flightType;
        }

        public string DisplayFlight()
        {
            
            return $"{flightType}: {city}, Time: {time}, Gate: {gate}, Status: {status}";
        }
    }
}
