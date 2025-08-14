using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Assignment4.Events;
using Assignment4.CommonFiles;
using System.Collections.Generic;


namespace Assignment4
{
    public class ControlTower : ListManager<Flight>
    {
     //   public event EventHandler<FlightEventArgs> TakeOffEvent;
     //   public event EventHandler<FlightEventArgs> LandedEvent;

        public ControlTower()
        {

        }

        public bool ControlIndex(int index)
        {
            if (CheckIndex(index))
            {
                Flight flight = GetAt(index);
                return !flight.InFlight;  // Returns true if flight is not in the air (ready to take off)
            }
            return false;
        }

        public void OrderTakeOff(int index)
        {
            if (ControlIndex(index))
            {
                Flight flight = GetAt(index);
                flight.OnTakeOff();
            }
        }
    }
}
