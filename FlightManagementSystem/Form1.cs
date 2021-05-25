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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IFirebaseConfig databaseConfig = new FirebaseConfig()
        {
            AuthSecret = "RZwk1TaNqek91VOVW4g6pYi8tMbwFVPXxs8rjhjB",
            BasePath = "https://flightmanagementdatabase-default-rtdb.europe-west1.firebasedatabase.app/"

        };
        IFirebaseClient databaseClient;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                databaseClient = new FireSharp.FirebaseClient(databaseConfig);
            }
            catch {
                MessageBox.Show("Problem gjate lidhjes me bazen e te dhenave!");
            }

          



        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var result = databaseClient.Get("UserList/");
            UserInfo ui = result.ResultAs<UserInfo>();

            if (textBoxUser.Text == ui.username && textBoxPassword.Text==ui.password)
            {
                ManagementForm mf = new ManagementForm();
                mf.Show();
                this.Hide();
                
            }
            else {
                MessageBox.Show("Gabim!");
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registerForm = new RegistrationForm();
            registerForm.Show();

        }
    }
}
