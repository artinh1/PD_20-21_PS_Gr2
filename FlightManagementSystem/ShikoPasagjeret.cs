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
    public partial class ShikoPasagjeret : Form
    {
        public ShikoPasagjeret()
        {
            InitializeComponent();
        }
        IFirebaseConfig databaseConfig = new FirebaseConfig()
        {
            AuthSecret = "RZwk1TaNqek91VOVW4g6pYi8tMbwFVPXxs8rjhjB",
            BasePath = "https://flightmanagementdatabase-default-rtdb.europe-west1.firebasedatabase.app/"

        };
        IFirebaseClient databaseClient;
        private void ShikoPasagjeret_Load(object sender, EventArgs e)
        {
            try
            {
                databaseClient = new FireSharp.FirebaseClient(databaseConfig);
            }
            catch
            {
                MessageBox.Show("Problem gjate lidhjes me bazen e te dhenave!");
            }

            var getter = databaseClient.Get("StoredIDs/passengerIDs");
            PassengerInfo pi;
            PassengerIDs pid = getter.ResultAs<PassengerIDs>();
            for (int i = 0; i < pid.passengerIDs.Length; i++) {
                getter = databaseClient.Get("PassengerList/" + pid.passengerIDs[i]);
                pi = getter.ResultAs<PassengerInfo>();
                this.dataGridViewPassengers.Rows.Add(pid.passengerIDs[i], pi.name, pi.surname, pi.email, pi.phone);

            }


        }

        private void buttonDeletePassenger_Click(object sender, EventArgs e)
        {
            int selectedColumn = this.dataGridViewPassengers.CurrentCell.ColumnIndex;
            if (selectedColumn == 0 && this.dataGridViewPassengers.CurrentCell != null)
            {

                var delete = databaseClient.Delete("PassengerList/" + this.dataGridViewPassengers.CurrentCell.Value.ToString());
                var getter = databaseClient.Get("StoredIDs/passengerIDs");
                PassengerIDs pid = getter.ResultAs<PassengerIDs>();
                pid.passengerIDs = pid.passengerIDs.Remove(pid.passengerIDs.IndexOf(this.dataGridViewPassengers.CurrentCell.Value.ToString()),1);
                var setter = databaseClient.Set("StoredIDs/passengerIDs", pid);
                this.dataGridViewPassengers.Rows.RemoveAt(this.dataGridViewPassengers.CurrentCell.RowIndex);
                
            }
            else {
                MessageBox.Show("Duhet te selektoni nje rresht nen kolonen ID!");
            }
        }
    }
}
