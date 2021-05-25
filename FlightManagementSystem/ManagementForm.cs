using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagementSystem
{


    public partial class ManagementForm : Form
    {
        Chat chat;
        Pasagjeret pasagjeret;
        Fluturimet fluturimet;
        public ManagementForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             fluturimet = new Fluturimet();
            fluturimet.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
             pasagjeret = new Pasagjeret();
            pasagjeret.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chat = new Chat();
            chat.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
