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
    public partial class ShikoFluturimet : Form
    {
        public ShikoFluturimet()
        {
            InitializeComponent();
        }

        IFirebaseConfig databaseConfig = new FirebaseConfig()
        {
            AuthSecret = "RZwk1TaNqek91VOVW4g6pYi8tMbwFVPXxs8rjhjB",
            BasePath = "https://flightmanagementdatabase-default-rtdb.europe-west1.firebasedatabase.app/"

        };
        IFirebaseClient databaseClient;

        private void ShikoFluturimet_Load(object sender, EventArgs e)
        {
            try
            {
                databaseClient = new FireSharp.FirebaseClient(databaseConfig);
            }
            catch
            {
                MessageBox.Show("Problem gjate lidhjes me bazen e te dhenave!");
            }
            FlightInfo fi;
            var result = databaseClient.Get("StoredIDs/Flights");
            FlightIDs fid = result.ResultAs<FlightIDs>();
            for (int i = 0; i < fid.flightIDs.Length; i++) {
                result = databaseClient.Get("FlightList/" + fid.flightIDs[i]);
                fi = result.ResultAs<FlightInfo>();
                this.dataGridFlights.Rows.Add(fid.flightIDs[i], fi.Source, fi.Destination, fi.takeoffdate, fi.numPassengers);
            }
            
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            if (this.dataGridFlights.CurrentCell.ColumnIndex == 0 && this.dataGridFlights.CurrentCell != null) 
            {
                var result = databaseClient.Get("StoredIDs/Flights");
                FlightIDs fid = result.ResultAs<FlightIDs>();
                string selectedId = this.dataGridFlights.CurrentCell.Value.ToString();
                fid.flightIDs = fid.flightIDs.Remove(fid.flightIDs.IndexOf(selectedId), 1);
                var result2 = databaseClient.Delete("FlightList/" + selectedId);
                var setter = databaseClient.Set("StoredIDs/Flights", fid);
                this.dataGridFlights.Rows.RemoveAt(this.dataGridFlights.CurrentCell.RowIndex);

            }
            else {
                MessageBox.Show("Duhet te selektoni nje rresht nga kolona ID!");
            }

        }
    }
}
