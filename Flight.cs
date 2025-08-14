using Assignment4.Events;
using System.Windows;
using System.Windows.Threading;


namespace Assignment4
{
    public class Flight
    {
        public TimeOnly DepartureTime { get; set; }
        public string Destination { get; set; }

        public DispatcherTimer dispatcherTimer;

        public string Id { get; set; }

        public bool InFlight { get; set; }

        public TimeOnly LocalTime { get; set; }

        public string Name { get; set; }

        public double Time { get; set; }

        public TimeSpan ElapsedFlightTime { get;  set; }

        public event EventHandler<FlightEventArgs> TakeOffEvent;
        public event EventHandler<FlightEventArgs> LandedEvent;


        public Flight(string destination, string id, string name, double time)
        {
            Destination = destination;
            Id = id;
            Name = name;
            Time = time;
            ElapsedFlightTime = TimeSpan.Zero;
            InFlight = false;
        }

        public void DispatchTimer_tick(object? sender, EventArgs e)
        {            

            ElapsedFlightTime += TimeSpan.FromHours(1);

            if (ElapsedFlightTime.TotalHours >= Time)
            {
                OnLanded(); 
            }
        }

        public virtual void OnTakeOff()
        {
            LocalTime = TimeOnly.FromDateTime(DateTime.Now);
            DepartureTime = LocalTime;
            TakeOffEvent?.Invoke(this, new FlightEventArgs(Name, "Takeoff", LocalTime, Id, Destination));
            InFlight = true;
            SetupTimer();
        }

        public virtual void OnLanded()
        {
            TimeOnly landingTime = DepartureTime.AddHours(Time);
            LandedEvent?.Invoke(this, new FlightEventArgs(Name, "Landed", landingTime, Id, Destination)); 
            InFlight = false; 
            StopTimer(); 
        }

        public void SetupTimer()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += DispatchTimer_tick;
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1); 
            dispatcherTimer.Start(); 
        }

        public void StopTimer()
        {
            dispatcherTimer.Stop();
            ElapsedFlightTime = TimeSpan.Zero;
        }

        public override string ToString()
        {
            return $"Destination: {Destination}     -       Airline: {Name}       -     FligthId: {Id}      -      DurationTime(hrs): {Time}";
        }

        public event EventHandler TimerTickEvent;

    }
}
