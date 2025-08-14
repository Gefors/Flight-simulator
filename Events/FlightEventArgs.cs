using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Events
{
    public class FlightEventArgs : EventArgs
    {
        public string Message { get;  set; }
        public string Name { get; set; }
        public TimeOnly LocalTime { get; set; }
        public string FlightId { get; } 
        public string FlightDestination { get; }

        public FlightEventArgs(string name, string mesage, TimeOnly localTime, string flightId, string flightDestination)
        {
            Name = name;
            Message = mesage;
            LocalTime = localTime;
            FlightId = flightId;
            FlightDestination = flightDestination;
        }
    }
}
