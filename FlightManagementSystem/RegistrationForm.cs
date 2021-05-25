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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        IFirebaseConfig databaseConfig = new FirebaseConfig()
        {
            AuthSecret = "RZwk1TaNqek91VOVW4g6pYi8tMbwFVPXxs8rjhjB",
            BasePath = "https://flightmanagementdatabase-default-rtdb.europe-west1.firebasedatabase.app/"

        };
        IFirebaseClient databaseClient;

        private void buttonRegister2_Click(object sender, EventArgs e)
        {
            UserInfo user = new UserInfo()
            {
                username = textBoxUserReg.Text,
                password = textBoxPasswordReg.Text
            };
            try
            {
                var setter = databaseClient.Set("UserList/", user);
                MessageBox.Show("Regjistrimi i suksesshem!");
                this.Close();
            }
            catch {
                MessageBox.Show("Gabim gjate regjistrimit!");
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            databaseClient = new FireSharp.FirebaseClient(databaseConfig);

        }
    }
}

