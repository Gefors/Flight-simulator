namespace Assignment4
{
    using Assignment4.CommonFiles;
    using Assignment4.Events;
    using System;
    using System.Windows;
    using System.Windows.Threading;

    public partial class Mainform : Form
    {
        private ControlTower controlTower = new ControlTower();
        private Flight flight = null;

        public Mainform()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            txtDestination.Text = string.Empty;
            txtAirline.Text = string.Empty;
            txtFlightID.Text = string.Empty;
            txtFlightDuration.Text = string.Empty;

            lstAddedPlanes.Items.Clear();
            lstAddedPlanes.Items.AddRange(controlTower.ToStringArray());
        }

        private void CreatFligth()
        {
            string destination;
            string airline;
            string flightID;
            double flightDuration;

            try
            {
                destination = txtDestination.Text;
                airline = txtAirline.Text;
                flightID = txtFlightID.Text;
            }
            catch (Exception)
            {

                throw;
            }

            if (!decimal.TryParse(txtFlightDuration.Text, out decimal duration))
            {
                MessageBox.Show("Please enter a valid number for flight duration.");
                return;
            }

            flight = new Flight(destination, flightID, airline, (double)duration);

            SetupUI();

        }


        private void Flight_TakeOffEvent(object sender, FlightEventArgs e)
        {
            string formattedTime = e.LocalTime.ToString("HH:mm:ss"); // Formatting to HH:mm:ss
            lstOutput.Items.Add($"Flight {e.Name} (Flight ID: {e.FlightId}) has departed for {e.FlightDestination} at {formattedTime}.");

        }

        private void Flight_LandedEvent(object sender, FlightEventArgs e)
        {
            string formattedTime = e.LocalTime.ToString("HH:mm:ss"); // Formatting to HH:mm:ss
            lstOutput.Items.Add($"Flight {e.Name} (Flight ID: {e.FlightId}) has landed at {e.FlightDestination} at {formattedTime}.");

        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtDestination.Text) || string.IsNullOrEmpty(txtAirline.Text) || string.IsNullOrEmpty(txtFlightID.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            return true;
        }

        private void btnAddPlane_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                CreatFligth();
                if (flight != null)
                {
                    controlTower.Add(flight);
                    SetupUI();
                }
            }
        }
        private void btnTakeOff_Click(object sender, EventArgs e)
        {
            if (lstAddedPlanes.SelectedIndex >= 0)
            {
                Flight flight = controlTower.GetAt(lstAddedPlanes.SelectedIndex);

                // Check if the flight is not currently in flight
                if (!flight.InFlight)
                {
                    // Unsubscribe existing event handlers to avoid duplicate subscriptions
                    flight.TakeOffEvent -= Flight_TakeOffEvent;
                    flight.LandedEvent -= Flight_LandedEvent;

                    // Subscribe to the flight's events for UI updates
                    flight.TakeOffEvent += Flight_TakeOffEvent;
                    flight.LandedEvent += Flight_LandedEvent;

                    // Order the flight to take off
                    controlTower.OrderTakeOff(lstAddedPlanes.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("The airplane cannot take off until it has landed.");
                }
            }
        }
    }
}
