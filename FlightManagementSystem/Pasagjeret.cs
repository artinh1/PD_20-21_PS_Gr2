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
    public partial class Pasagjeret : Form
    {
        public Pasagjeret()
        {
            InitializeComponent();
        }
        IFirebaseConfig databaseConfig = new FirebaseConfig()
        {
            AuthSecret = "RZwk1TaNqek91VOVW4g6pYi8tMbwFVPXxs8rjhjB",
            BasePath = "https://flightmanagementdatabase-default-rtdb.europe-west1.firebasedatabase.app/"

        };
        IFirebaseClient databaseClient;

        private void Pasagjeret_Load(object sender, EventArgs e)
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

        private void buttonAddPassenger_Click(object sender, EventArgs e)
        {
            PassengerInfo pi = new PassengerInfo() {
                name = this.textBoxPassengerName.Text,
                surname = this.textBoxPassengerSurname.Text,
                email = this.textBoxEmail.Text,
                phone=this.textBoxPhone.Text
                
            };
            try
            {
                var setter = databaseClient.Set("PassengerList/" + this.textBoxPassengerID.Text, pi);
                var getter = databaseClient.Get("StoredIDs/passengerIDs");
                PassengerIDs pid = getter.ResultAs<PassengerIDs>();
                pid.passengerIDs = pid.passengerIDs + textBoxPassengerID.Text;
                var setter2 = databaseClient.Set("StoredIDs/passengerIDs", pid);
                MessageBox.Show("Pasagjeri u shtua me sukses!");
            }
            catch {
                MessageBox.Show("Gabim gjate shtimit te pasagjerit!");
            }
        }

        private void buttonViewPassengers_Click(object sender, EventArgs e)
        {
            ShikoPasagjeret sp = new ShikoPasagjeret();
            sp.Show();
            this.Close();
        }
    }
}
