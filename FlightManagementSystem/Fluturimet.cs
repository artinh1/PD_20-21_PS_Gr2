using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace FlightManagementSystem
{
    public partial class Fluturimet : Form
    {
        public Fluturimet()
        {
            InitializeComponent();
        }

        IFirebaseConfig databaseConfig = new FirebaseConfig()
        {
            AuthSecret = "RZwk1TaNqek91VOVW4g6pYi8tMbwFVPXxs8rjhjB",
            BasePath = "https://flightmanagementdatabase-default-rtdb.europe-west1.firebasedatabase.app/"

        };
        IFirebaseClient databaseClient;
        private void buttonAddFlight_Click(object sender, EventArgs e)
        {
            FlightInfo flight = new FlightInfo()
            {
                Source = textBoxSource.Text,
                Destination = textBoxDestination.Text,
                takeoffdate = textBoxTakeOff.Text,
                numPassengers = int.Parse(textBoxNumPassengers.Text)
                    
            };

            try
            {
                var setter = databaseClient.Set("FlightList/" + textBoxFlightID.Text, flight);
                var result = databaseClient.Get("StoredIDs/Flights");
                FlightIDs fid = result.ResultAs<FlightIDs>();
                fid.flightIDs = fid.flightIDs + textBoxFlightID.Text;
                var setter2 = databaseClient.Set("StoredIDs/Flights", fid);
                MessageBox.Show("Fluturimi u shtua me sukses!");
            }
            catch {
                MessageBox.Show("Gabim gjate shtimit te fluturimit!");
            }

        }
        

        private void Fluturimet_Load(object sender, EventArgs e)
        {
            try
            {
                databaseClient = new FireSharp.FirebaseClient(databaseConfig);
            }
            catch
            {
                MessageBox.Show("Problem gjate lidhjes me bazen e te dhenave!");
            }

        }

        private void buttonViewFlights_Click(object sender, EventArgs e)
        {
            ShikoFluturimet shikoFluturimet = new ShikoFluturimet();
            shikoFluturimet.Show();
            this.Close();
        }
    }
}
